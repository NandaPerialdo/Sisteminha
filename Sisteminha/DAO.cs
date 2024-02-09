using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sisteminha
{
    internal class DAO
    {
        //crioar elemento q representa o mysql
        MySqlConnection conexao;
        public string dados;
        public string sql;

        //metodo contrutor
        public DAO()
        {
            //criar script pra acessar o banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=ti18n;Uid=root;password=");//informar a conexao com o servidor locar (este pc)

            try
            {
                conexao.Open();//estabelecer conexao com o bd
                MessageBox.Show("Conectado com sucesso!");//tmporariamente
            }catch(Exception erro)
            {
                MessageBox.Show(erro + "Algo deu errado!");
                conexao.Close();
            }//fim do try catch
        }//fim do metodo contrutor

        public void Inserir(int codigo, string nome, string telefone, string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into pessoa(codigo,nome,telefone,cidade,estado) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " Dado Inserido!");
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
            
        }//fim do metodo

    }//fim da classe
}//fim do projeto
