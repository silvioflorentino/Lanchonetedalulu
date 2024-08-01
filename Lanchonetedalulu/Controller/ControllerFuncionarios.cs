using Lanchonetedalulu.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetedalulu.Controller
{
    internal class ControllerFuncionarios
    {
        public void CadastrarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastrarFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cmd.Parameters.AddWithValue("@nome", Funcionarios.Nome_Fun);
                cmd.Parameters.AddWithValue("@fone", Funcionarios.Fone_Fun);
                cmd.Parameters.AddWithValue("@email", Funcionarios.Email_Fun);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Cadastrados com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeletarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PExcluirFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Deletados com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarCodigoFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarCodigoFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Funcionarios.Id_Fun = Convert.ToInt32(dr["Id_Fun"]);
                    Funcionarios.Nome_Fun = (string)dr["nome_Fun"];
                    Funcionarios.Fone_Fun = dr["fone_Fun"].ToString();
                    Funcionarios.Email_Fun = dr["email_Fun"].ToString();
                }
                else
                {
                    Funcionarios.Id_Fun = 0;
                    Funcionarios.Nome_Fun = "";
                    Funcionarios.Fone_Fun = "";
                    Funcionarios.Email_Fun = "";
                    MessageBox.Show("Código não localizado.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PAlterarFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cmd.Parameters.AddWithValue("@nome", Funcionarios.Nome_Fun);
                cmd.Parameters.AddWithValue("@fone", Funcionarios.Fone_Fun);
                cmd.Parameters.AddWithValue("@email", Funcionarios.Email_Fun);

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
