using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //inicializar um valor para a resposta
            ViewBag.Resposta = "";

            return View();
        }
        [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {
            string resposta = "";

            if (nome != "") {
                //preparar a resposta a enviar para a view
                resposta = "você chama-se " + nome; 
            }
            if (idade != null)
            {
               resposta +=" e tem " + idade + " anos.";
            }

            // enviar a 'resposta' para a view
            ViewBag.Resposta = resposta;

            return View();
        }
    }
}