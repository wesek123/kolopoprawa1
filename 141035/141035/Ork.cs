using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Ork:Bohater
    {
        public int walka;

        public Ork(int walka, int hp)
            :base(hp)
        {
            this.walka = walka;
            base.hp = hp;
        }
        public override void ZadajCios()
        {
            //base.Zadajcios(7);
        }
        /*public override string ToString()
        {
            return "Ork. walka: " + walka + " hp: " + hp;
        }*/
    }
}
