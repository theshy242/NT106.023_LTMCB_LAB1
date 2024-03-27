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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
            if(!int.TryParse(txt1.Text,out int number ))
            {
                MessageBox.Show("Vui lòng nhập số nguyên ");
            }
            else if(number>9||number<0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9 ");
            } 
           
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(txt1.Text.Trim());
           switch(number1)
            {
                case 0:
                    lbl4.Text = "Không";
                    break;
                case 1:
                    lbl4.Text = "Một";
                    break;
                case 2:
                    lbl4.Text = "Hai";
                    break;
                case 3:
                    lbl4.Text = "Ba";
                    break;
                case 4:
                    lbl4.Text = "Bốn";
                    break;
                case 5:
                    lbl4.Text = "Năm";
                    break;
                case 6:
                    lbl4.Text = "sáu";
                    break;
                case 7:
                    lbl4.Text = "bảy";
                    break;
                case 8:
                    lbl4.Text = "Tám";
                    break;
                case 9:
                    lbl4.Text = "Chín";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
