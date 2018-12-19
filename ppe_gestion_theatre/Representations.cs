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
            this.currentUser = currentUser;

            List<Show> lesRepresentations = ModuleRepresentations.GetShows();

            // Blocage de la génération automatique des colonnes
            //dgvListePiecesTheatre.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dgvListeRepresentations.DataSource = dt;

            dt.Columns.Add(new DataColumn("representation", typeof(Show)));

            dt.Columns.Add(new DataColumn("nom", typeof(string)));
            dgvListeRepresentations.Columns["Nom"].HeaderText = "Nom de la pièce";

            dt.Columns.Add(new DataColumn("date", typeof(string)));
            dgvListeRepresentations.Columns["Date"].HeaderText = "Date";

            dt.Columns.Add(new DataColumn("heure", typeof(string)));
            dgvListeRepresentations.Columns["Heure"].HeaderText = "Heure";

            dt.Columns.Add(new DataColumn("places", typeof(int)));
            dgvListeRepresentations.Columns["Places"].HeaderText = "Places";

            dt.Columns.Add(new DataColumn("durée", typeof(float)));
            dgvListeRepresentations.Columns["Durée"].HeaderText = "Durée";

            dt.Columns.Add(new DataColumn("tarif", typeof(float)));
            dgvListeRepresentations.Columns["Tarif"].HeaderText = "Tarif";

            dgvListeRepresentations.ReadOnly = true;
            

            //test dgv
            foreach (Show uneRepresentation in lesRepresentations)
            {
                string nomPiece = uneRepresentation.Show_theaterPiece.TheaterPiece_name;

                DateTime dateHeure = uneRepresentation.Show_dateTime;

                string date = dateHeure.ToString("dd/MM/yyyy");

                string heure = dateHeure.ToString("HH:mm");

                int places = uneRepresentation.Show_seats;

                float duree = uneRepresentation.Show_theaterPiece.TheaterPiece_duration;

                float prix = uneRepresentation.Show_theaterPiece.TheaterPiece_seatsPrice;

                dt.Rows.Add(uneRepresentation, nomPiece, date, heure, places, duree, prix);
            }


            // La première colonne contenant l'objet ne sera pas visible
            dgvListeRepresentations.Columns["representation"].Visible = false;

            // Remplissable de la comboBox avec les pièces de théâtre
            cbChoixPiece.DataSource = ModulePiecesTheatre.GetTheaterPieces();
            cbChoixPiece.DisplayMember = "theaterPiece_name";
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

        private void dgvListeRepresentations_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
