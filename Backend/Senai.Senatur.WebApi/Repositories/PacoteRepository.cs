using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Alterar(Pacotes pacote)
        {
            Pacotes pacoteExiste = ctx.Pacotes.Find(pacote.PacoteId);

            if (pacoteExiste != null)
            {
                pacoteExiste.NomePacote = pacote.NomePacote;
                pacoteExiste.Descricao = pacote.Descricao;
                pacoteExiste.DataIda = pacote.DataIda;
                pacoteExiste.DataVolta = pacote.DataVolta;
                pacoteExiste.Valor = pacote.Valor;
                pacoteExiste.Ativo = pacote.Ativo;
                pacoteExiste.NomeCidade = pacote.NomeCidade;

                ctx.Pacotes.Update(pacoteExiste);
                ctx.SaveChanges();
            }
        }

        public Pacotes BuscarPacotePorId(int id)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(id);

            if (pacoteBuscado == null)
            {
                return null;
            }

            return pacoteBuscado;
        }

        public void Cadastrar(Pacotes pacote)
        {
            ctx.Pacotes.Add(pacote);
            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
