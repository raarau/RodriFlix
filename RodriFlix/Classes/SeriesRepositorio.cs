using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodriFlix
{
    class SeriesRepositorio : IRepositorio<Serie>
    {
        List<Serie> listaSeries = new List<Serie>();
        public void Atualiza(int id, Serie serie)
        {
            listaSeries[id] = serie;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Insere(Serie serie)
        {
            listaSeries.Add(serie);
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count();
        }

        public Serie RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}
