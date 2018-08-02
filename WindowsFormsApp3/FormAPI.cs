using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShodanDesktop
{


    public partial class FormAPI : Form
    {
        public FormAPI()
        {
            InitializeComponent();
        }

        public void txtAPIKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            FormMain.MasterAPIkeyValue = txtAPIKey.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            txtAPIKey.Text = txtAPIKey.Text;
            this.Close();
        }

        private void Form2APIsettings_Load(object sender, EventArgs e)
        {

        }

        private void APIkeyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
