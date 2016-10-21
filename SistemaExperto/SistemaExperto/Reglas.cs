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
    public partial class Reglas : Form
    {

        List<string> Atomos = new List<string>();
        string verdadera;

        public Reglas()
        {
            InitializeComponent();
        }

        private void Reglas_Load(object sender, EventArgs e)
        {
            comboAtomo.Items.Add("Selecciona un Atomo");
            string sql = "SELECT * FROM diccionario";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertoDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var atomo = reader.GetString("Atomo");
                    Atomos.Add(atomo);
                    comboAtomo.Items.Add(atomo);
                    //combo_Atom.Items.Add(reader.GetString("Atomo"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }
            comboAtomo.SelectedIndex = 0;
            //MessageBox.Show(comboAtomo.SelectedItem.ToString());
            Clean();
        }

        void Clean()
        {
            txtReglas.Text = string.Empty;
            richRules.Text = string.Empty;
            verdadera = string.Empty;

            string sql = "SELECT * FROM reglas";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertodb;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var antecedente = reader.GetString("Antecedente");
                    antecedente = antecedente.Trim();
                    var antecedentes = antecedente.Split('&');
                    for (int i = 0; i < antecedentes.Length; i++)
                    {
                        antecedentes[i] = antecedentes[i].Trim();
                        var posicicion = Int32.Parse(antecedentes[i]);
                        if (posicicion < 0)
                        {
                            richRules.Text += " no ";
                            posicicion = posicicion * -1;
                        }
                            
                        var atomo = Atomos[posicicion - 1];
                        //var atomo = Atomos antecedentes[i];
                        richRules.Text += " " + atomo;

                        if(i < antecedentes.Length - 1)
                            richRules.Text += " & ";
                       
                    }
                    var consecuente = reader.GetString("Consecuente");
                    consecuente = consecuente.Trim();
                    var pos = Int32.Parse(consecuente);
                    richRules.Text += " -> ";
                    if (pos < 0)
                    {
                        richRules.Text += " no ";
                        pos = pos * -1;
                    }
                    richRules.Text += Atomos[pos - 1] + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se puede conectar" + ex.ToString());
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtReglas.Text = string.Empty;
            verdadera = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboAtomo.SelectedIndex == 0)
                MessageBox.Show("Ese no es un atomo, selecciona uno");
            else
            {
                if (chBoxNo.Checked)
                {
                    txtReglas.Text += " no" + comboAtomo.SelectedItem;
                    verdadera += " -" + comboAtomo.SelectedIndex;
                }
                else
                {
                    txtReglas.Text += " " + comboAtomo.SelectedItem;
                    verdadera += " " + comboAtomo.SelectedIndex;
                }
            }        
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            txtReglas.Text += " &";
            verdadera += " &";
        }

        private void btnImplica_Click(object sender, EventArgs e)
        {
            txtReglas.Text += " →";
            verdadera += " →";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            String conectionSrtring = "server=localhost;database=expertodb;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            string commandLine = @"insert reglas (Antecedente,Consecuente) values (@valor1,@valor2)";
            verdadera = verdadera.Trim();
            String[] cosa = verdadera.Split('→');
            cosa[0] = cosa[0].Trim();
            cosa[1] = cosa[1].Trim();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = commandLine;
                cmd.Parameters.AddWithValue("@valor1", cosa[0].ToString());
                cmd.Parameters.AddWithValue("@valor2", cosa[1].ToString());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C" + " " + ex.ToString());
            }
            Clean();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

}
