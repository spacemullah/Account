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
        // Variable to be used
        double balance =0;
        double amount;
        string name;
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = name +","+ balance;
        }
        public double deposit(int amount)
        {
            balance += amount;
            return balance;
        }
        public int withdrawal(int amount)
        {
            balance -= amount;
            return (int)balance;
        }
        public string inquiry()
        {
            MessageBox.Show("Account Name: \n" + name + "Account Balance: " + balance, "Inquiry");
            return null;
        }
        public double transfer(int amount, int AccNo)
        {
            if (balance < amount)
            {
                MessageBox.Show("Insufficient Funds, balance is: " + balance, "Invalid Transfer");
            }
            else
            {
                balance -= amount;
                MessageBox.Show("Transaction Succesful \n Your new Balance is: " + balance, "Success");
            }
            return balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inquiry();
        }
    }
}
