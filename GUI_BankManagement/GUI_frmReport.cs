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
    public partial class GUI_frmReport : DevExpress.XtraEditors.XtraForm
    {
        public static string MaHD;
        public delegate void LayMaHD(string mahd);
        public LayMaHD sender;
        public GUI_frmReport()
        {
            InitializeComponent();
            sender = new LayMaHD(NhanGiaTriMaHD);
        }
        public void NhanGiaTriMaHD(string mahd)
        {
            MaHD = mahd;
        }
        BUS_HopDongVay hdvay = new BUS_HopDongVay();
        private void GUI_frmReport_Load(object sender, EventArgs e)
        {
            RptHopDongChoVay rpt = new RptHopDongChoVay();
            rpt.DataSource = hdvay.ReportHDVay(MaHD);
            rpt.BindData();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}