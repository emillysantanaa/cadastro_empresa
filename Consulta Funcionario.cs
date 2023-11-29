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
    public partial class Consulta_Funcionario : Form
    {
        public Consulta_Funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Form1 conexao = new Form1();
            conexao.ShowDialog();
        }
    }
}
