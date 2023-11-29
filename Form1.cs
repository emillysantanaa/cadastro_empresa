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

namespace funcionario
{
    public partial class Form1 : Form
    {
        List<Cadastro> funcionario;
        MySqlConnection Conexao;

        public Form1()
        {
            
            InitializeComponent();
        }
      
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string validarcpf = mkd_cpf.Text;
            bool Resulcpf = CPF.ValidacaoCpf(validarcpf);

            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=cadastro_bd";
                //criar conexão com o MySql
              
                Conexao = new MySqlConnection();

                string sql = "INSERT INTO funcionario (nome_fun,estado_civil_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, " +
                "telefone_fun, cidade_fun, estado_fun, funcao_fun, salario_fun) VALUES ('" + tx_nome + "', '" + cb_estadocivil +"', '" + mkd_datanascimento.Text +  "', '" + tx_rg.Text + "', '" + mkd_cpf.Text + "'," +
                " '"+ tx_email +"', '"+ mkd_telefone.Text+"', '"+ tx_cidade+"', '"+tx_estado+"', '"+tx_funcao+"', '"+tx_salario.Text+"')";

                //executar comando insert

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Inserido");

                if (Resulcpf == true)
                {
                    Cadastro funcionario = new Cadastro();
                    funcionario.Nome = tx_nome.Text;
                    funcionario.EstadoCivil = cb_estadocivil.Text;
                    funcionario.DataNascimento = Convert.ToDateTime(mkd_datanascimento.Text);
                    funcionario.RG = Convert.ToInt32(tx_rg.Text);
                    funcionario.CPF = Convert.ToInt32(mkd_cpf.Text);
                    funcionario.Email = tx_email.Text;
                    funcionario.Telefone = Convert.ToString(mkd_telefone.Text);
                    funcionario.Endereco = tx_endereco.Text;
                    funcionario.Cidade = tx_cidade.Text;
                    funcionario.Estado = tx_estado.Text;
                    funcionario.Funcao = tx_funcao.Text;
                    funcionario.Salario = Convert.ToDouble(tx_salario.Text);

                    Cadastro.Add(funcionario);

                    MessageBox.Show($"Funcionário cadastrado." + "\n Dados do funcionario(a): \n ");
                }
                else
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                Conexao.Close();
            }


        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


