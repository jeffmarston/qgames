using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace QGames.Games
{
    [Route("api/games")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IHubContext<NotificationHub> _context;

        public GamesController(IHubContext<NotificationHub> context)
        {
            _context = context;
        }
        // GET api/games
        [HttpGet()]
        public ActionResult<IEnumerable<GameData>> Get()
        {
            return GetDummyData();
        }

        // POST api/games/save
        [HttpPost("{gameId}/save")]
        public void SaveGame(string gameId)
        {
            throw new NotImplementedException();
        }

        private ActionResult<IEnumerable<GameData>> GetDummyData()
        {
            var rand = new Random();
            return new GameData[] {
                new GameData() { name="Connect 4" }
             };
        }

    }
}