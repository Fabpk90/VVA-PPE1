using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using VVA_PPE1.Actor;
using VVA_PPE1.Activity;

namespace VVA_PPE1.Modele
{
    /*
     * 
     * TO DO: SQL INJECTION!
     * 
     */


    class BDDInteraction
    {
        public static string chConn = "server=127.0.0.1;uid=root;pwd=;database=act_vva";

        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;
        private static MySqlDataReader rdr = null;

        public static bool Connection()
        {
            conn = new MySqlConnection(chConn);
            conn.Open();

            cmd = conn.CreateCommand();

            return conn.State == System.Data.ConnectionState.Open ? true : false;
        }

        public static Encadrant getEncadrant(string user, string mdp)
        {
            string query = "SELECT * FROM ENCADRANT AS E, PROFIL AS P WHERE P.USER = '"+user+"' AND E.USER = P.USER AND P.MDP = '"+mdp+"'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            Encadrant enc = new Encadrant();

            //check si il y a un résultat
            if(rdr.Read())
            {
                enc = new Encadrant(rdr.GetInt32("NOENCADRANT"), rdr.GetString("NOMENCADRANT"), rdr.GetString("PRENOMENCADRANT"),
                    rdr.GetString("ADRMAILENCADRANT"), rdr.GetString("ETATSERVICE"), DateTime.Parse(rdr.GetString("DATENAISENCADRANT"))
                    , rdr.GetString("MDP"), DateTime.Parse(rdr.GetString("DATEINSPRO")), DateTime.Parse(rdr.GetString("DATEVALIDITE")) );

                rdr.Close();

                return enc;


            }

            rdr.Close();       
            return enc;
          
        }

       public static void Deconnection()
        {
            rdr.Close();
            conn.Close();
        }

        public static Loisant getLoisant()
        {
            string query = "SELECT * FROM";

            return new Loisant();
        }

        public static List<Animation> getAnimations()
        {
            string query = "SELECT * FROM ANIMATION AS A, TYPE_ANIM AS T WHERE A.CODETYPEANIM = T.CODETYPEANIM";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();
            

            List<Animation> listAnim = new List<Animation>();

            Animation anim = new Animation();
            Animation_Type animType = new Animation_Type();
     
            while (rdr.Read())
            {              

                anim.Code = rdr.GetString("CODEANIM");
                anim.Nom = rdr.GetString("NOMANIM");

                anim.DtCreation = DateTime.Parse(rdr.GetString("DATECREATIONANIM"));
                anim.DtValidite = DateTime.Parse(rdr.GetString("DATEVALIDITEANIM"));

                anim.Duree = rdr.GetUInt32("DUREEANIM");
                anim.LimiteAge = rdr.GetInt32("LIMITEAGE");
                anim.Tarif = rdr.GetFloat("TARIFANIM");

                anim.NbPlace = rdr.GetInt32("NBREPLACEANIM");             

                anim.Desc = rdr.GetString("DESCRIPTANIM");
                anim.Commentaire = rdr.GetString("COMMENTANIM");

                anim.Difficulte = (EdiffAnim)rdr.GetInt32("DIFFICULTEANIM");

                animType.Code = rdr.GetString("CODETYPEANIM");
                animType.Nom = rdr.GetString("NOMTYPEANIM");

                anim.AnimType = animType;             

                listAnim.Add(anim);

                anim = new Animation();
                animType = new Animation_Type();
            }

            rdr.Close();

            return listAnim;
        }

        public static List<Animation_Type> getAnimType()
        {
            string query = "SELECT * FROM TYPE_ANIM";

            cmd.CommandText = query;

            rdr.Close();

            rdr = cmd.ExecuteReader();


            List<Animation_Type> listAnimType = new List<Animation_Type>();

            Animation_Type animType = new Animation_Type();

            while (rdr.Read())
            {
                animType = new Animation_Type();

                animType.Code = rdr.GetString("CODETYPEANIM");
                animType.Nom = rdr.GetString("NOMTYPEANIM");
                
                listAnimType.Add(animType);
            }

            rdr.Close();

            return listAnimType;
        }

        public static bool addAnimation(Animation anim)
        {
            string query = "INSERT INTO ANIMATION(CODEANIM, CODETYPEANIM, NOMANIM, DATECREATIONANIM, DATEVALIDITEANIM"
                +", DUREEANIM, LIMITEAGE, TARIFANIM, NBREPLACEANIM, DESCRIPTANIM, COMMENTANIM, DIFFICULTEANIM) "
                + "VALUES('"+anim.Code+ "', '" + anim.AnimType.Code + "','" + anim.Nom + "','" + anim.DtCreation.ToString("yyyy-MM-dd HH:mm:ss.fff") +
                "', '" + anim.DtValidite.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', " + anim.Duree.ToString().Replace(",", ".") + ", " + anim.LimiteAge + ", " + anim.Tarif.ToString().Replace(",", ".") +
                ", " + anim.NbPlace + ", '" + anim.Desc + "', '" + anim.Commentaire + "', " + (int) anim.Difficulte + ")";

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;       
        }

        public static bool isAnimationExists(Animation anim)
        {
            string query = "SELECT CODEANIM FROM ANIMATION WHERE CODEANIM = '" + anim.Code + "'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            bool Exists = rdr.Read();
            rdr.Close();

            return Exists ? true : false;
        }

        public static bool modifyAnimation(Animation newAnim)
        {
            string query = "UPDATE ANIMATION"
               + " SET NOMANIM = '" + newAnim.Nom + "' , DATECREATIONANIM = '" + newAnim.DtCreation.ToString("yyyy-MM-dd HH:mm:ss.fff")+"'"
                + ", DATEVALIDITEANIM = '" + newAnim.DtValidite.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'"
                + " , DUREEANIM = " + newAnim.Duree + " , LIMITEAGE = " + newAnim.LimiteAge + " , TARIFANIM = " + newAnim.Tarif +
                " , NBREPLACEANIM = " + newAnim.NbPlace + " , DESCRIPTANIM = '" + newAnim.Desc + "', COMMENTANIM = '" + newAnim.Commentaire + "', DIFFICULTEANIM = " + (int)newAnim.Difficulte +
                " WHERE CODEANIM = '" + newAnim.Code + "'";

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static List<Activite> getActivites()
        {
            string query = "SELECT * FROM ACTIVITE AS A, ETAT_ACT AS E"
              + " WHERE A.CODEETATACT = E.CODEETATACT";

            cmd.CommandText = query;

            rdr.Close();

            rdr = cmd.ExecuteReader();


            List<Activite> listAct = new List<Activite>();

            Activite act = new Activite();

            while (rdr.Read())
            {
                act = new Activite();

                act.Code = rdr.GetString("CODEANIM");
                act.Date = rdr.GetDateTime("DATEACT");

                act.NoEncadrant = rdr.GetInt32("NOENCADRANT");
                act.HrRDV = rdr.GetDateTime("HRRDVACT");
                act.Prix = rdr.GetFloat("PRIXACT");

                act.HrDebut = rdr.GetDateTime("HRDEBUTACT");
                act.HrFin = rdr.GetDateTime("HRFINACT");

                act.DateAnnulation = rdr.GetDateTime("DATEANNULATIONACT");

                act.Objectif = rdr.GetString("OBJECTIFACT");

                act.Etat = new Activite_Etat(rdr.GetString("CODEETATACT"), rdr.GetString("NOMETATACT"));

                listAct.Add(act);
            }

            rdr.Close();

            return listAct;
        }

        public static List<Activite_Etat> getEtatActivite()
        {
            string query = "SELECT * FROM ETAT_ACT";
            

            cmd.CommandText = query;

            rdr.Close();

            rdr = cmd.ExecuteReader();


            List<Activite_Etat> listAct = new List<Activite_Etat>();

            Activite_Etat act_etat = new Activite_Etat();

            while (rdr.Read())
            {
                act_etat = new Activite_Etat();

                act_etat.Code = rdr.GetString("CODEETATACT");
                act_etat.Nom = rdr.GetString("NOMETATACT");

                listAct.Add(act_etat);
            }



            rdr.Close();

            return listAct;
        }

        public static bool isActiviteExist(Activite act)
        {
            string query = "SELECT CODEANIM FROM ANIMATION WHERE CODEANIM = '" + act.Code + "' AND DATEACT = '"+ act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff")+"'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            bool Exists = rdr.Read();
            rdr.Close();

            return Exists ? true : false;
        }

        public static bool addActivite(Activite act)
        {
            string query = "INSERT INTO ACTIVITE(CODEANIM, DATEACT, NOENCADRANT, CODEETATACT, HRRDVACT, PRIXACT, HRDEBUTACT, HRFINACT, OBJECTIFACT)"
              + "VALUES('" + act.Code + "', '" + act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', " + act.NoEncadrant + ",'" + act.Etat.Code + "', '" + act.HrRDV.ToString("yyyy-MM-dd HH:mm:ss.fff") + "',"
             + " " + act.Prix + ", '" + act.HrDebut.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + act.HrFin.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + act.Objectif + "')";


            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static bool modifyActivite()
        {
            string query = "";

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }
            
    }
}
