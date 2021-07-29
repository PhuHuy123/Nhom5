using System;
using System.Windows.Forms;

namespace UocChungLonNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (a > b)
            {
                int i;
                for (i = b; i >= 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        label5.Text = "" + i;
                        break;
                    }
                }
            }
            else
            {
                int i;
                for (i = a; i >= 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {

                        label5.Text = "" + i;
                        break;
                    }
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát hay không", "Thoát", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
