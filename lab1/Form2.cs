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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     

       
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txt1.Text, out _))
            {
                MessageBox.Show("Vui Lòng Nhập Số Nguyên ");
            }  
            else
            {
                
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt2.Text, out _))
            {
                MessageBox.Show("Vui Lòng Nhập Số Nguyên ");
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int so1, so2;
            long sum = 0;
            so1 = Int32.Parse(txt1.Text.Trim());
            so2 = Int32.Parse(txt2.Text.Trim());
            sum = so1 + so2;
            lbl4.Text = sum.ToString();
        }
    }
}
