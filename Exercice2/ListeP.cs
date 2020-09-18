using Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class ListeP: List<Personne>
    {
        public Personne this[string prenom]
        {
            get 
            {
                foreach (Personne p in this)
                {
                    if (p.Prenom == prenom)
                    {
                        return p;
                    }
                }
                return null;
            }
            set 
            {
                foreach (Personne p in this.ToList())
                {
                    if (p.Prenom == prenom)
                    {
                        this[IndexOf(p)] = value;
                    }
                }
            }
        }
        public static List<Personne> operator +(Personne p, ListeP list)
        {
            list.Add(p);
            return list;
        }
        public override string ToString()
        {
            string result = "";
            foreach (Personne p in this)
            {
                result += $"{p.ToString()}\n";
            }
            return result;
        }
    }
}
