namespace frontcshap
{
    partial class Consultar
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
            this.Cadastro = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cadastro.Location = new System.Drawing.Point(236, 226);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(93, 23);
            this.Cadastro.TabIndex = 22;
            this.Cadastro.Text = "Consultar";
            this.Cadastro.UseVisualStyleBackColor = false;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Voltar.Location = new System.Drawing.Point(408, 226);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(105, 23);
            this.Voltar.TabIndex = 21;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(266, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(186, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 73);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consultar";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}