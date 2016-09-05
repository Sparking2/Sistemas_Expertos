using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SistemaExperto
{
    public partial class Frm_Atomos : Form
    {
        Atomos dsAtomos = new Atomos();
        String XMLlocationAtomos = Application.StartupPath + @"\XMLAtomos.xml";
        String XMLlocationReglas = Application.StartupPath + @"\XMLReglas.xml";

        public Frm_Atomos()
        {
            InitializeComponent();
           
        }

        
        private void Frm_Atomos_Load(object sender, EventArgs e)
        {
            dsAtomos.ReadXml(XMLlocationAtomos);
            UpdateText();
        }

        private void btn_AddAtom_Click(object sender, EventArgs e)
        {
            
            DataTable dtTable = dsAtomos.Tables["DiccionarioAtomos"];
            DataRow drRows = dtTable.NewRow();
            drRows["Atomo"] = txtAtomo.Text;
            txtAtomo.Text = "";
            dtTable.Rows.Add(drRows);
            dtTable.WriteXml(XMLlocationAtomos);
            UpdateText();
        }

        void UpdateText()
        {
            
            rich_Text.Text = "";
            for (int i = 0;i < dsAtomos.Tables["DiccionarioAtomos"].Rows.Count; i++)
            {
                rich_Text.Text += dsAtomos.Tables["DiccionarioAtomos"].Rows[i]["Atomo"].ToString();
                rich_Text.Text += "\n";

            }
        }
    }
}
