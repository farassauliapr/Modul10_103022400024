using Modul10_103022400024;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;


namespace Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class Controllers : ControllerBase
    {
        private static List<Game> games = new List<Game>
    {
        new Game
        {
            Id = 1,
            Nama = "Valorant",
            Developer = "Riot Games",
            TahunRilis = 2020,
            Genre = "FPS",
            Rating = 8.5,
            Platform = new List<String> { "PC" },
            Mode = new List<string> { "MultiPlayer" },
            IsOnline = true,
            Harga = 0
        },

        new Game
        {
            Id = 2,
            Nama = "Genshin Impact",
            Developer = "miHoYo",
            TahunRilis = 2020,
            Genre = "Action RPG",
            Rating = 8.0,
            Platform = new List<string> { "PC", "PS4", "PS5", "Xbox" },
            Mode = new List<string> { "Single Player", "Multiplayer" },
            IsOnline = true,
            Harga = 0
        },
        new Game
        {
            Id = 3,
            Nama = "The Witcher 3",
            Developer = "CD Projekt Red",
            TahunRilis = 2015,
            Genre = "RPG",
            Rating = 9.7,
            Platform = new List<string> { "PC", "PS4", "PS5", "Xbox", "Switch" },
            Mode = new List<string> { "Single Player" },
            IsOnline = false,
            Harga = 250000

        },







    };

        [HttpGet]

        public IEnumerable<Game> GetAllGame()
        {
            return games;
        }

        [HttpGet("{id}")]

        public Game GetGameById(int id)
        {
            return games[id];
        }

        [HttpPost]
        public void Post([FromBody] Game game)
        {
            games.Add(game);
        }

        [HttpPut("{id}")]
        public ActionResult Put (int id,  Game update)
        {
            var index = games.FindIndex(g => g.Id == id);
            if (index == -1)
            {
                return NotFound();
            }
            games[index] = update;
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        { 
            games.RemoveAt(id);
        }







    }
}

