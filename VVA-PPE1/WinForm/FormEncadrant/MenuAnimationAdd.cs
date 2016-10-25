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

namespace VVA_PPE1.WinForm.FormEncadrant
{
    public partial class MenuAnimationAdd : Form
    {
        private MenuAnimationListe menuAnimationListe;
        private Animation selectedAnim = null;

        public MenuAnimationAdd(MenuAnimationListe menuAnimationListe)
        {
            this.menuAnimationListe = menuAnimationListe;

            InitializeComponent();         

            cbTypeAnim.Items.AddRange(BDDInteraction.getAnimType().ToArray());
            
            if(cbTypeAnim.Items.Count != 0)
            {
                cbTypeAnim.SelectedIndex = 0;
            }
        }

        public MenuAnimationAdd(MenuAnimationListe menuAnimationListe, Animation selectedItem) : this(menuAnimationListe)
        {
            this.selectedAnim = selectedItem;

            btnAdd.Text = "Modifier l'animation";

            tbCodeAnim.Text = selectedAnim.Code;
            tbCodeAnim.Enabled = false;     

            tbNomAnim.Text = selectedAnim.Nom;

            cbDifficulteAnim.SelectedIndex = (int) selectedAnim.Difficulte;

            cbTypeAnim.SelectedText = selectedAnim.AnimType.Nom;
            cbTypeAnim.Enabled = false;
            
        }

        private void MenuAnimationAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAnimationListe.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //creates the animation based on the form
            Animation anim = new Animation(tbCodeAnim.Text, tbNomAnim.Text, DateTime.Now, dtValiditeAnim.Value, (int)numLimiteAge.Value, (float)numTarifAnim.Value
                   , (int)numNbPlace.Value, rbDescAnim.Text, rbCommAnim.Text, (EdiffAnim)cbDifficulteAnim.SelectedIndex,
                   ((Animation_Type)cbTypeAnim.SelectedItem).Code, ((Animation_Type)cbTypeAnim.SelectedItem).Nom);

            //if the user is not modifying an animation
            if (selectedAnim == null)
            {            

                anim.AnimType = (Animation_Type)cbTypeAnim.SelectedItem;

                if (!BDDInteraction.isAnimationExists(anim))
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
                if(BDDInteraction.modifyAnimation(anim))
                {
                    MessageBox.Show("Animation modifiée");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de l'animation");
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            menuAnimationListe.reload();
            menuAnimationListe.Show();

            this.Close();

        }
    }
}
