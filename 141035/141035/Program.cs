using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Magazyn> stos = new Stack<Magazyn>();
            stos.Push(new Magazyn("qwe"));
            stos.Push(new Magazyn("asd"));
            stos.Push(new Magazyn("zxc"));

            List<Magazyn> lista = new List<Magazyn>();
            lista.Add(new Magazyn("mag1"));
            lista.Add(new Magazyn("mag2"));
            lista.Add(new Magazyn("mag3"));
            lista.Reverse();
            //lista.Sort();

            List<Bohater> lista2 = new List<Bohater>();
            lista2.Add(new Ork(6, 5));
            lista2.Add(new Ork(7, 6));
            lista2.Add(new Elf(4, "magia1"));
            lista2.Add(new Elf(3, "magia2"));
            /*foreach (var element in Bohater)
            {
                Console.WriteLine(element);
            }*/
            Console.WriteLine("Podaj 1sza liczbe:");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj 2ga liczbe:");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            new Ork(liczba1, liczba2);


        }
    }
}
