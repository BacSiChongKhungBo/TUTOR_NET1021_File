namespace TUTOR_NET1021_File
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Path = new TextBox();
            rtxt_NoiDung = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Doc = new Button();
            btn_Ghi = new Button();
            txt_MaSV = new TextBox();
            txt_HoTen = new TextBox();
            txt_Tuoi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_GhiSV = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txt_Path
            // 
            txt_Path.Location = new Point(12, 96);
            txt_Path.Name = "txt_Path";
            txt_Path.Size = new Size(219, 23);
            txt_Path.TabIndex = 0;
            // 
            // rtxt_NoiDung
            // 
            rtxt_NoiDung.Location = new Point(12, 213);
            rtxt_NoiDung.Name = "rtxt_NoiDung";
            rtxt_NoiDung.Size = new Size(364, 225);
            rtxt_NoiDung.TabIndex = 1;
            rtxt_NoiDung.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 2;
            label1.Text = "Địa chỉ file (Path)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(132, 37);
            label2.TabIndex = 3;
            label2.Text = "Nội Dung";
            // 
            // btn_Doc
            // 
            btn_Doc.Font = new Font("Segoe UI", 20F);
            btn_Doc.Location = new Point(247, 67);
            btn_Doc.Name = "btn_Doc";
            btn_Doc.Size = new Size(129, 64);
            btn_Doc.TabIndex = 4;
            btn_Doc.Text = "Đọc";
            btn_Doc.UseVisualStyleBackColor = true;
            btn_Doc.Click += btn_Doc_Click;
            // 
            // btn_Ghi
            // 
            btn_Ghi.Font = new Font("Segoe UI", 20F);
            btn_Ghi.Location = new Point(247, 143);
            btn_Ghi.Name = "btn_Ghi";
            btn_Ghi.Size = new Size(129, 64);
            btn_Ghi.TabIndex = 5;
            btn_Ghi.Text = "Ghi";
            btn_Ghi.UseVisualStyleBackColor = true;
            btn_Ghi.Click += btn_Ghi_Click;
            // 
            // txt_MaSV
            // 
            txt_MaSV.Location = new Point(533, 96);
            txt_MaSV.Name = "txt_MaSV";
            txt_MaSV.Size = new Size(219, 23);
            txt_MaSV.TabIndex = 6;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(533, 143);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(219, 23);
            txt_HoTen.TabIndex = 7;
            // 
            // txt_Tuoi
            // 
            txt_Tuoi.Location = new Point(533, 187);
            txt_Tuoi.Name = "txt_Tuoi";
            txt_Tuoi.Size = new Size(219, 23);
            txt_Tuoi.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(382, 82);
            label3.Name = "label3";
            label3.Size = new Size(93, 37);
            label3.TabIndex = 9;
            label3.Text = "Mã SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(382, 128);
            label4.Name = "label4";
            label4.Size = new Size(99, 37);
            label4.TabIndex = 10;
            label4.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(382, 173);
            label5.Name = "label5";
            label5.Size = new Size(69, 37);
            label5.TabIndex = 11;
            label5.Text = "Tuổi";
            // 
            // btn_GhiSV
            // 
            btn_GhiSV.Font = new Font("Segoe UI", 20F);
            btn_GhiSV.Location = new Point(623, 236);
            btn_GhiSV.Name = "btn_GhiSV";
            btn_GhiSV.Size = new Size(129, 64);
            btn_GhiSV.TabIndex = 12;
            btn_GhiSV.Text = "Ghi";
            btn_GhiSV.UseVisualStyleBackColor = true;
            btn_GhiSV.Click += btn_GhiSV_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(414, 236);
            button1.Name = "button1";
            button1.Size = new Size(129, 64);
            button1.TabIndex = 13;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(382, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(585, 315);
            button2.Name = "button2";
            button2.Size = new Size(129, 51);
            button2.TabIndex = 15;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 621);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(btn_GhiSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Tuoi);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_MaSV);
            Controls.Add(btn_Ghi);
            Controls.Add(btn_Doc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxt_NoiDung);
            Controls.Add(txt_Path);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Path;
        private RichTextBox rtxt_NoiDung;
        private Label label1;
        private Label label2;
        private Button btn_Doc;
        private Button btn_Ghi;
        private TextBox txt_MaSV;
        private TextBox txt_HoTen;
        private TextBox txt_Tuoi;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_GhiSV;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}
