using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         double interestRate;
         double balance;
        double interest;
         int time;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (bankCombe.Text=="Brac")
            {
                interestRate = 6;
            }
            else if(bankCombe.Text=="DBBL")
            {
                interestRate = 7;
            }
            else if(balanceBox.Text=="HSBC")
            {
                interestRate = 8;
            }

            time = Convert.ToInt16(TimeBox.Text);
            balance = Convert.ToDouble(balanceBox.Text);

            interest = (interestRate*balance* time)/100;

            MessageBox.Show("The interest is " + interest);

        }

        private void bankCombe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
