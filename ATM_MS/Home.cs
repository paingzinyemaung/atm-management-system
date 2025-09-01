using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_MS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void bnfTbDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.Show();
            //this.Hide();
        }

        private void bnfTbFastCash_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            this.Hide();
            fastCash.Show();
            //this.Hide();
        }

        private void bnfTbChangePin_Click(object sender, EventArgs e)
        {
            ChangePin changePin = new ChangePin();
            this.Hide();
            changePin.Show();
        }

        private void bnfTbWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void bnfTbMs_Click(object sender, EventArgs e)
        {
            MiniStatement ms = new MiniStatement();
            this.Hide();
            ms.Show();
        }

        private void bnfTbBl_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();      
        }
        public static String accNum;
        private void Home_Load(object sender, EventArgs e)
        {
            lblAccNumber.Text = "Account Number: " + Login.accNum;
            accNum = Login.accNum;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
