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
    public partial class Diccionario : Form
    {
        public Diccionario()
        {
            InitializeComponent();
        }

        private void Diccionario_Load(object sender, EventArgs e)
        {

        }

        void UpdateText()
        {
            txtAtomo.Text = String.Empty;
            richTextBox1.Text = string.Empty;
            string sql = "SELECT * FROM diccionario";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertodb;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.Text += reader.GetString("Atomo");
                    richTextBox1.Text += "\n";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String conectionSrtring = "server=localhost;database=expertodb;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            string commandLine = @"insert diccionario (Atomo) values (@valor)";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = commandLine;
                cmd.Parameters.AddWithValue("@valor", txtAtomo.Text.ToString());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C" + " " + ex.ToString(),"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            UpdateText();
        }
    }
}
