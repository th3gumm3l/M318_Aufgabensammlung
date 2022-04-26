using System;
using System.Windows.Forms;

namespace Aufgabe04_3
{
    public partial class FormA043 : Form
    {
        public FormA043()
        {
            InitializeComponent();
        }

        //Der Bankaccount muss global sein, weil sonst der aktuelle Kontostand in der Balance Variable nicht aktualisiert wird, sondern immer neu geschrieben wird.
        BankAccount bankAccount = new BankAccount();

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

    }
}
