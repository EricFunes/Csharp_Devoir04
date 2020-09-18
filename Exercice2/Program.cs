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

            Personne p3 = new Personne(p1, "Philippe");
            Console.WriteLine($"{p3}");

            Console.WriteLine($"jean.Equals(phil) = {p1.Equals(p3)}");

            p1 += 2;
            Console.WriteLine($"{p1}");

            p1.Equals(p3);
            Console.WriteLine($"jean.Equals(phil) = {p1.Equals(p3)}");

            p1.Equals(p2);
            Console.WriteLine($"jean.Equals(jc) = {p1.Equals(p2)}\n");

            ListeP list = new ListeP();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            Console.WriteLine($"Liste initiale: \n{list.ToString()}\n");

            Console.WriteLine($"Est-ce que la liste contient Jean? {list.Contains(p1)}");
            
            Personne x = new Personne("Leduc", 11);
            Console.WriteLine($"x = {x}");
            
            Console.WriteLine($"Est-ce que la liste contient x? {list.Contains(x)}");
            
            x += 1;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Est-ce que la liste contient x? {list.Contains(x)}\n");

            list[1].Prenom = "Milou";
            Console.WriteLine($"Liste après changement du prénom de la seconde personne: \n{list.ToString()}\n");

            list["Milou"] = new Personne("Rintintin", 24);
            Console.WriteLine($"Liste après remplacement de Milou par Rintintin: \n{list.ToString()}\n");

            Console.WriteLine($"Personne prénomée Jean obtenu par indexeur = {list[p1.Prenom]}\n");

            Console.WriteLine($"Trouvez Philippe: {list["Philippe"].ToString()}");
        }
    }
}
