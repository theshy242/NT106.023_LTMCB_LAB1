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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            // Lấy số được nhập từ TextBox
            string input = txt1.Text.Trim();

            // Kiểm tra xem liệu số có đủ 12 chữ số không
            if (input.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập một số có 12 chữ số.", "Thông báo");
                return;
            }

            // Mảng các chuỗi đại diện cho từng chữ số
            string[] digits = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            // Mảng các chuỗi đại diện cho các mức độ của số
            string[] levels = { "", "nghìn", "triệu", "tỷ" };

            // Biến lưu trữ chuỗi kết quả
            string result = "";

            // Đọc từng nhóm 3 chữ số, bắt đầu từ hàng đơn vị
            for (int i = 0; i < 12; i += 3)
            {
                string group = input.Substring(i, 3); // Lấy 3 chữ số tiếp theo
                int number = int.Parse(group); // Chuyển đổi chuỗi thành số nguyên

                // Nếu nhóm số này không phải là số 0
                if (number != 0)
                {
                    // Đọc hàng đơn vị và hàng chục
                    int unit = number / 100;
                    int ten = (number % 100) / 10;

                    if (unit > 0)
                        result += digits[unit] + " trăm ";

                    if (ten == 0 && unit > 0)
                        result += "linh ";
                    else if (ten == 1)
                        result += "mười ";
                    else if (ten > 1)
                        result += digits[ten] + " mươi ";

                    int unitDigit = number % 10;
                    if (unitDigit > 1)
                        result += digits[unitDigit] + " ";
                    else if (unitDigit == 1)
                        result += (ten > 1) ? "mốt " : "một ";

                    // Thêm mức độ tương ứng
                    result += levels[i / 3] + ", ";
                }
            }

            // Xóa dấu phẩy cuối cùng
            result = result.TrimEnd(' ', ',');

            // Hiển thị kết quả trong Label
            lbl4.Text = result;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

