using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uniftec.Biblioteca.UI.Models;

namespace Uniftec.Biblioteca.UI.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            
                     
            List<Livro> livros;
            if(Session["livros"]==null)
            {
                livros = new List<Livro>();
            }
            else
            {
                livros = (List<Livro>)Session["livros"];
            }
            ViewBag.livros = livros;
            return View();

        }
        public ActionResult Gravar()
        {
            return View();
        }
        public ActionResult processarEdicaoGet(Livro livro)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProcessarGravacaoPost(Livro livro)
        {
            
            List<Livro> livros;
            if(Session["livros"] == null)
            {
                livros = new List<Livro>();
            }
            else
            {
                livros = (List<Livro>)Session["livros"];
            }
            livros.Add(livro);

            Session["livros"] = livros;
                 
               return RedirectToAction("Gravar");
        }
        public ActionResult ProcessarGravacao(String titulo, String autor, String isbn, String paginas, String editoras, String edicao , String categoria)
        {
            Livro livro = new Livro();
            livro.Autor = autor;
            livro.Categoria = categoria;
            livro.Edicao = edicao;
            livro.Editora = editoras;
            livro.ISBN = isbn;
            livro.Paginas = Convert.ToInt32(paginas);
            livro.Titulo = titulo;

            return RedirectToAction("Gravar");
        }
    }
}