using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheaterBO;

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
            //string testPseudo = "Admin";
            //string testMdp = "abcd";
            AppUser user = new AppUser();
            user = ModuleLogin.GetUser(txtLogin.Text);

            // Vérification de l'existance du pseudo
            if (user.User_pseudo == txtLogin.Text)
            //if (testPseudo.ToLower() == txtLogin.Text.ToLower())
            {
                if (user.User_password == txtPassword.Text)
                //if (testMdp == txtPassword.Text)
                {
                    LoginInfo currentUser = new LoginInfo(user);

                    // Ouverture de la nouvelle fenêtre
                    Menu frmMenu = new Menu(currentUser);
                    this.Hide(); // le formulaire est caché
                    frmMenu.ShowDialog(); // ouverture du formulaire 
                }
                else
                {
                    lblError.ForeColor = Color.Red;
                    lblError.BackColor = Color.LightPink;
                    lblError.Text = "Le mot de passe est incorrect";
                }
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.BackColor = Color.LightPink;
                lblError.Text = "Ce pseudo est inconnu de la base de données.";
            }
        }
    }
}
