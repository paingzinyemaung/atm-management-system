using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ATM_MS
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\ATM_MS\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void bnfTbSignUp_Click_1(object sender, EventArgs e)
        {
            int bal = 0;
            if (txtAccNum.Text == "" || txtName.Text == "" || txtFaName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtPin.Text == "" || cboEducation.SelectedItem.ToString() == "" || txtOccupation.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    conn.Open();
                    String insertQuery = "INSERT INTO AccountTbl(AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, Pin, Balance) VALUES(@accNum, @name, @faName, @dob, @phone, @address, @education, @occupation, @pin, @balance)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@faname", txtFaName.Text);
                    cmd.Parameters.AddWithValue("@dob", dobDate.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@education", cboEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@pin", txtPin.Text);
                    cmd.Parameters.AddWithValue("@balance", bal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Creation is Successful!");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
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

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
