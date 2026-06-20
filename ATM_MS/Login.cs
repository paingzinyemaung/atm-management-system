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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\ATM_MS\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Account account = new Account(); 
            account.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static String accNum;
        private void bnfTbLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            String selectQuery = "SELECT Count(*) FROM AccountTbl WHERE AccNum = '" + txtAccNum.Text + "' AND Pin = '"+txtPinCode.Text+"'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                accNum = txtAccNum.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials!");
            }
            conn.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
