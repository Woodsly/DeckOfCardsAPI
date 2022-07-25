using DeckofCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckofCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public DeckDAL deckDAL = new DeckDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DrawCards()
        {
            DeckModel cards = deckDAL.GetDeck();
            return View(cards);
        }
        public IActionResult ShuffleCards()
        {
            deckDAL.ShuffleCards();
            return View();
        }
        public IActionResult AutoShuffle()
        {
            deckDAL.ShuffleCards();
            return View();
        }
        //public IActionResult DrawAgain()
        //{
        //    DeckModel cards = deckDAL.GetDeck();
        //    return View(cards);
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}