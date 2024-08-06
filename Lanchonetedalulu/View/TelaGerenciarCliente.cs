using Lanchonetedalulu.Controller;
using Lanchonetedalulu.Model;
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
    public partial class TelaGerenciarCliente : Form
    {
        public TelaGerenciarCliente()
        {
            InitializeComponent();
        }

        private void btn_BuscarClienteCodigo_Click(object sender, EventArgs e)
        {
            Clientes.Id_Cli = Convert.ToInt32(tbx_CodigoCliente.Text);
            ControllerClientes controllerClientes = new ControllerClientes();
            controllerClientes.VisualizarCodigoClientes();

            tbx_CodigoClienteVer.Text = Convert.ToString(Clientes.Id_Cli);
            tbx_NomeClienteVer.Text = Clientes.Nome_Cli;
            tbx_CPFClienteVer.Text = Clientes.Cpf_Cli;
            tbx_FoneClienteVer.Text = Clientes.Fone_Cli;

        }

        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoCliente.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do cliente: " +
                    tbx_NomeClienteVer.Text + " ? ","Atenção", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Stop);
                
                if (resposta == DialogResult.Yes)
                {
                    Clientes.Id_Cli = Convert.ToInt32(tbx_CodigoCliente.Text);
                    Clientes.Nome_Cli = tbx_NomeClienteVer.Text;
                    Clientes.Fone_Cli = tbx_FoneClienteVer.Text;
                    Clientes.Cpf_Cli = tbx_CPFClienteVer.Text;

                    ControllerClientes controllerClientes = new ControllerClientes();
                    controllerClientes.AlterarClientes();

                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_FoneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";

                }
                else
                {
                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_FoneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";
                    tbx_CodigoCliente.Focus();

                }

            }
        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoCliente.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir as informações do cliente: " +
                    tbx_NomeClienteVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.Id_Cli = Convert.ToInt32(tbx_CodigoCliente.Text);


                    ControllerClientes controllerClientes = new ControllerClientes();
                    controllerClientes.DeletarClientes();

                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_FoneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";

                }
                else
                {
                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_FoneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";
                    tbx_CodigoCliente.Focus();

                }

            }
        }
    }
}
