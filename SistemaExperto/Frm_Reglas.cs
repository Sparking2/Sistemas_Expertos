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
    public partial class Frm_Reglas : Form
    {
        Atomos dsAtomos = new Atomos();
        String XMLlocationAtomos = Application.StartupPath + @"\XMLAtomos.xml";
        String XMLlocationReglas = Application.StartupPath + @"\XMLReglas.xml";
        String SimpleRule = "";

        public Frm_Reglas()
        {
            InitializeComponent();
            this.FormClosing += Frm_Reglas_FormClosing;

        }

        private void Frm_Reglas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(richBox.Text);
            //int index = combo_Atom.SelectedIndex;
            //MessageBox.Show(combo_Atom.SelectedIndex.ToString());
        }

        private void Frm_Reglas_Load(object sender, EventArgs e)
        {
            combo_Atom.Items.Add("Selecciona un Atomo");
            combo_Atom.SelectedIndex=0;
            string sql = "SELECT * FROM atomos";
            MySqlConnection con = new MySqlConnection("server=localhost;database=testDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_Atom.Items.Add(reader.GetString("Atomo"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }

            Clean();
        }

        private void implies_Click(object sender, EventArgs e)
        {
            richBox.Text += " →";
            SimpleRule += " →";
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            richBox.Text += " y";
            SimpleRule += " ^";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(combo_Atom.SelectedIndex == 0)
            {
                MessageBox.Show("Ese no es Un Atomo","Aviso");
            }else
            {
                if (cBox_no.Checked) { 
                    richBox.Text += " no " + combo_Atom.SelectedItem;
                    SimpleRule += " -" + combo_Atom.SelectedIndex+" ";
                }
                else
                { 
                    richBox.Text += " " + combo_Atom.SelectedItem;
                    SimpleRule += " " + combo_Atom.SelectedIndex;
                }
            }
        }
            

        private void btn_left_Click(object sender, EventArgs e)
        {
            richBox.Text += " (";
            SimpleRule += " (";
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            richBox.Text += " )";
            SimpleRule += " )";
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            richBox.Text += " o";
            SimpleRule += " v";
        }

        private void btn_Regla_Click(object sender, EventArgs e)
        {

            String conectionSrtring = "server=localhost;database=testDB;uid=root;pwd=123456";
            MySqlConnection cnn = new MySqlConnection(conectionSrtring);
            string commandLine = @"insert reglas (Regla,Implica) values (@valor1,@valor2)";
            String[] cosa = richBox.Text.Split('→');
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
            /*
            DataTable dtTable = dsAtomos.Tables["DiccionarioReglas"];
            DataRow drRows = dtTable.NewRow();
            drRows["Regla"] = richBox.Text;
            drRows["ReglaSimple"] = SimpleRule;
            CreateRules(SimpleRule);
          
            Clean();
            */
        }

        void Clean()
        {
            richBox.Text = "";
            richRules.Text = "";
            SimpleRule = "";

            string sql = "SELECT * FROM reglas";
            MySqlConnection con = new MySqlConnection("server=localhost;database=testDB;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    richRules.Text += reader.GetString("Regla") + " → " + reader.GetString("Implica") + "\n";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar!! :C " + ex.ToString());
            }
            
        }

        void CreateRules(String Frase)
        {
            String[] substrings = Frase.Split('→');
            Dictionary<int, String> Diccionario = new Dictionary<int, String>();
            String previo = substrings[0], consecuente = substrings[1];
            String[] previos = previo.Split(' ');

            ArbolNodos(previos);
            Nodo cosa = new Nodo();
            cosa = raiz;
            LeerArbol(cosa);
            DataTable dtTable = dsAtomos.Tables["DiccionarioReglas"];
            
            String ReglaSimple = "";
            String Regla = "";
            for (int x = 0; x < raiz.HijosInfo.Count; x++)
            {
                DataRow drRows = dtTable.NewRow();

                for (int i = 0; i < raiz.HijosInfo[x].Length-1; i++)
                {
                    if (raiz.HijosInfo[x][i] != ',')
                    {
                        ReglaSimple += raiz.HijosInfo[x][i];
                    }
                    else
                    {
                        ReglaSimple += "^";
                    }
                    

                }
                //String[] Ruler = ReglaSimple.Split('');
                /*for (int i = 0; i < ReglaSimple.Length; i++)
                {
                    if(ReglaSimple[i] == '¬')
                        Regla += " NO ";

                    if (ReglaSimple[i] != '^' && ReglaSimple[i] != '¬')
                        Regla += combo_Atom.Items[(int)Char.GetNumericValue(ReglaSimple[i])];                        
    
                    if (ReglaSimple[i] == '^')
                        Regla += " y ";
                }*/
                ReglaSimple += "→" + consecuente;
                Regla += " → " + combo_Atom.Items[Int32.Parse(consecuente)];
                drRows["ReglaSimple"] = ReglaSimple;
                drRows["Regla"] = Regla;
                dtTable.Rows.Add(drRows);
                dtTable.WriteXml(XMLlocationReglas);
                ReglaSimple = "";
                Regla = "";
            }
            MessageBox.Show(":v");
           }

    

        private void btnRestart_Click(object sender, EventArgs e)
        {
            richBox.Text = "";
            SimpleRule = "";
        }

        class Nodo
        {
            public string info;
            public List<String> HijosInfo;
            public Nodo izq, der,padre;
        }

        Nodo raiz;

        public void ArbolNodos(String[] antecedente)
        {
            Nodo anterior = null;
            raiz = new Nodo();
            anterior = raiz;
            for (int i = 0; i < antecedente.Length; i++)
            {
                if (antecedente[i] == "")
                {

                }
                else if (antecedente[i] == "(")
                {
                    Nodo nuevoIzq = new Nodo();
                    Nodo nuevoDer = new Nodo();
                    if (anterior.izq != null && anterior.der != null)
                    {
                        anterior = anterior.der;
                    }
                    anterior.izq = nuevoIzq;
                    anterior.der = nuevoDer;
                    nuevoIzq.padre = anterior;
                    anterior = nuevoIzq;
                }
                else if (antecedente[i] != "(" && antecedente[i] != ")" && antecedente[i] != "^" && antecedente[i] != "v")
                {
                    if (anterior.izq == null)
                    {
                        anterior.info = antecedente[i];
                        /*Nodo nuevo = new Nodo();
                        anterior.izq = nuevo;
                        nuevo.info = antecedente[i];*/
                        anterior.izq = null;
                        anterior.der = null;
                        anterior = anterior.padre;
                    }
                    else
                    {
                        //Nodo nuevo = new Nodo();
                        anterior.der.info = antecedente[i];
                        //nuevo.info = antecedente[i];
                        anterior.der.izq = null;
                        anterior.der.der = null;
                    }
                }
                else if (antecedente[i] == "^" || antecedente[i] == "v")
                {
                   anterior.info = antecedente[i];
                }
                else if (antecedente[i] == ")")
                {
                    if(anterior.padre != null)
                        anterior = anterior.padre;
                }
                    
                else if (anterior.info != null)
                    anterior = anterior.padre;
            }
        }

        private void LeerArbol(Nodo Madre)
        {
            bool disyuncion = false;
            Madre.HijosInfo = new List<string>();
            if (Madre.izq != null && Madre.der != null)
            {
                LeerArbol(Madre.izq);
                if (Madre.info == "^")
                    disyuncion = true;
                LeerArbol(Madre.der);
                if (disyuncion)
                    foreach (String rd in Madre.izq.HijosInfo)
                        foreach (String ri in Madre.der.HijosInfo)
                            Madre.HijosInfo.Add(rd + ri);
                else
                {
                    foreach (String rd in Madre.izq.HijosInfo)
                        Madre.HijosInfo.Add(rd);
                    foreach (String ri in Madre.der.HijosInfo)
                        Madre.HijosInfo.Add(ri);
                }
            }
            else
                Madre.HijosInfo.Add(Madre.info + ",");
            return;
        }


    }


}
