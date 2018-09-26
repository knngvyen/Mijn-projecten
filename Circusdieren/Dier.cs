using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusdieren
{
    public enum Grootte
    {
        Klein,
        Middel,
        Groot
    }
    class Dier
    {
        public string naam { get; }
        public bool carnivoor { get; }
        public Grootte grootte { get; }

        public Dier(string naam, bool carnivoor, Grootte grootte)
        {
            this.naam = naam;
            this.carnivoor = carnivoor;
            this.grootte = grootte;
        }
    }
}
