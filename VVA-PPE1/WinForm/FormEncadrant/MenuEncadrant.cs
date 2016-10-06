using System;
using System.Windows.Forms;
using VVA_PPE1.Modele;
using VVA_PPE1.Actor;

namespace VVA_PPE1.WinForm.FormEncandrant
{
    public partial class MenuEncadrant : Form
    {
        private VVA_PPE1.Actor.Encadrant enc;
        private MenuPrincipal menuPrincipal;

        public MenuEncadrant(Actor.Encadrant enc, MenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            this.enc = enc;
        }

        private void btnListeAnim_Click(object sender, EventArgs e)
        {
            MenuAnimationListe menu = new MenuAnimationListe(true);

            menu.Show();
        }

        private void MenuEncadrant_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDDInteraction.Deconnection();
            menuPrincipal.Close();
        }
    }
}
