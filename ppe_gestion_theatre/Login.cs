using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe_gestion_theatre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Au clic sur le bouton "valider" pour se connecter
        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Ouverture de la nouvelle fenêtre
            Menu frmMenu;
            frmMenu = new Menu();
            this.Hide(); // le formulaire est caché
            frmMenu.ShowDialog(); // ouverture du formulaire 
        }
    }
}
