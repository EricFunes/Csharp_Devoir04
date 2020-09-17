using System;
using System.Collections;
using System.Text;

namespace Ex2
{
  
    //classe Personne
    public class Personne {

        const int ageMinimum = 10;
         	
        // propriétés d'instance
        public string Nom
        {
            get;
        }

        public string? Prenom { get; set; }

        // attributs d'instance
        private int? age;
        public int? Age
        {
            get { return age; }
            set
            {
            if (value >= ageMinimum)
                age = value;
            else
                age = null;
            }
        }
	    // constructeurs
        
        public Personne(String n, int? age = 10){
            this.Nom = n;
	        this.Age=age;
	    }

        public Personne(Personne p) : this(p.Nom, p.Age)
        {

        }
        public static Personne operator +(Personne p, int annee)
        {
            p.Age += annee;
            return p;
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Prenom))
            {
                return $"{this.Nom} ({this.Age})";
            }
            return $"{this.Prenom} {this.Nom} ({this.Age})";
        }
        public override bool Equals(Object obj)
        {
            Personne p = (Personne) obj;

            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            return this.Nom == p.Nom && this.Age == p.Age ;
        }

    }//classe
}
      

