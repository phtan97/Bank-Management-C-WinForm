namespace GUI_BankManagement
{
    partial class GUI_TimHDTheChap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimHDTheChap));
            this.dgvHopDongTheChap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTangGiam = new System.Windows.Forms.ComboBox();
            this.txtGiaTriTS = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtLoaiTS = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDongTheChap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHopDongTheChap
            // 
            this.dgvHopDongTheChap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDongTheChap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDongTheChap.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHopDongTheChap.Location = new System.Drawing.Point(0, 77);
            this.dgvHopDongTheChap.Name = "dgvHopDongTheChap";
            this.dgvHopDongTheChap.Size = new System.Drawing.Size(554, 224);
            this.dgvHopDongTheChap.TabIndex = 19;
            this.dgvHopDongTheChap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDongTheChap_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 77);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Location = new System.Drawing.Point(926, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 83);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập hợp đồng";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(22, 23);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(50, 50);
            this.btnReport.TabIndex = 12;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboSapXep
            // 
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Items.AddRange(new object[] {
            "Mã hợp đồng",
            "Mã khách hàng",
            "Loại tài sản",
            "Giá trị tài sản"});
            this.cboSapXep.Location = new System.Drawing.Point(680, 247);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(120, 21);
            this.cboSapXep.TabIndex = 62;
            this.cboSapXep.Text = "Mã hợp đồng";
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cboSapXep_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Sắp xếp theo:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(709, 204);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(603, 206);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 21);
            this.txtTimKiem.TabIndex = 58;
            // 
            // cboTangGiam
            // 
            this.cboTangGiam.FormattingEnabled = true;
            this.cboTangGiam.Items.AddRange(new object[] {
            "Tăng",
            "Giảm"});
            this.cboTangGiam.Location = new System.Drawing.Point(808, 247);
            this.cboTangGiam.Name = "cboTangGiam";
            this.cboTangGiam.Size = new System.Drawing.Size(69, 21);
            this.cboTangGiam.TabIndex = 61;
            this.cboTangGiam.Text = "Tăng";
            this.cboTangGiam.SelectedIndexChanged += new System.EventHandler(this.cboTangGiam_SelectedIndexChanged);
            // 
            // txtGiaTriTS
            // 
            this.txtGiaTriTS.Location = new System.Drawing.Point(892, 138);
            this.txtGiaTriTS.Name = "txtGiaTriTS";
            this.txtGiaTriTS.Size = new System.Drawing.Size(100, 21);
            this.txtGiaTriTS.TabIndex = 57;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(892, 104);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 21);
            this.txtMaKH.TabIndex = 56;
            // 
            // txtLoaiTS
            // 
            this.txtLoaiTS.Location = new System.Drawing.Point(680, 138);
            this.txtLoaiTS.Name = "txtLoaiTS";
            this.txtLoaiTS.Size = new System.Drawing.Size(100, 21);
            this.txtLoaiTS.TabIndex = 54;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(680, 107);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 21);
            this.txtMaHD.TabIndex = 53;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(782, 86);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(20, 97);
            this.separatorControl2.TabIndex = 52;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(586, 177);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(430, 23);
            this.separatorControl1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Giá trị tài sản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Loại tài sản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã hợp đồng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(323, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "TÌM KIẾM, SẮP XẾP VÀ LẬP HỢP ĐỒNG THẾ CHẤP TÀI SẢN";
            // 
            // GUI_TimHDTheChap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboSapXep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cboTangGiam);
            this.Controls.Add(this.txtGiaTriTS);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtLoaiTS);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHopDongTheChap);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TimHDTheChap";
            this.Text = "GUI_TimHDTheChap";
            this.Load += new System.EventHandler(this.GUI_TimHDTheChap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDongTheChap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHopDongTheChap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTangGiam;
        private System.Windows.Forms.TextBox txtGiaTriTS;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtLoaiTS;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}