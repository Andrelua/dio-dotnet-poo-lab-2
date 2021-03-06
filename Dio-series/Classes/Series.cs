using System;

namespace Dio_series
{
    public class Series : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // Métodos
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {   
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {   
            string retorno = "";
            retorno += "Gênero: " + this.Genero + "/n";
            retorno += "Título: " + this.Titulo + "/n";
            retorno += "Descrição: " + this.Descricao + "/n";
            retorno += "Ano: " + this.Ano + "/n";
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}