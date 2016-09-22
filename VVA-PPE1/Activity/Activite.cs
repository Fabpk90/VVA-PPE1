using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVA_PPE1.Actor;

namespace VVA_PPE1.Activity
{
    
    class Activite
    {
        private DateTime date;
        private DateTime hrRDV;

        private float prix;

        private DateTime hrDebut;
        private DateTime hrFin;

        private DateTime dateAnnulation;

        private string objectif;

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

        public DateTime HrRDV
        {
            get
            {
                return hrRDV;
            }

            set
            {
                hrRDV = value;
            }
        }

        public float Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public DateTime HrDebut
        {
            get
            {
                return hrDebut;
            }

            set
            {
                hrDebut = value;
            }
        }

        public DateTime HrFin
        {
            get
            {
                return hrFin;
            }

            set
            {
                hrFin = value;
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

        public string Objectif
        {
            get
            {
                return objectif;
            }

            set
            {
                objectif = value;
            }
        }

        public Activite(DateTime date, DateTime hrRDV, float prix, DateTime hrDebut, DateTime hrFin, DateTime dateAnnulation, string objectif)
        {
            this.date = date;
            this.hrRDV = hrRDV;

            this.prix = prix;

            this.hrDebut = hrDebut;
            this.hrFin = hrFin;

            this.dateAnnulation = dateAnnulation;

            this.objectif = objectif;
        }
    }
}
