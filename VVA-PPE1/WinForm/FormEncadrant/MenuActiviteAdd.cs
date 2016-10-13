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

            
            
        }

        //editing an activity
        public MenuActiviteAdd(MenuActiviteListe menuActiviteListe, Activite selectedItem) : this(menuActiviteListe)
        {
            this.selectedItem = selectedItem;                         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Activite act = new Activite();

            act.Code = tbCodeAct.Text;
            act.Date = dtAct.Value;

            act.NoEncadrant = menuActiviteListe.getEncadrant().Numero;

            act.Etat = (Activite_Etat)cbEtat.SelectedItem;

            act.HrRDV = dtRDV.Value;

            act.Prix = (float) numPrix.Value;

            act.HrDebut = dtHrDebut.Value;
            act.HrFin = dtHrFin.Value;

            act.Objectif = rtObj.Text;

            if (BDDInteraction.addActivite(act))
                MessageBox.Show("Activité ajoutée");
            else
                MessageBox.Show("Activité non ajoutée");
        }
    }
}
