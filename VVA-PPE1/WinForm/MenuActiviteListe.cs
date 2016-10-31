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
using VVA_PPE1.WinForm.FormEncadrant;

namespace VVA_PPE1.WinForm
{
    public partial class MenuActiviteListe : Form
    {
        private Encadrant enc;

        private List<Encadrant> listEnc = BDDInteraction.getEncadrants();

        public MenuActiviteListe()
        {      
            InitializeComponent();
            btnPlanAct.Enabled = false;
        }

        public MenuActiviteListe( Encadrant enc)
        {
            InitializeComponent();
            this.enc = enc;
        }

        private void MenuActiviteListe_Load(object sender, EventArgs e)
        {        
            listBAct.Items.AddRange(BDDInteraction.getActivites().ToArray());

            if(listBAct.Items.Count != 0)
            {
                listBAct.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuActiviteAdd menuAdd;
            
            menuAdd = new MenuActiviteAdd(this);

            menuAdd.Show();
            this.Hide();
        }

        public Encadrant getEncadrant()
        {
            return enc;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(listBAct.SelectedIndex != -1)
            {
                MenuActiviteAdd menu = new MenuActiviteAdd(this, (Activite)listBAct.SelectedItem);

                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selectionner une activité pour la modifier");
            }
            
        }

        private void listBAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBAct.SelectedIndex != -1)
            {
                Activite act = ((Activite)listBAct.SelectedItem);

                lblDesc.Text = act.getDescription();
                lblDescEnc.Text = listEnc[act.NoEncadrant].getDescription();
            }
        }

        private void btnPlanAct_Click(object sender, EventArgs e)
        {
            if(listBAct.SelectedIndex != -1)
            {
                MenuPlanningAdd planning = new MenuPlanningAdd((Activite)listBAct.SelectedItem, enc, this);

                this.Hide();
                planning.Show();
            }
            else
                MessageBox.Show("Séléctionner une activité");
        }
    }
}
