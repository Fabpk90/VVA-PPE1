using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Activity
{
    enum EdiffAnim
    {
        FACILE = 0,
        NORMAL,
        DIFFICILE
    }

    class Animation
    {
        private string code;

        private string nom;

        private DateTime dtCreation;
        private DateTime dtValidite;

        //durée en minutes
        private uint duree;

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

        public Animation() { }

        public Animation(string code, string nom, DateTime dtCreation, DateTime dtValidite, int limiteAge, float tarif, int nbPlace, string desc, string commentaire, EdiffAnim difficulte)
        {
            this.code = code;

            this.nom = nom;

            this.dtCreation = dtCreation;
            this.dtValidite = dtValidite;

            this.limiteAge = limiteAge;
            this.tarif = tarif;

            this.nbPlace = nbPlace;

            this.desc = desc;
            this.commentaire = commentaire;

            this.difficulte = difficulte;

            animType = new Animation_Type();
        }

        public Animation(string code, string nom, DateTime dtCreation, DateTime dtValidite, int limiteAge, float tarif, int nbPlace, string desc, 
            string commentaire, EdiffAnim difficulte, int codeAnim, string nomAnim) 
            : this(code, nom, dtCreation, dtValidite, limiteAge, tarif, nbPlace, desc, commentaire, difficulte)
        {
            animType = new Animation_Type(codeAnim, nomAnim);
        }
    }
}
