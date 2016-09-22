using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
    public class Inscription
    {
        private int numero;

        private DateTime date;
        private DateTime dateAnnulation;

        private string remarque;


        public Inscription(int numero, DateTime date, DateTime dateAnnulation)
        {
            this.numero = numero;

            this.date = date;
            this.dateAnnulation = dateAnnulation;
        }

    }
}
