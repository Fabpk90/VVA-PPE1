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

            cbTypeAnim.Items.AddRange(BDDInteraction.getAnimType().ToArray());

            if (cbTypeAnim.Items.Count != 0)
            {
                cbTypeAnim.SelectedIndex = 0;
            }

            //check if the difficulty has been set
            if (cbDifficulteAnim.SelectedIndex == -1)
                cbDifficulteAnim.SelectedIndex = 0;
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

            cbTypeAnim.SelectedItem = selectedAnim.AnimType;
            cbTypeAnim.Enabled = false;
            
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

                if(string.IsNullOrEmpty(tbCodeAnim.Text))
                {
                    MessageBox.Show("Le code de l'animation doit être remplit", "Code de l'animation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(string.IsNullOrEmpty(tbNomAnim.Text))
                {
                    MessageBox.Show("Le nom de l'animation doit être remplit", "Nom de l'animation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //creates the animation based on the form
                    Animation anim = new Animation(tbCodeAnim.Text, tbNomAnim.Text, DateTime.Now, dtValiditeAnim.Value, (int)numDureeAnim.Value, (int)numLimiteAge.Value, (float)numTarifAnim.Value
                           , (int)numNbPlace.Value, rbDescAnim.Text, rbCommAnim.Text, (EdiffAnim)cbDifficulteAnim.SelectedIndex,
                           ((Animation_Type)cbTypeAnim.SelectedItem).Code, ((Animation_Type)cbTypeAnim.SelectedItem).Nom);

                    //if the user is not modifying an animation
                    if (selectedAnim == null)
                    {
                        anim.AnimType = (Animation_Type)cbTypeAnim.SelectedItem;

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
