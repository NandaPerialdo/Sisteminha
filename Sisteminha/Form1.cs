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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//metodo construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//metodo que faz o carregamento de conteudos na tela

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }//fim do atualizar

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//fim do cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {

        }//fim do consultar

        private void excluir_Click(object sender, EventArgs e)
        {

        }//fim do excluir
    }//fim da classe menu
}//fim do projeto
