using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    class Program
    {
        static void Main()
        {
            try
            {
                Team @new = new TeamBuilder()
                    .Create("Karpaty Lviv")
                    .WithColor(ConsoleColor.DarkMagenta)
                    .WithHomeTown("Lviv")
                    .WithPlayers()
                    .Build();

                PrintTeam(@new);
            }
            catch (NullReferenceException) // in case of not initalizing some field
            {
                Console.WriteLine("Error");
            }


        }
        public static void PrintTeam(Team obj)
        {
            Console.ForegroundColor = obj.Color;
            Console.WriteLine(String.Format("\t{0} from {1}\t", obj.Name, obj.HomeTown));
            Console.WriteLine("Players : ");
            foreach (var el in obj.Players)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
        }
    }

    

    



    }
