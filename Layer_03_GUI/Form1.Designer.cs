namespace Layer_03_GUI
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
            lbl_sp_Heading = new Label();
            lbl_sp_TenSP = new Label();
            lbl_sp_GiaSP = new Label();
            lbl_sp_HangSP = new Label();
            lbl_sp_TKSP = new Label();
            txt_sp_TenSP = new TextBox();
            txt_sp_GiaSP = new TextBox();
            txt_sp_TKSP = new TextBox();
            btn_sp_Them = new Button();
            btn_sp_Xoa = new Button();
            btn_sp_Sua = new Button();
            btn_sp_TimKiem = new Button();
            btn_sp_ThoatTK = new Button();
            dgv_sp_ThongTin = new DataGridView();
            cbb_sp_HangSP = new ComboBox();
            rb_sp_DTT = new RadioButton();
            rb_sp_CTT = new RadioButton();
            lbl_sp_TrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_sp_ThongTin).BeginInit();
            SuspendLayout();
            // 
            // lbl_sp_Heading
            // 
            lbl_sp_Heading.AutoSize = true;
            lbl_sp_Heading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sp_Heading.Location = new Point(188, 35);
            lbl_sp_Heading.Name = "lbl_sp_Heading";
            lbl_sp_Heading.Size = new Size(252, 32);
            lbl_sp_Heading.TabIndex = 0;
            lbl_sp_Heading.Text = "QUAN LY SAN PHAM";
            // 
            // lbl_sp_TenSP
            // 
            lbl_sp_TenSP.AutoSize = true;
            lbl_sp_TenSP.Location = new Point(43, 106);
            lbl_sp_TenSP.Name = "lbl_sp_TenSP";
            lbl_sp_TenSP.Size = new Size(80, 15);
            lbl_sp_TenSP.TabIndex = 1;
            lbl_sp_TenSP.Text = "Ten san pham";
            // 
            // lbl_sp_GiaSP
            // 
            lbl_sp_GiaSP.AutoSize = true;
            lbl_sp_GiaSP.Location = new Point(43, 150);
            lbl_sp_GiaSP.Name = "lbl_sp_GiaSP";
            lbl_sp_GiaSP.Size = new Size(79, 15);
            lbl_sp_GiaSP.TabIndex = 2;
            lbl_sp_GiaSP.Text = "Gia san pham";
            // 
            // lbl_sp_HangSP
            // 
            lbl_sp_HangSP.AutoSize = true;
            lbl_sp_HangSP.Location = new Point(43, 194);
            lbl_sp_HangSP.Name = "lbl_sp_HangSP";
            lbl_sp_HangSP.Size = new Size(91, 15);
            lbl_sp_HangSP.TabIndex = 3;
            lbl_sp_HangSP.Text = "Hang san pham";
            // 
            // lbl_sp_TKSP
            // 
            lbl_sp_TKSP.AutoSize = true;
            lbl_sp_TKSP.Location = new Point(23, 263);
            lbl_sp_TKSP.Name = "lbl_sp_TKSP";
            lbl_sp_TKSP.Size = new Size(111, 15);
            lbl_sp_TKSP.TabIndex = 4;
            lbl_sp_TKSP.Text = "Tim kiem san pham";
            // 
            // txt_sp_TenSP
            // 
            txt_sp_TenSP.Location = new Point(142, 98);
            txt_sp_TenSP.Name = "txt_sp_TenSP";
            txt_sp_TenSP.Size = new Size(196, 23);
            txt_sp_TenSP.TabIndex = 5;
            // 
            // txt_sp_GiaSP
            // 
            txt_sp_GiaSP.Location = new Point(142, 142);
            txt_sp_GiaSP.Name = "txt_sp_GiaSP";
            txt_sp_GiaSP.Size = new Size(196, 23);
            txt_sp_GiaSP.TabIndex = 6;
            // 
            // txt_sp_TKSP
            // 
            txt_sp_TKSP.Location = new Point(140, 255);
            txt_sp_TKSP.Name = "txt_sp_TKSP";
            txt_sp_TKSP.Size = new Size(196, 23);
            txt_sp_TKSP.TabIndex = 8;
            // 
            // btn_sp_Them
            // 
            btn_sp_Them.Location = new Point(423, 98);
            btn_sp_Them.Name = "btn_sp_Them";
            btn_sp_Them.Size = new Size(75, 23);
            btn_sp_Them.TabIndex = 9;
            btn_sp_Them.Text = "Them";
            btn_sp_Them.UseVisualStyleBackColor = true;
            btn_sp_Them.Click += btn_sp_Them_Click;
            // 
            // btn_sp_Xoa
            // 
            btn_sp_Xoa.Location = new Point(423, 142);
            btn_sp_Xoa.Name = "btn_sp_Xoa";
            btn_sp_Xoa.Size = new Size(75, 23);
            btn_sp_Xoa.TabIndex = 10;
            btn_sp_Xoa.Text = "Xoa";
            btn_sp_Xoa.UseVisualStyleBackColor = true;
            btn_sp_Xoa.Click += btn_sp_Xoa_Click;
            // 
            // btn_sp_Sua
            // 
            btn_sp_Sua.Location = new Point(423, 186);
            btn_sp_Sua.Name = "btn_sp_Sua";
            btn_sp_Sua.Size = new Size(75, 23);
            btn_sp_Sua.TabIndex = 11;
            btn_sp_Sua.Text = "Sua";
            btn_sp_Sua.UseVisualStyleBackColor = true;
            btn_sp_Sua.Click += btn_sp_Sua_Click;
            // 
            // btn_sp_TimKiem
            // 
            btn_sp_TimKiem.Location = new Point(423, 223);
            btn_sp_TimKiem.Name = "btn_sp_TimKiem";
            btn_sp_TimKiem.Size = new Size(75, 23);
            btn_sp_TimKiem.TabIndex = 12;
            btn_sp_TimKiem.Text = "Tim kiem";
            btn_sp_TimKiem.UseVisualStyleBackColor = true;
            btn_sp_TimKiem.Click += btn_sp_TimKiem_Click;
            // 
            // btn_sp_ThoatTK
            // 
            btn_sp_ThoatTK.Location = new Point(423, 255);
            btn_sp_ThoatTK.Name = "btn_sp_ThoatTK";
            btn_sp_ThoatTK.Size = new Size(105, 23);
            btn_sp_ThoatTK.TabIndex = 13;
            btn_sp_ThoatTK.Text = "Thoat tim kiem";
            btn_sp_ThoatTK.UseVisualStyleBackColor = true;
            btn_sp_ThoatTK.Click += btn_sp_ThoatTK_Click;
            // 
            // dgv_sp_ThongTin
            // 
            dgv_sp_ThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sp_ThongTin.Location = new Point(13, 291);
            dgv_sp_ThongTin.Name = "dgv_sp_ThongTin";
            dgv_sp_ThongTin.Size = new Size(672, 273);
            dgv_sp_ThongTin.TabIndex = 14;
            dgv_sp_ThongTin.SelectionChanged += dgv_sp_ThongTin_SelectionChanged;
            // 
            // cbb_sp_HangSP
            // 
            cbb_sp_HangSP.FormattingEnabled = true;
            cbb_sp_HangSP.Location = new Point(142, 186);
            cbb_sp_HangSP.Name = "cbb_sp_HangSP";
            cbb_sp_HangSP.Size = new Size(196, 23);
            cbb_sp_HangSP.TabIndex = 15;
            // 
            // rb_sp_DTT
            // 
            rb_sp_DTT.AutoSize = true;
            rb_sp_DTT.Location = new Point(142, 225);
            rb_sp_DTT.Name = "rb_sp_DTT";
            rb_sp_DTT.Size = new Size(100, 19);
            rb_sp_DTT.TabIndex = 16;
            rb_sp_DTT.TabStop = true;
            rb_sp_DTT.Text = "Da thanh toan";
            rb_sp_DTT.UseVisualStyleBackColor = true;
            // 
            // rb_sp_CTT
            // 
            rb_sp_CTT.AutoSize = true;
            rb_sp_CTT.Location = new Point(270, 225);
            rb_sp_CTT.Name = "rb_sp_CTT";
            rb_sp_CTT.Size = new Size(114, 19);
            rb_sp_CTT.TabIndex = 17;
            rb_sp_CTT.TabStop = true;
            rb_sp_CTT.Text = "Chua thanh toan";
            rb_sp_CTT.UseVisualStyleBackColor = true;
            // 
            // lbl_sp_TrangThai
            // 
            lbl_sp_TrangThai.AutoSize = true;
            lbl_sp_TrangThai.Location = new Point(14, 227);
            lbl_sp_TrangThai.Name = "lbl_sp_TrangThai";
            lbl_sp_TrangThai.Size = new Size(120, 15);
            lbl_sp_TrangThai.TabIndex = 18;
            lbl_sp_TrangThai.Text = "Trang thai thanh toan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 610);
            Controls.Add(lbl_sp_TrangThai);
            Controls.Add(rb_sp_CTT);
            Controls.Add(rb_sp_DTT);
            Controls.Add(cbb_sp_HangSP);
            Controls.Add(dgv_sp_ThongTin);
            Controls.Add(btn_sp_ThoatTK);
            Controls.Add(btn_sp_TimKiem);
            Controls.Add(btn_sp_Sua);
            Controls.Add(btn_sp_Xoa);
            Controls.Add(btn_sp_Them);
            Controls.Add(txt_sp_TKSP);
            Controls.Add(txt_sp_GiaSP);
            Controls.Add(txt_sp_TenSP);
            Controls.Add(lbl_sp_TKSP);
            Controls.Add(lbl_sp_HangSP);
            Controls.Add(lbl_sp_GiaSP);
            Controls.Add(lbl_sp_TenSP);
            Controls.Add(lbl_sp_Heading);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sp_ThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sp_Heading;
        private Label lbl_sp_TenSP;
        private Label lbl_sp_GiaSP;
        private Label lbl_sp_HangSP;
        private Label lbl_sp_TKSP;
        private TextBox txt_sp_TenSP;
        private TextBox txt_sp_GiaSP;
        private TextBox txt_sp_TKSP;
        private Button btn_sp_Them;
        private Button btn_sp_Xoa;
        private Button btn_sp_Sua;
        private Button btn_sp_TimKiem;
        private Button btn_sp_ThoatTK;
        private DataGridView dgv_sp_ThongTin;
        private ComboBox cbb_sp_HangSP;
        private RadioButton rb_sp_DTT;
        private RadioButton rb_sp_CTT;
        private Label lbl_sp_TrangThai;
    }
}
