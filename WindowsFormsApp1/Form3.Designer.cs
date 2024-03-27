namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.IndianRed;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Lime;
            this.lbl1.Location = new System.Drawing.Point(94, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(515, 33);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bài 2: Số Lớn Nhất, Nhỏ Nhất";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 116);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(96, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Số Thứ Nhất ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(234, 115);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(81, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Số Thứ hai";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(461, 113);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(79, 16);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "Số Thứ Ba";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(12, 335);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(113, 20);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "Số Lớn Nhất";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(419, 335);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(121, 20);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "Số Nhỏ Nhất ";
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(114, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 41);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Tìm ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(339, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 41);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Xóa ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(556, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 41);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Thoát";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Cyan;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(131, 328);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(184, 27);
            this.lbl8.TabIndex = 9;
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Cyan;
            this.lbl9.Location = new System.Drawing.Point(553, 328);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(184, 27);
            this.lbl9.TabIndex = 10;
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(114, 112);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 11;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(339, 110);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 12;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(556, 109);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 22);
            this.txt3.TabIndex = 13;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
    }
}