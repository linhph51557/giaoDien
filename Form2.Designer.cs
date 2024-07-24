namespace giaoDien
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            grpmenu = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
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
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(groupBox3);
            grpmenu.Controls.Add(groupBox2);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(279, 81);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(919, 573);
            grpmenu.TabIndex = 19;
            grpmenu.TabStop = false;
            grpmenu.Text = "Đánh Giá";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(488, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 388);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chất lượng phục vụ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(376, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 219);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhận xét của bạn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 252);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 130);
            textBox3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(29, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 388);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chất lượng bữa ăn";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 219);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhận xét của bạn";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 252);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 130);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 18;
            // 
            // btndatBan
            // 
            btndatBan.BackColor = Color.IndianRed;
            btndatBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btndatBan.Location = new Point(994, 39);
            btndatBan.Name = "btndatBan";
            btndatBan.Size = new Size(109, 43);
            btndatBan.TabIndex = 17;
            btndatBan.Text = "Đặt bàn";
            btndatBan.UseVisualStyleBackColor = false;
            // 
            // btntiemKiem
            // 
            btntiemKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntiemKiem.Location = new Point(296, 32);
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
            groupBox1.Location = new Point(27, 40);
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
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1489, 757);
            Controls.Add(grpmenu);
            Controls.Add(textBox1);
            Controls.Add(btndatBan);
            Controls.Add(btntiemKiem);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            grpmenu.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpmenu;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox2;
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}