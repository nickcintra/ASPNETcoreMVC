using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "nickcintra@gmail.com" && usuario.Senha == "cassialinda456123")
                {
                    ////Add Session
                    //HttpContext.Session.SetString("Login", "true");
                    //HttpContext.Session.SetInt32("");

                    //se quiser armazenar um objeto mais complexo como é o caso do objeto usuário é preciso  Serializar (pegar o objeto e converter pra String)
                    //Exemplo: HttpContext.Session.SetString("Login", Serializar Object > String);

                    // pacote NewtoSoft é um dos mais conhecidos do ASP.NET, da pra serializar os objetos baixando ele.

                    ////Ler Session
                    //string login = HttpContext.Session.GetString("Login");

                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são invalidos!";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
