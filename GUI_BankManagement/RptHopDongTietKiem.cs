using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace GUI_BankManagement
{
    public partial class RptHopDongTietKiem : DevExpress.XtraReports.UI.XtraReport
    {
        public RptHopDongTietKiem()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            xrlNgay.Text = DateTime.Now.Day.ToString();
            xrlThang.Text = DateTime.Now.Month.ToString();
            xrlNam.Text = DateTime.Now.Year.ToString();                      
        }
    }
}
