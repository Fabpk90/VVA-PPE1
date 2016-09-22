using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{
   public class Inscrit
    {
        private int numero;

        private string nom;
        private string prenom;

        private DateTime dtNaissance;

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public DateTime DtNaissance
        {
            get
            {
                return dtNaissance;
            }

            set
            {
                dtNaissance = value;
            }
        }

        public Inscrit(string nom, string prenom, DateTime dtNaissance, int numero)
        {
            this.nom = nom;
            this.prenom = prenom;

            this.numero = numero;

            this.dtNaissance = dtNaissance;
        }
    }
}
