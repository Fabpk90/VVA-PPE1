using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
    public class Inscrit
    {
        private string nom;
        private string prenom;

        private DateTime dt_naissance;

        public Inscrit(string nom, string prenom, DateTime dt_naissance)
        {
            this.nom = nom;
            this.prenom = prenom;

            this.dt_naissance = dt_naissance;
        }
    }
}
