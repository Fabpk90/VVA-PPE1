using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVA_PPE1.Modele;

namespace VVA_PPE1.WinForm.FormEncadrant
{
    public partial class MenuTypeAnimAdd : Form
    {
        public MenuTypeAnimAdd()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbCodeType.Text) && !string.IsNullOrWhiteSpace(rtNomType.Text))
            {
                if(!BDDInteraction.checkIfTypeAnimExists(tbCodeType.Text))
                {
                    if (!BDDInteraction.addTypeAnim(tbCodeType.Text, rtNomType.Text))
                    {
                        MessageBox.Show("Type ajouté!");
                    }
                    else
                    {
                        MessageBox.Show("Type non ajouté!");
                    }
                }
                else
                {
                    MessageBox.Show("Le code du type existe déjà");
                }
               
            }
            else
            {
                MessageBox.Show("Les champs ne peuvent pas être nuls");
            }
        }
    }
}
