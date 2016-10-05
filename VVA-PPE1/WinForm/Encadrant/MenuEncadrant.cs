using System;
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

namespace VVA_PPE1.WinForm
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
