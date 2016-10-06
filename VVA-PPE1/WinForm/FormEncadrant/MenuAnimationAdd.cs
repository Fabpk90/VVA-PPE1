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

        private void MenuAnimationAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAnimationListe.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Animation anim = new Animation(tbCodeAnim.Text, tbNomAnim.Text, DateTime.Now, dtValiditeAnim.Value, (int) numLimiteAge.Value, (float) numTarifAnim.Value
                , (int) numNbPlace.Value, rbDescAnim.Text, rbCommAnim.Text, (EdiffAnim)cbDifficulteAnim.SelectedIndex, 
                ((Animation_Type)cbTypeAnim.SelectedItem).Code, ((Animation_Type)cbTypeAnim.SelectedItem).Nom);

            anim.AnimType = (Animation_Type) cbTypeAnim.SelectedItem;

            if(!BDDInteraction.isAnimationExists(anim))
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
    }
}
