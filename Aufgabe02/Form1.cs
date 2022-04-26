using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_toAusgabe_Click(object sender, EventArgs e)
        {
            lbx_Ausgabe.Items.Add(cmb_Items.SelectedItem);
            cmb_Items.Items.Remove(cmb_Items.SelectedItem);
        }

        private void btn_toItems_Click(object sender, EventArgs e)
        {
            cmb_Items.Items.Add(lbx_Ausgabe.SelectedItem);
            lbx_Ausgabe.Items.Remove(lbx_Ausgabe.SelectedItem);
        }

        private void lbx_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            cmb_Items.Items.Add(lbx_Ausgabe.SelectedItem);
            lbx_Ausgabe.Items.Remove(lbx_Ausgabe.SelectedItem);
        }

        private void cmb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_toAusgabe.Enabled = true;
            btn_toItems.Enabled = false;
        }

        private void lbx_Ausgabe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_toItems.Enabled = true;
            btn_toAusgabe.Enabled = false;
        }
    }
}
