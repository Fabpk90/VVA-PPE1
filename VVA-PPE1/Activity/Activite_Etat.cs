using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
    class Activite_Etat
    {
        private string code;
        private string nom;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
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

        public Activite_Etat()
        {
        }

        public Activite_Etat(string code, string nom)
        {
            this.code = code;
            this.nom = nom;
        }

        public override string ToString()
        {
            return nom;
        }

    }
}
