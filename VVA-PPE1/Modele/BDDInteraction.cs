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
            string query = "SELECT * FROM ANIMATION";

            cmd.CommandText = query;

            rdr = cmd.ExecuteReader();
            

            List<Animation> listAnim = new List<Animation>();

            Animation anim = new Animation();
     
            while (rdr.Read())
            {
                anim.Nom = rdr.GetString("NOMANIM");

                anim.DtCreation = DateTime.Parse(rdr.GetString("DATECREATIONANIM"));
                anim.DtValidite = DateTime.Parse(rdr.GetString("DATEVALIDITEANIM"));

                anim.Desc = rdr.GetString("DESCRIPTANIM");
                anim.Commentaire = rdr.GetString("COMMENTANIM");

                listAnim.Add(anim);
            }

            return listAnim;
        }
    }
}
