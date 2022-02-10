using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);

            PrimeCheck prime = new PrimeCheck();
            bool isPrime = prime.CheckPrime(num);

            if (isPrime)
            {
                MessageBox.Show(num + " is not a prime number");
            }
            else
            {
                MessageBox.Show(num + " is a prime number");
            }

        }
    }
}
