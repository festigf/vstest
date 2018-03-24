using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class ClsForm : Form
    {
        Button btn = new Button();
        public ClsForm()
        {
            this.Controls.Add(btn);
        }

    }

    class Program
    { 


        static void Main(string[] args)
        {
            Application.Run(new ClsForm());
        }
    }
}
