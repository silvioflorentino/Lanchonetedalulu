using Lanchonetedalulu.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetedalulu.Controller
{
    internal class ControllerProdutos
    {
        public void CadastrarProdutos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastrarProdutos",cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
          
            try
            {
                cmd.Parameters.AddWithValue("@codigo", Produtos.Id_Prod);
                cmd.Parameters.AddWithValue("@nome", Produtos.Nome_Prod);
                cmd.Parameters.AddWithValue("@qtd", Produtos.Qtd_Prod);
                cmd.Parameters.AddWithValue("@preco", Produtos.Preco_Prod);
                cmd.Parameters.AddWithValue("@tipo", Produtos.Tipo_Prod);
                
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Cadastrados com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeletarProdutos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PExcluirProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Produtos.Id_Prod);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Deletados com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarCodigoProdutos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarCodigoProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Produtos.Id_Prod);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Produtos.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    Produtos.Nome_Prod = dr["nome_Prod"].ToString();
                    Produtos.Qtd_Prod = Convert.ToInt32(dr["qtd_Prod"]);
                    Produtos.Tipo_Prod = dr["tipo_Prod"].ToString();
                    Produtos.Preco_Prod = Convert.ToInt32(dr["preco_Prod"]);
                }
                else
                {
                    Produtos.Id_Prod = 0;
                    Produtos.Nome_Prod = "";
                    Produtos.Qtd_Prod = 0;
                    Produtos.Tipo_Prod = "";
                    Produtos.Preco_Prod = 0;

                    MessageBox.Show("Código não localizado.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarProdutos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PAlterarProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeProd", Produtos.Nome_Prod);
                cmd.Parameters.AddWithValue("@qtdProd", Produtos.Qtd_Prod);
                cmd.Parameters.AddWithValue("@precoProd", Produtos.Preco_Prod);
                cmd.Parameters.AddWithValue("@tipoProd", Produtos.Tipo_Prod);
                cmd.Parameters.AddWithValue("@codigo", Produtos.Id_Prod);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
