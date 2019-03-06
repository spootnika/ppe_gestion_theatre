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
                // Nom de la pièce
                string piece = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_name;

                // Date et heure de la représentation
                string representation = uneReservation.Spectator_show.Show_dateTime.ToString("MM/dd/yyyy à H:mm");

                // Durée de la pièce
                double doubleConvertDuree = double.Parse(uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                string duree = convertDuree.ToString();

                // Thème de la pièce
                string theme = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_theme.Theme_name;

                // Type de public de la pièce
                string typePublic = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_publicType.PublicType_name;

                // Nom et prénom de la réservation 
                string nom = uneReservation.Spectator_lastname;
                int places = uneReservation.Spectator_seatsBooked;

                // Calcul du prix total
                float taux = uneReservation.Spectator_show.Show_priceRate.PriceRate_rate;
                float prixHT = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice * places;
                float total = prixHT + (prixHT * taux);

                // Ajout de la ligne à la table
                table.Rows.Add(uneReservation, piece, representation, duree, theme, typePublic, nom, places, total);
            }

            // La première colonne contenant l'objet ne sera pas visible
            dgvListeReservations.Columns["reservation"].Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            // Ouverture de la nouvelle fenêtre
            Menu frmMenu = new Menu(currentUser);
            this.Hide(); // le formulaire est caché
            frmMenu.ShowDialog(); // ouverture du formulaire 
        }

        // Affichage des détails au clic sur une cellule de la DGV
        private void dgvListeReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListeReservations.CurrentRow.Selected = true;

            // Récupération du numéro de la ligne (index)
            int indexRow = dgvListeReservations.CurrentRow.Index;

            // Si la ligne contient bien une valeur, on valorise les labels avec les valeurs correspondantes
            if (dgvListeReservations.Rows[indexRow].Cells[0].Value != DBNull.Value)
            {

                // Récupération de l'objet réservation (spectator)
                Spectator laReserv = (Spectator)dgvListeReservations.Rows[indexRow].Cells[0].Value;

                // Ajout du nom de la pièce
                lblLaPiece.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_name;

                // Ajout du nom du theme
                lblLeTheme.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_theme.Theme_name;

                // Ajout de la durée
                double doubleConvertDuree = double.Parse(laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                lblLaDuree.Text = convertDuree.ToString();

                // Ajout du type
                lblLeType.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_publicType.PublicType_name;

                // Ajout de la date et de l'heure de la représentation
                lblLaRepresentation.Text = laReserv.Spectator_show.Show_dateTime.ToString("MM/dd/yyyy à H:mm");

                // Ajout du nom de la compagnie
                lblLaCompagnie.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_company.Company_name;

                // Ajout du prix fixe
                lblLePrixFixe.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice.ToString() + " €";

                // Ajout du nom auquel la réservation a été faite
                lblLeNom.Text = laReserv.Spectator_lastname;

                // Ajout du prénom auquel la réservation a été faite
                lblLePrenom.Text = laReserv.Spectator_firstname;

                // Ajout du nombre de places réservées
                lblLeNbPlaces.Text = laReserv.Spectator_seatsBooked.ToString();

                // Ajout de l'email de la réservation
                lblLeEmail.Text = laReserv.Spectator_email;

                // Ajout du téléphone de la réservation
                lblLeTelephone.Text = laReserv.Spectator_phone;

                // Calcul du prix à payer
                float prixFixe = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice;
                int places = laReserv.Spectator_seatsBooked;
                float taux = laReserv.Spectator_show.Show_priceRate.PriceRate_rate;
                float prixHT = prixFixe * places;
                float total = prixHT + (prixHT * taux);

                // Ajout du prix à payer
                lblLePrixTotal.Text = total.ToString() + " €";
            }
            else // Si pas de valeur dans la cellule
            {
                // On valorise chaque label avec une valeur vide
                lblLaPiece.Text = "";

                lblLeTheme.Text = "";

                lblLaDuree.Text = "";

                lblLeType.Text = "";

                lblLaRepresentation.Text = "";

                lblLaCompagnie.Text = "";

                lblLePrixFixe.Text = "€";

                lblLeNom.Text = "";

                lblLePrenom.Text = "";

                lblLeNbPlaces.Text = "";

                lblLeEmail.Text = "";

                lblLeTelephone.Text = "";

                lblLePrixTotal.Text = "0 €";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Affichage du formulaire d'ajout
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grbDetails.Text = "Ajouter une réservation";

            #region Affiche et cache les champs concernés
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            lblLaPiece.Visible = false;
            lblLaRepresentation.Visible = false;
            lblLeNom.Visible = false;
            lblLePrenom.Visible = false;
            lblLeNbPlaces.Visible = false;
            lblLeEmail.Visible = false;
            lblLeTelephone.Visible = false;

            btnValiderAjout.Visible = true;
            btnAnnulerAjout.Visible = true;
            cmbPiece.Visible = true;
            cmbDates.Visible = true;
            cmbHeures.Visible = true;
            txtNom.Visible = true;
            txtPrenom.Visible = true;
            txtNbPlaces.Visible = true;
            txtEmail.Visible = true;
            txtTelephone.Visible = true;
            #endregion Affiche et cache les champs concernés

            List<TheaterPiece> lesPieces = ModulePiecesTheatre.GetTheaterPieces();

            foreach (var piece in lesPieces)
            {
                cmbPiece.Items.Add(piece.TheaterPiece_name);
            }

        }

        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            grbDetails.Text = "Détails de la réservation";

            #region Affiche et cache les champs concernés
            btnValiderAjout.Visible = false;
            btnAnnulerAjout.Visible = false;
            cmbPiece.Visible = false;
            cmbDates.Visible = false;
            cmbHeures.Visible = false;
            txtNom.Visible = false;
            txtPrenom.Visible = false;
            txtNbPlaces.Visible = false;
            txtEmail.Visible = false;
            txtTelephone.Visible = false;

            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            lblLaPiece.Visible = true;
            lblLaRepresentation.Visible = true;
            lblLeNom.Visible = true;
            lblLePrenom.Visible = true;
            lblLeNbPlaces.Visible = true;
            lblLeEmail.Visible = true;
            lblLeTelephone.Visible = true;
            #endregion Affiche et cache les champs concernés
        }

        private void cmbPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDates.Items.Clear();
            if (cmbPiece.SelectedItem != null && cmbPiece.SelectedItem.ToString() != "")
            {
                TheaterPiece laPiece = ModulePiecesTheatre.GetOneTheaterPiece(cmbPiece.SelectedItem.ToString());

                lblLeTheme.Text = laPiece.TheaterPiece_theme.Theme_name;
                lblLaDuree.Text = laPiece.TheaterPiece_duration.ToString();
                lblLeType.Text = laPiece.TheaterPiece_publicType.PublicType_name;
                lblLaCompagnie.Text = laPiece.TheaterPiece_company.Company_name;
                lblLePrixFixe.Text = laPiece.TheaterPiece_seatsPrice.ToString();

                List<Show> lesRepresentations = ModuleRepresentations.GetFilterShows(laPiece.TheaterPiece_id);

                if (lesRepresentations.Count > 0)
                {
                    foreach(var uneRep in lesRepresentations)
                    {
                        cmbDates.Items.Add(uneRep.Show_dateTime.ToString("dddd dd MMM yyyy"));
                        cmbDates.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmbDates.Items.Add("Aucune date disponible");
                    cmbDates.SelectedIndex = 0;
                }
            }
            else
            {
                lblLeTheme.Text = "";
                lblLaDuree.Text = "";
                lblLeType.Text = "";
                lblLaCompagnie.Text = "";
                lblLePrixFixe.Text = "";
            }
        }

        private void cmbDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHeures.Items.Clear();
            if(cmbDates.SelectedItem != null && cmbDates.SelectedItem.ToString() != "" && cmbDates.SelectedItem.ToString() != "Aucune date disponible")
            {
                TheaterPiece laPiece = ModulePiecesTheatre.GetOneTheaterPiece(cmbPiece.SelectedItem.ToString());
                List<Show> lesRepresentations = ModuleRepresentations.GetFilterShows(laPiece.TheaterPiece_id);
                
                foreach (var uneRep in lesRepresentations)
                {
                    if(uneRep.Show_dateTime.ToString("dddd dd MMM yyyy") == cmbDates.SelectedItem.ToString())
                    {
                        cmbHeures.Items.Add(uneRep.Show_dateTime.ToString("HH:mm"));
                    }
                }

            }
            else
            {
                cmbHeures.SelectedIndex = -1;
            }
        }
    }
}
