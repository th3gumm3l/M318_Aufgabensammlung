using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int zähler = 1;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            string Eingabe = tbx_Eingabe.Text;

            lbx_Ausgabe.Items.Add(zähler + ":" + Eingabe);

            ++zähler;

        }
    }
}
