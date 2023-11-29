using MySql.Data.MySqlClient;
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
   
    public partial class Empresa : Form
    {
        List<Cadastro_empresa> empresa;
        MySqlConnection conexao2;

        public Empresa()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source2 = "datasource=localhost;username=root;password=;database=cadastro_bd";
                //criar conexão com o MySql

                conexao2 = new MySqlConnection();

                string sql2 = "INSERT INTO Empresa (nome_fun,estado_civil_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, " +
                "telefone_fun, cidade_fun, estado_fun, funcao_fun, salario_fun) VALUES ('" + tx_nome + "', '" + cb_estadocivil + "', '" + mkd_datanascimento.Text + "', '" + tx_rg.Text + "', '" + mkd_cpf.Text + "'," +
                " '" + tx_email + "', '" + mkd_telefone.Text + "', '" + tx_cidadee + "', '" + tx_estado + "', '" + tx_funcao + "', '" + tx_salario.Text + "')";

                //executar comando insert

                MySqlCommand comando2 = new MySqlCommand(sql2, conexao2);

                conexao2.Open();

                comando2.ExecuteReader();

                MessageBox.Show("Inserido");


                Empresa empresa = new Empresa();
                empresa.RazaoSocial = tx_RazaoSocial;
                empresa.NomeFantasia = tx_nomeFantasia;
                empresa.SituacaoCadastral = Convert.ToString(cb_situacaoCadastral);
                empresa.RegimeTributario = Convert.ToString(panel1);
                empresa.DataInicio = Convert.ToDateTime(msk_data);
                empresa.Telefonee = Convert.ToInt32(msk_telefone);
                empresa.CapitalSocial = Convert.ToDouble(tx_capitalSocial);
                empresa.Enderecoo = tx_enderecoo;
                empresa.tx_cidadee = tx_cidadee;
                empresa.Estadoo = Convert.ToString(cb_estado);
                empresa.Tipo = Convert.ToString(panel2);
                empresa.PorteEmpresa = Convert.ToString(panel3);
                empresa.NaturezaJuridica = tx_naturezaJuridica;
                empresa.NomeProprietario = tx_noomeProprie;
                empresa.CpfProprietario = Convert.ToInt32(msk_cpfProprie);

                Cadastro_empresa.Add(empresa);

                MessageBox.Show($"Empresa cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao2.Close();
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

