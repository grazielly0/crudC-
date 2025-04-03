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
    public partial class Consultar : Form
    {
        DAO consul;
        
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();
            AddDados();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do nutton voltar


        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false; // não pode add linhas
            dataGridView1.AllowUserToDeleteRows = false; //não pode apagar linhas 
            dataGridView1.AllowUserToResizeColumns = false; //não pode redimensionar colunas 
            dataGridView1.AllowUserToResizeRows = false; //não pode redimensionar as linhas 

            dataGridView1.ColumnCount = 4;
        }


        public void AddDados()
        {
            consul.PreencherVetor();
            for(int i = 0; i <consul.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i],consul.endereco[i]);
            }
        }
      

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }//fim do button cadastro

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }//fim do datagridView
    }
}
