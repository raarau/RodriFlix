using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodriFlix
{
    class Filme : EntidadeBase
    {
        public Genero Genero { get; set; }
        public Filme(int id, Genero genero, string titulo, int ano, DateTime duracao, string descricao)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Ano = ano;
            Duracao = duracao;
            Descricao = descricao;

        }

        public override string ToString()
        {
            string retorna = "";

            retorna += "Genero: " + Genero + Environment.NewLine;
            retorna += "Título: " + Titulo + Environment.NewLine;
            retorna += "Ano: " + Ano + Environment.NewLine;
            retorna += "Duração: " + Duracao.ToString("HH:mm") + Environment.NewLine;
            retorna += "Descrição: " + Descricao + Environment.NewLine;
            return retorna;
        }
    }
}
