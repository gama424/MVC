
using System;
using E_Player_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Player_AspNetCore.Controllers
{

    [Route("Equipe")]
    //https.localhost5000
    public class EquipeController : Controller
    {
// CRIAMOS UM INSTANCIA equipeModel
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
 
        {
                //LISTAMOS TODAS AS EQUIPES E ENVIAMOS PARA A VIEW UTILIZANDO ViewBag
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }


        public ActionResult Cadastrar(IFormCollection form)
        {
                Equipe novaEquipe = new Equipe();
                novaEquipe.IdEquipe = Int32.Parse( form["IdEquipe"] );
                novaEquipe.Nome = form["Name"];
                novaEquipe.Imagem = form["Imagem"];

                //criamos o metodo create para salvar a novaEquipe no CSV
                equipeModel.Create(novaEquipe);

                // atualiza a lista de equipes na View
                ViewBag.Equipes = equipeModel.ReadAll();


                return LocalRedirect("~/Equipe");
        }
    }
}