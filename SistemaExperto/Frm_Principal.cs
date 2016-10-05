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
using MySql.Data.MySqlClient;


namespace SistemaExperto
{
    public partial class MenuPpl : Form
    {
        Atomos dsAtomos = new Atomos();
        //String connectionString = "server=localhost;database=testDB;uid=root;pwd=123456";
        //MySqlConnection cnn = new MySqlConnection(connectionString);
        //String XMLlocationAtomos = Application.StartupPath + @"\XMLAtomos.xml";
        //String XMLlocationReglas = Application.StartupPath + @"\XMLReglas.xml";
        public MenuPpl()
        {
            InitializeComponent();
            String conectionSrtring = "server=localhost;database=testDB;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            try
            {
                cnn.Open();
                MessageBox.Show("Conexion abierta :D! ");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C");
            }
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
            /*if (!File.Exists(XMLlocationAtomos))
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
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diccionario nuevo = new Diccionario();
            nuevo.Show();
        }

        private void btn_delante_Click(object sender, EventArgs e)
        {
            delante nuevo = new delante();
            nuevo.Show();
        }
    }
}
