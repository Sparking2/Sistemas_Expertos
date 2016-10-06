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
    public partial class delante : Form
    {
        String[] hola = new String[];
        int puntero = 0;
        public delante()
        {
            InitializeComponent();
        }

        private void delante_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM atomos";
            MySqlConnection con = new MySqlConnection("server=localhost;database=testDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            int i = 0;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hola[i] = reader.GetString("Atomo");
                    i++;
                    //combo_Atom.Items.Add(reader.GetString("Atomo"));
                }
                con.Close();
                lbl_atomo.Text = hola[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            puntero++;
            lbl_atomo.Text = hola[puntero];
        }
    }
}
