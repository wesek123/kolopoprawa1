using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Elf:Bohater
    {
        private string magia;
        public Elf(int hp, string magia)
            :base(hp)
        {
            base.hp = hp;
            this.magia = magia;
        }
        public override void ZadajCios()
        {
            //base.Zadajcios(5);
        }
        /*public override string ToString()
        {
            return "Elf. hp: " + hp + " magia: " + magia;
        }*/
        
    }
}
