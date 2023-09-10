using Microsoft.AspNetCore.Mvc;
using wiki_blue_exorcist.Models;

namespace wiki_blue_exorcist.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HomeController : ControllerBase {
    [HttpGet]
    public async Task<Home> Get(){
        Home home = new Home();

        home.Title = "Blue Exorcist";
        home.Sinopse = "Rin Okumura é um orfão que vive com Yukio, seu irmão gêmeo, no Monastério de Vera Cruz. Ao contrário de seu irmão, que é aplicado e conseguiu uma bolsa de estudos, Rin não é muito inteligente e tem um dom natural para arrumar confusão.";
        home.Sinopse += "Um dia, em meio a uma briga, o jovem descobrirá o grande segredo que envolve seu passado e também que existem dêmonios no mundo. Criado por um padre exorcista, Rin não vê outra saída a não ser estudar para se tornar também um exorcista e lutar contra o mal.";
        home.Sinopse += "O jovem ingressa no Colégio Vera Cruz para se tornar um verdadeiro exorcista. Mas, é claro que as aulas não serão todas teóricas… Acompanhe Rin em sua estrada dividida entre o bem e o mal, entre os exorcistas e os demônios, entre a paz e a batalha!";
        home.Image = "https://userstyles.org/style_screenshots/243723_after.jpeg?r=1694332876";
        home.Quantidade = 25;

        return await Task.FromResult(home);
    }

}