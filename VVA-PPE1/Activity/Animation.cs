﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
   public enum EdiffAnim
    {
        FACILE = 0,
        NORMAL,
        DIFFICILE
    }

  public  class Animation
    {
        private string codeAnim;

        private string nom;

        private DateTime dtCreation;
        private DateTime dtValidite;

        //durée en minutes
        private int duree;

        private int limiteAge;

        private float tarif;
        private int nbPlace;

        private string desc;
        private string commentaire;

        private EdiffAnim difficulte;

        private Animation_Type animType;

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

        public DateTime DtCreation
        {
            get
            {
                return dtCreation;
            }

            set
            {
                dtCreation = value;
            }
        }

        public DateTime DtValidite
        {
            get
            {
                return dtValidite;
            }

            set
            {
                dtValidite = value;
            }
        }

        public int LimiteAge
        {
            get
            {
                return limiteAge;
            }

            set
            {
                limiteAge = value;
            }
        }

        public float Tarif
        {
            get
            {
                return tarif;
            }

            set
            {
                tarif = value;
            }
        }

        public int NbPlace
        {
            get
            {
                return nbPlace;
            }

            set
            {
                nbPlace = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public int Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public string Code
        {
            get
            {
                return codeAnim;
            }

            set
            {
                codeAnim = value;
            }
        }

        internal Animation_Type AnimType
        {
            get
            {
                return animType;
            }

            set
            {
                animType = value;
            }
        }

        internal EdiffAnim Difficulte
        {
            get
            {
                return difficulte;
            }

            set
            {
                difficulte = value;
            }
        }

        public Animation() { }

        public Animation(string code, string nom, DateTime dtCreation, DateTime dtValidite, int duree, int limiteAge, float tarif, int nbPlace, string desc, string commentaire, EdiffAnim difficulte)
        {
            this.codeAnim = code;

            this.nom = nom;

            this.dtCreation = dtCreation;
            this.dtValidite = dtValidite;

            this.duree = duree;

            this.limiteAge = limiteAge;
            this.tarif = tarif;

            this.nbPlace = nbPlace;

            this.desc = desc;
            this.commentaire = commentaire;

            this.difficulte = difficulte;

            animType = new Animation_Type();
        }

        public Animation(string code, string nom, DateTime dtCreation, DateTime dtValidite, int duree, int limiteAge, float tarif, int nbPlace, string desc, 
            string commentaire, EdiffAnim difficulte, string codeAnim, string nomAnim) 
            : this(code, nom, dtCreation, dtValidite, duree, limiteAge, tarif, nbPlace, desc, commentaire, difficulte)
        {
            animType = new Animation_Type(codeAnim, nomAnim);
        }


        public override string ToString()
        {
            return nom;
        }

        public string getDescription()
        {
            string desc = "";

            desc += "Code :" + this.codeAnim + "\n";
            desc += "Nom :" + this.nom + "\n";

            desc += "Date creation :" + this.dtCreation.ToLongDateString() + "\n";
            desc += "Date validite :" + this.dtValidite.ToLongDateString() + "\n";

            desc += "Duree :" + this.duree + " (min) \n";
            desc += "Limite d'âge :" + this.limiteAge + " ans \n";
            desc += "Description :" + this.desc + " \n";
            desc += "Type :" + this.animType.Nom + "\n";
            desc += "Prix :" + this.tarif + " \n";

            desc += "Nombres de place :" + this.nbPlace + "\n";

            desc += "Difficulté :";

            switch(this.difficulte)
            {
                case EdiffAnim.FACILE:
                    desc += "facile";
                    break;

                case EdiffAnim.NORMAL:
                    desc += "normal";
                    break;

                case EdiffAnim.DIFFICILE:
                    desc += "difficile";
                    break;
            }

            desc += "\n";

            return desc;
        }
    }
}
