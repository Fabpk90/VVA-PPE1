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

        public string Remarque
        {
            get
            {
                return remarque;
            }

            set
            {
                remarque = value;
            }
        }

        public DateTime DateAnnulation
        {
            get
            {
                return dateAnnulation;
            }

            set
            {
                dateAnnulation = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

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

        public Inscription(int numero, DateTime date, DateTime dateAnnulation, string remarque)
        {
            this.numero = numero;

            this.date = date;
            this.dateAnnulation = dateAnnulation;
            this.remarque = remarque;
        }

    }
}
