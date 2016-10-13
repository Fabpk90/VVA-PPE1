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
        
        private bool isEncadrant;
        private Encadrant enc;

        public MenuActiviteListe()
        {
            InitializeComponent();
        }

        public MenuActiviteListe(bool isEncadrant)
        {
            this.isEncadrant = isEncadrant;

            InitializeComponent();
        }

        public MenuActiviteListe(bool isEncadrant, Encadrant enc) : this(isEncadrant)
        {
            this.enc = enc;
        }

        private void MenuActiviteListe_Load(object sender, EventArgs e)
        {        
            listBAct.Items.AddRange(BDDInteraction.getActivites().ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuActiviteAdd menuAdd;
            if (listBAct.SelectedIndex != -1)
            {
                menuAdd = new MenuActiviteAdd(this, (Activite) listBAct.SelectedItem);
            }
            else
                menuAdd = new MenuActiviteAdd(this);

            menuAdd.Show();
            this.Hide();
        }

        public Encadrant getEncadrant()
        {
            return enc;
        }
    }
}
