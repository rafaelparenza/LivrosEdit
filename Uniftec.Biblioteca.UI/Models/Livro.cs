using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uniftec.Biblioteca.UI.Models
{
    public class Livro
    {
        

        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String ISBN { get; set; }
        public int Paginas { get; set; }
        public String Editora { get; set; }
        public String Edicao { get; set; }
        public String Categoria { get; set; }
        /*
        private String titulo;
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetLivro()
        {
            return this.titulo;
        }*/
        public Livro()
        {

        }
    }
}