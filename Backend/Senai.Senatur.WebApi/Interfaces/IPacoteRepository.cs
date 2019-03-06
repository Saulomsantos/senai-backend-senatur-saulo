using Senai.Senatur.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacoteRepository
    {
        /// <summary>
        /// Lista os pacotes
        /// </summary>
        /// <returns>Lista de pacotes</returns>
        List<Pacotes> Listar();

        /// <summary>
        /// Cadastra um pacote
        /// </summary>
        /// <param name="pacote">Objeto pacote a ser cadastrado</param>
        void Cadastrar(Pacotes pacote);

        /// <summary>
        /// Altera um pacote
        /// </summary>
        /// <param name="pacote">Objeto pacote a ser alterado</param>
        void Alterar(Pacotes pacote);

        /// <summary>
        /// Busca um pacote por Id
        /// </summary>
        /// <param name="id">Id do pacote a ser buscado</param>
        /// <returns>Pacote buscado</returns>
        Pacotes BuscarPacotePorId(int id);
    }
}
