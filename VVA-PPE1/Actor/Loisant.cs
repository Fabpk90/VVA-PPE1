using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
    class Loisant : Inscrit
    {
        private Profil profil;

        private DateTime dt_debut_sejour;
        private DateTime dt_fin_sejour;

        public Loisant(string nom, string prenom, DateTime dt_naissance, DateTime dt_debut_sejour, DateTime dt_fin_sejour) 
            : base(nom, prenom, dt_naissance)
        {
            
            this.dt_debut_sejour = dt_debut_sejour;
            this.dt_fin_sejour = dt_fin_sejour;
                           
        }

        public void SetProfil(Profil profil)
        {
            this.profil = profil;
        }

        public void SetProfil(string mdp, DateTime dt_inscription, DateTime dt_validite)
        {
            this.profil = new Profil(mdp, dt_inscription, dt_validite);
        }
    }
}
