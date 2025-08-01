namespace supportlink
{
    partial class SupportLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportLink));
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox3 = new ComboBox();
            button4 = new Button();
            lbl_tt_token = new Label();
            button5 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            label4 = new Label();
            label5 = new Label();
            button8 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Image = Properties.Resources.Custom_Icon_Design_Flatastic_9_Generate_keys_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-1, 109);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 0;
            button1.Text = "Chuyển Token";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(124, 151);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 414;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hệ thống thanh toán tập trung", "Hệ thống thanh toán quốc tế - SWIFT", "Quản lý xác thực và làm sạch thông tin khách hàng", "ARS - Kiều hối", "Hệ thống thanh toán song phương kho bạc", "Hệ thống thanh toán bảo hiểm xã hội", "Hệ thống thanh toán hoá đợn - Bill Payment" });
            comboBox1.Location = new Point(390, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 33);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(754, 303);
            button2.Name = "button2";
            button2.Size = new Size(133, 33);
            button2.TabIndex = 3;
            button2.Text = "Truy cập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Image = Properties.Resources.Iconoir_Team_Iconoir_Ip_address_32;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(541, 203);
            button3.Name = "button3";
            button3.Size = new Size(147, 80);
            button3.TabIndex = 5;
            button3.Text = "Lấy địa chỉ IP";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(lbl_tt_token);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(206, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 164);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chỉnh sửa file IPCAS2.ini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 30);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(224, 37);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 11;
            label2.Text = "Chi nhánh hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(-2, 37);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 10;
            label1.Text = "Token hiện tại:";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 11F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "6612 - Agribank Chi nhánh Bắc Long An", "6609 - Agribank Chi nhánh Đức Huệ", "6613 - Agribank Chi nhánh Đức Hoà", "6619 - Agribank Chi nhánh Tân Mỹ", "6620 - Agribank Chi nhánh Mộc Hoá" });
            comboBox3.Location = new Point(224, 68);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(414, 33);
            comboBox3.TabIndex = 9;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Image = Properties.Resources.icon_1753414546;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(224, 112);
            button4.Name = "button4";
            button4.Size = new Size(173, 44);
            button4.TabIndex = 8;
            button4.Text = "Chuyển chi nhánh";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lbl_tt_token
            // 
            lbl_tt_token.AutoSize = true;
            lbl_tt_token.Font = new Font("Segoe UI", 11F);
            lbl_tt_token.Location = new Point(-1, 76);
            lbl_tt_token.Name = "lbl_tt_token";
            lbl_tt_token.Size = new Size(63, 25);
            lbl_tt_token.TabIndex = 7;
            lbl_tt_token.Text = "label1";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Image = Properties.Resources.logo__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-7, 33);
            button5.Name = "button5";
            button5.Size = new Size(145, 80);
            button5.TabIndex = 7;
            button5.Text = "IPCAS2";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Image = Properties.Resources.logo__1_;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(145, 33);
            button6.Name = "button6";
            button6.Size = new Size(184, 80);
            button6.TabIndex = 8;
            button6.Text = "Update IPCAS";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(206, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 124);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hệ thống IPCAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vector_agribank_chu_do_Photoroom;
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.z6839368237570_605d083b044e69475c7ca1673c29e5d9_Photoroom;
            pictureBox2.Location = new Point(5, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_system_software_update_32;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(694, 203);
            button7.Name = "button7";
            button7.Size = new Size(193, 78);
            button7.TabIndex = 12;
            button7.Text = "Cập nhật phần mềm";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(206, 311);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 13;
            label4.Text = "Truy cập hệ thống:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(580, 355);
            label5.Name = "label5";
            label5.Size = new Size(314, 40);
            label5.TabIndex = 14;
            label5.Text = "Mọi thắc mắc liên hệ Hotline: 0908 033 850\r\nLê Hoàng An - Bộ phận IT";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_system_time_32;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(5, 174);
            button8.Name = "button8";
            button8.Size = new Size(195, 47);
            button8.TabIndex = 15;
            button8.Text = "Hẹn giờ Windows";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // SupportLink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 414);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SupportLink";
            Text = "Support Link - Version: 1.0.1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label lbl_tt_token;
        private Button button4;
        private ComboBox comboBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button6;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button7;
        private Label label4;
        private Label label5;
        private Button button8;
    }
}
