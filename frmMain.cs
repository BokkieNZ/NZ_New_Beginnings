using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankIT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }           

        private void PopulateServerList()
        {
            cmbServer.Items.Clear();
            lblMachineName.Text = "Machine Name";

            string myServer = Environment.MachineName;
            lblMachineName.Text = myServer;

            DBConnectFunctions dbConnectFunctions = new DBConnectFunctions();
            List<string> ServerNameList = new List<string>();
            ServerNameList = dbConnectFunctions.GetSQLServerInstanceNames();
            foreach (string ListItem in ServerNameList)
            {
                cmbServer.Items.Add(ListItem);
            }            
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            tbcMain.SelectedTab = tabLogin;
            PopulateServerList();
        }

        
    }
}