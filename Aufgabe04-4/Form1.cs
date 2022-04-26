using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aufgabe04_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Der Bankaccount muss global sein, weil sonst der aktuelle Kontostand in der Balance Variable nicht aktualisiert wird, sondern immer neu geschrieben wird.
        Bankaccount bankAccount = new Bankaccount();

        /// <summary>
        /// Click Funktion, welche das Geldeinzahlen simuliert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            double Eingabe = Convert.ToDouble(numericUpDown1.Value);

            if (bankAccount.Deposit(Eingabe))
            {
                lbl_Balance.Text = Convert.ToString(bankAccount.Balance);
                AddRowsAddition(Eingabe);
            }

            else
            {
                MessageBox.Show("Deine Eingabe kann nicht eingezahlt werden");
            }
        }

        /// <summary>
        /// Click Funktion, welche das Geldabheben simuliert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            double Eingabe = Convert.ToDouble(numericUpDown1.Value);

            if (bankAccount.Withdraw(Eingabe))
            {
                lbl_Balance.Text = Convert.ToString(bankAccount.Balance);
                AddRowsSubtraktion(Eingabe);
            }

            else
            {
                MessageBox.Show("Deine Eingabe kann nicht abgehoben werden");
            }


        }

        /// <summary>
        /// Fügt die Reihen hinzu in einem DataGridView und ein zusätzliches Plus-Zeichen
        /// </summary>
        /// <param name="Wert"></param>
        public void AddRowsAddition(double Wert)
        {
            dataGridView1.Rows.Add(     //Hier werden die Reihen für das DataGrid hinzugefügt
                DateTime.Now,
                "+" + Wert,
                bankAccount.Balance
            );
        }

        /// <summary>
        /// Fügt die Reihen hinzu in einem DataGridView und ein zusätzliches Minus-Zeichen
        /// </summary>
        /// <param name="Wert"></param>
        public void AddRowsSubtraktion(double Wert)
        {
            dataGridView1.Rows.Add(     //Hier werden die Reihen für das DataGrid hinzugefügt
                DateTime.Now,
                "-" + Wert,
                bankAccount.Balance
            );
        }

        /// <summary>
        /// Was passieren soll, wenn das Programm geladen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {   
            double txtData = Convert.ToDouble(File.ReadAllText(@"C:\Users\TIMBER~1\AppData\Local\Temp\Aufgabe04.txt"));
            lbl_Balance.Text = Convert.ToString(txtData);
            bankAccount.OverrideBalance(txtData);
        }

        /// <summary>
        /// Was passieren soll, wenn das Programm geschlossen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = File.CreateText(@"C:\Users\TIMBER~1\AppData\Local\Temp\Aufgabe04.txt");
            
            sw.WriteLine(lbl_Balance.Text);
            sw.Close();

        }

    }
}
