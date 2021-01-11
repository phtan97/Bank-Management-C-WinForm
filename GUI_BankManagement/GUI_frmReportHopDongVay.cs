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
    public partial class GUI_frmReportHopDongVay : DevExpress.XtraEditors.XtraForm
    {
        public GUI_frmReportHopDongVay()
        {
            InitializeComponent();
        }
        BUS_HopDongVay bus_hdvay = new BUS_HopDongVay();
        private void GUI_frmReportHopDongVay_Load(object sender, EventArgs e)
        {
            RptThongKeHDVay rpt = new RptThongKeHDVay();
            rpt.DataSource = bus_hdvay.ThongKeHopDongVay();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}