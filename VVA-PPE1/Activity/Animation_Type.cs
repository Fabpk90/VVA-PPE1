using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
    class Animation_Type
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

        public Animation_Type(string code, string nom)
        {
            this.code = code;
            this.nom = nom;
        }

        public Animation_Type()
        {
            code = "";
        }

        public override string ToString()
        {
            return code;
        }
    }
}
