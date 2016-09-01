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
    public partial class Frm_Diccionario : Form
    {
        public Frm_Diccionario()
        {
            InitializeComponent();

            this.FormClosing += Frm_Diccionario_FormClosing;
        }

        private void Frm_Diccionario_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_Diccionario_Load(object sender, EventArgs e)
        {
           
        }

    }
}
