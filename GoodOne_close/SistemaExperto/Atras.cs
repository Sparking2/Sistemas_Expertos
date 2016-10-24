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
    public partial class Atras : Form
    {
        List<List<int>> Matrix = new List<List<int>>();
        List<int> consecuentes = new List<int>();
        List<int> AtomosPregunta = new List<int>();
        public Atras()
        {
            InitializeComponent();
        }

        private void Atras_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM reglas";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertodb;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<int> Lista = new List<int>();
                    var antecedente = reader.GetString("Antecedente");
                    antecedente.Trim();
                    var antecedentes = antecedente.Split('&');
                    for (int i = 0; i < antecedentes.Length; i++)
                    {
                        //Atomos.Add(antecedentes[i].Trim());
                        Lista.Add(int.Parse(antecedentes[i]));
                    }
                    Matrix.Add(Lista);

                    var consecu = reader.GetString("Consecuente");
                    consecuentes.Add(int.Parse(consecu));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }/// Load
        public List<int> atomosFinale()
        {
            List<int> Lista = new List<int>();
            foreach (var item in consecuentes)
            {
                foreach (var objeto in Matrix)
                {
                    objeto.Exists(a => a == item);
                    MessageBox.Show(item.ToString());
                }
            }
            return Lista;
        }
    }

}
