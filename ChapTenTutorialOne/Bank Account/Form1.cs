using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CDAccount newAccount = new CDAccount();

            GetCDDate(newAccount);

            lblAccount.Text = newAccount.AccountNumber;
            lblInterest.Text = newAccount.InterestRate.ToString("n2");
            lblBalance.Text = newAccount.Balance.ToString("c");
            lblDate.Text = newAccount.MaturityDate;

        }

        private void GetCDDate(CDAccount account)
        {
            decimal interestRate;
            decimal balance;

            account.AccountNumber = txtAccount.Text;
            account.MaturityDate = txtDate.Text;

            if (decimal.TryParse(txtInterest.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(txtBalance.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    MessageBox.Show("Invalid Balance.");
                }
            }
            else
            {
                MessageBox.Show("Invalid interest rate.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
