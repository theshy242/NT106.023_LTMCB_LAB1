namespace WindowsFormsApp1
{
    partial class Form8
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
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(103, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(580, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Chương trình tìm cung hoàng đạo của bạn";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(31, 78);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(207, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Mời bạn nhập ngày sinh";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(31, 136);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(214, 20);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Mời bạn nhập thánh sinh";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(31, 191);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(209, 20);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Mời bạn nhập năm sinh ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(266, 76);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(354, 22);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(266, 134);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(354, 22);
            this.txt2.TabIndex = 5;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(266, 188);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(354, 22);
            this.txt3.TabIndex = 6;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(58, 343);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(657, 73);
            this.lbl6.TabIndex = 7;
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(109, 245);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 41);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Tìm";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Lime;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(283, 245);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 41);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "xóa";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Lime;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(471, 245);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 41);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "Thoát";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}