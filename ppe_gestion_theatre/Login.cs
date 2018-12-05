using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheaterBLL;
using TheaterBO;
using System.Configuration;

namespace ppe_gestion_theatre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ModuleLogin.SetchaineConnexion(ConfigurationManager.ConnectionStrings["dbGestionTheatre"]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Au clic sur le bouton "valider" pour se connecter
        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblError.ForeColor = Color.Transparent;
            lblError.BackColor = Color.Transparent;
            lblError.Text = "";
            AppUser user;

            // récupération user 
            user = ModuleLogin.GetUser(txtLogin.Text);
            //user = new AppUser(2, "user", "1234", false);
            //user = new AppUser(1, "admin", "1234", true);

            // Vérification de l'existance de l'utilisateur
            if (user != null)
            {
                // Vérification de la validité du mot de passe
                if (user.User_password == txtPassword.Text)
                {
                    LoginInfo currentUser = ModuleLogin.CreateLoginInfo(user);
                    //LoginInfo currentUser = new LoginInfo(user);

                    // Ouverture de la nouvelle fenêtre
                    Menu frmMenu = new Menu(currentUser);
                    this.Hide(); // le formulaire est caché
                    frmMenu.ShowDialog(); // ouverture du formulaire 
                }
                else
                {
                    // Affichage d'un message d'erreur
                    lblError.ForeColor = Color.Red;
                    lblError.BackColor = Color.LightPink;
                    lblError.Text = "Le mot de passe est incorrect";
                }
            }
            else
            {
                // Affichage d'un message d'erreur
                lblError.ForeColor = Color.Red;
                lblError.BackColor = Color.LightPink;
                lblError.Text = "Ce pseudo est inconnu de la base de données.";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
