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
        public Menu(LoginInfo currentUser)
        {
            InitializeComponent();

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
    }
}
