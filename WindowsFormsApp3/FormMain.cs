using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ShodanDesktop
{
    public partial class FormMain : Form
    {
        //Global Variables
        int comboIndex1 = 0;
        int comboIndex2 = 0;

        private static string masterAPIkeyValue = "";
        public static string MasterAPIkeyValue { get => masterAPIkeyValue; set => masterAPIkeyValue = value; }


        public FormMain()
        {
            InitializeComponent();
            //Hides API key textbox in menu
            txtKey.Visible = false;
            comboFacet.Enabled = false;
            comboQuery.Enabled = false;
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            try { 
                {
                    updateExample(comboIndex1, comboIndex2);
                }
            } catch
                {
                    MessageBox.Show("Other Issue");
                }
        }
        private void buttonConnect(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtExampleOutput.Text))
                {
                    MessageBox.Show("Please create connection string first");
                }
                else
                {
                    var client = new WebClient();
                    client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                    var response = client.DownloadString(txtExampleOutput.Text);
                    try
                    {
                        var releases = JObject.Parse(response);
                        textBoxOutput.Text = releases.ToString();

                    }
                    catch
                    {
                        var releases = response;
                        textBoxOutput.Text = releases.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                //Prints out exception
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonClear(object sender, EventArgs e)
        {
                comboPart2URL.SelectedItem = null;
                txtURL2.Text = null;
                comboPart3URL.SelectedItem = null;
                txtURL3.Text = " ";
                comboQuery.SelectedItem = null;
                txtQuery.Text = null;
                comboFacet.SelectedItem = null;
                txtFacet.Text = null;
                txtURLip.Text = null;
                txtHostname.Text = null;
                txtExampleOutput.Text = null;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            String callResolveHost = "https://api.shodan.io/dns/reverse?ips=" + txtURLip.Text + "&key=" + txtKey.Text;
            var client = new WebClient();       //Parse Data to JSON.net Object
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var response = client.DownloadString(callResolveHost);
            var releases = JObject.Parse(response);
            JsonTextReader reader = new JsonTextReader(new StringReader(response));

            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                if (reader.TokenType == JsonToken.String)
                {
                    Console.WriteLine(reader.Value);
                    txtHostname.Text = (string)reader.Value;
                }
            }
        }
        private void buttonResolve_Click(object sender, EventArgs e)
        {
            //DNS Hostname Resolve API Call
            //api.shodan.io/dns/resolve?hostnames={hostnames}&key={YOUR_API_KEY}

            String callResolveHost = "https://api.shodan.io/dns/resolve?hostnames=" + txtHostname.Text + "&key=" + txtKey.Text;

            //Parse Data to JSON.net Object
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            var response = client.DownloadString(callResolveHost);
            var releases = JObject.Parse(response);

            //Isolate JSON Values in Object
            string jsHostIP = (string)releases[txtHostname.Text];
            string hostIP = jsHostIP;

            //Change the value of the IP from the hostname DNS lookup
            txtURLip.Text = hostIP;


            //toolStripCreditValue.Text =  releases.ToString();

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void apiMenuItem_Click(object sender, EventArgs e)
        {
            FormAPI frm2 = new FormAPI()
            {
                //ShowDialog() waits until form has closed to run remaining code.
                StartPosition = FormStartPosition.Manual,
                Location = new Point(800, 300)
            };
            frm2.ShowDialog();
            updateExample(comboIndex1, comboIndex2);
            //After Form2 is closed... 
            txtKey.Text = MasterAPIkeyValue;
            toolStripRefresh_Click(sender, e);
        }

        private void comboPart2URL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtURL2.Text = (String)comboPart2URL.SelectedItem;
            Console.WriteLine(comboPart2URL.SelectedIndex);
            comboIndex1 = comboPart2URL.SelectedIndex;

            comboPart3URL.Items.Clear();

            int value = comboIndex1;
            switch (value)
            {
                case 0:                     //Shodan
                    Console.WriteLine(0);
                    comboPart3URL.Items.Insert(0, "-- Search Methods --");
                    comboPart3URL.Items.Insert(1, "host/{ip}");
                    comboPart3URL.Items.Insert(2, "host/count");
                    comboPart3URL.Items.Insert(3, "host/search");
                    comboPart3URL.Items.Insert(4, "host/search/tokens");
                    comboPart3URL.Items.Insert(5, "ports");
                    comboPart3URL.Items.Insert(6, "-- Demand Scan --");
                    comboPart3URL.Items.Insert(7, "protocols");
                    comboPart3URL.Items.Insert(8, "scan (1 credit)");
                    comboPart3URL.Items.Insert(9, "scan/internet");
                    comboPart3URL.Items.Insert(10, "scan/{id}");
                    comboPart3URL.Items.Insert(11, "-- Network Alert --");
                    comboPart3URL.Items.Insert(12, "alert (POST)");
                    comboPart3URL.Items.Insert(13, "alert/{id}/info");
                    comboPart3URL.Items.Insert(14, "alert/{id} (DELETE)");
                    comboPart3URL.Items.Insert(15, "alert/info");
                    comboPart3URL.Items.Insert(16, "-- Directory Method --");
                    comboPart3URL.Items.Insert(17, "query");
                    comboPart3URL.Items.Insert(18, "query/search");
                    comboPart3URL.Items.Insert(19, "query/tags");
                    comboPart3URL.Items.Insert(20, "-- Bulk Data --");
                    comboPart3URL.Items.Insert(21, "data");
                    comboPart3URL.Items.Insert(22, "data/{dataset}");
                    break;
                case 1:                     //Account
                    Console.WriteLine(1);
                    comboPart3URL.Items.Insert(0, "profile");
                    break;
                case 2:                     //DNS
                    Console.WriteLine(2);
                    comboPart3URL.Items.Insert(0, "resolve");
                    comboPart3URL.Items.Insert(1, "reverse");
                    break;
                case 3:                     //Tools
                    Console.WriteLine(3);
                    comboPart3URL.Items.Insert(0, "httpheaders");
                    comboPart3URL.Items.Insert(1, "myip");
                    break;
                case 4:                     //api-info
                    Console.WriteLine(4);
                    comboPart3URL.Items.Insert(0, "");
                    break;
                case 5:                     //labs
                    Console.WriteLine(5);
                    comboPart3URL.Items.Insert(0, "honeyscore/{ip}");                    
                    break;
            }

            //Select 1st index in comboBox -> moved to txtBox
            if (comboPart2URL.SelectedIndex != -1) { 
            comboPart3URL.SelectedIndex = 0;
            txtURL3.Text = comboPart3URL.Text;
            }

        }
        private void comboPart3URL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtURL3.Text = (String)comboPart3URL.SelectedItem;
            Console.WriteLine(comboPart3URL.SelectedIndex);
            comboIndex2 = comboPart3URL.SelectedIndex;
            buttonUpdate(sender, e);
        }

        private void ScrollTextBox(object sender, MouseEventArgs e)
        {
            // Check scroll amount (+ve is upwards)
            int deltaWheel = e.Delta;
            if (deltaWheel != 0)
            {
                // Find total number of lines
                int nLines = textBoxOutput.Lines.Length;
                if (nLines > 0)
                {
                    // Find line containing caret
                    int iLine = textBoxOutput.GetLineFromCharIndex(textBoxOutput.SelectionStart);
                    if (iLine >= 0)
                    {
                        // Scroll down
                        if (deltaWheel > 0)
                        {
                            // Move caret to start of previous line
                            if (iLine > 0)
                            {
                                int position = textBoxOutput.GetFirstCharIndexFromLine(iLine - 1);
                                textBoxOutput.Select(position, 0);

                            }
                        }
                        else // Scroll up
                        {
                            // Move caret to start of next line
                            if (iLine < (nLines - 1))
                            {
                                int position = textBoxOutput.GetFirstCharIndexFromLine(iLine + 1);
                                textBoxOutput.Select(position, 0);
                            }
                        }
                        // Scroll to new caret position
                        textBoxOutput.ScrollToCaret();
                    }
                }
            }
        }
        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Create API Call
                String checkUser = "i";
                checkUser = "https://api.shodan.io/account/profile" + "?key=" + txtKey.Text;

                //Parse Data to JSON.net Object
                var client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                var response = client.DownloadString(checkUser);
                var releases = JObject.Parse(response);

                //Isolate JSON Values in Object
                string jsMember = (string)releases["member"];
                string jsCredits = (string)releases["credits"];
                string jsDisplayName = (string)releases["display_name"];
                string jsCreated = (string)releases["created"];

                string userInfo = "Agent Info: " + " " + "CREDITS:" + jsCredits + "     " + "EMAIL:" + jsDisplayName;

                toolStripEmail.Text = jsDisplayName;
                toolStripCredits.Text = jsCredits;
                toolStripKey.Text = txtKey.Text;

                //toolStripCreditValue.Text =  releases.ToString();
            }

            catch
            {
                MessageBox.Show("Your API Key is Invalid. Please try again.");
            }

        }






        private void updateExample(int comboIndex1, int comboIndex2)
        {
            String exampleStr = null;

            //SHODAN
            if (comboIndex1 == 0)
            {
                int value = comboIndex2;






                switch (value)
                {
                    case 0:             //Search Methods
                        Console.WriteLine("-- Search Methods --");
                        break;
                    case 1:             //api.shodan.io/shodan/host/{ip}?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/" + "shodan/host/" + txtURLip.Text + "?key=";
                        break;
                    case 2:             //api.shodan.io/shodan/host/count?key={YOUR_API_KEY}&query={query}&facets={facets}                                              //FIX
                        exampleStr = txtAPIurl.Text + "/shodan/host/count?key=" + txtKey.Text + "&query=" + (String)comboQuery.SelectedItem + ":" + txtQuery.Text;
                        break;
                    case 3:             //api.shodan.io/shodan/host/search?key={YOUR_API_KEY}&query={query}&facets={facets}                                             //FIX
                        exampleStr = txtAPIurl.Text + "/shodan/host/search?key=" + txtKey.Text + "&query=" + (String)comboQuery.SelectedItem + ":" + txtQuery.Text;
                        break;
                    case 4:             //api.shodan.io/shodan/host/search/tokens?key={YOUR_API_KEY}&query={query}
                        exampleStr = txtAPIurl.Text + "/shodan/host/search/tokens?key=" + txtKey.Text + "&query=" + (String)comboQuery.SelectedItem + ":" + txtQuery.Text;
                        break;
                    case 5:             //api.shodan.io/shodan/ports?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/ports?key=" + txtKey.Text;
                        break;
                    case 6:             
                        Console.WriteLine("-- Demand Scan --");
                        break;
                    case 7:             //api.shodan.io/shodan/protocols?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/protocols?key=" + txtKey.Text;
                        break;
                    case 8:             //api.shodan.io/shodan/scan?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/scan?key=" + txtKey.Text;
                        break;
                    case 9:             //api.shodan.io/shodan/scan/internet?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/scan/internet?key=" + txtKey.Text;
                        break;
                    case 10:             //api.shodan.io/shodan/scan/{id}?key={YOUR_API_KEY}                    //FIX (ID input required)
                        exampleStr = txtAPIurl.Text + "/shodan/scan/{id}?key=" + txtKey.Text;
                        break;
                    case 11:
                        Console.WriteLine("-- Network Alerts --");
                        break;
                    case 12:             //api.shodan.io/shodan/scan/{id}?key={YOUR_API_KEY}                    //ALERT Post (Needs to post function)
                        exampleStr = txtAPIurl.Text + "/shodan/scan/{id}?key=" + txtKey.Text;
                        break;
                    case 13:             //api.shodan.io/shodan/alert/HKVGCP1WD79Z7W2T/info?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/alert/{id}/info?key=" + txtKey.Text;
                        break;
                    case 14:             //api.shodan.io/shodan/alert/{id}?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/alert/{id}/info?key=" + txtKey.Text;
                        break;
                    case 15:             //api.shodan.io/shodan/alert/info?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/alert/info?key=" + txtKey.Text;
                        break;
                    case 16:
                        Console.WriteLine("-- Directory Method --");
                        break;
                    case 17:             //api.shodan.io/shodan/query?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/query?key=" + txtKey.Text;
                        break;
                    case 18:             //api.shodan.io/shodan/query/search?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/query/search?key=" + txtKey.Text;
                        break;
                    case 19:             //api.shodan.io/shodan/query/tags?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/query/tags?key=" + txtKey.Text;                
                        break;
                    case 20:
                        Console.WriteLine("-- Bulk Data --");
                        break;
                    case 21:             //api.shodan.io/shodan/data?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/data?key=" + txtKey.Text;
                        break;
                    case 22:             //api.shodan.io/shodan/data/raw-daily?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/shodan/data/raw-daily?key=" + txtKey.Text;
                        break;

                }
            }               
            //ACCOUNT
            else if (comboIndex1 == 1)
            {
                int value = comboIndex2;

                switch (value)
                {
                    case 0:             //account/profile
                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text + "/" + txtURL3.Text + "?key=" + txtKey.Text;
                        break;
                }
            }
            //DNS
            else if (comboIndex1 == 2)
            {
                int value = comboIndex2;

                switch (value)
                {
                    case 0:
                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text + "/" + txtURL3.Text + "?hostnames=" + txtHostname.Text + "&key=" + txtKey.Text;
                        break;
                    case 1:             //dns/reverse
                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text + "/" + txtURL3.Text + "?ips=" + txtURLip.Text + "&key=" + txtKey.Text;
                        break;
                }
            }
            //TOOLS
            else if (comboIndex1 == 3)
            {
                int value = comboIndex2;

                switch (value)
                {
                    case 0:             //api.shodan.io/tools/httpheaders?key={YOUR_API_KEY}

                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text + "/" + txtURL3.Text + "?key=" + txtKey.Text;
                        break;
                    case 1:             //api.shodan.io/tools/myip?key={YOUR_API_KEY}

                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text + "/" + txtURL3.Text + "?key=" + txtKey.Text;
                        break;
                }
            }
            //API-INFO
            else if (comboIndex1 == 4)
            {
                int value = comboIndex2;

                switch (value)
                {
                    case 0:             //api.shodan.io/api-info?key={YOUR_API_KEY}

                        exampleStr = txtAPIurl.Text + "/" + txtURL2.Text+ "?key=" + txtKey.Text;
                        break;
                }
            }
            //LABS
            else if (comboIndex1 == 5)
            {
                int value = comboIndex2;

                switch (value)
                {
                    case 0:             //api.shodan.io/labs/honeyscore/{ip}?key={YOUR_API_KEY}
                        exampleStr = txtAPIurl.Text + "/" + comboPart2URL.Text + "/" + "honeyscore/" + txtURLip.Text + "?key=" + txtKey.Text;
                        break;
                }
            }          
            else { };

            //Write string to log, and change text..
            Console.WriteLine(exampleStr);
            txtExampleOutput.Text = exampleStr;
        }

        





        private void checkFacets_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFacets.Checked){
                comboFacet.Enabled = true;
                buttonUpdate(sender, e);
            }
            else{comboFacet.SelectedItem = null;
                comboFacet.Enabled = false;
            }

        }
        private void checkQuery_CheckedChanged(object sender, EventArgs e)
        {
            if (checkQuery.Checked){
                comboQuery.Enabled = true;
                buttonUpdate(sender, e);
            }
            else { comboQuery.SelectedItem = null;
                comboQuery.Enabled = false;
            }
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            buttonUpdate(sender, e);
        }

        private void comboQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUpdate(sender, e);
        }

        private void comboFacet_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUpdate(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about1 = new AboutBox1()
            {
                Location = new Point(800, 300)
            };
            about1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView frm2 = new TreeView();
            frm2.Show();
        }

        private void txtURL2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }
    }


}