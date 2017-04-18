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

namespace VVA_PPE1.WinForm.FormEncadrant
{
    public partial class MenuAnimationAdd : Form
    {
        private MenuAnimationListe menuAnimationListe;
        private Animation selectedAnim = null;

        public MenuAnimationAdd()
        {
            InitializeComponent();

            dtValiditeAnim.Value = DateTime.Now.AddDays(1);

            lbCodeTypeAnim.Items.AddRange(BDDInteraction.getAnimType().ToArray());

            if (lbCodeTypeAnim.Items.Count != 0)
            {
                lbCodeTypeAnim.SelectedIndex = 0;
            }
        }

        public MenuAnimationAdd(MenuAnimationListe menuAnimationListe) : this ()
        {
            this.menuAnimationListe = menuAnimationListe;        
        }

        public MenuAnimationAdd(MenuAnimationListe menuAnimationListe, Animation selectedItem) : this(menuAnimationListe)
        {
            this.selectedAnim = selectedItem;

            btnAdd.Text = "Modifier l'animation";

            tbCodeAnim.Text = selectedAnim.Code;
            tbCodeAnim.Enabled = false;     

            tbNomAnim.Text = selectedAnim.Nom;

            cbDifficulteAnim.SelectedIndex = (int) selectedAnim.Difficulte;

            lbCodeTypeAnim.SelectedItem = selectedAnim.AnimType;
            lbCodeTypeAnim.Enabled = false;
            
        }

        private void MenuAnimationAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (menuAnimationListe != null)
                menuAnimationListe.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dtValiditeAnim.Value > DateTime.Now)
            {
                //creates the animation based on the form
                Animation anim = new Animation(tbCodeAnim.Text, tbNomAnim.Text, DateTime.Now, dtValiditeAnim.Value,(int) numDureeAnim.Value, (int)numLimiteAge.Value, (float)numTarifAnim.Value
                       , (int)numNbPlace.Value, rbDescAnim.Text, rbCommAnim.Text, (EdiffAnim)cbDifficulteAnim.SelectedIndex,
                       ((Animation_Type)lbCodeTypeAnim.SelectedItem).Code, ((Animation_Type)lbCodeTypeAnim.SelectedItem).Nom);

                //if the user is not modifying an animation
                if (selectedAnim == null)
                {
                    anim.AnimType = (Animation_Type)lbCodeTypeAnim.SelectedItem;

                    if (!BDDInteraction.checkIfAnimationExists(anim))
                    {
                        if (BDDInteraction.addAnimation(anim))
                        {
                            MessageBox.Show("Animation ajoutée corréctement");
                        }
                        else
                            MessageBox.Show("Erreur de requête!");
                    }
                    else
                        MessageBox.Show("L'animation existe déjà!");
                }
                else // if he does
                {
                    if (BDDInteraction.modifyAnimation(anim))
                    {
                        MessageBox.Show("Animation modifiée");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification de l'animation");
                    }
                }
            }
            else
            {
                MessageBox.Show("Date de validité non valide");
            }
           
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if(menuAnimationListe != null)
            {
                menuAnimationListe.reload();
                menuAnimationListe.Show();
            }
            

            this.Close();

        }
    }
}
