﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVA_PPE1.Actor;
using VVA_PPE1.Modele;

namespace VVA_PPE1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (!BDDInteraction.Connection())
            {
                //TO DO: alerte que la bdd est pas accessible 
                MessageBox.Show("");
            }
                           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //champs de co pas vides
            if(!string.IsNullOrEmpty(tbUser.Text)
                && !string.IsNullOrEmpty(tbMdp.Text))
            {
                if(cbEncadrant.Checked)
                {
                    Encadrant encadrant = BDDInteraction.getEncadrant(tbUser.Text, tbMdp.Text);

                    MessageBox.Show(encadrant.ToString());
                }
                else // loisant
                {
                   // Loisant encadrant = BDDInteraction.getLoisant(tbNom.Text, tbPrenom.Text, tbMdp.Text);
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseignez tout les champs");
            }
        }
    }
}
