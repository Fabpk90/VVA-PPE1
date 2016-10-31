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
using VVA_PPE1.WinForm;
using VVA_PPE1.WinForm.FormEncandrant;
using VVA_PPE1.WinForm.FormLoisant;

namespace VVA_PPE1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (!BDDInteraction.Connection())
            { 
                MessageBox.Show("Base de donnée non accessible");
            }
                           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //champs de co pas vides
            if(!string.IsNullOrEmpty(tbUser.Text)
                && !string.IsNullOrEmpty(tbMdp.Text))
            {
                if(cbEncadrant.Checked)
                {
                    Encadrant encadrant = BDDInteraction.getEncadrant(tbUser.Text, tbMdp.Text);                 

                    //if found
                    if(encadrant.Nom != "")
                    {
                        MenuEncadrant menu = new MenuEncadrant(encadrant, this);

                        menu.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Informations érronées");


                }
                else // loisant
                {
                    Loisant loisant = BDDInteraction.getLoisant(tbUser.Text, tbMdp.Text);

                    if(loisant.Nom != "")
                    {
                        MenuLoisant menu = new MenuLoisant(loisant, this);

                        menu.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Informations érronées");

                }
            }
            else
            {
                MessageBox.Show("Veuillez renseignez tout les champs");
            }
        }

        public void resetFields()
        {
            tbMdp.Text = "";
            tbUser.Text = "";

            cbEncadrant.Checked = false;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            BDDInteraction.Deconnection();
        }
    }
}
