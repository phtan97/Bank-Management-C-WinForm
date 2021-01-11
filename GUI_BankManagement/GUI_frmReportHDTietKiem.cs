using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_BankManagement;

namespace GUI_BankManagement
{
    public partial class GUI_frmReportHDTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public static string MaHD;
        public delegate void LayMaHD(string mahd);
        public LayMaHD sender;
        public GUI_frmReportHDTietKiem()
        {
            InitializeComponent();
            sender = new LayMaHD(NhanGiaTriMaHD);
        }
        public void NhanGiaTriMaHD(string mahd)
        {
            MaHD = mahd;
        }
        BUS_HopDongTietKiem bus_hdtietkiem = new BUS_HopDongTietKiem();
        private void GUI_frmReportHDTietKiem_Load(object sender, EventArgs e)
        {
            RptHopDongTietKiem rpt = new RptHopDongTietKiem();
            rpt.DataSource = bus_hdtietkiem.ReportHDTietKiem(MaHD);
            rpt.BindData();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}