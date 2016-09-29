using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
    class Animation_Type
    {
        private int code;
        private string nom;

        public Animation_Type(int code, string nom)
        {
            this.code = code;
            this.nom = nom;
        }

        public Animation_Type()
        {
            code = -1;
        }
    }
}
