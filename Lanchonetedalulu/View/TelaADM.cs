using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonetedalulu.View
{
    public partial class TelaADM : Form
    {
        public TelaADM()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.Show();
        }

        private void manipularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaGerenciaProduto telagerenciaProduto = new TelaGerenciaProduto();
            telagerenciaProduto.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastrarCliente telaCadastrarCliente = new TelaCadastrarCliente();
            telaCadastrarCliente.Show();
        }

        private void manipularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaGerenciarCliente telaGerenciarCliente = new TelaGerenciarCliente();
            telaGerenciarCliente.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telaCadastrarFuncionario = new TelaCadastrarFuncionario();
            telaCadastrarFuncionario.Show();
        }

        private void manipularToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaGerenciarFuncionario telaGerenciarFuncionario = new TelaGerenciarFuncionario();
            telaGerenciarFuncionario.Show();
        }
    }
}
