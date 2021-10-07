using fixed_assess9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace fixed_assess9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(int char_id, int char_id2, int char_id3, int char_id4, int char_id5)
        {
            char_id = 583;
            char_id2 = 26;
            char_id3 = 89;
            char_id4 = 221;
            char_id5 = 115;
            
            List<Character> characters = new List<Character>();
            Character char1 = await DAL.GetSpecificCharacter(char_id);
            characters.Add(char1);
            Character char2 = await DAL.GetSpecificCharacter(char_id2);
            characters.Add(char2);
            Character char3 = await DAL.GetSpecificCharacter(char_id3);
            characters.Add(char3);
            Character char4 = await DAL.GetSpecificCharacter(char_id4);
            characters.Add(char4);
            Character char5 = await DAL.GetSpecificCharacter(char_id5);
            characters.Add(char5);


            return View(characters);
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
