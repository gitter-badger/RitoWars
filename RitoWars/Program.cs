using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RitoWars.Logic.Game.Champions.Champs;
using RitoWars.Logic.Game.Players;

namespace RitoWars
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("RitoWars  Copyright (C) 2015  eddy5641");
                Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details press 'w'.");
                Console.WriteLine("This is free software, and you are welcome to redistribute it");
                Console.WriteLine("under certain conditions; press 'c' for details.");
                Console.WriteLine(string.Empty);
                Console.WriteLine("If you accept press 'Y' and if you do not, press 'N' to close the program");
                Console.Write(">");
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        Process.Start("http://www.gnu.org/licenses/gpl-3.0.en.html");
                        break;
                    case ConsoleKey.C:
                        Process.Start("http://www.gnu.org/licenses/gpl-3.0.en.html");
                        break;
                    case ConsoleKey.Y:
                        goto PostLicense;
                    case ConsoleKey.N:
                        Environment.Exit(0);
                        break;
                }
            }
            PostLicense:
            Console.WriteLine("Starting");
        }
    }
}
