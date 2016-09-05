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

namespace SistemaExperto
{
    public partial class MenuPpl : Form
    {
        Atomos dsAtomos = new Atomos();
        String XMLlocationAtomos = Application.StartupPath + @"\XMLAtomos.xml";
        String XMLlocationReglas = Application.StartupPath + @"\XMLReglas.xml";
        public MenuPpl()
        {
            InitializeComponent();
        }

        private void btn_diccionario_Click(object sender, EventArgs e)
        {
            Frm_Atomos nuevo = new Frm_Atomos();
            nuevo.Show();
        }

        private void btn_reglas_Click(object sender, EventArgs e)
        {
            Frm_Reglas nuevo = new Frm_Reglas();
            nuevo.Show();
        }

        private void MenuPpl_Load(object sender, EventArgs e)
        {
            if (!File.Exists(XMLlocationAtomos))
            {
                MessageBox.Show("No existe el Archivo de Atomos, Creando");
                DataTable dtTable = dsAtomos.Tables["DiccionarioAtomos"];          
                dtTable.WriteXml(XMLlocationAtomos);
            }
            if (!File.Exists(XMLlocationReglas))
            {
                MessageBox.Show("No existe el Archivo de Reglas, Creando");
                DataTable dtTable = dsAtomos.Tables["DiccionarioAtomos"];
                dtTable = dsAtomos.Tables["DiccionarioReglas"];
                dtTable.WriteXml(XMLlocationReglas);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diccionario nuevo = new Diccionario();
            nuevo.Show();
        }
    }
}
