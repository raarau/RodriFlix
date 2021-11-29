using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodriFlix
{
    class FilmeRepositorio : IRepositorio<Filme>
    {
        List<Filme> listaFilmes = new List<Filme>();
        public void Atualiza(int id, Filme filme)
        {
            listaFilmes[id] = filme;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere(Filme filme)
        {
            listaFilmes.Add(filme);
        }

        public List<Filme> Lista()
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}
