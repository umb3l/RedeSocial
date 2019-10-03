using System;
using System.Data.SqlClient;
using RedeSocial.Models;

namespace RedeSocial.Controllers.Data.DAO
{
    public class AmizadeDAO : Conexao
    {
        public void Registrar(Usuario u)
        {
            try
            {
                AbrirConexao();

                query = new SqlCommand("");

            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                FecharConexao();
            }
        }
    }
}