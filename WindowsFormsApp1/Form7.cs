using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (cbx1.Text == "Bảng cửu chương")
            {
                int A, B;
                if (int.TryParse(txt1.Text, out A) && int.TryParse(txt2.Text, out B))
                {
                    // Bảng cửu chương của B - A
                    int result = B - A;
                    string multiplicationTable = "";
                    for (int i = 1; i <= 10; i++)
                    {
                        multiplicationTable += $"{result} x {i} = {result * i}\n";
                    }


                    // Hiển thị kết quả
                    lbl1.Text = $"Bảng cửu chương của {result}:\n{multiplicationTable}\n(A - B)! = " + multiplicationTable;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B!");
                }
            }
            else if(cbx1.Text=="Tính toán giá trị")
            {
                int A, B;
                if (int.TryParse(txt1.Text, out A) && int.TryParse(txt2.Text, out B))
                {
                    int diff = A - B;
                    long factorial = 1;
                    for (int i = 1; i <= diff; i++)
                    {
                        factorial *= i;
                    }
                  
                    // Tính tổng
                    double sum = 0;
                    for (int i = 1; i <= B; i++)
                    {
                        sum += Math.Pow(A, i);
                    }
                    lbl1.Text=($"(A-B)!=({A - B})! = {factorial}\n   Tổng S(A^1+A^2+...+A^B) = {sum}\n");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chức năng.");
                }
            } 
            }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lbl1.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }
