using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_MS
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            lblAN.Text = Home.accNum;
            getBalance();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            conn.Open();
            String selectQuery = "SELECT Balance FROM AccountTbl WHERE AccNum = '" +lblAN.Text+"'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblBlMmk.Text = "MMK " + dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
