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

namespace VVA_PPE1.WinForm.FormEncadrant
{
    public partial class MenuActiviteAdd : Form
    {
        private Encadrant enc;
        private Activite selectedItem = null;

        public MenuActiviteAdd(Encadrant enc)
        {
            this.enc = enc;

            InitializeComponent();

            Init();
        }

        //adding an activity
        public MenuActiviteAdd(MenuActiviteListe menuActiviteListe)
        {
            enc = menuActiviteListe.getEncadrant();
            InitializeComponent();

            Init();           
        }

        private void Init()
        {
            cbEtat.Items.AddRange(BDDInteraction.getEtatActivite().ToArray());


            foreach (Animation anim in BDDInteraction.getAnimations())
            {
                cbCodeAnim.Items.Add(anim.Code);
            }      

        }

        //editing an activity
        public MenuActiviteAdd(MenuActiviteListe menuActiviteListe, Activite selectedItem) : this(menuActiviteListe)
        {
            this.selectedItem = selectedItem;

            btnAdd.Text = "Modifier";

            cbCodeAnim.SelectedItem = selectedItem.Code;

            dtAct.Value = selectedItem.Date;

            //search which state(by name) is the act
            //because cbEtat has object, so sleceteditem = doesn't work as it should
            for(int i = 0; i < cbEtat.Items.Count; ++i)
            {

                if( ((Activite_Etat) cbEtat.Items[i]).Nom == selectedItem.Etat.Nom)
                {
                    cbEtat.SelectedIndex = i;
                    break;
                }

            }
            
            dtHrDebut.Value = DateTime.Parse(selectedItem.HrDebut.ToString());
            dtHrFin.Value = DateTime.Parse(selectedItem.HrFin.ToString());
            dtRDV.Value = DateTime.Parse(selectedItem.HrRDV.ToString());

            numPrix.Value = (decimal) selectedItem.Prix;

            rtObj.Text = selectedItem.Objectif;
                                      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbCodeAnim.SelectedItem != null && cbEtat.SelectedItem != null)
            {
                //15 mins de battement entre le rdv et la date actuelle
                if((DateTime.Now - dtRDV.Value).Minutes <= 15 )
                {
                    MessageBox.Show("L'heure de rendez-vous ne doit pas être antérieure à celle actuelle", "Heure de rendez-vous", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if((dtRDV.Value - dtHrDebut.Value).Minutes >= 0 || (dtRDV.Value - dtHrFin.Value).Minutes >= 0 )
                {
                    MessageBox.Show("L'heure de rendez-vous doit être correcte", "Heure de rendez-vous", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if((dtHrDebut.Value - dtHrFin.Value).Minutes >= 0)
                {
                    MessageBox.Show("L'heure du début doit être correcte", "Heure du début", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Activite act = new Activite();

                    act.Code = cbCodeAnim.SelectedItem.ToString();
                    act.Date = dtAct.Value;

                    act.NoEncadrant = enc.Numero;

                    act.Etat = (Activite_Etat)cbEtat.SelectedItem;

                    act.HrRDV = dtRDV.Value.TimeOfDay;

                    act.Prix = (float)numPrix.Value;

                    act.HrDebut = dtHrDebut.Value.TimeOfDay;
                    act.HrFin = dtHrFin.Value.TimeOfDay;

                    act.Objectif = rtObj.Text;

                    if (selectedItem != null)//modif en cours
                    {
                        if (BDDInteraction.modifyActivite(act))
                            MessageBox.Show("Activité modifiée", "Activité", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (!BDDInteraction.checkIfActiviteExists(act))
                        {
                            if (BDDInteraction.addActivite(act))
                                MessageBox.Show("Activité ajoutée", "Activité", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            else
                                MessageBox.Show("Activité non ajoutée", "Activité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Une activité existe déjà le "+act.Date.ToLongDateString(), "Activité", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }

                
               
            }
            else
                MessageBox.Show("Renseigner tous les champs", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void MenuActiviteAdd_Load(object sender, EventArgs e)
        {
            if (cbCodeAnim.Items.Count == 0)
            {
                this.Hide();
                MessageBox.Show("Aucune Animation est disponible", "Animation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }
    }
}
