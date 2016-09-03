using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExperto
{
    public partial class Frm_Reglas : Form
    {
        public Frm_Reglas()
        {
            InitializeComponent();
            this.FormClosing += Frm_Reglas_FormClosing;
        }

        private void Frm_Reglas_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(richBox.Text);
        }

        private void Frm_Reglas_Load(object sender, EventArgs e)
        {
            combo_Atom.Items.Add("qwe");
        }

        private void implies_Click(object sender, EventArgs e)
        {
            richBox.Text += " -> ";
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            richBox.Text += " y ";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cBox_no.Checked)
                richBox.Text += " NO " + combo_Atom.SelectedItem;
            else
                richBox.Text += combo_Atom.SelectedItem;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            richBox.Text += " ( ";
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            richBox.Text += " ) ";
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            richBox.Text += " o ";
        }
    }
}
