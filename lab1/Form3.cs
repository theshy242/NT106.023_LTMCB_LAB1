using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
            
            if(!double.TryParse(txt1.Text,out _ ))
            {
                MessageBox.Show("Vui lòng nhập số bất kì ");
            }
            else
            {

            }
                
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txt2.Text, out _))
            {
                MessageBox.Show("vui long nhập số bất kì ");
            }
            else
            {

            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txt3.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số bất kì ");
            }
            else
            {

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double so1, so2, so3;
            so1 = double.Parse(txt1.Text.Trim());
            so2 = double.Parse(txt2.Text.Trim());
            so3 = double.Parse(txt3.Text.Trim());
            double max, min;
            if(so1>=so2&& so2>=so3)
            {
                max = so1;
            }
            else if(so2>=so1 && so2>=so3)
            {
                max = so2;
            }
            else
            {
                max = so3;
            }
            if (so1 <= so2 && so2 <= so3)
            {
                min = so1;
            }
            else if (so2 <= so1 && so2 <= so3)
            {
                min = so2;
            }
            else
            {
                min = so3;
            }
            lbl8.Text = max.ToString();
            lbl9.Text = min.ToString();
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
