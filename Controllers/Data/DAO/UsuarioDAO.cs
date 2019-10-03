using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RedeSocial.Models;

namespace RedeSocial.Controllers.Data.DAO
{
    public class UsuarioDAO : Conexao
    {
        public void Registrar(Usuario u)
        {
            try
            {
                //Conecta com o banco
                AbrirConexao();


                //Cria string de comando INSERT em SQL
                query = new SqlCommand("INSERT INTO Usuario (Nick, Nome, Senha, Bio, Privacidade) VALUES (@Nick, @Nome, @Senha, @Bio, @Privacidade)", conexao);

                //Referencia os parametros da string com o modelo
                query.Parameters.AddWithValue("@Nick", u.Nick);
                query.Parameters.AddWithValue("@Nome", u.Nome);
                query.Parameters.AddWithValue("@Senha", u.Senha);
                query.Parameters.AddWithValue("@Bio", u.Bio);
                query.Parameters.AddWithValue("@Privacidade", u.Privacidade);

                //Executa query
                query.ExecuteNonQuery();

            } catch (Exception e){
                throw e;
            }

            finally
            {
                //Desconecta do banco
                FecharConexao();
            }
        }

        public Usuario Login(string Nick, string Senha)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                query = new SqlCommand("SELECT Nick, Nome, Senha, Bio, Privacidade FROM Usuario WHERE Nick = @Nick AND Senha = @Senha", conexao);

                //Referencia os parametros da string com o modelo
                query.Parameters.AddWithValue("@Nick", Nick);
                query.Parameters.AddWithValue("@Senha", Senha);

                //Executa query e passa resultados para uma tabela 
                da.SelectCommand = query;

                da.Fill(dt);

                //Passa dados do usuário encontrado para um objeto usuario.
                Usuario u = new Usuario();

                foreach (DataRow row in dt.Rows)
                {
                    u.Nick = row["Nick"].ToString();
                    u.Nome = row["Nome"].ToString();
                    u.Senha = row["Senha"].ToString();
                    u.Bio = row["Bio"].ToString();

                    if(row["Privacidade"].ToString() == "True")
                    {
                        u.Privacidade = true;
                    }

                    if(row["Privacidade"].ToString() == "False")
                    {
                        u.Privacidade = false;
                    }
                }

                da.Dispose();

                return u;

            } catch (Exception e){
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