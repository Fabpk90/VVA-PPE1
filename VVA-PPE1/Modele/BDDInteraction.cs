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

        /*
         *  execute non query != 0 == erreur
         * */

    class BDDInteraction
    {
        public static string chConn = "server=127.0.0.1;uid=root;pwd=;database=act_vva_ppe2";

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

                
            return getEncadrant(query);
          
        }

        public static Encadrant getEncadrant(int noEnc)
        {
            string query = "SELECT * FROM ENCADRANT AS E, PROFIL AS P WHERE NOENCADRANT = "+noEnc;


            return getEncadrant(query);
        }

        internal static Encadrant getEncadrant(string query)
        {
            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            Encadrant enc = null;

            //check si il y a un résultat
            if (rdr.Read())
            {
                enc = new Encadrant(rdr.GetInt32("NOENCADRANT"), rdr.GetString("NOMENCADRANT"), rdr.GetString("PRENOMENCADRANT"),
                    rdr.GetString("ADRMAILENCADRANT"), rdr.GetString("ETATSERVICE"), DateTime.Parse(rdr.GetString("DATENAISENCADRANT"))
                    , rdr.GetString("MDP"), DateTime.Parse(rdr.GetString("DATEINSPRO")), DateTime.Parse(rdr.GetString("DATEVALIDITE")));
            }
            rdr.Close();

            return enc;

        }

        /// <summary>
        /// Check if the loisant is laready inscrit, then inscrit the loisant
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <param name="loi"></param>
        /// <param name="enc"></param>
        /// <param name="remarque"></param>
        /// <param name="nbInscription"></param>
        /// <returns></returns>
        public static bool inscription(Activite selectedItem, Loisant loi, Encadrant enc,string remarque, out int nbInscription)
        {

            string query = "SELECT NOLOISANT FROM INSCRIPTION"
                + " WHERE NOLOISANT = " + loi.Numero + " AND CODEANIM = '" + selectedItem.Code + "' AND DATEACT = '" + selectedItem.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'"
                + " AND DATE_ANNULATION IS NULL";

            cmd.CommandText = query;

            if (cmd.ExecuteNonQuery() != 0)
            {
                nbInscription = -1;
                return false;
            }

            
            nbInscription = getInscriptionNb(loi);

             query = "INSERT INTO INSCRIPTION(NOLOISANT, NOINSCRIP, CODEANIM, DATEACT, DATEINSCRIP, REMARQUEINSCRIP)"
                + " VALUES('" + loi.Numero + "', " + (nbInscription + 1) + ", '" + selectedItem.Code + "', "
                + " '" + selectedItem.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', NOW(), '')"; 

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static bool cancelInscription(Loisant loi, int numInscription)
        {
            string query = "UPDATE INSCRIPTION "
                + " SET DATE_ANNULATION = NOW() WHERE NOLOISANT = " + loi.Numero + " AND NOINSCRIP = " + numInscription;

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static int getInscriptionNb(Loisant loi)
        {
            string query = "SELECT MAX(NOINSCRIP) AS NBINSCRIP FROM INSCRIPTION"
                + " WHERE NOLOISANT = " + loi.Numero;

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            rdr.Read();

            int inscripNb = rdr.GetInt32("NBINSCRIP");
            rdr.Close();

            return inscripNb;
        }

        /// <summary>
        /// Affecte les encadrants aux activités
        /// </summary>
        /// <param name="selectedAct"></param>
        /// <param name="listEnc"></param>
        /// <returns>0 OK -1 already planned -2 query problem</returns>
        public static bool setPlanning(Activite selectedAct, List<Encadrant> listEnc)
        {
            string query = ""; 

            foreach (Encadrant enc in listEnc)
            {
                if (!checkIfEncPlanned(enc, selectedAct))
                {
                    query = "INSERT INTO PLANNING(NOENCADRANT, CODEANIM, DATEACT)"
                    + "VALUES( " + enc.Numero + ", '" + selectedAct.Code + "', '" + selectedAct.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "') ";

                    cmd.CommandText = query;

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Probléme de base de données");
                        return false;
                    }
                        
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Encadrant " + enc.getDescription() + " \ndéjà affecté!");
                    return false;
                }
            }

            System.Windows.Forms.MessageBox.Show("Activité plannifiée");
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enc"></param>
        /// <param name="act"></param>
        /// <returns>whether the Enc is affected on this act</returns>
        public static bool checkIfEncPlanned(Encadrant enc, Activite act)
        {
            string query = "SELECT NOENCADRANT FROM PLANNING "
               +" WHERE NOENCADRANT = "+enc.Numero+" AND CODEANIM = '"+act.Code+"' AND DATEACT = '"+act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            bool found = rdr.Read();
            rdr.Close();

            if(!found)
            {
                return enc.Numero != act.NoEncadrant ? false : true;
            }

            return found;    
        }

        public static List<Encadrant> getEncadrants()
        {
            string query = "SELECT * FROM ENCADRANT AS E, PROFIL AS P WHERE P.USER = E.USER";

            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();

            Encadrant enc;

            List<Encadrant> listEnc = new List<Encadrant>();

            while(rdr.Read())
            {
                enc = new Encadrant(rdr.GetInt32("NOENCADRANT"), rdr.GetString("NOMENCADRANT"), rdr.GetString("PRENOMENCADRANT"),
                   rdr.GetString("ADRMAILENCADRANT"), rdr.GetString("ETATSERVICE"), DateTime.Parse(rdr.GetString("DATENAISENCADRANT"))
                   , rdr.GetString("MDP"), DateTime.Parse(rdr.GetString("DATEINSPRO")), DateTime.Parse(rdr.GetString("DATEVALIDITE")));

                listEnc.Add(enc);
            }

            rdr.Close();

            return listEnc;
        }

        public static void Deconnection()
        {
            if(rdr != null)
                rdr.Close();

            conn.Close();
        }

        public static Loisant getLoisant(string user, string mdp)
        {
            string query = "SELECT * FROM LOISANT AS L, PROFIL AS P"
               + " WHERE L.USER = P.USER AND P.USER = '" + user + "' AND P.MDP = '" + mdp + "'";

            Loisant loi = new Loisant();

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                loi = new Loisant(rdr.GetInt32("NOLOISANT"), rdr.GetString("NOMLOISANT"), rdr.GetString("PRENOMLOISANT"),
                    rdr.GetDateTime("DATENAISLOISANT"), rdr.GetDateTime("DATEFINSEJOUR"), rdr.GetDateTime("DATEDEBSEJOUR"));
            }

            rdr.Close();

            return loi;
        }

        public static Loisant getLoisant(string user)
        {
            string query = "SELECT * FROM LOISANT AS L, PROFIL AS P"
               + " WHERE L.USER = P.USER AND P.USER = '" + user + "'";

            Loisant loi = new Loisant();

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                loi = new Loisant(rdr.GetInt32("NOLOISANT"), rdr.GetString("NOMLOISANT"), rdr.GetString("PRENOMLOISANT"),
                    rdr.GetDateTime("DATENAISLOISANT"), rdr.GetDateTime("DATEFINSEJOUR"), rdr.GetDateTime("DATEDEBSEJOUR"));
            }

            rdr.Close();

            return loi;
        }

        public static List<Loisant> getLoisants()
        {
            string query = "SELECT * FROM LOISANT AS L, PROFIL AS P"
              + " WHERE L.USER = P.USER ";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            List<Loisant> listLoisant = new List<Loisant>();

            while (rdr.Read())
            {
                Loisant loi = new Loisant(rdr.GetInt32("NOLOISANT"), rdr.GetString("NOMLOISANT"), rdr.GetString("PRENOMLOISANT"),
                    rdr.GetDateTime("DATENAISLOISANT"), rdr.GetDateTime("DATEFINSEJOUR"), rdr.GetDateTime("DATEDEBSEJOUR"));

                listLoisant.Add(loi);
            }

            rdr.Close();

            return listLoisant;
        }

        public static List<Loisant> getLoisantInscrit(Activite act)
        {
            string query = "SELECT L.NOLOISANT, NOMLOISANT, PRENOMLOISANT, DATENAISLOISANT, DATEFINSEJOUR, DATEDEBSEJOUR FROM LOISANT AS L, INSCRIPTION AS I"
                + " WHERE L.NOLOISANT = I.NOLOISANT AND CODEANIM = '"+act.Code+"' AND DATEACT = '"+act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff")+"' AND I.DATE_ANNULATION IS NULL";

            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();

            List<Loisant> listLoi = new List<Loisant>();

            while(rdr.Read())
            {
                Loisant loi = new Loisant(rdr.GetInt32("NOLOISANT"), rdr.GetString("NOMLOISANT"), rdr.GetString("PRENOMLOISANT"),
                    rdr.GetDateTime("DATENAISLOISANT"), rdr.GetDateTime("DATEFINSEJOUR"), rdr.GetDateTime("DATEDEBSEJOUR"));

                listLoi.Add(loi);
            }

            rdr.Close();

            return listLoi;
        }

        public static List<Animation> getAnimations()
        {
            string query = "SELECT * FROM ANIMATION AS A, TYPE_ANIM AS T WHERE A.CODETYPEANIM = T.CODETYPEANIM"+
                " AND A.DATEVALIDITEANIM > NOW()";

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

                anim.Duree = rdr.GetInt32("DUREEANIM");
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
                + "VALUES('"+anim.Code+ "', '" + anim.AnimType.Code + "','" + anim.Nom.Replace('\'', ' ') + "','" + anim.DtCreation.ToString("yyyy-MM-dd HH:mm:ss.fff") +
                "', '" + anim.DtValidite.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', " + anim.Duree.ToString().Replace(",", ".") + ", " + anim.LimiteAge + ", " + anim.Tarif.ToString().Replace(",", ".") +
                ", " + anim.NbPlace + ", '" + anim.Desc.Replace('\'', ' ') + "', '" + anim.Commentaire.Replace('\'', ' ') + "', " + (int) anim.Difficulte + ")";

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;       
        }

        public static bool checkIfAnimationExists(Animation anim)
        {
            string query = "SELECT CODEANIM FROM ANIMATION WHERE CODEANIM = '" + anim.Code + "'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            bool Exists = rdr.Read();
            rdr.Close();

            return Exists;
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
            string query = "SELECT * FROM ACTIVITE AS A, ETAT_ACT AS E, ANIMATION AS AN"
              + " WHERE A.CODEETATACT = E.CODEETATACT " +
              "AND A.CODEANIM = AN.CODEANIM AND AN.DATEVALIDITEANIM >= NOW()";

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
                act.HrRDV = (TimeSpan) rdr["HRRDVACT"];
                act.Prix = rdr.GetFloat("PRIXACT");

                act.HrDebut = (TimeSpan)rdr["HRDEBUTACT"];
                act.HrFin = (TimeSpan)rdr["HRFINACT"];

                if (!rdr.IsDBNull(8))// Date annulation is null?
                    act.DateAnnulation = rdr.GetDateTime("DATEANNULATIONACT");
                else
                    act.DateAnnulation = new DateTime();

               act.Objectif = rdr.GetString("OBJECTIFACT");

                act.Etat = new Activite_Etat(rdr.GetString("CODEETATACT"), rdr.GetString("NOMETATACT"));

                listAct.Add(act);
            }

            rdr.Close();

            return listAct;
        }

        public static bool cancelActivite(Activite act)
        {
            string query = "UPDATE ACTIVITE SET DATEANNULATIONACT = NOW() "
                + "WHERE CODEANIM = '" + act.Code + "' AND DATEACT = '" + act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'";

            cmd.CommandText = query;

            if (cmd.ExecuteNonQuery() != 0)
            {
               query = "UPDATE INSCRIPTION SET DATE_ANNULATION = NOW() "
                + "WHERE CODEANIM = '" + act.Code + "' AND DATEACT = '" + act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'";

                cmd.CommandText = query;

                return cmd.ExecuteNonQuery() != 0 ? true : false;
            }
            else
                return false;
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

        public static bool checkIfActiviteExists(Activite act)
        {
            string query = "SELECT CODEANIM FROM ACTIVITE WHERE DATEACT = '" + act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            bool Exists = rdr.Read();
            rdr.Close();

            return Exists ? true : false;
        }

        public static bool addActivite(Activite act)
        {
            string query = "INSERT INTO ACTIVITE(CODEANIM, DATEACT, NOENCADRANT, CODEETATACT, HRRDVACT, PRIXACT, HRDEBUTACT, HRFINACT, OBJECTIFACT)"
              + "VALUES('" + act.Code + "', '" + act.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', '" + act.NoEncadrant + "','" + act.Etat.Code + "', '" + act.HrRDV + "',"
             + " " + act.Prix.ToString().Replace(',', '.') + ", '" + act.HrDebut + "', '" + act.HrFin + "', '" + act.Objectif.Replace('\'', ' ') + "')";


            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static bool modifyActivite(Activite act)
        {
            string query = "UPDATE ACTIVITE"
                + " SET NOENCADRANT = '" + act.NoEncadrant+"'"
                + " , CODEETATACT = '" + act.Etat.Code + "' , HRRDVACT = '" + act.HrRDV + "' , PRIXACT = " + act.Prix.ToString().Replace(',', '.')
                + " , HRDEBUTACT = '" + act.HrDebut+ "', HRFINACT = '" + act.HrFin.ToString() + "'"
                + " , DATEANNULATIONACT = '" + act.DateAnnulation.ToString("yyyy-MM-dd") + "', OBJECTIFACT = '" + act.Objectif + "'"
                + "WHERE CODEANIM = '" + act.Code + "' AND DATEACT = '" + act.Date.ToString("yyyy-MM-dd") + "'";


            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        public static List<Activite> getPlanningAnim(Animation anim)
        {
            //get act + etatAct depending on anim 
            string query = "SELECT * FROM ACTIVITE AS A, ANIMATION AS AN, ETAT_ACT AS E"
                + " WHERE A.CODEANIM = '" + anim.Code + "' AND A.CODEANIM = AN.CODEANIM AND A.CODEETATACT = E.CODEETATACT "
                + " AND DATEANNULATIONACT IS NULL";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            List<Activite> listAct = new List<Activite>();

            Activite act = new Activite();

            while(rdr.Read())
            {
                act = new Activite();

                act.Code = rdr.GetString("CODEANIM");
                act.Date = rdr.GetDateTime("DATEACT");

                act.NoEncadrant = rdr.GetInt32("NOENCADRANT");
                act.HrRDV = (TimeSpan)rdr["HRRDVACT"];
                act.Prix = rdr.GetFloat("PRIXACT");

                act.HrDebut = (TimeSpan)rdr["HRDEBUTACT"];
                act.HrFin = (TimeSpan)rdr["HRFINACT"];

                if (!rdr.IsDBNull(8))// Date annulation is null?
                    act.DateAnnulation = rdr.GetDateTime("DATEANNULATIONACT");
                else
                    act.DateAnnulation = new DateTime();

                act.Objectif = rdr.GetString("OBJECTIFACT");

                act.Etat = new Activite_Etat(rdr.GetString("CODEETATACT"), rdr.GetString("NOMETATACT"));

                listAct.Add(act);

            }

            rdr.Close();

            return listAct;
        }

        public static int getNbPlace(Animation anim)
        {
            string query = "SELECT (NBREPLACEANIM - COUNT(NOINSCRIP)) AS NBPLACESLIBRES FROM ANIMATION AS A, INSCRIPTION AS I"
                + " WHERE A.CODEANIM = '"+anim.Code+"' AND A.CODEANIM = I.CODEANIM AND I.DATE_ANNULATION IS NULL"
                +" GROUP BY A.CODEANIM";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();

            int nbPlace = -1;

            if (rdr.Read())
                nbPlace = rdr.GetInt32("NBPLACESLIBRES");

            rdr.Close();

            return nbPlace;
        }

        /// <summary>
        /// Ajoute un type d'animation après avoir mis les params en maj
        /// </summary>
        /// <param name="codeType"></param>
        /// <param name="nomType"></param>
        /// <returns>false if fails</returns>
        public static bool addTypeAnim(string codeType, string nomType)
        {
            codeType = codeType.ToUpper();
            nomType = nomType.ToUpper();

            string query = "INSERT INTO `act_vva_ppe2`.`type_anim` (`CODETYPEANIM`, `NOMTYPEANIM`) VALUES ('" + codeType + "', '" + nomType + "');";

            cmd.CommandText = query;

            return cmd.ExecuteNonQuery() != 0 ? false : true;
        }

        public static bool checkIfTypeAnimExists(string codeType)
        {
            codeType = codeType.ToUpper();

            string query = "SELECT * FROM TYPE_ANIM WHERE CODETYPEANIM = '" + codeType + "'";

            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();

            bool ok = rdr.Read();
            rdr.Close();

            return ok;
        }
    }
}
