using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusdieren
{
    class Trein
    {
        public List<Wagon> wagonlijst = new List<Wagon>();

        public void VoegDierToe(Dier d)
        {
            foreach (Wagon wagon in wagonlijst)
            {
                if (wagon.VoegDierToe(d))
                {
                    return;
                }

            }
            wagonlijst.Add(new Wagon());
            VoegDierToe(d);
        }
    }
}
