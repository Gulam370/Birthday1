using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using surprise.Models;

namespace surprise.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Letter()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            var memories = new List<Memory>
            {
                new Memory
                {
                    Title = "First Meeting",
                    Description = "The day my life changed ??",
                    ImageUrl = "\\images\\first_image.jpeg"
                },

                new Memory
                {
                    Title = "Best Day Together",
                    Description = "A memory I'll never forget",
                    ImageUrl = "\\images\\second_image.jpeg"
                },

                new Memory
                {
                    Title = "Our Special Moment",
                    Description = "Forever in my heart",
                    ImageUrl = "\\images\\third_image.jpeg"
                }
            };

            return View(memories);
        }

        public IActionResult Chatting()
        {
            var memories = new List<Memory>
            {
                new Memory
                {
                   
                    ImageUrl = "\\images2\\WhatsApp Image 2026-07-20 at 11.42.44 PM.jpeg"
                },

                new Memory
                {
                   
                    ImageUrl = "\\images2\\WhatsApp Image 2026-07-20 at 11.42.44 PM.jpeg"
                },

                new Memory
                {
                  
                    ImageUrl = "\\images2\\WhatsApp Image 2026-07-20 at 11.42.44 PM.jpeg"
                }
            };

            return View(memories);
        }
        public IActionResult Surprise()
        {
            return View();
        }

    }
}
