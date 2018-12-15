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
    public partial class Reservations : Form
    {
        LoginInfo currentUser;
        public Reservations(LoginInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // récupération de la liste des réservations
            List<Spectator> lesReservations = ModuleReservations.GetSpectators();

            // Structure de la dgv
            DataTable table = new DataTable();
            dgvListeReservations.DataSource = table;

            // Ajout des colonnes de la table
            table.Columns.Add(new DataColumn("reservation", typeof(Spectator)));

            table.Columns.Add(new DataColumn("piece", typeof(string)));
            dgvListeReservations.Columns["piece"].HeaderText = "Pièce";

            table.Columns.Add(new DataColumn("representation", typeof(string)));
            dgvListeReservations.Columns["representation"].HeaderText = "Représentation";

            table.Columns.Add(new DataColumn("duree", typeof(string)));
            dgvListeReservations.Columns["duree"].HeaderText = "Durée";

            table.Columns.Add(new DataColumn("theme", typeof(string)));
            dgvListeReservations.Columns["theme"].HeaderText = "Thème";

            table.Columns.Add(new DataColumn("public", typeof(string)));
            dgvListeReservations.Columns["public"].HeaderText = "Public";

            table.Columns.Add(new DataColumn("nom", typeof(string)));
            dgvListeReservations.Columns["nom"].HeaderText = "Nom";

            table.Columns.Add(new DataColumn("places", typeof(string)));
            dgvListeReservations.Columns["places"].HeaderText = "Places";

            table.Columns.Add(new DataColumn("total", typeof(string)));
            dgvListeReservations.Columns["total"].HeaderText = "Total";

            dgvListeReservations.ReadOnly = true;

            // Valorisation de la DGV avec les réservations
            foreach (Spectator uneReservation in lesReservations)
            {
                string piece = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_name;
                string representation = uneReservation.Spectator_show.Show_dateTime.ToString("MM/dd/yyyy à H:mm");
                string duree = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_duration.ToString();
                string theme = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_theme.Theme_name;
                string typePublic = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_publicType.PublicType_name;
                string nom = uneReservation.Spectator_lastname;
                string places = uneReservation.Spectator_seatsBooked.ToString();
                string total = "0";

                table.Rows.Add(uneReservation, piece, representation, duree, theme, typePublic, nom, places, total);
            }

            dgvListeReservations.Columns["reservation"].Visible = false;
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
