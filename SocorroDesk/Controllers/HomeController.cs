using Microsoft.AspNetCore.Mvc;
using SocorroDesk.Models;
using SocorroDesk.Repositories;
using System.Diagnostics;

namespace SocorroDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChamadoRepository _repository;
        public HomeController(IChamadoRepository repository)
        {
            _repository = repository;
        }

        //GET
        [HttpGet]
        public IActionResult Index()
        {
            var listaChamados = _repository.Get();
            return View(listaChamados);
        }

        [HttpGet]
        public IActionResult NovoChamado()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Acessar()
        {

            return View();
        }


        //POST

        [HttpPost]
        public IActionResult NovoChamado(Chamado chamado)
        {
            if (ModelState.IsValid) //Verifica se a model recebida é valida
            {
                _repository.Create(chamado);
                return RedirectToAction("Index"); //Após o cadastro, redirecionando para a index
            }

            return View(); //Caso a model estiver incorreta, ele continuará na pagina de cadastro.
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}