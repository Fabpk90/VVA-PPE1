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
        private string etat_service;


        public Encadrant(string nom, string prenom, string mail, string etat_service, DateTime dt_naissance) : base(nom, prenom, dt_naissance)
        {
            this.etat_service = etat_service;
            this.mail = mail;
        }
    }
}
