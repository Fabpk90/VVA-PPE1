using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
    class Encadrant : Inscrit
    {

        private string mail;
        private string etatService;

        private Profil profil;

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string EtatService
        {
            get
            {
                return etatService;
            }

            set
            {
                etatService = value;
            }
        }

        public Encadrant(int numero, string nom, string prenom, string mail, string etatService, DateTime dtNaissance, 
            string mdpProfil, DateTime dtInscriptionProfil, DateTime dtValiditeProfil) 
            : base(nom, prenom, dtNaissance, numero)
        {
            this.etatService = etatService;
            this.mail = mail;

            profil = new Profil(mdpProfil, dtInscriptionProfil, dtValiditeProfil);
        }

        public Encadrant()
        {
            this.Numero = -1;
        }
    }
}
