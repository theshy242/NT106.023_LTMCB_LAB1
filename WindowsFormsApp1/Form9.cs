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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            string[] data = input.Split(',');

            // Kiểm tra tính hợp lệ của dữ liệu
            if (data.Length < 2 )
            {
                MessageBox.Show("Đã nhập sai định dạng.");
                return;
            }

            // Xuất tên sinh viên
            string name = data[0].Trim();
            lbl1.Text=($"Họ và tên: {name}\n");

            // Xuất danh sách điểm
            
            for (int i = 1; i < data.Length; i++)
            {
                lbl2.Text += $"  Môn {i}: {data[i].Trim()}";
            }

            // Tính điểm trung bình
            double totalScore = 0;
            double maxScore = double.MinValue;
            double minScore = double.MaxValue;
            int passedSubjects = 0;
            for (int i = 1; i < data.Length; i++)
            {
                double score;
                if (double.TryParse(data[i].Trim(), out score))
                {
                    totalScore += score;
                    if (score > maxScore)
                        maxScore = score;
                    if (score < minScore)
                        minScore = score;
                    if (score >= 5)
                        passedSubjects++;
                }
                else
                {
                    MessageBox.Show("Đã nhập sai định dạng điểm.");
                    return;
                }
            }

            double averageScore = totalScore / (data.Length - 1);
            lbl3.Text=($"Điểm trung bình: {averageScore}");

            lbl4.Text=($"Điểm cao nhất: {maxScore}");
            lbl5.Text=($"Điểm thấp nhất: {minScore}");

            lbl6.Text=($"Số môn đậu: {passedSubjects}");
            lbl7.Text=($"Số môn không đậu: {data.Length - 1 - passedSubjects}");

            // Xếp loại sinh viên
            string classification;
            if (averageScore >= 8 && minScore >= 6.5)
                classification = "Giỏi";
            else if (averageScore >= 6.5 && minScore >= 5)
                classification = "Khá";
            else if (averageScore >= 5 && minScore >= 3.5)
                classification = "Trung bình";
            else if (averageScore >= 3.5 && minScore >= 2)
                classification = "Yếu";
            else
                classification = "Kém";

           lbl8.Text=($"Xếp loại: {classification}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
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
