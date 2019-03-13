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
        private float taux;
        private float prixPlace;
        private List<Show> lesRepresentations;
        private Show laRepres;
        LoginInfo currentUser;

        public Reservations(LoginInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            LoadDataGridView();
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
                lblLaPiece.Text = String.Empty;

                lblLeTheme.Text = String.Empty;

                lblLaDuree.Text = String.Empty;

                lblLeType.Text = String.Empty;

                lblLaRepresentation.Text = String.Empty;

                lblLaCompagnie.Text = String.Empty;

                lblLePrixFixe.Text = "€";

                lblLeNom.Text = String.Empty;

                lblLePrenom.Text = String.Empty;

                lblLeNbPlaces.Text = String.Empty;

                lblLeEmail.Text = String.Empty;

                lblLeTelephone.Text = String.Empty;

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
            dgvListeReservations.Enabled = false;
            dgvListeReservations.ClearSelection();

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
            lblHeure.Visible = true;
            lblPlacesRest.Visible = true;
            lblLesPlacesRest.Visible = true;
            lblLesPlacesRest.Text = "";
            #endregion Affiche et cache les champs concernés

            lblReprésentation.Text = "Dates : ";

            lblLeTheme.Text = String.Empty;
            lblLaDuree.Text = String.Empty;
            lblLeType.Text = String.Empty;
            lblLaCompagnie.Text = String.Empty;
            lblLaPiece.Text = String.Empty;
            lblLaRepresentation.Text = String.Empty; 
            lblLeNom.Text = String.Empty;
            lblLePrenom.Text = String.Empty;
            lblLeNbPlaces.Text = String.Empty;
            lblLeEmail.Text = String.Empty;
            lblLeTelephone.Text = String.Empty;
            lblLePrixFixe.Text = "€";
            lblLePrixTotal.Text = "0 €";

            List<TheaterPiece> lesPieces = ModulePiecesTheatre.GetTheaterPieces();
            cmbPiece.DataSource = lesPieces;
            cmbPiece.DisplayMember = "theaterPiece_name";

            // Récupération de toutes les pièces disponibles et ajout dans la comboBox
            //foreach (var piece in lesPieces)
            //{
            //    cmbPiece.Items.Add(piece.TheaterPiece_name);
            //}

        }

        // Validation de l'ajout 
        private void btnValiderAjout_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == null || txtNom.Text == String.Empty || txtPrenom.Text == null || txtPrenom.Text == String.Empty || txtEmail.Text == null || txtEmail.Text == String.Empty || txtTelephone.Text == null || txtTelephone.Text == String.Empty || txtNbPlaces.Text == null || txtNbPlaces.Text == String.Empty)
            {
                errEmail.SetError(txtEmail, "Ce champ est requis !");
                errNbPlaces.SetError(txtNbPlaces, "Ce champ est requis !");
                errNom.SetError(txtNom, "Ce champ est requis !");
                errPrenom.SetError(txtPrenom, "Ce champ est requis !");
                errPhone.SetError(txtTelephone, "Ce champ est requis !");
            }
            else
            {
                Spectator uneReservation = new Spectator(txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTelephone.Text, laRepres, int.Parse(txtNbPlaces.Text));
                ModuleReservations.AddSpectator(uneReservation);


                grbDetails.Text = "Détails de la réservation";
                cmbHeures.Items.Clear();
                cmbDates.Items.Clear();

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
                lblHeure.Visible = false;
                lblPlacesRest.Visible = false;
                lblLesPlacesRest.Visible = false;
                lblLesPlacesRest.Text = "";

                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
                lblLaPiece.Visible = true;
                lblLaRepresentation.Visible = true;
                lblLeNom.Visible = true;
                lblLePrenom.Visible = true;
                lblLeNbPlaces.Visible = true;
                lblLeEmail.Visible = true;
                lblLeTelephone.Visible = true;
                dgvListeReservations.Enabled = true;
                #endregion Affiche et cache les champs concernés

                lblReprésentation.Text = "Représentation :";
                lblLeTheme.Text = String.Empty;
                lblLaDuree.Text = String.Empty;
                lblLeType.Text = String.Empty;
                lblLaCompagnie.Text = String.Empty;
                lblLePrixFixe.Text = "€";
                lblLePrixTotal.Text = "0 €";
                LoadDataGridView();
                dgvListeReservations.Refresh();
            }
        }

        // Annulation de l'ajout
        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            var rep = MessageBox.Show("Êtes vous sûr de vouloir annuler l'ajout de cette réservation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (rep == DialogResult.Yes)
            {
                grbDetails.Text = "Détails de la réservation";
                cmbHeures.Items.Clear();
                cmbDates.Items.Clear();

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
                lblHeure.Visible = false;
                lblPlacesRest.Visible = false;
                lblLesPlacesRest.Visible = false;
                lblLesPlacesRest.Text = "";

                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
                lblLaPiece.Visible = true;
                lblLaRepresentation.Visible = true;
                lblLeNom.Visible = true;
                lblLePrenom.Visible = true;
                lblLeNbPlaces.Visible = true;
                lblLeEmail.Visible = true;
                lblLeTelephone.Visible = true;
                dgvListeReservations.Enabled = true;
                #endregion Affiche et cache les champs concernés

                lblReprésentation.Text = "Représentation :";
                lblLeTheme.Text = String.Empty;
                lblLaDuree.Text = String.Empty;
                lblLeType.Text = String.Empty;
                lblLaCompagnie.Text = String.Empty;
                lblLePrixFixe.Text = "€";
                lblLePrixTotal.Text = "0 €";
            }
        }

        // Au changement de sélection d'une pièce
        private void cmbPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDates.Items.Clear();
            cmbHeures.Items.Clear();
            if (cmbPiece.SelectedItem != null)
            {
                TheaterPiece laPiece = cmbPiece.SelectedItem as TheaterPiece;

                lblLeTheme.Text = laPiece.TheaterPiece_theme.Theme_name;
                lblLaDuree.Text = laPiece.TheaterPiece_duration.ToString();
                lblLeType.Text = laPiece.TheaterPiece_publicType.PublicType_name;
                lblLaCompagnie.Text = laPiece.TheaterPiece_company.Company_name;
                lblLePrixFixe.Text = laPiece.TheaterPiece_seatsPrice.ToString()+" €";

                lesRepresentations = ModuleRepresentations.GetFilterShows(laPiece.TheaterPiece_id);

                if (lesRepresentations.Count > 0)
                {
                    cmbDates.Enabled = true;
                    foreach (var uneRep in lesRepresentations)
                    {
                        if (!cmbDates.Items.Contains(uneRep.Show_dateTime.ToString("dd/MM/yyyy")))
                        {
                            cmbDates.Items.Add(uneRep.Show_dateTime.ToString("dd/MM/yyyy"));
                        }
                    }
                }
                else
                {
                    cmbDates.Enabled = false;
                    cmbDates.Items.Add("Aucune date disponible");
                }
                cmbDates.SelectedIndex = 0;
            }
            else
            {
                lblLeTheme.Text = String.Empty;
                lblLaDuree.Text = String.Empty;
                lblLeType.Text = String.Empty;
                lblLaCompagnie.Text = String.Empty;
                lblLePrixFixe.Text = "€";
                lblLePrixTotal.Text = "0 €";
            }
        }

        // Au changement de sélection d'une date
        private void cmbDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHeures.Items.Clear();
            if (cmbDates.SelectedItem != null && cmbDates.SelectedItem.ToString() != String.Empty && cmbDates.SelectedItem.ToString() != "Aucune date disponible")
            {
                cmbHeures.Enabled = true;

                foreach (var uneRep in lesRepresentations)
                {
                    if (uneRep.Show_dateTime.ToString("dd/MM/yyyy") == cmbDates.SelectedItem.ToString())
                    {
                        cmbHeures.Items.Add(uneRep.Show_dateTime.ToString("HH:mm"));
                    }
                }
                cmbHeures.SelectedIndex = 0;

            }
            else
            {
                cmbHeures.Enabled = false;
                cmbHeures.Items.Add("");
                cmbHeures.SelectedIndex = 0;
            }
        }

        // Affichage du prix total en fonction de ce qui est entré dans le champs nbPlaces
        private void txtNbPlaces_TextChanged(object sender, EventArgs e)
        {

            ChangementPrixTotal();
        }
        
        private void cmbHeures_SelectedValueChanged(object sender, EventArgs e)
        {

            foreach (var uneRep in lesRepresentations)
            {
                if (uneRep.Show_dateTime.ToString("dd/MM/yyyy") == cmbDates.SelectedItem.ToString() && uneRep.Show_dateTime.ToString("HH:mm") == cmbHeures.SelectedItem.ToString())
                {
                    laRepres = uneRep;
                    taux = uneRep.Show_priceRate.PriceRate_rate;
                    prixPlace = uneRep.Show_theaterPiece.TheaterPiece_seatsPrice;
                }
            }

            ChangementPrixTotal();
        }

        private void ChangementPrixTotal()
        {
            if (txtNbPlaces.Text.Length > 0)
            {
                int nbPlaces;
                if (int.TryParse(txtNbPlaces.Text, out nbPlaces))
                {
                    float prixHT = prixPlace * nbPlaces;
                    float total = prixHT + (prixHT * taux);

                    lblLePrixTotal.Text = total.ToString() + " €";
                }
                else
                {
                    lblLePrixTotal.Text = "0 €";
                }
            }
            else
            {
                lblLePrixTotal.Text = "0 €";
            }
        }

        #region Error Provider
        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;

            if (!ModuleReservations.ValidChampTxt(txtNom.Text, out errMsg))
            {
                e.Cancel = true;
                txtNom.Select(0, txtNom.Text.Length);
                errNom.SetError(txtNom, errMsg);
            }

        }

        private void txtNom_Validated(object sender, EventArgs e)
        {
            errNom.SetError(txtNom, "");
        }

        private void txtPrenom_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;

            if (!ModuleReservations.ValidChampTxt(txtPrenom.Text, out errMsg))
            {
                e.Cancel = true;
                txtPrenom.Select(0, txtPrenom.Text.Length);
                errNom.SetError(txtPrenom, errMsg);
            }
        }

        private void txtPrenom_Validated(object sender, EventArgs e)
        {
            errNom.SetError(txtPrenom, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;

            if (!ModuleReservations.ValidChampEmail(txtEmail.Text, out errMsg))
            {
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);
                errNom.SetError(txtEmail, errMsg);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errNom.SetError(txtEmail, "");
        }

        private void txtTelephone_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;

            if (!ModuleReservations.ValidChampPhone(txtTelephone.Text, out errMsg))
            {
                e.Cancel = true;
                txtTelephone.Select(0, txtTelephone.Text.Length);
                errNom.SetError(txtTelephone, errMsg);
            }
        }

        private void txtTelephone_Validated(object sender, EventArgs e)
        {
            errNom.SetError(txtTelephone, "");
        }


        private void txtNbPlaces_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;

            if (!ModuleReservations.ValidChampNb(txtNbPlaces.Text, out errMsg))
            {
                e.Cancel = true;
                txtTelephone.Select(0, txtNbPlaces.Text.Length);
                errNom.SetError(txtNbPlaces, errMsg);
            }
        }

        private void txtNbPlaces_Validated(object sender, EventArgs e)
        {
            errNom.SetError(txtNbPlaces, "");
        }
        #endregion Error Provider

        private void LoadDataGridView()
        {
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
    }
}
