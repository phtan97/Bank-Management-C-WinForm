namespace GUI_BankManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ricMainMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThemTaiKhoanKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThongTinKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLaiSuatVay = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLaiSuatGui = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHopDongVay = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHopDongTietKiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReconnect = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThemTaiKhoanNV = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTimKiemHopDongChoVay = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHopDongTheChap = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHopDongGuiTietKiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCacLoaiHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThongKeHopDongVay = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThongKeHDTheChap = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThongKeHDTietKiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rgbTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rgbKetNoi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQuanLyTaiKhoanKH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgHopDong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgTinhLai = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgThongKeBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ricMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ricMainMenu
            // 
            this.ricMainMenu.ExpandCollapseItem.Id = 0;
            this.ricMainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ricMainMenu.ExpandCollapseItem,
            this.ricMainMenu.SearchEditItem,
            this.bbiDangXuat,
            this.bbiThemTaiKhoanKH,
            this.bbiThongTinKH,
            this.bbiThemNV,
            this.bbiLaiSuatVay,
            this.bbiLaiSuatGui,
            this.bbiHopDong,
            this.bbiHopDongVay,
            this.bbiHopDongTietKiem,
            this.bbiReconnect,
            this.barButtonItem1,
            this.bbiThemTaiKhoanNV,
            this.bbiTimKiemHopDongChoVay,
            this.bbiHopDongTheChap,
            this.bbiHopDongGuiTietKiem,
            this.bbiThoat,
            this.bbiCacLoaiHopDong,
            this.bbiThongKeHopDongVay,
            this.bbiThongKeHDTheChap,
            this.bbiThongKeHDTietKiem,
            this.bbiDangNhap});
            this.ricMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ricMainMenu.MaxItemId = 29;
            this.ricMainMenu.Name = "ricMainMenu";
            this.ricMainMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbHeThong,
            this.ribQuanLyTaiKhoanKH,
            this.ribbonPage1});
            this.ricMainMenu.Size = new System.Drawing.Size(905, 148);
            // 
            // bbiDangXuat
            // 
            this.bbiDangXuat.Caption = "Đăng xuất";
            this.bbiDangXuat.Id = 3;
            this.bbiDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDangXuat.ImageOptions.LargeImage")));
            this.bbiDangXuat.LargeWidth = 60;
            this.bbiDangXuat.Name = "bbiDangXuat";
            this.bbiDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDangXuat_ItemClick);
            // 
            // bbiThemTaiKhoanKH
            // 
            this.bbiThemTaiKhoanKH.Caption = "Mở tài khoản khách hàng";
            this.bbiThemTaiKhoanKH.Enabled = false;
            this.bbiThemTaiKhoanKH.Id = 4;
            this.bbiThemTaiKhoanKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThemTaiKhoanKH.ImageOptions.LargeImage")));
            this.bbiThemTaiKhoanKH.Name = "bbiThemTaiKhoanKH";
            // 
            // bbiThongTinKH
            // 
            this.bbiThongTinKH.Caption = "Tác vụ khách hàng";
            this.bbiThongTinKH.Id = 5;
            this.bbiThongTinKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThongTinKH.ImageOptions.LargeImage")));
            this.bbiThongTinKH.Name = "bbiThongTinKH";
            this.bbiThongTinKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThongTinKH_ItemClick);
            // 
            // bbiThemNV
            // 
            this.bbiThemNV.Caption = "Tác vụ nhân viên";
            this.bbiThemNV.Id = 8;
            this.bbiThemNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThemNV.ImageOptions.LargeImage")));
            this.bbiThemNV.Name = "bbiThemNV";
            this.bbiThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemNV_ItemClick);
            // 
            // bbiLaiSuatVay
            // 
            this.bbiLaiSuatVay.Caption = "Lãi suất vay";
            this.bbiLaiSuatVay.Id = 10;
            this.bbiLaiSuatVay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiLaiSuatVay.ImageOptions.LargeImage")));
            this.bbiLaiSuatVay.LargeWidth = 65;
            this.bbiLaiSuatVay.Name = "bbiLaiSuatVay";
            this.bbiLaiSuatVay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLaiSuatVay_ItemClick);
            // 
            // bbiLaiSuatGui
            // 
            this.bbiLaiSuatGui.Caption = "Lãi suất gửi tiết kiệm";
            this.bbiLaiSuatGui.Id = 11;
            this.bbiLaiSuatGui.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiLaiSuatGui.ImageOptions.LargeImage")));
            this.bbiLaiSuatGui.LargeWidth = 65;
            this.bbiLaiSuatGui.Name = "bbiLaiSuatGui";
            this.bbiLaiSuatGui.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLaiSuatGui_ItemClick);
            // 
            // bbiHopDong
            // 
            this.bbiHopDong.Caption = "Thông tin hợp đồng";
            this.bbiHopDong.Id = 13;
            this.bbiHopDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiHopDong.ImageOptions.LargeImage")));
            this.bbiHopDong.Name = "bbiHopDong";
            this.bbiHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHopDong_ItemClick);
            // 
            // bbiHopDongVay
            // 
            this.bbiHopDongVay.Caption = "Tạo hợp đồng cho vay";
            this.bbiHopDongVay.Id = 14;
            this.bbiHopDongVay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiHopDongVay.ImageOptions.LargeImage")));
            this.bbiHopDongVay.Name = "bbiHopDongVay";
            this.bbiHopDongVay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHopDongVay_ItemClick);
            // 
            // bbiHopDongTietKiem
            // 
            this.bbiHopDongTietKiem.Caption = "Tạo hợp đồng gửi tiết kiệm";
            this.bbiHopDongTietKiem.Id = 15;
            this.bbiHopDongTietKiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiHopDongTietKiem.ImageOptions.LargeImage")));
            this.bbiHopDongTietKiem.Name = "bbiHopDongTietKiem";
            this.bbiHopDongTietKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHopDongTietKiem_ItemClick);
            // 
            // bbiReconnect
            // 
            this.bbiReconnect.Caption = "Kết nối lại";
            this.bbiReconnect.Id = 16;
            this.bbiReconnect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReconnect.ImageOptions.LargeImage")));
            this.bbiReconnect.LargeWidth = 60;
            this.bbiReconnect.Name = "bbiReconnect";
            this.bbiReconnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReconnect_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiThemTaiKhoanNV
            // 
            this.bbiThemTaiKhoanNV.Caption = "Tài khoản nhân viên";
            this.bbiThemTaiKhoanNV.Id = 18;
            this.bbiThemTaiKhoanNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThemTaiKhoanNV.ImageOptions.LargeImage")));
            this.bbiThemTaiKhoanNV.Name = "bbiThemTaiKhoanNV";
            this.bbiThemTaiKhoanNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemTaiKhoanNV_ItemClick);
            // 
            // bbiTimKiemHopDongChoVay
            // 
            this.bbiTimKiemHopDongChoVay.Caption = "Hợp đồng cho vay";
            this.bbiTimKiemHopDongChoVay.Id = 19;
            this.bbiTimKiemHopDongChoVay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiTimKiemHopDongChoVay.ImageOptions.Image")));
            this.bbiTimKiemHopDongChoVay.Name = "bbiTimKiemHopDongChoVay";
            this.bbiTimKiemHopDongChoVay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTimKiemHopDongChoVay_ItemClick);
            // 
            // bbiHopDongTheChap
            // 
            this.bbiHopDongTheChap.Caption = "Hợp đồng thế chấp";
            this.bbiHopDongTheChap.Id = 20;
            this.bbiHopDongTheChap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiHopDongTheChap.ImageOptions.Image")));
            this.bbiHopDongTheChap.Name = "bbiHopDongTheChap";
            this.bbiHopDongTheChap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHopDongTheChap_ItemClick);
            // 
            // bbiHopDongGuiTietKiem
            // 
            this.bbiHopDongGuiTietKiem.Caption = "Hợp đồng gửi tiết kiệm";
            this.bbiHopDongGuiTietKiem.Id = 21;
            this.bbiHopDongGuiTietKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiHopDongGuiTietKiem.ImageOptions.Image")));
            this.bbiHopDongGuiTietKiem.Name = "bbiHopDongGuiTietKiem";
            this.bbiHopDongGuiTietKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHopDongGuiTietKiem_ItemClick);
            // 
            // bbiThoat
            // 
            this.bbiThoat.Caption = "Thoát khỏi chương trình";
            this.bbiThoat.Id = 22;
            this.bbiThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThoat.ImageOptions.LargeImage")));
            this.bbiThoat.Name = "bbiThoat";
            this.bbiThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThoat_ItemClick);
            // 
            // bbiCacLoaiHopDong
            // 
            this.bbiCacLoaiHopDong.Caption = "Các loại hợp đồng";
            this.bbiCacLoaiHopDong.Id = 23;
            this.bbiCacLoaiHopDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCacLoaiHopDong.ImageOptions.LargeImage")));
            this.bbiCacLoaiHopDong.Name = "bbiCacLoaiHopDong";
            this.bbiCacLoaiHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCacLoaiHopDong_ItemClick);
            // 
            // bbiThongKeHopDongVay
            // 
            this.bbiThongKeHopDongVay.Caption = "Hợp đồng vay";
            this.bbiThongKeHopDongVay.Id = 24;
            this.bbiThongKeHopDongVay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThongKeHopDongVay.ImageOptions.LargeImage")));
            this.bbiThongKeHopDongVay.Name = "bbiThongKeHopDongVay";
            this.bbiThongKeHopDongVay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThongKeHopDongVay_ItemClick);
            // 
            // bbiThongKeHDTheChap
            // 
            this.bbiThongKeHDTheChap.Caption = "Hợp đồng thế chấp";
            this.bbiThongKeHDTheChap.Id = 25;
            this.bbiThongKeHDTheChap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThongKeHDTheChap.ImageOptions.LargeImage")));
            this.bbiThongKeHDTheChap.Name = "bbiThongKeHDTheChap";
            this.bbiThongKeHDTheChap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThongKeHDTheChap_ItemClick);
            // 
            // bbiThongKeHDTietKiem
            // 
            this.bbiThongKeHDTietKiem.Caption = "Hợp đồng gửi tiết kiệm";
            this.bbiThongKeHDTietKiem.Id = 26;
            this.bbiThongKeHDTietKiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThongKeHDTietKiem.ImageOptions.LargeImage")));
            this.bbiThongKeHDTietKiem.Name = "bbiThongKeHDTietKiem";
            this.bbiThongKeHDTietKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThongKeHDTietKiem_ItemClick);
            // 
            // bbiDangNhap
            // 
            this.bbiDangNhap.Caption = "Đăng nhập";
            this.bbiDangNhap.Id = 28;
            this.bbiDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDangNhap.ImageOptions.LargeImage")));
            this.bbiDangNhap.Name = "bbiDangNhap";
            this.bbiDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDangNhap_ItemClick);
            // 
            // ribbHeThong
            // 
            this.ribbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rgbTaiKhoan,
            this.rgbKetNoi});
            this.ribbHeThong.Name = "ribbHeThong";
            this.ribbHeThong.Text = "Hệ Thống";
            // 
            // rgbTaiKhoan
            // 
            this.rgbTaiKhoan.ItemLinks.Add(this.bbiDangNhap);
            this.rgbTaiKhoan.ItemLinks.Add(this.bbiDangXuat);
            this.rgbTaiKhoan.Name = "rgbTaiKhoan";
            this.rgbTaiKhoan.Text = "Tài Khoản";
            // 
            // rgbKetNoi
            // 
            this.rgbKetNoi.ItemLinks.Add(this.bbiReconnect);
            this.rgbKetNoi.ItemLinks.Add(this.bbiThoat);
            this.rgbKetNoi.Name = "rgbKetNoi";
            this.rgbKetNoi.Text = "Kết nối";
            // 
            // ribQuanLyTaiKhoanKH
            // 
            this.ribQuanLyTaiKhoanKH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.rbgQuanLy});
            this.ribQuanLyTaiKhoanKH.Name = "ribQuanLyTaiKhoanKH";
            this.ribQuanLyTaiKhoanKH.Text = "Quản lý tài khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiThongTinKH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nhân Viên";
            // 
            // rbgQuanLy
            // 
            this.rbgQuanLy.ItemLinks.Add(this.bbiThemNV);
            this.rbgQuanLy.ItemLinks.Add(this.bbiThemTaiKhoanNV);
            this.rbgQuanLy.Name = "rbgQuanLy";
            this.rbgQuanLy.Text = "Quản Lý";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgHopDong,
            this.rbgTinhLai,
            this.rbgTimKiem,
            this.rbgThongKeBaoCao});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý hợp đồng";
            // 
            // rbgHopDong
            // 
            this.rbgHopDong.ItemLinks.Add(this.bbiHopDong);
            this.rbgHopDong.ItemLinks.Add(this.bbiHopDongVay);
            this.rbgHopDong.ItemLinks.Add(this.bbiHopDongTietKiem);
            this.rbgHopDong.Name = "rbgHopDong";
            this.rbgHopDong.Text = "Hợp đồng khách hàng";
            // 
            // rbgTinhLai
            // 
            this.rbgTinhLai.ItemLinks.Add(this.bbiLaiSuatVay);
            this.rbgTinhLai.ItemLinks.Add(this.bbiLaiSuatGui);
            this.rbgTinhLai.Name = "rbgTinhLai";
            this.rbgTinhLai.Text = "Tra cứu và tính toán tiền lãi";
            // 
            // rbgTimKiem
            // 
            this.rbgTimKiem.ItemLinks.Add(this.bbiTimKiemHopDongChoVay);
            this.rbgTimKiem.ItemLinks.Add(this.bbiHopDongTheChap);
            this.rbgTimKiem.ItemLinks.Add(this.bbiHopDongGuiTietKiem);
            this.rbgTimKiem.Name = "rbgTimKiem";
            this.rbgTimKiem.Text = "Tìm kiếm";
            // 
            // rbgThongKeBaoCao
            // 
            this.rbgThongKeBaoCao.ItemLinks.Add(this.bbiCacLoaiHopDong);
            this.rbgThongKeBaoCao.ItemLinks.Add(this.bbiThongKeHopDongVay);
            this.rbgThongKeBaoCao.ItemLinks.Add(this.bbiThongKeHDTheChap);
            this.rbgThongKeBaoCao.ItemLinks.Add(this.bbiThongKeHDTietKiem);
            this.rbgThongKeBaoCao.Name = "rbgThongKeBaoCao";
            this.rbgThongKeBaoCao.Text = "Thống kê và báo cáo";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 360);
            this.Controls.Add(this.ricMainMenu);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ricMainMenu;
            this.Text = "CHƯƠNG TRÌNH VAY GỬI TIẾT KIỆM CHI NHÁNH NGÂN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ricMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ricMainMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rgbTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem bbiDangXuat;
        private DevExpress.XtraBars.BarButtonItem bbiThemTaiKhoanKH;
        private DevExpress.XtraBars.BarButtonItem bbiThongTinKH;
        private DevExpress.XtraBars.BarButtonItem bbiThemNV;
        private DevExpress.XtraBars.BarButtonItem bbiLaiSuatVay;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQuanLyTaiKhoanKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgTinhLai;
        private DevExpress.XtraBars.BarButtonItem bbiLaiSuatGui;
        private DevExpress.XtraBars.BarButtonItem bbiHopDong;
        private DevExpress.XtraBars.BarButtonItem bbiHopDongVay;
        private DevExpress.XtraBars.BarButtonItem bbiHopDongTietKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgHopDong;
        private DevExpress.XtraBars.BarButtonItem bbiReconnect;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rgbKetNoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiThemTaiKhoanNV;
        private DevExpress.XtraBars.BarButtonItem bbiTimKiemHopDongChoVay;
        private DevExpress.XtraBars.BarButtonItem bbiHopDongTheChap;
        private DevExpress.XtraBars.BarButtonItem bbiHopDongGuiTietKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgTimKiem;
        private DevExpress.XtraBars.BarButtonItem bbiThoat;
        private DevExpress.XtraBars.BarButtonItem bbiCacLoaiHopDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgThongKeBaoCao;
        private DevExpress.XtraBars.BarButtonItem bbiThongKeHopDongVay;
        private DevExpress.XtraBars.BarButtonItem bbiThongKeHDTheChap;
        private DevExpress.XtraBars.BarButtonItem bbiThongKeHDTietKiem;
        private DevExpress.XtraBars.BarButtonItem bbiDangNhap;
    }
}

