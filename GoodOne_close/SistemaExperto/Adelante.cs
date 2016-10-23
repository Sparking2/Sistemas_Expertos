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
    public partial class Adelante : Form
    {
        List<string> Atomos = new List<string>();
        List<List<int>> Matrix = new List<List<int>>();
        List<int> consecuentes = new List<int>();
        List<int> soloConsecuentes = new List<int>();
        List<int> soloAntecedentes = new List<int>();
        List<int> Ambos = new List<int>();
        List<int> explicación = new List<int>();

        public Adelante()
        {
            InitializeComponent();
        }

        private void Adelante_Load(object sender, EventArgs e)
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
                    for(int i = 0; i < antecedentes.Length; i++)
                    {
                        //Atomos.Add(antecedentes[i].Trim());
                        Lista.Add(int.Parse(antecedentes[i]));
                    }
                    Matrix.Add(Lista);

                    var consecu = reader.GetString("Consecuente");
                    consecuentes.Add(int.Parse(consecu));
                }
                con.Close();

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, no se puede continuar \n" + ex.ToString());
            }

            try
            {
                Atomos.Add("Basura");
                sql = "SELECT * FROM Diccionario";
                cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var atomo = reader.GetString("Atomo");
                    Atomos.Add(atomo);
                    //comboAtomo.Items.Add(atomo);
                    //combo_Atom.Items.Add(reader.GetString("Atomo"));
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, no se puede continuar \n" + ex.ToString());
            }
            CrearLista();
            //MessageBox.Show("Stop");
            Preguntar();
        }



        void CrearLista()
        {
            soloAntecedentes.Clear();
            Ambos.Clear();
            soloConsecuentes.Clear();
            for (int i = 0; i < consecuentes.Count; i++)
            {
                foreach (var item in Matrix) 
                        foreach (int entero in item)
                        {
                        if (Math.Abs(consecuentes[i]) == Math.Abs(entero))
                            Ambos.Add(consecuentes[i]);
                        else
                        {
                            var num = Math.Abs(consecuentes[i]);
                            if (!soloConsecuentes.Exists(a => a == num))
                                soloConsecuentes.Add(Math.Abs(consecuentes[i]));
                        }
                    }
             }
            

            for (int i = 0; i < Matrix.Count; i++)
                foreach (var item in Matrix[i])
                {
                    var num = Math.Abs(item);
                    if (!soloAntecedentes.Exists(a => a == num))
                        soloAntecedentes.Add(num);
                }
            for (int i = 0; i < Ambos.Count; i++) { 
                soloConsecuentes.RemoveAll(a => a == Ambos[i]);
                soloAntecedentes.RemoveAll(a => a == Ambos[i]);
            }

        }

        void Preguntar()
        {
            if (soloAntecedentes.Any())
                lblAtomo.Text = Atomos[soloAntecedentes[0]];
            else if (Ambos.Any())
                lblAtomo.Text = Atomos[Ambos[0]];
            else if (soloConsecuentes.Any())
                lblAtomo.Text = Atomos[soloConsecuentes[0]];
            //soloAntecedentes[0];
        }

        void RevisarMatrix()
        {
            foreach (var item in Matrix)
                if (item.Count == 0)
                {
                    var asd = Matrix.IndexOf(item);
                    var cosa = consecuentes.ElementAt(asd);
                    if (soloConsecuentes.Exists(a=>a==cosa) || soloConsecuentes.Exists(a=>a==-cosa)) { 
                        if(Math.Sign(cosa) == -1)
                            MessageBox.Show("Se determino que no " + Atomos[Math.Abs(cosa)] + " es lo que sucede");
                        else
                                MessageBox.Show("Se determino que " + Atomos[cosa] + " es lo que sucede");
                    }
                    Matrix.RemoveAt(asd);
                    consecuentes.RemoveAt(asd);
                    //explicación.Add()
                    lblAtomo.Text = Atomos[cosa];
                    DijoSi();
                    break;
                }
                    
           
        }

        void DijoSi()
        {
            var index = Atomos.FindIndex(a => a == lblAtomo.Text);
            for (int i = 0; i < Matrix.Count; i++)
            {
                //var index = Atomos.FindIndex(a => a == lblAtomo.Text);
                if (Matrix[i].Contains(index) || Matrix[i].Contains(-index))
                {
                    int ubi;
                    if (Matrix[i].Contains(index))
                    {
                        ubi = Matrix[i].IndexOf(index);
                    }
                    else
                    {
                        ubi = Matrix[i].IndexOf(-index);
                    }

                    //ubi = Matrix[i].FindIndex(a => a == -index);
                    //var test = Math.Sign(Matrix[i].Find(a=>a==ubi));
                    if (Math.Sign(Matrix[i][ubi]) == 1)
                    {
                        Matrix[i].Remove(index);
                    }
                    else
                    {
                        //Matrix[i][ubi] = 0;
                        Matrix.RemoveAt(i);
                        consecuentes.RemoveAt(i);
                        i = -1;
                    }

                }


            }
            Borrar(index);
            RevisarMatrix();
            CrearLista();
            Preguntar();
            //MessageBox.Show("stopa");
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            DijoSi();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            var index = Atomos.FindIndex(a => a == lblAtomo.Text);
            for (int i = 0; i < Matrix.Count; i++)
            {
                //var index = Atomos.FindIndex(a => a == lblAtomo.Text);
                if (Matrix[i].Contains(index) || Matrix[i].Contains(-index))
                {
                    int ubi;
                    if (Matrix[i].Contains(index))
                    {
                        ubi = Matrix[i].IndexOf(index);
                    }
                    else
                    {
                        ubi = Matrix[i].IndexOf(-index);
                    }
                    var test = Math.Sign(Matrix[i][ubi]);
                    if (Math.Sign(Matrix[i][ubi]) == -1)
                    {
                        Matrix[i].Remove(-index);
                    }
                    else
                    {
                        Matrix[i][ubi] = 0;
                        Matrix.RemoveAt(i);
                        consecuentes.RemoveAt(i);
                        i = -1;
                    }
                }
            }
            Borrar(index);
            RevisarMatrix();
            Preguntar();
            CrearLista();
            //MessageBox.Show("stopa");
        }

        void Borrar(int index)
        {
            if (soloAntecedentes.Exists(a => a == index))
                soloAntecedentes.Remove(index);
            else if (Ambos.Exists(a => a == index))
                Ambos.Remove(index);
            else if (soloConsecuentes.Exists(a => a == index))
                soloConsecuentes.Remove(index);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
