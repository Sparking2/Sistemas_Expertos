using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaExperto
{
    public partial class Frm_Atomos : Form
    {
        //Atomos dsAtomos = new Atomos();
        //String XMLlocationAtomos = Application.StartupPath + @"\XMLAtomos.xml";
        //String XMLlocationReglas = Application.StartupPath + @"\XMLReglas.xml";

        public Frm_Atomos()
        {
            InitializeComponent();
           
        }

        
        private void Frm_Atomos_Load(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void btn_AddAtom_Click(object sender, EventArgs e)
        {
            String conectionSrtring = "server=localhost;database=testDB;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            string commandLine = @"insert atomos (Atomo) values (@valor)";
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
                MessageBox.Show("No se pudo conectar!! :C" + " " + ex.ToString());
            }
            UpdateText();
        }

        void UpdateText()
        {
            txtAtomo.Text = String.Empty;
            rich_Text.Text = String.Empty;
            string sql = "SELECT * FROM atomos";
            MySqlConnection con = new MySqlConnection("server=localhost;database=testDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rich_Text.Text += reader.GetString("Atomo");
                    rich_Text.Text += "\n";
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }

        }
    }
}
