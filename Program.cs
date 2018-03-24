using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class ClsForm : Form
    {
        Button btnLength,btnArea;
        Line line = new Line();
        public ClsForm()
        {
            btnLength = new Button
            {
                Text = "Length"
                //
            };
            this.Controls.Add(btnLength);
            this.btnLength.Click += Btn_Click;
            btnArea = new Button {
                Text = "area",
                Top=50
            };
            this.Controls.Add(btnArea);
            this.btnArea.Click += BtnArea_Click;
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            line.Area();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            line.X = 0; line.X1 = 10;
            line.Y = 0; line.Y1 = 0;
            this.Text = line.ToString()+"Length="+ line.Length();
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
