using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SenaturContext ctx = new SenaturContext();

        private string StringConexao = "Data Source=.\\SqlDeveloper;" +
            "initial catalog=SENATUR_MANHA;" +
            "integrated security=true";

        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "SELECT UsuarioId, Email, Senha, TipoUsuario FROM USUARIOS " +
                                                         "WHERE Email = @EMAIL AND Senha = @SENHA";

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@SENHA", senha);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        Usuarios usuario = new Usuarios();

                        while (sdr.Read())
                        {
                            usuario.UsuarioId = Convert.ToInt32(sdr["UsuarioId"]);
                            usuario.Email = sdr["Email"].ToString();
                            usuario.TipoUsuario = sdr["TipoUsuario"].ToString();
                        }

                        return usuario;
                    }
                }

                return null;
            }

            //Usuarios usuarioBuscado = ctx.Find(email, senha);
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
