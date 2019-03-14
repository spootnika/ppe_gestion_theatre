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


            // Remplissable de la comboBox avec les pièces de théâtre
            cbChoixPiece.DataSource = ModulePiecesTheatre.GetTheaterPieces();
            cbChoixPiece.DisplayMember = "theaterPiece_name";


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

            dt.Columns.Add(new DataColumn("durée", typeof(string)));
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

                double doubleConvertDuree = double.Parse(uneRepresentation.Show_theaterPiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                string duree = convertDuree.ToString();

                float prix = uneRepresentation.Show_theaterPiece.TheaterPiece_seatsPrice;

                dt.Rows.Add(uneRepresentation, nomPiece, date, heure, places, duree, prix);
            }


            // La première colonne contenant l'objet ne sera pas visible
            dgvListeRepresentations.Columns["representation"].Visible = false;
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

        private void dgvListeRepresentations_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvListeRepresentations.CurrentRow.Selected = true; 

            int indexRow = dgvListeRepresentations.CurrentRow.Index;

            if (dgvListeRepresentations.Rows[indexRow].Cells[0].Value != DBNull.Value)
            {
                Show laRepres = (Show)dgvListeRepresentations.Rows[indexRow].Cells[0].Value;

                lblLaPiece.Text = laRepres.Show_theaterPiece.TheaterPiece_name;

                lblLesPlaces.Text = laRepres.Show_seats.ToString();

                lblLesPlacesRest.Text = ModuleRepresentations.GetRemainingSeats(laRepres).ToString();

                lblLaDate.Text = laRepres.Show_dateTime.ToString("dd/MM/yyyy");

                lblLHeure.Text = laRepres.Show_dateTime.ToString("HH:mm");

                lblLePrixFixe.Text = laRepres.Show_theaterPiece.TheaterPiece_seatsPrice.ToString() + " €";
            }
            else
            {
                lblLaPiece.Text = "";

                lblLesPlaces.Text = "";

                lblLesPlacesRest.Text = "";

                lblLaDate.Text = "";

                lblLHeure.Text = "";

                lblLePrixFixe.Text = " €";
            }
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            List<Show> lesRepresentations = ModuleRepresentations.GetFilterShows(ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPiece.Text).TheaterPiece_id, dtpDateDeb.Value, dtpDateFin.Value);
            
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
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {


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
        }

        //ajout d'un nouvel utilisateur
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //on cache
          //  grbDetails.Hide();
            //quand on clique sur le bouton affichage des cases de saisie
            grbAjoutRepresentation.Visible = true;

            // Remplissable de la comboBox avec les pièces de théâtre
            cbChoixPieceSaisieShow.DataSource = ModulePiecesTheatre.GetTheaterPieces();
            cbChoixPieceSaisieShow.DisplayMember = "theaterPiece_name";

            //mettre tout ça dans l'event clique sur le bouton ajouter
             if(saisieDateShow.Text.Trim() != "" && saisieHeureShow.Text.Trim() != "" && saisiePlacesShow.Text.Trim() != "" && saisiePrixShow.Text.Trim() != "" && cbChoixPieceSaisieShow.Text.Trim() != "")
             {     
                //on récupère date saisie et heure à mettre en datetime         
                string mesdates = saisieDateShow.ToString() + " " + saisieHeureShow.ToString();
                DateTime parsedDate = DateTime.Parse(mesdates);
                //on récupère nb places
                int mesPlaces = int.Parse(saisiePlacesShow.ToString());
                //on affiche le prix
                float monPrix = float.Parse(saisiePrixShow.ToString());
                    //on vérifie l'heure pour voir dans quelle tranche de pricerate on va 
                    //et on multiplie le prix*priceRate
                //on récupère la pièce de théâtre
                TheaterPiece maPiece = ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPieceSaisieShow.Text);
                // Création de l'objet Show 
                Show show = new Show(parsedDate, mesPlaces, maPiece);
                // Appel de la méthode CreerUtilisateur de la couche BLL
                ModuleRepresentations.CreateShow(show);

             }


        }


    }
}
