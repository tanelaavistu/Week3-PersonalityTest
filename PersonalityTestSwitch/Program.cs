using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "Oled romantiline."
            //kui kasutaja sisestab "sinine", konsool kuvab "Oled töökas."
            //kui kasutaja sisestab "roheline", konsool kuvab "Oled loodusearmastaja."
            //kui kasutaja sisestab midagi muud, konsool kuvab "Oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv.");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusearmastaja.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik!");
                    break;

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
