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
                    richBox.Text += " NO " + combo_Atom.SelectedItem;
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
            richBox.Text += " ( ";
            SimpleRule += " (";
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            richBox.Text += " ) ";
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
            /*int num_of_portions = 0;
            int contador = 0;
            int start = 0;
            int finish = 0;
            char debug;
            for(int i = 0; i < previo.Length; i++)
            {
                if (previo[i] == '(')
                {
                    if (contador == 0)
                        start = i;
                    contador++;
                }
                finish++;
                if (previo[i] == ')')
                {
                    contador--;
                    if (contador == 0) {
                        finish = i;
                        Diccionario.Add(num_of_portions, previo.Substring(start, finish));
                        num_of_portions++;
                        finish = 0;
                    }
                }
                debug = previo[i];
            }
            for(int i = 0;i < Diccionario.Count ;i++)
                MessageBox.Show(Diccionario[i]);*/
           }

    

        private void btnRestart_Click(object sender, EventArgs e)
        {
            richBox.Text = "";
            SimpleRule = "";
        }

    }
}
