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
    public partial class GUI_frmThongKeHDTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public GUI_frmThongKeHDTietKiem()
        {
            InitializeComponent();
        }
        BUS_HopDongTietKiem bus_hdtietkiem = new BUS_HopDongTietKiem();
        private void GUI_frmThongKeHDTietKiem_Load(object sender, EventArgs e)
        {
            RptThongKeHDTietKiem rpt = new RptThongKeHDTietKiem();
            rpt.DataSource = bus_hdtietkiem.ThongKeHopDongTietKiem();
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}