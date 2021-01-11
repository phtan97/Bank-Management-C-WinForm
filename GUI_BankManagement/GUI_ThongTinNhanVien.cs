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
    public partial class GUI_ThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public GUI_ThongTinNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien nhanvien = new BUS_NhanVien();
        private void btnNhap_Click(object sender, EventArgs e)
        {            
            
            
        }
    }
}