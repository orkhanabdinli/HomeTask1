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
        List<Testimonials> testimonials = new List<Testimonials>()
        {
            new Testimonials()
            {
                FullName = "Saul Goodman",
                Position = "Ceo & Founder",
                Picture = "testimonials-1.jpg",
                Description = "\r\n                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.\r\n                                "
            },
            new Testimonials()
            {
                FullName = "Sara Wilsson",
                Position = "Ceo & Founder",
                Picture = "testimonials-2.jpg",
                Description = "\r\n                                Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa.\r\n                                "
            },
            new Testimonials()
            {
                FullName = "Jena Karlis",
                Position = "Store Owner",
                Picture = "testimonials-3.jpg",
                Description = "\r\n                                Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.\r\n                                "
            },
            new Testimonials()
            {
                FullName = "Matt Brandon",
                Position = "Freelancer",
                Picture = "testimonials-4.jpg",
                Description = "\r\n                                Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore.\r\n                                "
            },
            new Testimonials()
            {
                FullName = "John Larson",
                Position = "Entrepreneur",
                Picture = "testimonials-5.jpg",
                Description = "\r\n                                Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore.\r\n                                "
            }
        };

        HomeViewModel viewModel = new HomeViewModel()
        {
            Services = services,
            Testimonials = testimonials
        };

        return View(viewModel);
    }
}
