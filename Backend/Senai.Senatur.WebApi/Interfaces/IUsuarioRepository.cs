using Senai.Senatur.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Lista de usuários</returns>
        List<Usuarios> Listar();

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Usuário</returns>
        Usuarios BuscarPorEmailSenha(string email, string senha);
    }
}
