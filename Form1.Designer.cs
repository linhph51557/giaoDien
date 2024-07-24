namespace giaoDien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpmenu = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btndatBan = new Button();
            btntiemKiem = new Button();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            btnnhaHang = new Button();
            btnkhuyenMai = new Button();
            btnmenu = new Button();
            pictureBox5 = new PictureBox();
            btntrangChu = new Button();
            grpmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(label1);
            grpmenu.Controls.Add(pictureBox1);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(283, 70);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(919, 627);
            grpmenu.TabIndex = 19;
            grpmenu.TabStop = false;
            grpmenu.Text = "Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 565);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Tiểu sử nhà hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(907, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(425, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 18;
            // 
            // btndatBan
            // 
            btndatBan.BackColor = Color.IndianRed;
            btndatBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btndatBan.Location = new Point(998, 28);
            btndatBan.Name = "btndatBan";
            btndatBan.Size = new Size(109, 43);
            btndatBan.TabIndex = 17;
            btndatBan.Text = "Đặt bàn";
            btndatBan.UseVisualStyleBackColor = false;
            // 
            // btntiemKiem
            // 
            btntiemKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntiemKiem.Location = new Point(300, 21);
            btntiemKiem.Name = "btntiemKiem";
            btntiemKiem.RightToLeft = RightToLeft.Yes;
            btntiemKiem.Size = new Size(109, 43);
            btntiemKiem.TabIndex = 16;
            btntiemKiem.Text = "Tìm kiếm";
            btntiemKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(btnnhaHang);
            groupBox1.Controls.Add(btnkhuyenMai);
            groupBox1.Controls.Add(btnmenu);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(btntrangChu);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(32, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 614);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(-1, 516);
            button6.Name = "button6";
            button6.Size = new Size(217, 88);
            button6.TabIndex = 11;
            button6.Text = "Nhân Viên";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(0, 438);
            button5.Name = "button5";
            button5.Size = new Size(217, 88);
            button5.TabIndex = 10;
            button5.Text = "Đánh Giá";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnnhaHang
            // 
            btnnhaHang.BackColor = SystemColors.ActiveCaption;
            btnnhaHang.Location = new Point(0, 354);
            btnnhaHang.Name = "btnnhaHang";
            btnnhaHang.Size = new Size(217, 88);
            btnnhaHang.TabIndex = 9;
            btnnhaHang.Text = "Nhà Hàng";
            btnnhaHang.UseVisualStyleBackColor = false;
            btnnhaHang.Click += btnnhaHang_Click;
            // 
            // btnkhuyenMai
            // 
            btnkhuyenMai.BackColor = SystemColors.ActiveCaption;
            btnkhuyenMai.Location = new Point(0, 274);
            btnkhuyenMai.Name = "btnkhuyenMai";
            btnkhuyenMai.Size = new Size(217, 88);
            btnkhuyenMai.TabIndex = 8;
            btnkhuyenMai.Text = "Khuyến mãi";
            btnkhuyenMai.UseVisualStyleBackColor = false;
            btnkhuyenMai.Click += btnkhuyenMai_Click;
            // 
            // btnmenu
            // 
            btnmenu.BackColor = SystemColors.ActiveCaption;
            btnmenu.Location = new Point(0, 193);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(217, 88);
            btnmenu.TabIndex = 7;
            btnmenu.Text = "Menu";
            btnmenu.UseVisualStyleBackColor = false;
            btnmenu.Click += btnmenu_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(157, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // btntrangChu
            // 
            btntrangChu.BackColor = SystemColors.ActiveCaption;
            btntrangChu.Location = new Point(0, 109);
            btntrangChu.Name = "btntrangChu";
            btntrangChu.Size = new Size(217, 88);
            btntrangChu.TabIndex = 0;
            btntrangChu.Text = "Trang chủ";
            btntrangChu.UseVisualStyleBackColor = false;
            btntrangChu.Click += btntrangChu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1510, 739);
            Controls.Add(grpmenu);
            Controls.Add(textBox1);
            Controls.Add(btndatBan);
            Controls.Add(btntiemKiem);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            grpmenu.ResumeLayout(false);
            grpmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpmenu;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btndatBan;
        private Button btntiemKiem;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button btnnhaHang;
        private Button btnkhuyenMai;
        private Button btnmenu;
        private PictureBox pictureBox5;
        private Button btntrangChu;
    }
}