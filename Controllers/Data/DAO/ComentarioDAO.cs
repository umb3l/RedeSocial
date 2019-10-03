using System;
using System.Data.SqlClient;
using RedeSocial.Models;

namespace RedeSocial.Controllers.Data.DAO
{
    public class ComentarioDAO : Conexao
    {
        public void Comentar(Comentario c)
        {
            try
            {
                //Conecta com o banco
                AbrirConexao();

                //Cria string de comando INSERT em SQL
                query = new SqlCommand("INSERT (idPostagem, Comentario, Nick) INTO Comentarios VALUES (@idPostagem, @Texto, @Nick", conexao);

                //Referencia os parametros da string com o modelo
                query.Parameters.AddWithValue("@idPostagem", c.idPostagem);
                query.Parameters.AddWithValue("@Texto", c.Texto);
                query.Parameters.AddWithValue("@Nick", c.Nick);

                //Executa query
                query.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                //Desconecta do banco
                FecharConexao();
            }
        }
    }
}