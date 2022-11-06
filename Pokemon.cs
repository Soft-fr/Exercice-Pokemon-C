using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp
{

    public abstract class Pokemon
    {
        public string? Name { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Vit { get; set; }


        public Pokemon() { }


        /*
         * Methode pour attaquer le pokemon et qu'il nous attaque
         */
        public virtual string Attack(Pokemon pokemon, Pokemon sauvage)
        {
            Console.WriteLine($"vous attaquez {sauvage.Name} !");
            Console.WriteLine($"vous infligez {pokemon.Atk /8} PV à {sauvage.Name}!");
            sauvage.Pv -= pokemon.Atk /8;
            return $"Il reste {sauvage.Pv} à {sauvage.Name}";
        }

        /*
         * Methode pour healer le pokemon
         */
        public virtual string Healer(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} à {pokemon.Pv} tu utilises une potion !");
            pokemon.Pv += 5;
            return $"{pokemon.Name} à récupéré 5 PV, il a désormais {pokemon.Pv}";
        }

        /*
         * Methode pour voir les stats du pokemon
         */
        public virtual string Stats(Pokemon pokemon)
        {
            return $"les stats de ton pokemon sont : pv : {pokemon.Pv}, ATK : {pokemon.Atk}, DEF : {pokemon.Def}, VIT : {pokemon.Vit} ";

        }

        /*
         * Methode du choix de l'action du joueur
         */
        public string ActionChoice(Pokemon pokemon, Pokemon sauvage)
        {

            Console.WriteLine("Choisissez une action à réaliser : 1 - Attaquer, 2 - healer, 3 - stats");
            var choixAction = Console.ReadLine();
            switch (choixAction)
            {
                case "1":
                    return Attack(pokemon, sauvage);
                case "2":
                    return Healer(pokemon);
                case "3":
                    return Stats(pokemon);
            }
            return "aurevoir";
        }

        /*
         * Methode du choix de l'adversaire
         */
        public string ActionChoiceSauvage(Pokemon sauvage, Pokemon pokemon)
        {
            Random random = new Random();
            // choix aléatoire de l'action du pokemon adverse (attaque, utiliser une potion)
            int resultatChoix = random.Next(1);
            switch (resultatChoix) {
                case 0:
                    Console.WriteLine($"{sauvage.Name} vous attaque !");
                    Console.WriteLine($"il vous inflige {sauvage.Atk / 8} PV à {pokemon.Name}!");
                    pokemon.Pv -= sauvage.Atk / 8;
                    Console.WriteLine($"il reste {pokemon.Pv} à {pokemon.Name}");
                    break;
                case 1:
                    Console.WriteLine($"{sauvage.Name} observe !");
                    break;
            }
            // si il a moins de 15pv - 1/3 de fuir
            if (sauvage.Pv < 15)
            {
                Console.WriteLine("L'adversaire essaye de fuir");
                int resultat = random.Next(2);
                if (resultat != 2)
                {
                    
                    Console.WriteLine("L'adversaire à réussi à fuir !");
                    Console.WriteLine("souhaitez-vous continuer ? (Y/n)");
                    bool continuer = true;
                    string choix = Console.ReadLine();
                    continuer = choix != "quitter";
                }
            }
            return "";
        }
    }
}
