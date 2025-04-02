using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace frontcshap
{
     class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public DAO() 
        {
            conexao = new MySqlConnection("server=localhost;Database=Tintcsharp;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar com o banco 
                MessageBox.Show("Conectado!!");
            }catch(Exception erro) 
            {
                MessageBox.Show("Algo deu errado!\n\n\n" + erro);
            }
        }//fim do construtror

        public string Inserir(int codigo, string nome, string telefone, string endereco)
        {
            string inserir =$"insert into pessoa(codigo, nome, telefone, endereco) values('{codigo}', '{nome}', '{telefone}', '{endereco}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Execultado";
            return resultado;
        }//fim do inserir

        public void PreencherVetor()
        {
            string query = "select * from pessoa";
            //instanciar os vetores 

            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //prepara o comando para o banco 

            MySqlCommand sql = new MySqlCommand(query, conexao);

            //chamar o leitor de banco de dados 

            MySqlDataReader leitura  = sql.ExecuteReader();

            i = 0; //


            while (leitura.Read()) 
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;
            }//fim do while

            //encerrar o processso da leitura
            leitura.Close();

        }//fim do metodo 


    }//fim da DAO
}//fim do projeto 
