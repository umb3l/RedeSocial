using System;
using System.Data.SqlClient;
using System.Configuration;

namespace RedeSocial.Controllers.Data
{ 
    public class Conexao 
    {
        //Pega endereco do banco de dados no XML do site, chamado Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected SqlConnection conexao = null;
        protected SqlCommand query = null;

        //Funcao para conectar no banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new SqlConnection(connectionString);
                conexao.Open();

            } catch (Exception e){
                throw e;
            }
        }

        //Funcao para fechar conexao com o banco
        public void FecharConexao()
        {
            try
            {
                conexao = new SqlConnection(connectionString);
                conexao.Close();

            } catch (Exception e)
            {
                throw e;
            }

            finally
            {
                conexao.Close();
            }
        }

    }
}