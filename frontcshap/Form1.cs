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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir cad = new Excluir();
            cad.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar cad = new Atualizar();
            cad.ShowDialog();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar cad = new Consultar();
            cad.ShowDialog();
        }
    }
}
