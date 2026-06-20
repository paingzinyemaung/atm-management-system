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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# Projects\ATM_MS\AMT_DB.mdf"";Integrated Security=True;Connect Timeout=30");
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

        private void lblAvailBal_Click(object sender, EventArgs e)
        {

        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }
        int amt1 = 10000, amt2 = 30000, amt3 = 50000, amt4 = 100000, amt5 = 300000, amt6 = 500000;
        public void addTransaction1()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt1 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
        public void addTransaction2()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt2 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
        public void addTransaction3()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt3 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
        public void addTransaction4()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt4 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
        public void addTransaction5()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt5 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
        public void addTransaction6()
        {
            String tType = "Withdraw";
            try
            {
                conn.Open();
                String insertQuery = "INSERT INTO TransactionTbl VALUES('" + accNum + "','" + tType + "','" + amt6 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();
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
            lblAvailBal.Text = "Available Balance: MMK " + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void bnfTb10000_Click(object sender, EventArgs e)
        {
            if (balance < 10000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 10000;
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
                    addTransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnfTb30000_Click(object sender, EventArgs e)
        {
            if (balance < 30000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 30000;
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
                    addTransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnfTb50000_Click(object sender, EventArgs e)
        {
            if (balance < 50000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 50000;
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
                    addTransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnfTb300000_Click(object sender, EventArgs e)
        {
            if (balance < 300000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 300000;
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
                    addTransaction5();
                    Home home = new Home();
                    home.Show();
                    this.Close();
                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnfTb100000_Click(object sender, EventArgs e)
        {
            if (balance < 100000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 100000;
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
                    addTransaction4();
                    Home home = new Home();
                    home.Show();
                    this.Close();
                   // conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnfTb500000_Click(object sender, EventArgs e)
        {
            if (balance < 500000)
            {
                MessageBox.Show("Balance can't be Negative!");
            }
            else
            {
                int newBalance = balance - 500000;
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
                    addTransaction6();
                    Home home = new Home();
                    home.Show();
                    this.Close();
                   // conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
