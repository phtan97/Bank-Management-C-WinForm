namespace GUI_BankManagement
{
    partial class GUI_TimHopDongVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimHopDongVay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHopDongVay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtSoTienVay = new System.Windows.Forms.TextBox();
            this.txtMucDichVay = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.dtpNgayVay = new System.Windows.Forms.DateTimePicker();
            this.dtpKyHan = new System.Windows.Forms.DateTimePicker();
            this.radCo = new System.Windows.Forms.RadioButton();
            this.radKhong = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.cboTangGiam = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDongVay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 77);
            this.panel1.TabIndex = 0;
            // 
            // dgvHopDongVay
            // 
            this.dgvHopDongVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDongVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDongVay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHopDongVay.Location = new System.Drawing.Point(0, 77);
            this.dgvHopDongVay.Name = "dgvHopDongVay";
            this.dgvHopDongVay.Size = new System.Drawing.Size(762, 278);
            this.dgvHopDongVay.TabIndex = 1;
            this.dgvHopDongVay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDongVay_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền vay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lãi suất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày vay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(988, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(785, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mục đích vay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(988, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thế chấp:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(771, 233);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(430, 23);
            this.separatorControl1.TabIndex = 4;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(967, 81);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(20, 158);
            this.separatorControl2.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(865, 102);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 21);
            this.txtMaHD.TabIndex = 6;
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.Location = new System.Drawing.Point(865, 133);
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(100, 21);
            this.txtSoTienVay.TabIndex = 6;
            // 
            // txtMucDichVay
            // 
            this.txtMucDichVay.Location = new System.Drawing.Point(865, 210);
            this.txtMucDichVay.Name = "txtMucDichVay";
            this.txtMucDichVay.Size = new System.Drawing.Size(100, 21);
            this.txtMucDichVay.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(1077, 99);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 21);
            this.txtMaKH.TabIndex = 7;
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(1077, 133);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(100, 21);
            this.txtLaiSuat.TabIndex = 7;
            // 
            // dtpNgayVay
            // 
            this.dtpNgayVay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVay.Location = new System.Drawing.Point(865, 174);
            this.dtpNgayVay.Name = "dtpNgayVay";
            this.dtpNgayVay.Size = new System.Drawing.Size(100, 21);
            this.dtpNgayVay.TabIndex = 8;
            // 
            // dtpKyHan
            // 
            this.dtpKyHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKyHan.Location = new System.Drawing.Point(1077, 174);
            this.dtpKyHan.Name = "dtpKyHan";
            this.dtpKyHan.Size = new System.Drawing.Size(100, 21);
            this.dtpKyHan.TabIndex = 9;
            // 
            // radCo
            // 
            this.radCo.AutoSize = true;
            this.radCo.Location = new System.Drawing.Point(1077, 210);
            this.radCo.Name = "radCo";
            this.radCo.Size = new System.Drawing.Size(38, 17);
            this.radCo.TabIndex = 10;
            this.radCo.Text = "Có";
            this.radCo.UseVisualStyleBackColor = true;
            // 
            // radKhong
            // 
            this.radKhong.AutoSize = true;
            this.radKhong.Checked = true;
            this.radKhong.Location = new System.Drawing.Point(1136, 211);
            this.radKhong.Name = "radKhong";
            this.radKhong.Size = new System.Drawing.Size(55, 17);
            this.radKhong.TabIndex = 11;
            this.radKhong.TabStop = true;
            this.radKhong.Text = "Không";
            this.radKhong.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(18, 20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(50, 50);
            this.btnReport.TabIndex = 12;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(788, 262);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 21);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(894, 260);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(785, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sắp xếp theo:";
            // 
            // cboSapXep
            // 
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "Mã hợp đồng",
            "Mã khách hàng",
            "Số tiền vay",
            "Lãi suất",
            "Ngày vay",
            "Ngày trả",
            "Mục đích vay",
            "Thế chấp"});
            this.cboSapXep.Location = new System.Drawing.Point(867, 307);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(120, 21);
            this.cboSapXep.TabIndex = 16;
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cboSapXep_SelectedIndexChanged);
            // 
            // cboTangGiam
            // 
            this.cboTangGiam.FormattingEnabled = true;
            this.cboTangGiam.Items.AddRange(new object[] {
            "Tăng",
            "Giảm"});
            this.cboTangGiam.Location = new System.Drawing.Point(1002, 307);
            this.cboTangGiam.Name = "cboTangGiam";
            this.cboTangGiam.Size = new System.Drawing.Size(69, 21);
            this.cboTangGiam.TabIndex = 16;
            this.cboTangGiam.Text = "Tăng";
            this.cboTangGiam.SelectedIndexChanged += new System.EventHandler(this.cboTangGiam_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Location = new System.Drawing.Point(1115, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập hợp đồng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(555, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "TÌM KIẾM, SẮP XẾP VÀ LẬP HỢP ĐỒNG CHO VAY";
            // 
            // GUI_TimHopDongVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTangGiam);
            this.Controls.Add(this.cboSapXep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.radKhong);
            this.Controls.Add(this.radCo);
            this.Controls.Add(this.dtpKyHan);
            this.Controls.Add(this.dtpNgayVay);
            this.Controls.Add(this.txtLaiSuat);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMucDichVay);
            this.Controls.Add(this.txtSoTienVay);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHopDongVay);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TimHopDongVay";
            this.Text = "GUI_TimHopDongVay";
            this.Load += new System.EventHandler(this.GUI_TimHopDongVay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDongVay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHopDongVay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtSoTienVay;
        private System.Windows.Forms.TextBox txtMucDichVay;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtLaiSuat;
        private System.Windows.Forms.DateTimePicker dtpNgayVay;
        private System.Windows.Forms.DateTimePicker dtpKyHan;
        private System.Windows.Forms.RadioButton radCo;
        private System.Windows.Forms.RadioButton radKhong;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.ComboBox cboTangGiam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
    }
}