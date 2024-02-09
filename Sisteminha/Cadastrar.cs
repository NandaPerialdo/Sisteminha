using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisteminha
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//conecctar a tela com a classe DAO
        }//fim do contrutor

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do codigo

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//fim da cidade

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }//fim do estado

        private void finalizarCadastro_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tel = telefone.Text;
            string cid = cidade.Text;
            string est = estado.Text;

            bd.Inserir(cod,name,tel,cid,est);//inserindo no BD

            //limpar os campos apos a inserçao dos dados
            codigo.Text = "";
            nome.Text = "";
            telefone.Text = "";
            cidade.Text = "";
            estado.Text = "";
        }//fim do botao cadastrar

        private void voltarCadastro_Click(object sender, EventArgs e)
        {

        }//fim do botao voltar
    }//fim da classe
}//fim do projeto
