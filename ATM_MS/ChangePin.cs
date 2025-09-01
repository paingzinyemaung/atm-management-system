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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        String accNum = Login.accNum;
        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void bnfTbLogin_Click(object sender, EventArgs e)
        {
            if (txtNewPin.Text == "" || txtConfirmPin.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if(txtConfirmPin.Text != txtNewPin.Text)
            {
                MessageBox.Show("New Pin & Confirm Pin must be Same!");
            }
            else
            {
                // newBalance = oldBalance + Convert.ToInt32(txtAmount.Text);
                try
                {
                    conn.Open();
                    String updateQuery = "UPDATE AccountTbl SET Pin = @pin WHERE AccNum = @accNum";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@pin", txtConfirmPin.Text);
                    cmd.Parameters.AddWithValue("@accNum", accNum);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Updated Successful!");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
