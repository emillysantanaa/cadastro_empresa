namespace funcionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.mkd_datanascimento = new System.Windows.Forms.MaskedTextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.mkd_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mkd_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.cb_estadocivil = new System.Windows.Forms.ComboBox();
            this.tx_funcao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bt_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Salvar.Location = new System.Drawing.Point(1088, 873);
            this.bt_Salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(125, 39);
            this.bt_Salvar.TabIndex = 0;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_cancelar.Location = new System.Drawing.Point(917, 873);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(128, 39);
            this.bt_cancelar.TabIndex = 1;
            this.bt_cancelar.Text = "cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(72, 197);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(529, 23);
            this.tx_nome.TabIndex = 2;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mkd_datanascimento
            // 
            this.mkd_datanascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_datanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_datanascimento.Location = new System.Drawing.Point(72, 316);
            this.mkd_datanascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mkd_datanascimento.Mask = "00/00/0000";
            this.mkd_datanascimento.Name = "mkd_datanascimento";
            this.mkd_datanascimento.Size = new System.Drawing.Size(88, 23);
            this.mkd_datanascimento.TabIndex = 4;
            this.mkd_datanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tx_rg
            // 
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_rg.Location = new System.Drawing.Point(72, 434);
            this.tx_rg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(529, 23);
            this.tx_rg.TabIndex = 5;
            // 
            // tx_email
            // 
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(72, 668);
            this.tx_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(529, 23);
            this.tx_email.TabIndex = 6;
            // 
            // mkd_cpf
            // 
            this.mkd_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_cpf.Location = new System.Drawing.Point(880, 316);
            this.mkd_cpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mkd_cpf.Mask = "000.000.000-00";
            this.mkd_cpf.Name = "mkd_cpf";
            this.mkd_cpf.Size = new System.Drawing.Size(161, 23);
            this.mkd_cpf.TabIndex = 7;
            this.mkd_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mkd_telefone
            // 
            this.mkd_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_telefone.Location = new System.Drawing.Point(895, 434);
            this.mkd_telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mkd_telefone.Mask = "(00) 00000-0000";
            this.mkd_telefone.Name = "mkd_telefone";
            this.mkd_telefone.Size = new System.Drawing.Size(133, 23);
            this.mkd_telefone.TabIndex = 8;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(72, 541);
            this.tx_endereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(529, 23);
            this.tx_endereco.TabIndex = 9;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cidade.Location = new System.Drawing.Point(72, 793);
            this.tx_cidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(529, 22);
            this.tx_cidade.TabIndex = 10;
            this.tx_cidade.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tx_estado
            // 
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_estado.Location = new System.Drawing.Point(801, 792);
            this.tx_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(233, 23);
            this.tx_estado.TabIndex = 11;
            // 
            // tx_salario
            // 
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(840, 630);
            this.tx_salario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(188, 23);
            this.tx_salario.TabIndex = 13;
            // 
            // cb_estadocivil
            // 
            this.cb_estadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadocivil.FormattingEnabled = true;
            this.cb_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cb_estadocivil.Location = new System.Drawing.Point(880, 195);
            this.cb_estadocivil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_estadocivil.Name = "cb_estadocivil";
            this.cb_estadocivil.Size = new System.Drawing.Size(176, 32);
            this.cb_estadocivil.TabIndex = 15;
            // 
            // tx_funcao
            // 
            this.tx_funcao.Location = new System.Drawing.Point(535, 307);
            this.tx_funcao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(132, 22);
            this.tx_funcao.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 904);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.cb_estadocivil);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.mkd_telefone);
            this.Controls.Add(this.mkd_cpf);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.mkd_datanascimento);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_Salvar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox mkd_datanascimento;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.MaskedTextBox mkd_cpf;
        private System.Windows.Forms.MaskedTextBox mkd_telefone;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox cb_estadocivil;
        private System.Windows.Forms.TextBox tx_funcao;
    }
}

