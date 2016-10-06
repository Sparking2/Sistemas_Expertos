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
        //String[] hola;
        List<List<String>> Matrix = new List<List<String>>();
        List<string> onlyBefore = new List<string>();
        List<string> Both = new List<string>();
        List<string> onlyLater = new List<string>();

        int puntero = 0;
        public delante()
        {
            InitializeComponent();
        }

        private void delante_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM reglas";
            MySqlConnection con = new MySqlConnection("server=localhost;database=testDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<string> Regla = new List<string>();
                    string random = reader.GetString("Regla");
                    var data = random.Split('&');
                    for (int i = 0; i < data.Length; i++)
                        Regla.Add(data[i]);
                    Regla.Add("→");
                    Regla.Add(reader.GetString("Implica"));
                    Matrix.Add(Regla);
                 }
                con.Close();
                       }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }

            CrearListas();
            MessageBox.Show("Todo Cargado");
        }

        private void btn_si_Click(object sender, EventArgs e)
        {

        }

    private void CrearListas()
        {
            bool before = false;
            bool later = false;
            for(int y = 0; y < Matrix.Count; y++)
            {
                for (int x = 0; x < Matrix[y].Count; x++)
                {
                    var objeto = Matrix[y][x];

                    if (objeto != "→")
                    {
                        if (objeto[1] == 'n' && objeto[2] == 'o') 
                            objeto = objeto.Substring(3);
                        for (int i = 0; i < Matrix.Count; i++)
                        {
                            if (Matrix[i].Exists(a => a == objeto))
                            {
                                int index;
                                index = Matrix[i].IndexOf(objeto);
                                /*if (Matrix[i][index + 1] == null)
                                    later = true;*/
                                if (index + 1 > Matrix[i].Count)
                                    later = true;
                                if (index + 1 < Matrix[i].Count && Matrix[i][index + 1] != "→")
                                    before = true;
                                /*if (index + 1 < Matrix[i].Count && Matrix[i][index + 1] == "→")
                                    before = true;*/

                                if (before && !later)
                                    if (!onlyBefore.Exists(a => a == objeto))
                                        onlyBefore.Add(objeto);

                                else if (!before && later)
                                    if (!onlyLater.Exists(a => a == objeto))
                                        onlyLater.Add(objeto);

                                else if(before && later)
                                    if (!Both.Exists(a => a == objeto) && onlyLater.Exists(a => a == objeto) && onlyBefore.Exists((a => a == objeto)))
                                    {
                                        Both.Add(objeto);
                                        onlyLater.Remove(objeto);
                                        onlyBefore.Remove(objeto);
                                    }

                                before = later = false;
                                //Matrix[i].Fin
                                //MessageBox.Show("Existe" + objeto);
                            }
                            /* if (Matrix[i].FindIndex(a => a == objeto) != null)
                                 MessageBox.Show("Existe");*/
                            //MessageBox.Show(Matrix[i].FindIndex(a => a == objeto).ToString());
                        }
                       
                    }
                }
            }
        }
    }
}
