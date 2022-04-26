using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe04_2
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
            //überprüfung, ob die Eingabe 0 oder kleiner als 0 ist
            if (numericUpDown1.Value < 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Negativer Wert");
            }

            else
            {
                double Eingabe = Convert.ToDouble(numericUpDown1.Value);    //Eingabe wird in eine Variable geschrieben und in Double Konvertiert
                Balance += Eingabe;     //Der eingegebene Wert wird von der globalen Variable Balance abgerechnet
                lbl_Balance.Text = Balance.ToString();  //Hier wird der "Kontostand" in einem Label aktualisiert/gezeigt
                dataGridView1.Rows.Add(     //Hier werden die Reihen für das DataGrid hinzugefügt
                    DateTime.Now,
                    "+" + Eingabe,
                    Balance
                  );
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
                //Hier wird überprüft, ob die Eingabe nicht grösser als der "Kontostand" ist
                if (Convert.ToDouble(numericUpDown1.Value) > Balance)
                {
                    MessageBox.Show("Kann nicht abgehoben werden");
                }

                else
                {
                    double Eingabe = Convert.ToDouble(numericUpDown1.Value);
                    Balance -= Eingabe;
                    lbl_Balance.Text = Balance.ToString();
                    dataGridView1.Rows.Add(
                        DateTime.Now,
                        "-" + Eingabe,
                        Balance
                    );
                }
            }
        }
    }
}
