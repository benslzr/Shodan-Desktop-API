namespace WindowsFormsApp3
{

    using System;

    public class shodanCall
    {
        private string iOutVal;
        //Default constructor
        public shodanCall()
        {
            iOutVal = "Hello";
        }
        public shodanCall(int iVal1)
        {
            iOutVal = iVal1;
        }
        //destructor
        ~shodanCall()
        {
            iOutVal = 0;
        }

        //methods
        public void displayiOutVal()
        {
            Console.WriteLine("iOutVal = Hello");

        }





    }
}