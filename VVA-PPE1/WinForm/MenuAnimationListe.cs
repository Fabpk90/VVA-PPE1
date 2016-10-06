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
                lblNom.Text = ((Animation)listBAnim.SelectedItem).Nom;

            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            MenuAnimationAdd menuAdd = new MenuAnimationAdd(this);

            menuAdd.Show();
            this.Hide();
        }
    }
}
