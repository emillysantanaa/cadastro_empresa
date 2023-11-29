using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario
{
    public partial class Consulta_Empresa : Form
    {
        public Consulta_Empresa()
        {
            InitializeComponent();
        }

        private void bt_cadastrarempresa_Click(object sender, EventArgs e)
        {
            Empresa conexao4 = new Empresa();  
            conexao4.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
