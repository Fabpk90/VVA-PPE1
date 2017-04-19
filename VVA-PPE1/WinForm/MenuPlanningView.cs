using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVA_PPE1.Activity;
using VVA_PPE1.Actor;
using VVA_PPE1.Modele;

namespace VVA_PPE1.WinForm
{
    public partial class MenuPlanningView : Form
    {
        private Animation anim;

        private int nbPlace;

        private Loisant loi = null;
        private Encadrant enc = null;
        
        public MenuPlanningView(Animation anim)
        {
            InitializeComponent();

            //checkAct();

            this.anim = anim;

            lblTitle.Text += anim.Nom;

            listBAct.Items.AddRange(BDDInteraction.getPlanningAnim(anim).ToArray());              
        }

        /// <summary>
        /// Menu vu par l'encadrant
        /// </summary>
        /// <param name="anim"></param>
        /// <param name="enc"></param>
        public MenuPlanningView(Animation anim, Encadrant enc) : this(anim)
        {
            btnInscription.Text = "Inscrire un loisant";
            enc = this.enc;
        }
        /// <summary>
        /// Menu vu par le loisant
        /// </summary>
        /// <param name="anim"></param>
        /// <param name="loi"></param>
        public MenuPlanningView(Animation anim, Loisant loi) : this(anim)
        {
            btnInscription.Text = "S'inscire";         

            listBInscrit.Visible = false;
            listBLoisant.Visible = false;

            lblLoisant.Visible = false;
            lblInscrit.Visible = false;
            lblGestLoi.Visible = false;

            btnCancelAct.Visible = false;

            this.loi = loi;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if(nbPlace != 0)
            {
                if(loi != null)
                {
                    inscription(loi);
                }
                else if (listBLoisant.SelectedIndex != -1)
                {
                    inscription((Loisant)listBLoisant.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Séléctionner un loisant avant");
                }
            }
            else
                MessageBox.Show("Ancune place disponible");
        }

        private void inscription(Loisant loi)
        {
            int nbInscription;

            if (BDDInteraction.inscription((Activite)listBAct.SelectedItem, loi, enc, rtRemarque.Text, out nbInscription))
            {
                MessageBox.Show("Loisant inscrit! Numéro de l'inscription: " + nbInscription);

                listBInscrit.Items.Add(loi);
                nbPlace--;
                lblPlaces.Text = "Places disponibles: " + nbPlace;
            }
            else
            {
                if(nbInscription == -1)
                    MessageBox.Show("Le loisant est déjà inscrit");
                else
                    MessageBox.Show("Inscription impossible");
            }
        }

        private void btnCancelAct_Click(object sender, EventArgs e)
        {
            if(listBAct.SelectedIndex != -1)
            {
                BDDInteraction.cancelActivite((Activite)listBAct.SelectedItem);
            }
        }

        private void checkAct()
        {
            if (listBAct.Items.Count == 0)
            {
                MessageBox.Show("Aucune activité disponible pour cette animation");
                this.Close();
            }
            else
            {
                listBInscrit.Items.AddRange(BDDInteraction.getLoisantInscrit((Activite)listBAct.Items[0]).ToArray());

                listBAct.SelectedIndex = 0;

                updateDesign();
            }
        }

        private void updateDesign()
        {
            if(listBAct.SelectedIndex != -1)
            {
                lblDescAct.Text = ((Activite)listBAct.SelectedItem).getDescription();

                listBInscrit.Items.Clear();
                listBInscrit.Items.AddRange(BDDInteraction.getLoisantInscrit((Activite)listBAct.SelectedItem).ToArray());
            }
            
        }

        private void MenuPlanningView_Load(object sender, EventArgs e)
        {
            nbPlace = BDDInteraction.getNbPlace(anim);

            //if there is no inscription
            if (nbPlace == -1)
            {
                nbPlace = anim.NbPlace;
            }

            lblPlaces.Text = "Places disponibles: " + nbPlace;

            checkAct();

            if (loi == null)
                listBLoisant.Items.AddRange(BDDInteraction.getLoisants().ToArray());
        }

        private void btnCancelInscip_Click(object sender, EventArgs e)
        {
            //if this is the loiasnt asking for the cancel
            if(loi != null)
            {
                BDDInteraction.cancelInscription(loi, (int)numInscription.Value);
            }
            else if( listBLoisant.SelectedIndex != -1)
            {
                BDDInteraction.cancelInscription((Loisant)listBLoisant.SelectedItem, (int)numInscription.Value);
            }
            else
                MessageBox.Show("Impossible d'annuler l'inscription, vérifier les informations fournies");
        }

        private void listBAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDesign();
        }
    }
}