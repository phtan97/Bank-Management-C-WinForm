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
    public partial class GUI_frmReportTheChap : DevExpress.XtraEditors.XtraForm
    {
        public static string MaHD;
        public delegate void LayMaHD(string mahd);
        public LayMaHD sender;
        public GUI_frmReportTheChap()
        {
            InitializeComponent();
            sender = new LayMaHD(NhanGiaTriMaHD);
        }
        public void NhanGiaTriMaHD(string mahd)
        {
            MaHD = mahd;
        }
        BUS_HopDongTheChap bus_hdthechap = new BUS_HopDongTheChap();

        private void GUI_frmReportTheChap_Load(object sender, EventArgs e)
        {
            rptHopDongTheChap rpt = new rptHopDongTheChap();
            rpt.DataSource = bus_hdthechap.ReportHDTheChap(MaHD);
            rpt.BindData();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}