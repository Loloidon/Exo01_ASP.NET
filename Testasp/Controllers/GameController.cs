using Microsoft.AspNetCore.Mvc;

namespace Testasp.Controllers
{
    public class GameController : Controller
    {
        private readonly GameService gameService;
        public IActionResult Index()
        {
            return View(gameService.Games);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddGame(int Id,string Titre, int Annee,string Genre,string Resume)
        {
            gameService.addGame(Id, Resume, Annee, Genre, Titre);

            
            return View("Index",gameService.Games);
        }
        public GameController(GameService g)
        {
            gameService = g;
        }




    }
}
