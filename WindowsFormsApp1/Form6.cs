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
    public partial class Form6 : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int intthanhtien = 0;
        private String VeDaChon;
        private String PhongChieu;
        public Form6()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor !=Color.Yellow)
            {
                if(btn.BackColor==Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            } 
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Đào, phở và piano")
            {
                foreach (Button b in DanhSachChon)
                {
                    String a = b.Text;
                    VeDaChon += b.Text + "  ";
                    if (a == "A1" || a == "A5" || a == "C1" || a == "C5" || a == "B1"||a == "B5")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien +=45000*1/4;
                    }
                    else if (a == "A2" || a == "A3" || a == "A4" || a == "C2" || a == "C3"||a=="C4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 45000;
                    }
                    else if (a == "B2" || a == "B3" || a == "B4" )
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 45000*2;

                    }
                  
                }
            }
            else if (comboBox1.Text == "Mai")
            {
                foreach (Button b in DanhSachChon)
                {
                    String a = b.Text;
                    VeDaChon += b.Text + "  ";
                    if (a == "A1" || a == "A5" || a == "C1" || a == "C5" || a == "B1" || a == "B5")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 100000 * 1 / 4;
                    }
                    else if (a == "A2" || a == "A3" || a == "A4" || a == "C2" || a == "C3" || a == "C4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 100000;
                    }
                    else if (a == "B2" || a == "B3" || a == "B4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 100000 * 2;

                    }
                    
                }
            }
            else if (comboBox1.Text == "Gặp lại chị bầu")
            {
                foreach (Button b in DanhSachChon)
                {
                    String a = b.Text;
                    VeDaChon += b.Text + "  ";
                    if (a == "A1" || a == "A5" || a == "C1" || a == "C5" || a == "B1" || a == "B5")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 70000 / 4;
                    }
                    else if (a == "A2" || a == "A3" || a == "A4" || a == "C2" || a == "C3" || a == "C4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 70000;
                    }
                    else if (a == "B2" || a == "B3" || a == "B4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 70000 * 2;

                    }
                  
                }
            }
            else if (comboBox1.Text == "Tarot")
            {
                foreach (Button b in DanhSachChon)
                {
                    String a = b.Text;
                    VeDaChon += b.Text + "  ";
                    if (a == "A1" || a == "A5" || a == "C1" || a == "C5" || a == "B1" || a == "B5")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 90000 * 1 / 4;
                    }
                    else if (a == "A2" || a == "A3" || a == "A4" || a == "C2" || a == "C3" || a == "C4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 90000;
                    }
                    else if (a == "B2" || a == "B3" || a == "B4")
                    {
                        b.BackColor = Color.Yellow;
                        intthanhtien += 90000 * 2;

                    }
                   
                }
            }
            if (PhongChieu == null)
            {
                MessageBox.Show("ban can chon phong chieu truoc khi chon ve");
            }
            else
            // Tạo một instance của InputDialogForm
            {
                Form11 inputDialog = new Form11();

                // Hiển thị dialog

                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy giá trị từ TextBox của dialog và gán vào label7
                    label7.Text = "Họ tên: " + inputDialog.HoTen + "\n" + "ve da chon : " + VeDaChon + "\n" + "ten phim : " + comboBox1.Text + "\n" + PhongChieu + "\n" + "thanh tien : " + intthanhtien;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Đào, phở và piano")
            {
                btn4.Visible = true;
                btn5.Visible = true;
                btn6.Visible = true;
                btn4.Text = "Phòng Chiếu 1";
                btn5.Text = "phòng chiếu 2";
                btn6.Text = "phòng chiếu 3";
            }
            else if (comboBox1.Text == "Mai")
            {
                btn5.Visible = true;
                btn6.Visible = true;
                btn4.Visible = false;
                btn5.Text = "phòng chiếu 2";
                btn6.Text = "phòng chiếu 3";
            }
            else if (comboBox1.Text == "Gặp lại chị bầu")
            {
                btn4.Visible = true;
                btn4.Text = " Phòng chiếu 1 ";
                btn5.Visible = false;
                btn6.Visible = false;
            }
            else if (comboBox1.Text == "Tarot")
            {
                btn6.Visible = true;
                btn6.Text = " Phòng chiếu 3 ";
                btn4.Visible = false;
                btn5.Visible = false;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show(" Co nguoi chon roi !!!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            label7.Text = intthanhtien.ToString();
            intthanhtien = 0;
            DanhSachChon = new List<Button>();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            foreach(Button b in DanhSachChon)
            {
                b.BackColor = Color.White;
            }
            VeDaChon = "";
            PhongChieu = null;
            intthanhtien = 0;
            label7.Text = "";

            DanhSachChon = new List<Button>();
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
           
            btn5.Visible = false;
            btn6.Visible = false;
            
            PhongChieu = btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn4.Visible = false;
            btn6.Visible = false;
            
            PhongChieu = btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn5.Visible = false;
            btn4.Visible = false;
            
            PhongChieu = btn6.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
