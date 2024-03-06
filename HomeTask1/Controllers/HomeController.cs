using HomeTask1.Models;
using HomeTask1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Service> services = new List<Service>()
        {
            new Service()
            {
                Title = "Nesciunt Mete",
                Description = "Provident nihil minus qui consequatur non omnis maiores. Eos accusantium minus dolores iure perferendis tempore et consequatur.",
                IconName = "bi bi-arrow-right",
                Url = "https://google.com",
                UrlText = "Read more "
            },
            new Service()
            {
                Title = "Eosle Commodi",
                Description = "Ut autem aut autem non a. Sint sint sit facilis nam iusto sint. Libero corrupti neque eum hic non ut nesciunt dolorem.",
                IconName = "bi bi-broadcast",
                Url = "https://google.com",
                UrlText = "Read more "
            },
            new Service()
            {
                Title = "Ledo Markt",
                Description = "Ut excepturi voluptatem nisi sed. Quidem fuga consequatur. Minus ea aut. Vel qui id voluptas adipisci eos earum corrupti.",
                IconName = "bi bi-easel",
                Url = "https://google.com",
                UrlText = "Read more "
            },
            new Service()
            {
                Title = "Asperiores Commodit",
                Description = "Non et temporibus minus omnis sed dolor esse consequatur. Cupiditate sed error ea fuga sit provident adipisci neque.",
                IconName = "bi bi-bounding-box-circles",
                Url = "https://google.com",
                UrlText = "Read more "
            },
            new Service()
            {
                Title = "Velit Doloremque",
                Description = "Cumque et suscipit saepe. Est maiores autem enim facilis ut aut ipsam corporis aut. Sed animi at autem alias eius labore.",
                IconName = "bi bi-calendar4-week",
                Url = "https://google.com",
                UrlText = "Read more "
            },
            new Service()
            {
                Title = "Dolori Architecto",
                Description = "Hic molestias ea quibusdam eos. Fugiat enim doloremque aut neque non et debitis iure. Corrupti recusandae ducimus enim.",
                IconName = "bi bi-chat-square-text",
                Url = "https://google.com",
                UrlText = "Read more "
            }
        };

        HomeViewModel viewModel = new HomeViewModel()
        {
            Services = services
        };

        return View(viewModel);
    }
}
