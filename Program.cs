using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class ClsForm : Form
    {
        Button btnLength,btnArea;
        Shape line = new Line(0, 0, 10, 0, "Linea");
        Shape rect = new Rectagle(0, 0, 20, 30, "rect");
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
            //rect.X = 0; rect. = 10;
            //rect.Y = 0; rect.Y1 = 10;
            this.btnArea.Text=rect.Area.ToString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
           // line.X0 = 0; line.X1 = 10;
           // line.Y0 = 0; line.Y1 = 0;
            this.Text = line.ToString()+"Length="+ line.Length;
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
