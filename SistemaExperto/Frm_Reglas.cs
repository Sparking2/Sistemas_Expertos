using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show(richBox.Text);
            int index = combo_Atom.SelectedIndex;
            MessageBox.Show(combo_Atom.SelectedIndex.ToString());
        }

        private void Frm_Reglas_Load(object sender, EventArgs e)
        {
            dsAtomos.ReadXml(XMLlocationAtomos);
            combo_Atom.Items.Add("Selecciona un Atomo");
            combo_Atom.SelectedIndex = 0;
            for(int i = 0; i < dsAtomos.Tables["DiccionarioAtomos"].Rows.Count; i++)
            {
                combo_Atom.Items.Add(dsAtomos.Tables["DiccionarioAtomos"].Rows[i]["Atomo"].ToString());
            }
            dsAtomos.ReadXml(XMLlocationReglas);
            for (int i = 0; i < dsAtomos.Tables["DiccionarioReglas"].Rows.Count; i++)
            {
                richRules.Text += dsAtomos.Tables["DiccionarioReglas"].Rows[i]["Regla"].ToString();
                richRules.Text += "\n";

            }

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
                    richBox.Text += " NO" + combo_Atom.SelectedItem;
                    SimpleRule += " ¬" + combo_Atom.SelectedIndex+" ";
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
            DataTable dtTable = dsAtomos.Tables["DiccionarioReglas"];
            DataRow drRows = dtTable.NewRow();
            drRows["Regla"] = richBox.Text;
            drRows["ReglaSimple"] = SimpleRule;
            CreateRules(SimpleRule);
            dtTable.Rows.Add(drRows);
            dtTable.WriteXml(XMLlocationReglas);
            Clean();
            
        }

        void Clean()
        {
            richBox.Text = "";
            richRules.Text = "";
            SimpleRule = "";
            for (int i = 0; i < dsAtomos.Tables["DiccionarioReglas"].Rows.Count; i++)
            {
                richRules.Text += dsAtomos.Tables["DiccionarioReglas"].Rows[i]["Regla"].ToString();
                richRules.Text += "\n";

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
