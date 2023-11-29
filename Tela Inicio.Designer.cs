namespace funcionario
{
    partial class Tela_Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicio));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_verEmpresa = new System.Windows.Forms.Button();
            this.bt_verfuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_verEmpresa
            // 
            this.bt_verEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_verEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_verEmpresa.Location = new System.Drawing.Point(411, 257);
            this.bt_verEmpresa.Name = "bt_verEmpresa";
            this.bt_verEmpresa.Size = new System.Drawing.Size(268, 68);
            this.bt_verEmpresa.TabIndex = 1;
            this.bt_verEmpresa.Text = "Ver Empresa";
            this.bt_verEmpresa.UseVisualStyleBackColor = true;
            this.bt_verEmpresa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_verfuncionario
            // 
            this.bt_verfuncionario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_verfuncionario.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bt_verfuncionario.Location = new System.Drawing.Point(118, 257);
            this.bt_verfuncionario.Name = "bt_verfuncionario";
            this.bt_verfuncionario.Size = new System.Drawing.Size(259, 68);
            this.bt_verfuncionario.TabIndex = 2;
            this.bt_verfuncionario.Text = "Ver Funcionário";
            this.bt_verfuncionario.UseVisualStyleBackColor = true;
            this.bt_verfuncionario.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Tela_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 478);
            this.Controls.Add(this.bt_verfuncionario);
            this.Controls.Add(this.bt_verEmpresa);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_Inicio";
            this.Text = "Tela_Inicio";
            this.Load += new System.EventHandler(this.Tela_Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bt_verEmpresa;
        private System.Windows.Forms.Button bt_verfuncionario;
    }
}