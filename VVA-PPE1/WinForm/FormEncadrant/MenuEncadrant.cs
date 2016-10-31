using System;
using System.Windows.Forms;
using VVA_PPE1.Modele;
using VVA_PPE1.Actor;

namespace VVA_PPE1.WinForm.FormEncandrant
{
    public partial class MenuEncadrant : Form
    {
        private Encadrant enc;
        private MenuPrincipal menuPrincipal;

        public MenuEncadrant(Encadrant enc, MenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            this.enc = enc;
        }

        private void btnListeAnim_Click(object sender, EventArgs e)
        {

            MenuAnimationListe menu = new MenuAnimationListe(enc);

            menu.Show();
        }

        private void MenuEncadrant_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.resetFields();
            menuPrincipal.Show();
        }

        private void btnListeActivite_Click(object sender, EventArgs e)
        {
            MenuActiviteListe menu = new MenuActiviteListe(enc);

            menu.Show();
        }
    }
}
