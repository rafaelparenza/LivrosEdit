using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uniftec.Biblioteca.UI.Controllers // IGUAL PACKGE DO JAVA
{
    public class UNIFTECController : Controller // IGUAL EXTENDS DO JAVA
    {
        // GET: UNIFTEC
        public ActionResult Index()// ACTION RESULT É UMA AÇÃO
        {
            return View();//retorna a pagina que vizualizamos dentro do navegador
        }
        public ActionResult Gravar()
        {
            return View();//Quando não é definido nome o sistema retorna uma view com o mesmo nome da ActionResult.
        }
    }
}