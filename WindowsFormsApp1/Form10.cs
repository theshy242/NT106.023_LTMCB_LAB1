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
    public partial class Form10 : Form
    {
        private string foodList = "Cơm, Phở, Bún chả, Bánh mì, Hamburger, Pizza";
        
        
        public Form10()
        {
            InitializeComponent();
            lbl1.Text = string.Join(", ", foodList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFood = txt1.Text.Trim();
            if (!string.IsNullOrEmpty(newFood))
            {
                if (!foodList.Contains(newFood))
                {
                    foodList += $", {newFood}";
                    lbl1.Text = foodList;
                    txt1.Clear();
                    MessageBox.Show("Món ăn mới đã được thêm vào danh sách.");
                }
                else
                {
                    MessageBox.Show("Món ăn này đã có trong danh sách.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn mới.");
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] foods = foodList.Split(',');
            if (foods.Length > 0 && !string.IsNullOrEmpty(foodList))
            {
                Random random = new Random();
                int index = random.Next(0, foods.Length);
                string chosenFood = foods[index].Trim();
                 lbl2.Text=chosenFood;
            }
            else
            {
                MessageBox.Show("Danh sách món ăn trống. Vui lòng thêm món ăn mới.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foodList = "";
            lbl1.Text = "";
            txt1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
