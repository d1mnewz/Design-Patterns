using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class TeamBuilder
    {
        private String _name;
        private List<String> _players = new List<String>();
        private String _homeTown;
        private ConsoleColor _color;
        public TeamBuilder Create(String name)
        {
            this._name = name;
            return this;
        }
        public TeamBuilder WithPlayers()
        {
            for (int i = 0; i < 11; i++)
            {
                this._players.Add(Faker.Name.FullName());
            }
            return this;
        }
        public TeamBuilder WithColor(ConsoleColor color)
        {
            this._color = color;
            return this;
        }

        public TeamBuilder WithHomeTown(String home)
        {
            this._homeTown = home;
            return this;
        }
        public Team Build()
        {
            if (this._color != ConsoleColor.Black && this._homeTown != null && this._name != null && this._players.Count != 0)
            {
                return new Team(this._name, this._players, this._homeTown, this._color);
            }
            else throw new NullReferenceException();
        }
    }
}
