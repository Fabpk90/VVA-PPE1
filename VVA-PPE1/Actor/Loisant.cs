using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
    class Loisant : Inscrit
    {
        private DateTime dt_debut_sejour;
        private DateTime dt_fin_sejour;

        public Loisant(string nom, string prenom, DateTime dt_naissance, DateTime dt_debut_sejour, DateTime dt_fin_sejour) : base(nom, prenom, dt_naissance)
        {
            this.dt_debut_sejour = dt_debut_sejour;
            this.dt_fin_sejour = dt_fin_sejour;
        }
    }
}
