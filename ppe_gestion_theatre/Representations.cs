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

namespace ppe_gestion_theatre
{
    public partial class Representations : Form
    {
        LoginInfo currentUser;
        public Representations(LoginInfo currentUser)
        {
            InitializeComponent();
        }

        private void Representations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Ouverture de la nouvelle fenêtre
            Menu frmMenu = new Menu(currentUser);
            this.Hide(); // le formulaire est caché
            frmMenu.ShowDialog(); // ouverture du formulaire
        }
    }
}
