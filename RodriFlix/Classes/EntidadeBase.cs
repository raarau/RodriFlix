using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodriFlix
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        public string Titulo { get; protected set; }
        public int Ano { get; protected set; }
        public DateTime Duracao { get; protected set; }
        public string Descricao { get; protected set; }
        public bool Excluido { get; protected private set; }

        public int RetornaId()
        {
            return Id;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
