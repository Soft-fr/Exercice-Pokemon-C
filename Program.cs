using pokemonApp;
Pokemon sauvage = new Bulbizarre();
bool continuer = true;
string starterChoice = "0";

while (continuer)
{
    while (starterChoice != "1" && starterChoice != "2" && starterChoice != "3")
    {
        Console.WriteLine("choisi : 1 - Salameche, 2 - bulbizzare, 3 - carrapuce :");
        starterChoice = Console.ReadLine();
    

        if (starterChoice == "1")
        {
            Salameche salameche = new Salameche();
            Console.WriteLine($"tu as choisi {salameche.Name}");
    
            while (salameche.Pv > 0)
                {
                    Console.WriteLine(salameche.ActionChoice(salameche, sauvage));
                    Console.WriteLine(sauvage.ActionChoiceSauvage(sauvage, salameche));
                }
        }
        else if (starterChoice == "2")
        {
            Bulbizarre bulbizzare = new Bulbizarre();
            Console.WriteLine($"tu as choisi {bulbizzare.Name}");

            while (bulbizzare.Pv > 0)
            {
                Console.WriteLine(bulbizzare.ActionChoice(bulbizzare, sauvage));
                Console.WriteLine(sauvage.ActionChoiceSauvage(sauvage, bulbizzare));
            }
        }
        else
        {
            Carapuce carapuce = new Carapuce();
            Console.WriteLine($"tu as choisi {carapuce.Name}");

            while (carapuce.Pv > 0)
            {
                Console.WriteLine(carapuce.ActionChoice(carapuce, sauvage));
                Console.WriteLine(sauvage.ActionChoiceSauvage(sauvage, carapuce));
            }
        }
    }
    Console.WriteLine("souhaitez-vous continuer ? (Y/n)");
    string choix = Console.ReadLine();
    continuer = choix != "quitter";
}