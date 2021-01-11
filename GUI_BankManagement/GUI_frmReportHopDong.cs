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
    public partial class GUI_frmReportHopDong : DevExpress.XtraEditors.XtraForm
    {
        public GUI_frmReportHopDong()
        {
            InitializeComponent();
        }
        BUS_HopDong bus_hopdong = new BUS_HopDong();
        private void GUI_frmReportHopDong_Load(object sender, EventArgs e)
        {
            RptThongKeHopDong rpt = new RptThongKeHopDong();
            rpt.DataSource = bus_hopdong.LayDsHopDong();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}