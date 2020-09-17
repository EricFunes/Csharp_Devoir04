using Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Jean", "Leduc");
            Console.WriteLine($"{p1}");

            Personne p2 = new Personne("Boussion", 12);
            Console.WriteLine($"{p2}");

            Personne p3 = new Personne(p1, "Phillipe");
            Console.WriteLine($"{p1}");

            Console.WriteLine($"jean.Equals(phil) = {p1.Equals(p3)}");

            p1 += 2;
            Console.WriteLine($"{p1}");

            p1.Equals(p2);
            Console.WriteLine($"jean.Equals(phil) = {p1.Equals(p3)}");

            p1.Equals(p2);
            Console.WriteLine($"jean.Equals(jc) = {p1.Equals(p2)}");
        }
    }
}
