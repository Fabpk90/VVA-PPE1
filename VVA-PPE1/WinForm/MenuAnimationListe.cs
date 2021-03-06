﻿using System;
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
using VVA_PPE1.WinForm.FormEncadrant;


namespace VVA_PPE1.WinForm
{
    public partial class MenuAnimationListe : Form
    {
        private Encadrant enc = null;
        private Loisant loi = null;

        public MenuAnimationListe()
        {
            InitializeComponent();
        }

        public MenuAnimationListe(Encadrant enc) : this()
        {
            this.enc = enc;   
        }

        public MenuAnimationListe(Loisant loi) : this ()
        {
            this.loi = loi;

            btnAddMenu.Visible = false;
            btnModify.Visible = false;
            btnAddType.Visible = false;
            
        }

        private void MenuAnimationListe_Load(object sender, EventArgs e)
        {
            loadAnim();
        }

        private void listBAnim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si l'utilisateur est vraiment en train de clicker dessus
            if(listBAnim.SelectedIndex != -1)
            {
                Animation anim = ((Animation)listBAnim.SelectedItem);

                rtDesc.Visible = true;
                rtDesc.Text = anim.getDescription();
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
                MessageBox.Show("Ajouter un type d'animation d'abord");
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

        public void reload()
        {
            loadAnim();
        }

        private void loadAnim()
        {
            listBAnim.Items.Clear();
            listBAnim.Items.AddRange(BDDInteraction.getAnimations().ToArray());

            //if there is some elements, set the first selected
            if (listBAnim.Items.Count != 0)
            {
                listBAnim.SelectedIndex = 0;
            }
            else
            {
                rtDesc.Visible = false;
            }

        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            if(listBAnim.SelectedIndex != -1)
            {
                MenuPlanningView menuPlann;
                if (enc != null)
                    menuPlann = new MenuPlanningView((Animation)listBAnim.SelectedItem, enc);
                else
                    menuPlann = new MenuPlanningView((Animation)listBAnim.SelectedItem, loi);

                menuPlann.Show();
            }
            else
            {
                MessageBox.Show("Selectionner une animation avant");
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            MenuTypeAnimAdd menuTypeAdd = new MenuTypeAnimAdd();
            menuTypeAdd.Show();
        }
    }
}
