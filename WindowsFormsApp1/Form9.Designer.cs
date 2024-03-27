namespace WindowsFormsApp1
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài 07: Xử lý mảng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mời bạn nhập dữ liệu sinh viên. Ví dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9,10, 8.5, 9," +
    " 10, 3.5 ,5.5, 2. ";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 165);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(781, 30);
            this.lbl1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(776, 44);
            this.lbl2.TabIndex = 3;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 239);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(750, 26);
            this.lbl3.TabIndex = 4;
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(12, 280);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(750, 26);
            this.lbl4.TabIndex = 5;
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(12, 322);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(750, 37);
            this.lbl5.TabIndex = 6;
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(40, 392);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(163, 38);
            this.lbl6.TabIndex = 7;
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(8, 80);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(743, 22);
            this.txt1.TabIndex = 8;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(27, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(145, 43);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Hiện kết quả";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(261, 123);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(145, 43);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "Xóa";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(511, 123);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(145, 43);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "Thoát";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl7
            // 
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(301, 392);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(188, 38);
            this.lbl7.TabIndex = 12;
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl8
            // 
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(588, 392);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(163, 38);
            this.lbl8.TabIndex = 13;
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
    }
}