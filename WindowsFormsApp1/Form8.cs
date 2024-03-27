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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txt1.Text);
            int month = Convert.ToInt32(txt2.Text);

            string zodiacSign = FindZodiacSign(day, month);

            lbl6.Text = "Cung hoàng đạo của bạn là : " + zodiacSign;
        }

        private string FindZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day >= 21)
                        return "Bảo Bình";
                    else
                        return "Ma Kết";
                case 2:
                    if (day <= 19)
                        return "Bảo Bình";
                    else
                        return "Song Ngư";
                case 3:
                    if (day >= 21)
                        return "Bạch Dương";
                    else
                        return "Song Ngư";
                case 4:
                    if (day <= 20)
                        return "Bạch Dương";
                    else
                        return "Kim Ngưu";
                case 5:
                    if (day <= 21)
                        return "Kim Ngưu";
                    else
                        return "Song Tử";
                case 6:
                    if (day <= 21)
                        return "Song Tử";
                    else
                        return "Cự Giải";
                case 7:
                    if (day <= 22)
                        return "Cự Giải";
                    else
                        return "Sư Tử";
                case 8:
                    if (day <= 22)
                        return "Sư Tử";
                    else
                        return "Xử Nữ";
                case 9:
                    if (day <= 23)
                        return "Xử Nữ";
                    else
                        return "Thiên Bình";
                case 10:
                    if (day <= 23)
                        return "Thiên Bình";
                    else
                        return "Thần Nông";
                case 11:
                    if (day <= 22)
                        return "Thần Nông";
                    else
                        return "Nhân Mã";
                case 12:
                    if (day <= 21)
                        return "Nhân Mã";
                    else
                        return "Ma Kết";
                default:
                    return "xin vui lòng kiểm tra lại giá trị bạn nhập ";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            lbl6.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }
    }
}
