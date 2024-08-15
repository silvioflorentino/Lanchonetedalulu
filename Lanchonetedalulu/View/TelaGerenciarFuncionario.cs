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
    public partial class TelaGerenciarFuncionario : Form
    {
        public TelaGerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Funcionarios.Nome_Fun = tbxNomeFuncionario.Text;
            dataGridViewFuncionario.DataSource = ControllerFuncionarios.VisualizarNomeFuncionarios();
            dataGridViewFuncionario.Columns[0].Visible = false;
            dataGridViewFuncionario.Columns[1].Visible = false;
            dataGridViewFuncionario.Columns[2].Visible = false;
            dataGridViewFuncionario.Columns[3].HeaderCell.Value = "Código do Usuário";
            dataGridViewFuncionario.Columns[4].HeaderCell.Value = "Função";
            dataGridViewFuncionario.Columns[5].HeaderCell.Value = "Data Acesso";
            dataGridViewFuncionario.Columns[6].HeaderCell.Value = "Matricula Funcionário";
            dataGridViewFuncionario.Columns[7].Visible = false;
        }
    }
}
