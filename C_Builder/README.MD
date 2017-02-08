Builder pattern simply allows you to _build_ any configuration of object. Just like a pizza in a restorount, you can choose pizza elements by yourself and that's the way you build your own pizza.

Builder. Intent. Separate the construction of a complex object from its representation so that the same construction
process can create different representations. 


Imagine you are forming a team. 

I tryed my code to look english-like. 

		Team @new = new TeamBuilder()
                    .Create("Karpaty Lviv") // setting title of the team
                    .WithColor(ConsoleColor.DarkMagenta) // color of shirts
                    .WithHomeTown("Lviv") 
                    .WithPlayers() // setting random players using faker
                    .Build(); // getting team !