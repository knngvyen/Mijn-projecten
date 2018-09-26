using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusdieren
{
    class Wagon
    {
        public List<Dier> dierlijst = new List<Dier>();
        public int capiciteit;


        private static int MeetDierGrootte(Dier d)
        {
            int diergrootte = 0;

            if (d.grootte == Grootte.Klein)
            {
                diergrootte = 1;
            }
            else if (d.grootte == Grootte.Middel)
            {
                diergrootte = 3;
            }
            else if (d.grootte == Grootte.Groot)
            {
                diergrootte = 5;
            }
            return diergrootte;
        }

        public bool VoegDierToe(Dier d)
        {
            int diergrootte = MeetDierGrootte(d);
            capiciteit = 0;

            foreach (Dier x in dierlijst)
            {
                capiciteit += diergrootte;
            }

            if (capiciteit + diergrootte >= 11)
            {
                return false;
            }

            if (d.carnivoor)
            {
                foreach (Dier x in dierlijst)
                {
                    if (d.grootte >= x.grootte)
                    {
                        return false;
                    }

                    if (x.carnivoor)
                    {
                        if (x.grootte >= d.grootte)
                        {
                            return false;
                        }
                    }
                }
            }

            else
            {
                foreach (Dier x in dierlijst)
                {
                    if (x.carnivoor)
                    {
                        if (x.grootte >= d.grootte)
                        {
                            return false;
                        }
                    }
                }
            }
            dierlijst.Add(d);
            return true;

        
            
        }

        public override string ToString()
        {
             string x = "";
            foreach (Dier d in dierlijst)
            {
                x += " " + d.naam + " ";
            }
            return x;
        }
    }
}
