namespace funcionario
{
    partial class Consulta_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Funcionario));
            this.bt_cadastrarFuncionario = new System.Windows.Forms.Button();
            this.bt_concluirfuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cadastrarFuncionario
            // 
            this.bt_cadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrarFuncionario.Location = new System.Drawing.Point(286, 778);
            this.bt_cadastrarFuncionario.Name = "bt_cadastrarFuncionario";
            this.bt_cadastrarFuncionario.Size = new System.Drawing.Size(238, 43);
            this.bt_cadastrarFuncionario.TabIndex = 0;
            this.bt_cadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.bt_cadastrarFuncionario.UseVisualStyleBackColor = true;
            this.bt_cadastrarFuncionario.Click += new System.EventHandler(this.bt_cadastrarFuncionario_Click);
            // 
            // bt_concluirfuncionario
            // 
            this.bt_concluirfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluirfuncionario.Location = new System.Drawing.Point(647, 778);
            this.bt_concluirfuncionario.Name = "bt_concluirfuncionario";
            this.bt_concluirfuncionario.Size = new System.Drawing.Size(153, 43);
            this.bt_concluirfuncionario.TabIndex = 1;
            this.bt_concluirfuncionario.Text = "Concluir";
            this.bt_concluirfuncionario.UseVisualStyleBackColor = true;
            this.bt_concluirfuncionario.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consulta_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 937);
            this.Controls.Add(this.bt_concluirfuncionario);
            this.Controls.Add(this.bt_cadastrarFuncionario);
            this.Name = "Consulta_Funcionario";
            this.Text = "Consulta_Funcionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrarFuncionario;
        private System.Windows.Forms.Button bt_concluirfuncionario;
    }
}