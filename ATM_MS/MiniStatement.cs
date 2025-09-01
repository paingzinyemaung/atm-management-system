using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_MS
{
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        String accNum = Login.accNum;
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            conn.Open();
            String selectQuery = "SELECT * FROM TransactionTbl WHERE AccNum = '"+accNum+"'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            //cmd.Parameters.AddWithValue("@accNum", accNum);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
           // DataTable dt = new DataTable();
            da.Fill(ds);
            dGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
