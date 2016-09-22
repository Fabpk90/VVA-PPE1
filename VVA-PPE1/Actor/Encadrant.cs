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

        public Encadrant(int numero, string nom, string prenom, string mail, string etatService, DateTime dtNaissance) : base(nom, prenom, dtNaissance, numero)
        {
            this.etatService = etatService;
            this.mail = mail;
        }
    }
}
