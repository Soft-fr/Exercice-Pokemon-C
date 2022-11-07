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

        public int Potion(int potion)
        {
            return Pv += potion;
        }
        
    }
}
