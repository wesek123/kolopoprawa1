using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    abstract class Bohater
    {
        public int hp;

        public Bohater(int hp)
        {
            this.hp = hp;
        }
        public abstract void ZadajCios();
        /*public void Zadajcios(int hp)
        {
            
        }*/

        /*public string ToString()
        {
            return "Bohater. Hp:" + hp;
        }*/


    }
}
