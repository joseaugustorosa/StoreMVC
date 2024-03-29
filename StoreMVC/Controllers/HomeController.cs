using Microsoft.AspNetCore.Mvc;
using StoreMVC.Models;
using System.Diagnostics;

namespace StoreMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Produtos> Itens = new List<Produtos>
            {
                    new Produtos { Id = 1, Nome = "Red Dead Redemption 2", Valor = 99.00 , descricao= "Red Dead Redemption 2 é um jogo eletrônico de ação-aventura desenvolvido e publicado pela Rockstar Games. É o terceiro título da série Red Dead e uma prequela de Red Dead Redemption, tendo sido lançado em outubro de 2018 para PlayStation 4 e Xbox One e em novembro de 2019 para Microsoft Windows e Google Stadia.", img= "https://cdn.akamai.steamstatic.com/steam/apps/1174180/capsule_616x353.jpg?t=1695140956"},
                    new Produtos { Id = 2, Nome = "Spider-Man: Miles Morales", Valor = 89.90 , descricao= "Marvel's Spider-Man: Miles Morales é um jogo eletrônico de ação-aventura desenvolvido pela Insomniac Games e publicado pela Sony Interactive Entertainment para o PlayStation 4 e PlayStation 5.", img= "https://cdn1.epicgames.com/offer/f696430be718494fac1d6542cfb22542/EGS_MarvelsSpiderManMilesMorales_InsomniacGamesNixxesSoftware_S1_2560x1440-a0518b9f9f36a05294e37448df8a27a0"},
                    new Produtos { Id = 3, Nome = "God of War Ragnarök", Valor = 157.99, descricao= "God of War Ragnarök é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment. Foi lançado em 9 de novembro de 2022 para PlayStation 4 e PlayStation 5. É o nono título da série God of War, o nono em ordem cronológica, e a sequência de God of War.", img= "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi7nx9aB62gpDEXtd4Rqnvw0ZcRdXKdQ-2dbQWx4Z_FQPwE1HJRzEGmxqh8hHQFp2W1QGSHC9rCN7BdcHLU-E3NiHL9Ld6ICLUNbTBj4C8hHD3uJtJKev_ykw7w7aui7G_ru9eAvorcHmxG00efCdMoEmPnzEoZ7oaXfYAoyaaVSGwUPCBu1k1jh-gZ/w640-h360/analise-review-god-of-war-ragnarok.jpg" },
                    new Produtos { Id = 4, Nome = "God of War", Valor = 48.90 , descricao= "God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment. Foi lançado em 20 de abril de 2018 para PlayStation 4 e em 14 de janeiro de 2022 para Microsoft Windows.", img= "https://files.tecnoblog.net/wp-content/uploads/2021/03/Como-jogar-god-of-war-001.jpg"},
                    new Produtos { Id = 5, Nome = "Elden Ring", Valor = 209.90 , descricao= "Elden Ring é um jogo eletrônico de RPG de ação em terceira pessoa, desenvolvido pela FromSoftware e publicado pela Bandai Namco Entertainment. O jogo é um projeto colaborativo entre o diretor Hidetaka Miyazaki e o romancista de fantasia George R. R. Martin.", img= "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/aGhopp3MHppi7kooGE2Dtt8C.png"}
            };


            return View(Itens);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
