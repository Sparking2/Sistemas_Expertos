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
        public Atras()
        {
            InitializeComponent();
        }

        private void Atras_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM reglas";
            MySqlConnection con = new MySqlConnection("server=localhost;database=expertodb;uid=root;pwd=123456");
            MySqlCommand cmd = new MySqlCommand(sql, con);

        }
    }
}
