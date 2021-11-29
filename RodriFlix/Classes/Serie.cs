using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodriFlix
{
    class Serie : EntidadeBase
    {

        private Genero Genero { get; set; }

        public Serie(int id, string titulo, Genero genero, string descricao, int ano, DateTime duracao)
        {
            Id = id;
            Titulo = titulo;
            Genero = genero;
            Descricao = descricao;
            Ano = ano;
            Duracao = duracao;
        }

        public override string ToString()
        {
            string retorna = "";

            retorna += "Genero: " + Genero + Environment.NewLine;
            retorna += "Titulo: " + Titulo + Environment.NewLine;
            retorna += "Ano: " + Ano + Environment.NewLine;
            retorna += "Duração: " + Duracao.ToString("HH:mm") + Environment.NewLine;
            retorna += "Descricao: " + Descricao + Environment.NewLine;
            Excluido = false;

            return retorna;
        }
    }
}
