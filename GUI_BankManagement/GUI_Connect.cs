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
using DTO_BankManagement;
using System.Data.Sql;
using System.Data.SqlClient;
using BUS_BankManagement;

namespace GUI_BankManagement
{
    public partial class GUI_Connect : DevExpress.XtraEditors.XtraForm
    {
        public GUI_Connect()
        {
            InitializeComponent();
        }

        private void chkAuthen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuthen.Checked)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            BUS_Connect bus_connect = new BUS_Connect();
            if(!string.IsNullOrEmpty(cboServer.Text) || !string.IsNullOrEmpty(cboDatabase.Text))
            {
                bus_connect.Connect(cboServer.Text, cboDatabase.Text);
                MessageBox.Show("Kết nối thành công");
                Hide();                
            }
            else
            {
                MessageBox.Show("Kết nối thất bại, kiểm tra lại server và database");
            }
        }

        private void GUI_Connect_Load(object sender, EventArgs e)
        {
            DsServerName();
        }
        public void DsServerName()
        {
            List<string> ServerNames = new List<string>();
            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable dt = servers.GetDataSources();
            foreach (DataRow dr in dt.Rows)
            {
                string serverName = dr[0].ToString();
                try
                {
                    if (dr[1].ToString() != "")
                    {
                        serverName += dr[1].ToString();
                    }
                }
                catch { }
                ServerNames.Add(serverName);
                cboServer.Items.Add(serverName);
                cboServer.Text = serverName;
            }
        }
        public void DsDatabase()
        {
            List<string> databases = new List<string>();
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = cboServer.Text;
            if (chkAuthen.Checked)
            {
                connection.UserID = txtUsername.Text;
                connection.Password = txtPassword.Text;
            }
            connection.IntegratedSecurity = true;
            string ConnStr = connection.ToString();
            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            DataTable dt = sqlConn.GetSchema("Databases");
            sqlConn.Close();
            foreach (DataRow row in dt.Rows)
            {
                string strDatabaseName = row["database_name"].ToString();
                databases.Add(strDatabaseName);
                cboDatabase.Items.Add(strDatabaseName);
                cboDatabase.Text = strDatabaseName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DsDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                Close();
            }
        }
    }
}