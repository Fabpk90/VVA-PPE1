using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVA_PPE1.Actor;

namespace VVA_PPE1.Activity
{
    
   public class Activite
    {
        private string code;

        private int noEncadrant;

        private DateTime date;
        private DateTime hrRDV;

        private float prix;

        private DateTime hrDebut;
        private DateTime hrFin;

        private DateTime dateAnnulation;

        private string objectif;

        private Activite_Etat etat;

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

        public int NoEncadrant
        {
            get
            {
                return noEncadrant;
            }

            set
            {
                noEncadrant = value;
            }
        }

        internal Activite_Etat Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }

        public Activite(string code, DateTime date, int noEncadrant, DateTime hrRDV, float prix, DateTime hrDebut, DateTime hrFin, DateTime dateAnnulation, string objectif)
        {

            this.code = code;
            this.date = date;

            this.noEncadrant = noEncadrant;

            this.hrRDV = hrRDV;

            this.prix = prix;

            this.hrDebut = hrDebut;
            this.hrFin = hrFin;

            this.dateAnnulation = dateAnnulation;

            this.objectif = objectif;

            etat = new Activite_Etat();
        }

        public Activite()
        {
        }
    }
}
