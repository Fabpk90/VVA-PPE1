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

namespace VVA_PPE1.WinForm.FormLoisant
{
    public partial class MenuLoisant : Form
    {
        private Loisant loi;
        private MenuPrincipal menuPrincipal;

        public MenuLoisant(Loisant loi, MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            this.loi = loi;

            InitializeComponent();
        }

        private void btnVoirAnimation_Click(object sender, EventArgs e)
        {
            MenuAnimationListe menuAnim = new MenuAnimationListe(loi);
            menuAnim.Show();

        }

        private void MenuLoisant_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.resetFields();
            menuPrincipal.Show();
        }

        private void btnVoirActivite_Click(object sender, EventArgs e)
        {
            MenuActiviteListe menuAct = new MenuActiviteListe();

            menuAct.Show();
        }
    }
}
