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
                    return RedirectToAction("Index","Palavra");
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
    }
}
