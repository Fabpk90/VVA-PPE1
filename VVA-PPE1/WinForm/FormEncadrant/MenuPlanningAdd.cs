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
    public partial class MenuPlanningAdd : Form
    {
        private Encadrant enc;
        private Activite selectedAct;
        private MenuActiviteListe menuAct;

        public MenuPlanningAdd(Activite selectedItem, Encadrant enc, MenuActiviteListe menuAct)
        {
            this.enc = enc;
            this.selectedAct = selectedItem;
            this.menuAct = menuAct;

            InitializeComponent();

            listBEnc.Items.AddRange(BDDInteraction.getEncadrants().ToArray());

            lblAct.Text = selectedItem.getDescription();
            lblReferent.Text = BDDInteraction.getEncadrant(selectedAct.NoEncadrant).getDescription();
        }

        private void MenuPlanning_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAct.Show();
            this.Hide();
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            if(listBEnc.SelectedItems.Count != 0)
            {

                
                List<Encadrant> listEnc = new List<Encadrant>();

                foreach(Encadrant enc in listBEnc.SelectedItems)
                {
                    listEnc.Add(enc);
                }

                BDDInteraction.setPlanning(selectedAct, listEnc);
            }
        }
    }
}
