
using System;
using System.IO;
using E_Player_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Player_AspNetCore.Controllers
{

    [Route("Equipe")]
   // https://localhost:5000/Equipe
    public class EquipeController : Controller
    {
// CRIAMOS UM INSTANCIA equipeModel
        Equipe equipeModel = new Equipe();

        [Route("Listar")]
        public IActionResult Index()
 
        {
                //LISTAMOS TODAS AS EQUIPES E ENVIAMOS PARA A VIEW UTILIZANDO ViewBag
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

            [Route("Cadastrar")]
        public ActionResult Cadastrar(IFormCollection form)
        {
                Equipe novaEquipe = new Equipe();
                novaEquipe.IdEquipe = int.Parse( form["IdEquipe"] );
                novaEquipe.Nome = form["Nome"];
               //UPLOAD  INICIO

            //verifica se o user escolheu um arquivo
                if (form.Files.Count > 0)
                {
                    //recebe o arquivo e armazena na variavel File
                    var file = form.Files[0];
                    var folder = Path.Combine( Directory.GetCurrentDirectory(), "wwwroot/img/Equipes" );


                //verificamos se o diretorio ja existe, 
                //se nao, nós criamos
                if (Directory.Exists(folder))

                {

                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))

                {

                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;

                }
                else
                {
                        novaEquipe.Imagem = "padrao.png";

                }




               // UPLOAD FINAL

                //criamos o metodo create para salvar a novaEquipe no CSV
                equipeModel.Create(novaEquipe);

                // atualiza a lista de equipes na View
                ViewBag.Equipes = equipeModel.ReadAll();


                return LocalRedirect("~/Equipe/Listar");

        }

                [Route("{id}")]
                public IActionResult Excluir(int id)
                {
                    equipeModel.Delete(id);
                    ViewBag.Equipes = equipeModel.ReadAll();

                    return LocalRedirect("~/Equipe/Listar");
                }
    
    
    
    }



}