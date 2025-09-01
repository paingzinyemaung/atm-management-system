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
using System.Xml.Linq;

namespace ATM_MS
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
           // addTransaction();
        }
      
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
        public void addTransaction()
        {
            String tType = "Deposit";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('"+accNum+"','"+tType+"','"+txtAmount.Text+"','"+DateTime.Today.Date.ToString()+"')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
               // cmd.Parameters.AddWithValue("@accNum", accNum);
               // cmd.Parameters.AddWithValue("@tType", tType);
               // cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
               // cmd.Parameters.AddWithValue("@tDate", DateTime.Today.Date.ToString());
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account Creation is Successful!");
                conn.Close();
               // Login login = new Login();
                //login.Show();
                //this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int oldBalance,newBalance;
        String accNum = Login.accNum;
        private void getBalance()
        {
            conn.Open();
            String selectQuery = "SELECT Balance FROM AccountTbl WHERE AccNum = '" + accNum + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //lblBlMmk.Text = "MMK " + dt.Rows[0][0].ToString();
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bnfTbDeposit_Click(object sender, EventArgs e)
        {
           if(txtAmount.Text == "" || Convert.ToInt32(txtAmount.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount to Deposit!");
            }
            else
            {
                newBalance = oldBalance + Convert.ToInt32(txtAmount.Text);
                try
                {
                    conn.Open();
                    String updateQuery = "UPDATE AccountTbl SET Balance = @newBalance WHERE AccNum = @accNum";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newbalance", newBalance);
                    cmd.Parameters.AddWithValue("@accNum", accNum);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Deposit!");
                    conn.Close();
                    addTransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblDeposit_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        
    }
}
