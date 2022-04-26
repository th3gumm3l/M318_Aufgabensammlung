using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double Balance = 0;

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Negativer Wert");
            }

            else
            {
                Balance += Convert.ToDouble(numericUpDown1.Value);
                lbl_Balance.Text = Balance.ToString();
            }

        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Negativer Wert");
            }

            else
            {
                if (Convert.ToDouble(numericUpDown1.Value) > Balance)
                {
                    MessageBox.Show("Kann nicht abgehoben werden");
                }

                else
                {
                    Balance -= Convert.ToDouble(numericUpDown1.Value);
                    lbl_Balance.Text = Balance.ToString();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
