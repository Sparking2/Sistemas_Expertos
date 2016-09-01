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
    public partial class MenuPpl : Form
    {
        public MenuPpl()
        {
            InitializeComponent();
        }

        private void btn_diccionario_Click(object sender, EventArgs e)
        {
            Frm_Diccionario nuevo = new Frm_Diccionario();
            nuevo.Show();
        }

        private void btn_reglas_Click(object sender, EventArgs e)
        {
            Frm_Reglas nuevo = new Frm_Reglas();
            nuevo.Show();
        }

        private void MenuPpl_Load(object sender, EventArgs e)
        {

        }
    }
}
