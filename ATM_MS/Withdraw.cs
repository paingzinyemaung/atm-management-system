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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }
        public void addTransaction()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + txtAmount.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                // cmd.Parameters.AddWithValue("@accNum", accNum);
                // cmd.Parameters.AddWithValue("@tType", tType);
                // cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                // cmd.Parameters.AddWithValue("@tDate", DateTime.Today.Date.ToString());
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account Creation is Successful!");
                conn.Close();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            String accNum = Login.accNum;
        int balance;
        private void getBalance()
        {
            conn.Open();
            String selectQuery = "SELECT Balance FROM AccountTbl WHERE AccNum = '" + accNum + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblAvailableBalance.Text = "Available Balance: MMK " + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int oldBalance, newBalance;

        private void lblAvailableBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void bnfTbWithdraw_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }else if(Convert.ToInt32(txtAmount.Text) < 0)
            {
                MessageBox.Show("Balance must be Positive!");
            }else if(Convert.ToInt32(txtAmount.Text) > balance)
            {
                MessageBox.Show("Enter a Valid Amount!");
            }
            else
            {
                try
                {
                    newBalance = balance - Convert.ToInt32(txtAmount.Text);
                    try
                    {
                        conn.Open();
                        String updateQuery = "UPDATE AccountTbl SET Balance = @newBalance WHERE AccNum = @accNum";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@newbalance", newBalance);
                        cmd.Parameters.AddWithValue("@accNum", accNum);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw!");
                        conn.Close();
                        addTransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
        }
    }
}
