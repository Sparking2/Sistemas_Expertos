using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaExperto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            String conectionSrtring = "server=localhost;database=expertodb;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            try
            {
                cnn.Open();
                MessageBox.Show("Conexión establecida correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar con la Base de datos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiccionario_Click(object sender, EventArgs e)
        {
            Diccionario nuevo = new Diccionario();
            nuevo.Show();
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            Reglas nuevo = new Reglas();
            nuevo.Show();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            Adelante nuevo = new Adelante();
            nuevo.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras nuevo = new Atras();
            nuevo.Show();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            Objetivos nuevo = new Objetivos();
            nuevo.Show();
        }
    }
}
