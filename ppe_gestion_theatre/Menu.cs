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
    public partial class Menu : Form
    {
        LoginInfo test;
        public Menu(LoginInfo currentUser)
        {
            InitializeComponent();
            test = currentUser;
            // Si l'utilisateur n'est pas un admin, désactivation des boutons Représentations, Synthèse et Pièces de théâtre
            if(currentUser.IsAdmin == false)
            {
                btnShow.Enabled = false;
                btnSynthesis.Enabled = false;
                btnTheaterPiece.Enabled = false;
            }
            
        }

        private void lblConnect_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        // Arrêt du processus à la fermeture du formulaire
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // Ouverture de la nouvelle fenêtre
            Reservations frmReservations = new Reservations(this.test);
            this.Hide(); // le formulaire est caché
            frmReservations.ShowDialog(); // ouverture du formulaire 
        }
    }
}
