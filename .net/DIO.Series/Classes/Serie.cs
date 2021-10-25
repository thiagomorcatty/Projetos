using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
    //Atributos:
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private int Ano { get; set; }
        private string Descricao { get; set; }
        private bool Excluido { get; set; }

    //Metodos:
        public Serie (int id, Genero genero, string titulo, string descricao, int ano){
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
            retorno += "Genero: " + this.Genero + " \n";
            retorno += "Titulo: " + this.Genero + " \n";
            retorno += "Descrição: " + this.Genero + " \n";
            retorno += "Ano de Estréia: " + this.Genero + " \n";
            retorno += "Excluido" + this.Excluido + " \n";
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
        public bool retornaExcluido(){
            
            return this.Excluido;
        }
        public void Exclui(){
            this.Excluido = true;
        }
    }
}