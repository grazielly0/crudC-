namespace frontcshap
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(142, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Página Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(373, 173);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 1;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(343, 179);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(104, 41);
            this.Atualizar.TabIndex = 3;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(343, 268);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(104, 35);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(343, 133);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(104, 37);
            this.Cadastrar.TabIndex = 6;
            this.Cadastrar.Text = "Cadastar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(343, 226);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(104, 36);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "titulo da pag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
    }
}

