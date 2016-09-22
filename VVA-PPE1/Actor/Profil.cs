using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA_PPE1.Actor
{

    enum Etype_profil
    {
        LOISANT = 0,
        ENCADRANT,
        ADMIN
    }

    class Profil
    {
        private string mdp;

        private DateTime dt_inscription;
        private DateTime dt_validite;

        private Etype_profil type_profil;

        public Profil(string mdp, DateTime dt_inscription, DateTime dt_validite)
        {
            this.mdp = mdp;

            this.dt_inscription = dt_inscription;
            this.dt_validite = dt_validite;
        }
    }
}
