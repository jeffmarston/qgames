using System.Collections.Generic;
using System;

namespace QGames.Games
{
    public class GameData
    {
        public string name { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }


}
