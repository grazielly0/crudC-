using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontcshap
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();    
            InitializeComponent();
            textBox1.ReadOnly= false;
            textBox2.ReadOnly= true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        
        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        } //fim da caixa endereço

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefone

        private void Cadastro_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;


           
            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Dados atualizados com sucesso!");
            this.Close();
        }//fim do button atualizar

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do button voltar

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox2.Text = "Preencha os campos!";
                textBox3.Text = "Preencha os campos!";
                textBox4.Text = "Preencha os campos!";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                textBox2.Text = atu.RetornarNome(codigo);
                textBox3.Text = atu.RetornarTelefone(codigo);
                textBox4.Text = atu.RetornarEndereco(codigo);
                textBox1.ReadOnly = true;

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }//fim do buscar
    }
}
