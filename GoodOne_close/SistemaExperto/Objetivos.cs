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
            Atomos.Add("Basura**");
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
                try
                {
                    if (Matrix2[i].Exists(a => a == Busqueda[Ubicación]))
                    {
                        foreach (var item in Matrix2[i])
                        {
                            if (!Busqueda.Exists(a => a == item * -1))
                            {
                                if (item != Busqueda[Ubicación])
                                    Busqueda.Add(item * -1);
                            }
                        }
                        Matrix2.RemoveAt(i);
                        i = -1;
                    }
                }
                catch (Exception ex)
                {
                    if (Matrix2[i].Exists(a => a == Busqueda[Ubicación - 1]))
                    {
                        foreach (var item in Matrix2[i])
                        {
                            if (!Busqueda.Exists(a => a == item * -1))
                            {
                                if (item != Busqueda[Ubicación])
                                    Busqueda.Add(item * -1);
                            }
                        }
                        Matrix2.RemoveAt(i);
                        i = -1;
                    }
                }

            }
            if (Ubicación < Busqueda.Count)
            {
                Ubicación++;
                GenerarLista();
            }
            else
            {
                Ubicación = Busqueda.Count;
                //MessageBox.Show("Preguntas Re-planteadas");
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
            try
            {
                if (Math.Sign(Busqueda[Ubicación]) == -1)
                {
                    atomo = Busqueda[Ubicación] * -1;
                }
                else
                {
                    atomo = Busqueda[Ubicación];
                }
            }
            catch (Exception ex)
            {
                Ubicación = Busqueda.Count - 1;
                if (Math.Sign(Busqueda[Ubicación]) == -1)
                {
                    atomo = Busqueda[Ubicación] * -1;
                }
                else
                {
                    atomo = Busqueda[Ubicación];
                }
            }


            

            lblPregunta.Text = "Hay o Tienes " + Atomos.ElementAt(atomo);
            Resultado();
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
                    Lista.RemoveAt(asd);
                }
            }
            //Ubicación--;
            Verificar();
            Busqueda.Remove(atomo);
           Ubicación--;
            if (Busqueda.Count == 3)
                Ubicación++;
            //Resultado();
            Preguntar();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Verificar()
        {
            int control = 0;
            control = Matrix.Count;
            for (int i = 0; i < control; i++)
            {
                if (Matrix[i].Count == 0)
                {
                    Matrix.RemoveAt(i);
                    control = Matrix.Count;
                    i = 0;
                }
            }
            control = Matrix.Count;
            for(int i = 0; i < control; i++)
            {
                    if(Matrix[i].Count == 1)
                    {
                    Disparado(Matrix[i][0]);
                    control = Matrix.Count;
                    }
            }
            int existe = 0;
            for(int i = 0;i < Busqueda.Count;i++)
            {
                foreach (var Lista in Matrix)
                {
                    if(Lista.Exists(a => a == Busqueda[i]))
                    {
                        existe++;
                    }
                }
                if(existe != 0)
                {
                    existe = 0;
                }
                else
                {
                    Busqueda.Remove(Busqueda[i]);
                    i = 0;
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
                    var asd = Lista.IndexOf(atomo);
                    Lista.RemoveAt(asd);                    
                }
                else if (Lista.Exists(a => a == atomo * -1))
                {
                    Lista.Clear();

                }
            }
            Verificar();
            Busqueda.Remove(atomo);
            Busqueda.Remove(atomo * -1);
            Ubicación--;
            Preguntar();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Disparado(int bala)
        {
            atomo = bala;
            Ubicación++;
            //Busqueda.Remove(atomo);
            btnSI.PerformClick();
            //MessageBox.Show("Ya se disparo " + bala );
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Resultado()
        {
            if (Matrix.Count == 1)
            {
                if (Matrix[0].Count < 2)
                {
                    var asd = Matrix[0][0];
                    if(Math.Sign(asd) == -1)
                    {
                        MessageBox.Show("Se llego a una conclusión que" + Atomos[Math.Abs(asd)] + " es falso");
                        lblPregunta.Text = "";
                        btnSI.Enabled = false;
                        btnNo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Se llego a una conclusión que" + Atomos[Math.Abs(asd)] + " es verdadero");
                        lblPregunta.Text = "";
                        btnSI.Enabled = false;
                        btnNo.Enabled = false;
                    }
                    
                }
                    
            }
            else if (Matrix.Count == 0)
            {
                MessageBox.Show("NO se pudo concluir nada, se eliminaron todas las posibilidades");
                lblPregunta.Text = "";
                btnSI.Enabled = false;
                btnNo.Enabled = false;
            }
                  
          
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

