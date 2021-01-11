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
    public partial class GUI_frmThongKeHDTheChap : DevExpress.XtraEditors.XtraForm
    {
        public GUI_frmThongKeHDTheChap()
        {
            InitializeComponent();
        }
        BUS_HopDongTheChap bus_hdthechap = new BUS_HopDongTheChap();
        private void GUI_frmThongKeHDTheChap_Load(object sender, EventArgs e)
        {
            RptThongKeHDTheChap rpt = new RptThongKeHDTheChap();
            rpt.DataSource = bus_hdthechap.ThongKeHopDongTheChap();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}