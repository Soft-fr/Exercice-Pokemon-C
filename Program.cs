using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using pokemonApp;
internal class Program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Bienvenue a Sinnoh ou règne les pokémon !");
        Console.WriteLine("Chosis un pokemon pour débuter l'aventure.");
        Console.WriteLine("1- Tiplouf  2-Tortipouss   3-Ouisticram");

        var choixStarter = Console.ReadLine();



        switch (choixStarter)
        {
            case "1":

                Console.WriteLine("Vous avez choisis Tiplouf");
                break;


            case "2":

                Console.WriteLine("Vous avez choisis Tortipouss");
                break;



            case "3":

                Console.WriteLine("Vous avez choisis Ouisticram");
                break;

        }
        Random random = new();
        Sauvage sauvage = new Sauvage();
        Starter starter = new Starter("Ton Pokémon");
        string retour = "non";
        while (retour != "oui")
        {
            List<Object> NomCapture = new List<Object>();
            Console.WriteLine("Tu veux faire quoi ?");
            Console.WriteLine("1-Découvrir le monde de Sinnoh  2-Voir les stats de ton pokémon  3-Quitter");
            if(sauvage.Pv <= 0)
            {
                sauvage = new Sauvage();
            }
            var choixMenu = Console.ReadLine();

            switch (choixMenu)
            {
                case "1":
                    Console.WriteLine(sauvage.Name + " sauvage vous attaque");

                    while (starter.Pv > 0 | sauvage.Pv > 0)
                    {
                        Console.WriteLine("Tu veux faire quoi ?");
                        Console.WriteLine("1- Attaquer   2-Se Soigner   3-Fuir  4-Capturer");
                        int choixAction = int.Parse((Console.ReadLine()));
                        if (choixAction == 1)
                        {
                            if (starter.Vit >= starter.Vit)
                            {
                                sauvage.TakingDamage(starter.Atk);
                                Console.WriteLine("Tu as infligé  " + starter.Atk + "DMG");
                                Console.WriteLine(sauvage.Name + "  " + sauvage.Pv + " PV restants");
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Atk);
                                Console.WriteLine(sauvage.Name + " as infligé  " + sauvage.Atk + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Pv + " PV restants");
                            }
                            else
                            {
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Atk);
                                Console.WriteLine(sauvage.Name + " as infligé  " + sauvage.Atk + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Pv + " PV restants");
                                sauvage.TakingDamage(starter.Atk);
                                Console.WriteLine("Tu as infligé  " + starter.Atk + "DMG");
                                Console.WriteLine(sauvage.Name + "  " + sauvage.Pv + " PV restants");
                            }
                        }
                        if (choixAction == 2)
                        {
                            Console.WriteLine("Tu utilise une potion");
                            starter.Potion(20);
                            Console.WriteLine("Tu as " + starter.Pv + " HP");
                            Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                            starter.TakingDamage(sauvage.Atk);
                            Console.WriteLine(sauvage.Name + " as infligé  " + sauvage.Atk + "DMG");
                            Console.WriteLine(starter.Name + "  " + starter.Pv + " PV restants");
                        }

                        if (choixAction == 3)
                        {
                            if (random.Next(0, 50) < 10)
                            {
                                Console.WriteLine("Tu as pas réussi à t'échapper. Reste sur tes gardes.");
                                Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                starter.TakingDamage(sauvage.Atk);
                                Console.WriteLine(sauvage.Name + " as infligé  " + sauvage.Atk + "DMG");
                                Console.WriteLine(starter.Name + "  " + starter.Pv + " PV restants");
                            }
                            else
                            {
                                Console.WriteLine("Ta réussi à t'échaper, t'y a échappé belle");
                                break;
                            }
                        }

                        if (choixAction == 4)
                        {
                                Console.WriteLine("3");
                                Console.WriteLine("2");
                                Console.WriteLine("1");
                                if (random.Next(0, 50) < 10)
                                {
                                    Console.WriteLine("Zuuut, le pokemon est ressorti !");
                                    Console.WriteLine("ATTENTION!" + sauvage.Name + " attaque!");
                                    starter.TakingDamage(sauvage.Atk);
                                    Console.WriteLine(sauvage.Name + " as infligé  " + sauvage.Atk + "DMG");
                                    Console.WriteLine(starter.Name + "  " + starter.Pv + " PV restants");
                                }
                                else
                                {
                                    Console.WriteLine("Tu as capturé le pokemon sauvage ! Félicitation.");
                                    NomCapture.Add(new Sauvage());
                                    break;

                                }

                        }
                        if (starter.Pv <= 0)
                        {
                            Console.WriteLine("Nonnnnnn ! Ton pokemon est tombé K.O");
                            retour = "oui";
                            break;
                        }
                        if (sauvage.Pv <= 0)
                        {
                            Console.WriteLine("Tu as gagné le combat");
                            break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Point de vie = " + starter.Pv);
                    Console.WriteLine("Dégats = " + starter.Atk);
                    Console.WriteLine("Vitesse = " + starter.Vit);
                    Console.WriteLine("Defense = " + starter.Def);
                    Console.WriteLine("");
                    break;
                case "3":
                    Console.WriteLine("A bientot dans le monde de Sinnoh");
                    retour = "oui";
                    break;
            }

        }
    }
}


