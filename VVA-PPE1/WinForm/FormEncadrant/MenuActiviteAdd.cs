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
    public partial class MenuActiviteAdd : Form
    {
        private MenuActiviteListe menuActiviteListe;
        private Activite selectedItem = null;

        public MenuActiviteAdd()
        {
            InitializeComponent();
        }

        //adding an activity
        public MenuActiviteAdd(MenuActiviteListe menuActiviteListe)
        {
            this.menuActiviteListe = menuActiviteListe;
            InitializeComponent();

            cbEtat.Items.AddRange(BDDInteraction.getEtatActivite().ToArray());

            

            foreach(Animation anim in BDDInteraction.getAnimations())
            {
                cbCodeAnim.Items.Add(anim.Code);
            }

            cbCodeAnim.Items.AddRange(BDDInteraction.getAnimations().ToArray());
            
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
                Activite act = new Activite();

                act.Code = cbCodeAnim.SelectedItem.ToString();             
                act.Date = dtAct.Value;

                act.NoEncadrant = menuActiviteListe.getEncadrant().Numero;

                act.Etat = (Activite_Etat)cbEtat.SelectedItem;

                act.HrRDV = dtRDV.Value.TimeOfDay;

                act.Prix = (float)numPrix.Value;

                act.HrDebut = dtHrDebut.Value.TimeOfDay;
                act.HrFin = dtHrFin.Value.TimeOfDay;

                act.Objectif = rtObj.Text;

                if(selectedItem != null)//modif en cours
                {
                    //MessageBox.Show("test");
                    if(BDDInteraction.modifyActivite(act))
                        MessageBox.Show("Activité ajoutée");
                }
                else
                {
                    if (!BDDInteraction.isActiviteExist(act))
                    {
                        if (BDDInteraction.addActivite(act))
                            MessageBox.Show("Activité ajoutée");
                        else
                            MessageBox.Show("Activité non ajoutée");                       
                    }
                    else
                    {
                        MessageBox.Show("L'activité existe déjà");
                    }
                }
               
            }
            else
                MessageBox.Show("Renseigner tout les champs", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
