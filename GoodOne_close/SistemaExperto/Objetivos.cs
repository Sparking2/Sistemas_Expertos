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
    public partial class Objetivos : Form
    {
        List<string> Atomos = new List<string>();
        List<List<int>> Matrix = new List<List<int>>();
        List<int> Busqueda = new List<int>();
        List<List<int>> Matrix2 = new List<List<int>>();
        int Objetivo;
        public Objetivos()
        {
            InitializeComponent();
        }

        private void Objetivos_Load(object sender, EventArgs e)
        {
            comboAtomos.Items.Add("Selecciona un Atomo");
            string sql = "SELECT * FROM diccionario";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertodb;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var atomo = reader.GetString("Atomo");
                    Atomos.Add(atomo);
                    comboAtomos.Items.Add(atomo);
                    //combo_Atom.Items.Add(reader.GetString("Atomo"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo conectar " + ex, "ERROR!!");
            }

            sql = "SELECT * FROM reglas";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var Lista = new List<int>();
                    var antecedente = reader.GetString("Antecedente");
                    antecedente.Trim();
                    var antecedentes = antecedente.Split('&');
                    foreach (var item in antecedentes)
                    {
                        Lista.Add(int.Parse(item) * -1);
                    }
                    var consecuente = reader.GetString("Consecuente");
                    Lista.Add(int.Parse(consecuente));
                    Matrix.Add(Lista);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo conectar " + ex, "ERROR!!");
            }
            comboAtomos.SelectedIndex = 0;

        }//////////////////////////////LOAD/////////////////////////////

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (comboAtomos.SelectedIndex != 0)
            {
                Objetivo = comboAtomos.SelectedIndex;
                Busqueda.Add(Objetivo);
                Busqueda.Add(Objetivo * -1);
                btnStart.Enabled = false;
                Matrix.ForEach((item) =>
                {
                    Matrix2.Add((item));
                });
                GenerarLista();
                Preguntar();
            }

            else { 
                MessageBox.Show("ESE NO ES UN ATOMO!!!", "A pero que....");
            }

            ////
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int Ubicación = 0;
        private void GenerarLista()
        {
            for (int i = 0; i < Matrix2.Count; i++)
            {
                if (Matrix2[i].Exists(a => a == Busqueda[Ubicación]))
                {
                    foreach (var item in Matrix2[i])
                    {
                        if (!Busqueda.Exists(a => a == item))
                        {
                            Busqueda.Add(item * -1);
                        }
                    }
                    Matrix2.RemoveAt(i);
                }

            }
            if (Ubicación < Busqueda.Count)
            {
                Ubicación++;
                GenerarLista();
            }
            else
            {
                MessageBox.Show("Listo");
                Ubicación--;
                btnSI.Enabled = true;
                btnNo.Enabled = true;
                comboAtomos.Enabled = false;
            }


        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        int atomo;
        private void Preguntar()
        {
            
            if (Math.Sign(Busqueda[Ubicación]) == -1 )
            {
                atomo = Busqueda[Ubicación] * -1;
            }
            else
            {
                atomo = Busqueda[Ubicación];
            }
            lblPregunta.Text = "Hay o Tienes " + Atomos.ElementAt(atomo);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSI_Click(object sender, EventArgs e)
        {
            foreach (var Lista in Matrix)
            {
                if (Lista.Exists(a=>a==atomo))
                {
                    Lista.Clear();
                }
                else if (Lista.Exists(a=>a==atomo * -1))
                {
                    
                    var asd = Lista.IndexOf(atomo * -1);
                    Lista[asd] = 0;
                }
            }
            Verificar();
            Busqueda.RemoveAt(Ubicación);
            Ubicación--;
            Preguntar();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Verificar()
        {
            int control = 0;
            control = Matrix.Count;
            for(int i = 0; i < control; i++)
            { 
                if(Matrix[i].Count == 0)
                {
                    Matrix.RemoveAt(i);
                    control = Matrix.Count;
                    i = 0;
                }
            }
            control = Matrix.Count;
            for(int i = 0; i < control; i++)
            {
                int qwe = 0;
                foreach (var item in Matrix[i])
                {
                    if(item == 0)
                    {
                        //PENDIENTE!!!! se la debo de pasar a verificar ver si se disparo algo
                    }
                }
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnNo_Click(object sender, EventArgs e)
        {
            foreach (var Lista in Matrix)
            {
                if (Lista.Exists(a => a == atomo))
                {
                    var asd = Lista.IndexOf(atomo * -1);
                    Lista[asd] = 0;
                    
                }
                else if (Lista.Exists(a => a == atomo * -1))
                {
                    Lista.Clear();
                }
            }
            Verificar();
            Busqueda.RemoveAt(Ubicación);
            Ubicación--;
            Preguntar();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Disparado()
        {

        }
        
    }
}

