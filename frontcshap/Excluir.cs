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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
           
            InitializeComponent();
            exc = new DAO();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do button voltar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da codigo

        private void Exclui_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();

        }//fim do button excluir
    }
}
