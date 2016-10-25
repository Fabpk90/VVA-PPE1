using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVA_PPE1.Actor;
using VVA_PPE1.Modele;

namespace VVA_PPE1.Activity
{
    
   public class Activite
    {
        private string code;

        /*
         * TO DO: voir pour le noencadrant comment faire pour trouver 
         * un truc opti pour avoir ses infos
         */

        private int noEncadrant;
        private string identiteEncadrant;  //nom + prenom

        private DateTime date;
        private TimeSpan hrRDV;

        private float prix;

        private TimeSpan hrDebut;
        private TimeSpan hrFin;

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

        public Activite_Etat Etat
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

        public TimeSpan HrRDV
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

        public TimeSpan HrDebut
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

        public TimeSpan HrFin
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

        public Activite(string code, DateTime date, int noEncadrant, TimeSpan hrRDV, float prix, TimeSpan hrDebut, TimeSpan hrFin, DateTime dateAnnulation, string objectif)
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

        public override string ToString()
        {
            return code + " " + date.ToShortDateString();
        }
        
        public string getDescription()
        {
            string desc = "";

            desc += "Code : " + code + "\n";
            desc += "Date :" + date.ToShortDateString() + "\n";
            desc += "Heure de rdv :" + hrRDV + "\n";

            desc += "Prix :" + prix + "\n";

            desc += "Heure de début :" +hrDebut + "\n";
            desc += "Heure de fin :" + hrFin + "\n";

            desc += "Objectif :" + objectif + "\n";
            desc += "Etat :" + etat + "\n";

            return desc;
        }
    }
}
