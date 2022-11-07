using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemonApp;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Drawing;

namespace pokemonApp
{
    internal class Sauvage : Pokemon
    {
        private readonly string[] NomSauvage = { "Racaillou", "Leviator", "Artikodin" };
        public Sauvage()
        {
            Random random = new();
            Name = NomSauvage[random.Next(0, 3)];
            Pv = random.Next(40, 100);
            Atk = random.Next(10, 20);
            Def = random.Next(1, 5);
            Vit = random.Next(10, 20);
        }
        public int TakingDamage(int damages)
        {
            return Pv -= damages - Def;
        }
        public int Attack(int Damage)
        {
            return Damage;
        }
    }

}