using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Team
    {
        public String Name;
        public List<String> Players;
        public String HomeTown;
        public ConsoleColor Color;

        public Team(
            String name
            , List<String> players
            , String hometown
            , ConsoleColor color)
        {
            this.Color = color;
            this.HomeTown = hometown;
            this.Name = name;
            this.Players = players;
        }

    }
}
