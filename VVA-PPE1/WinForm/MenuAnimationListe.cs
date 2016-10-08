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
using VVA_PPE1.Modele;
using VVA_PPE1.WinForm.FormEncadrant;


namespace VVA_PPE1.WinForm
{
    public partial class MenuAnimationListe : Form
    {
        public MenuAnimationListe(bool IsEncadrant)
        {
            InitializeComponent();

            //TO DO: disable elements depending on isencadrant

            if(!IsEncadrant)
            {
                btnAddMenu.Hide();
            }

        }

        private void MenuAnimationListe_Load(object sender, EventArgs e)
        {                    
            listBAnim.Items.AddRange(BDDInteraction.getAnimations().ToArray());
        }

        private void listBAnim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si l'utilisateur est vraiment en train de clicker dessus
            if(listBAnim.SelectedIndex != -1)
            {
                Animation anim = ((Animation)listBAnim.SelectedItem);

                lblNom.Text = anim.Nom;
                lblNomType.Text = anim.AnimType.Nom;

                lblCom.Text = anim.Commentaire;
                lblDesc.Text = anim.Desc;

                lblDtCrea.Text = anim.DtCreation.ToShortDateString();
                lblDtVal.Text = anim.DtValidite.ToShortDateString();

                lblDuree.Text = "" + anim.Duree;
                lblLimitAge.Text = "" + anim.LimiteAge + " ans";

                lblNbPlace.Text = "" + anim.NbPlace;

                lblTarif.Text = "" + anim.Tarif;

                lblCom.Text = anim.Commentaire;
                                
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            //if there is anim types, open the add menu 
            if(BDDInteraction.getAnimType().Count != 0)
            {
                MenuAnimationAdd menuAdd = new MenuAnimationAdd(this);

                menuAdd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ajouter un ype d'animation d'abord");
            }

            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //if the user has selected an animation
            if(listBAnim.SelectedIndex != -1)
            {
               
                MenuAnimationAdd menuAdd = new MenuAnimationAdd(this, (Animation) listBAnim.SelectedItem);

                menuAdd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selectionner une animation avant");
            }
        }
    }
}
