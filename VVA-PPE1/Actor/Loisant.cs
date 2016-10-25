using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
  public class Loisant : Inscrit
    {
        private Profil profil;

        private DateTime dtDebutSejour;
        private DateTime dtFinSejour;

        internal Profil Profil
        {
            get
            {
                return profil;
            }

            set
            {
                profil = value;
            }
        }

        public DateTime DtDebutSejour
        {
            get
            {
                return dtDebutSejour;
            }

            set
            {
                dtDebutSejour = value;
            }
        }

        public DateTime DtFinSejour
        {
            get
            {
                return dtFinSejour;
            }

            set
            {
                dtFinSejour = value;
            }
        }

        public Loisant()
        {
            base.Nom = "";
        }

        public Loisant(int numero, string nom, string prenom, DateTime dtNaissance, DateTime dtDebutSejour, DateTime dtFinSejour) 
            : base(nom, prenom, dtNaissance, numero)
        {
            this.dtDebutSejour = dtDebutSejour;
            this.dtFinSejour = dtFinSejour;
        }

        public void SetProfil(Profil profil)
        {
            this.profil = profil;
        }

        public void SetProfil(string mdp, DateTime dtInscription, DateTime dtValidite)
        {
            this.profil = new Profil(mdp, dtInscription, dtValidite);
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
