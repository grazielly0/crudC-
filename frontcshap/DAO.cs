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
        public int contador;




        public DAO() 
        {
            conexao = new MySqlConnection("server=localhost;Database=Tintcsharp;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar com o banco 
               
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

        public int ConsultarPorCodigo(int cod)
        {
            
            //instanciar os vetores 
            PreencherVetor();
            i = 0;
            while (i<QuantidadeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;

            }//fim do while
            return -1;
            //encerrar o processso da leitura
        }


        public string RetornarNome(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if(posicao > -1)
            {
                return nome[posicao];
            }
            return "Código digitado inválido!";
        }


        public string RetornarTelefone(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return telefone[posicao];
            }
            return "Código digitado inválido!";
        }

        public string RetornarEndereco(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return endereco[posicao];
            }
            return "Código digitado inválido!";
        }



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

                MySqlDataReader leitura = sql.ExecuteReader();

                i = 0;
                contador = 0; //


                while (leitura.Read())
                {
                    codigo[i] = Convert.ToInt32(leitura["codigo"]);
                    nome[i] = leitura["nome"] + "";
                    telefone[i] = leitura["telefone"] + "";
                    endereco[i] = leitura["endereco"] + "";
                    i++;
                    contador++;
                }//fim do while

                //encerrar o processso da leitura
                leitura.Close();

            }//fim do metodo 

        public int QuantidadeDados()
        {
            return contador;
        }
          
        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update pessoa set {campo} = '{dado}' Where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
            
        }

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Deletado!";
            return resultado;
        }

    }//fim da DAO
}//fim do projeto 
