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
        private Activite selectedItem;

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
            else
                MessageBox.Show("Renseigner tout les champs");
        }
    }
}
