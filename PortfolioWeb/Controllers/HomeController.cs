using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Data;
using PortfolioWeb.Entities;
using PortfolioWeb.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PortfolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public readonly PortfolioContext _context;

        public HomeController(ILogger<HomeController> logger, PortfolioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var user = _context.UserEntities.Include(x=>x.Videos).FirstOrDefault();
            return View(user);
        }

        public IActionResult Experiments()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Project(Guid id)
        {
            var video = _context.VideoEntities.Where(x => x.Id == id).Include(x => x.Images).FirstOrDefault();
            return View(video);
        }

        public IActionResult InsertUser() 
        {
            var model = new UserEntity()
            {
                Id = Guid.NewGuid(),
                FirstName = "Bekhzod",
                LastName = "Usmonov",
                UserName = "@usmonoff",
                Birthdate = "09.05.1999",
                Avatar = "images/photo1.jpg",
                Phone = "+998939511077",
                Professions = "Motion & Graphic designer, Web developer, Animator",
                Information = @"Bekhzod Usmonov is a graphic & motion designer based in Uzbekistan,Central Asia. He is working in the field of visual communication with a strong focus on typography and Motion design. Working as an independent graphic & motion designer since 2019",
                ChatId = 123456,
                RegisterTime = DateTime.UtcNow,
                Videos = new List<VideoEntity>()
                {
                    new VideoEntity()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Project name and short about the “Project”",
                        Description = @"Here will be more information about project. Artificial intelligence holds the potential to transform various industries, however, many companies have yet to adopt its use due to integration obstacles, development expenses, and a lack of expertise in the field.

        Monobotics Technologies' mission is to become an affordable go-to provider of plug-and-play computer vision systems for SMEs.",
                        Poster = "images/photo1.jpg",
                        URL = "videos/oneplus.mp4",
                        Images = new Collection<ScreenshotEntity>()
                        {
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 1",
                                URL = "images/photo1.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 2",
                                URL = "images/photo2.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 3",
                                URL = "images/photo3.jpg"
                            }
                        }
                    },
                    new VideoEntity()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Project name and short about the “Project”",
                        Description = @"Here will be more information about project. Artificial intelligence holds the potential to transform various industries, however, many companies have yet to adopt its use due to integration obstacles, development expenses, and a lack of expertise in the field.

        Monobotics Technologies' mission is to become an affordable go-to provider of plug-and-play computer vision systems for SMEs.",
                        Poster = "images/v21.jpg",
                        URL = "videos/video2.mp4",
                        Images = new Collection<ScreenshotEntity>()
                        {
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 1",
                                URL = "images/v21.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 2",
                                URL = "images/v22.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 3",
                                URL = "images/v23.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 4",
                                URL = "images/v24.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 5",
                                URL = "images/v25.jpg"
                            },
                            new ScreenshotEntity()
                            {
                                Name = "screenshot 6",
                                URL = "images/v26.jpg"
                            }
                        }
                    }
                }
            };

            _context.UserEntities.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult InsertVideo()
        {
            var user = _context.UserEntities.FirstOrDefault()!.Id;
            var model = new VideoEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Project name and short about the “Project”",
                Description = @"Here will be more information about project. Artificial intelligence holds the potential to transform various industries, however, many companies have yet to adopt its use due to integration obstacles, development expenses, and a lack of expertise in the field.

Monobotics Technologies' mission is to become an affordable go-to provider of plug-and-play computer vision systems for SMEs.",
                Poster = "images/photo1.jpg",
                UserId = Guid.Parse("18b40474-a0dd-4251-9d34-399db7055d7c"),
                URL = "videos/oneplus.mp4",
                Images = new Collection<ScreenshotEntity>()
                {
                    new ScreenshotEntity()
                    {
                        Name = "screenshot 1",
                        URL = "images/photo1.jpg"
                    },
                    new ScreenshotEntity()
                    {
                        Name = "screenshot 2",
                        URL = "images/photo2.jpg"
                    },
                    new ScreenshotEntity()
                    {
                        Name = "screenshot 3",
                        URL = "images/photo3.jpg"
                    }
                }
            };

            _context.VideoEntities.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
