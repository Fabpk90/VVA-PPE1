using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{

    enum EtypeProfil
    {
        LOISANT = 0,
        ENCADRANT,
        ADMIN
    }

    class Profil
    {
        private string mdp;

        private DateTime dtInscription;
        private DateTime dtValidite;

        private EtypeProfil EProfil;

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;
            }
        }

        public DateTime DtInscription
        {
            get
            {
                return dtInscription;
            }

            set
            {
                dtInscription = value;
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

        internal EtypeProfil EProfil1
        {
            get
            {
                return EProfil;
            }

            set
            {
                EProfil = value;
            }
        }

        public Profil(string mdp, DateTime dtInscription, DateTime dtValidite)
        {
            this.mdp = mdp;

            this.dtInscription = dtInscription;
            this.dtValidite = dtValidite;
        }

        public Profil(string mdp, DateTime dtInscription, DateTime dtValidite, EtypeProfil Etype) : 
            this(mdp, dtInscription, dtValidite)
        {
            this.EProfil = Etype;
        }
    }
}
