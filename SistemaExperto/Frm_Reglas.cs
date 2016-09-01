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

        }

        private void Frm_Reglas_Load(object sender, EventArgs e)
        {

        }
    }
}
