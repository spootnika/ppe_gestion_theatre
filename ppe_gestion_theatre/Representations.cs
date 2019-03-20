using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        #region errorProvider messages
        private bool ValidHeure(string heureSaisie, out string errorMessage)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("fr-FR");
            DateTime maDate;
            DateTime HeureDebut = DateTime.Parse("14:00", culture);
            //  DateTime HeureFin = DateTime.Parse("23:59", culture);
            DateTimeStyles styles;
            styles = DateTimeStyles.None;
            bool retConv = DateTime.TryParse(heureSaisie, culture, styles, out maDate);
            if (heureSaisie.Trim() == "")
            {
                errorMessage = "Veuillez entrer une heure pour la représentation.";
            }
            else if (maDate.TimeOfDay < HeureDebut.TimeOfDay)
            {
                errorMessage = "Il ne peut y avoir de représentation avant 14h.";
                retConv = false;
            }
            else
            {
                errorMessage = "Veuillez entrer l'heure au fomat HH:mm.";
            }

            return retConv;
        }
        private bool ValidPlaces(string nbPlacesSaisie, out string errorMessage)
        {
            int nbPlaces;
            bool retConv = int.TryParse(nbPlacesSaisie, out nbPlaces);
            if (nbPlacesSaisie.Trim() == "")
            {
                errorMessage = "Veuillez entrer un nombre de places pour la représentation.";
            }
            else
            {
                errorMessage = "Veuillez entrer un nombre.";
            }
            return retConv;
        }
        #endregion errorProvider messages

        private void afficherRepresentations()
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

            afficherRepresentations();

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //quand on clique sur le bouton affichage des cases de saisie
            grbAjoutRepresentation.Visible = true;

            grbFiltres.Enabled = false;
            dgvListeRepresentations.Enabled = false;

            // Remplissable de la comboBox avec les pièces de théâtre
            cbChoixPieceSaisieShow.DataSource = ModulePiecesTheatre.GetTheaterPieces();
            cbChoixPieceSaisieShow.DisplayMember = "theaterPiece_name";


        }

        private void btnValiderAjout_Click(object sender, EventArgs e)
        {

            if (saisieDateShow.Text.Trim() != "" && saisieHeureShow.Text.Trim() != "" && saisiePlacesShow.Text.Trim() != "" && cbChoixPieceSaisieShow.Text.Trim() != "")
            {
                //on récupère date saisie et heure à mettre en datetime         
                string mesdates = saisieDateShow.Text.ToString() + " " + saisieHeureShow.Text.ToString();
                DateTime parsedDate = DateTime.Parse(mesdates);
                //on vérifie l'heure pour voir dans quelle tranche de pricerate on va 
                List<PriceRate> Lestaux = new List<PriceRate>();
                Lestaux = ModuleRepresentations.GetPriceRate();
                List<PriceRate> LestauxdansLHeure = new List<PriceRate>();
                PriceRate monTaux = null;
                foreach (PriceRate unTaux in Lestaux)
                {
                    TimeSpan debutHeure = unTaux.PriceRate_startTime;
                    TimeSpan finHeure = unTaux.PriceRate_endTime;
                    TimeSpan monHeure = TimeSpan.Parse(saisieHeureShow.Text.ToString());
                    if (debutHeure <= monHeure && monHeure <= finHeure)
                    {
                        LestauxdansLHeure.Add(unTaux);
                    }
                }
                //on vérifie le jour et on a le pricerate !!!!
                int monJour = (int)parsedDate.DayOfWeek;

                foreach (PriceRate unTaux in LestauxdansLHeure)
                {
                    foreach (WeekDays unJour in unTaux.PriceRate_weekDays)
                    {
                        if (unJour.WeekDays_id == monJour)
                        {
                            monTaux = unTaux;
                        }
                    }

                }
                //on récupère nb places
                int mesPlaces = int.Parse(saisiePlacesShow.Text.ToString());
                //on récupère la pièce de théâtre
                TheaterPiece maPiece = ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPieceSaisieShow.Text);
              float duree=  maPiece.TheaterPiece_duration;
                // Création de l'objet Show 
                Show show = new Show(parsedDate, mesPlaces, monTaux, maPiece);
                //TimeSpan madureeShowFin = TimeSpan.FromHours((double)duree) + show.Show_dateTime.TimeOfDay;
                //récupérer les datetime de toutes représentations 
                bool trouve = false;
                List<Show> lesRepresentations = ModuleRepresentations.GetShows();
                //s'il existe déjà une représentation à la date afficher message d'erreur
                foreach (Show uneRepresentation in lesRepresentations)
                {
                    TimeSpan madureeFin = TimeSpan.FromHours((double)duree) + uneRepresentation.Show_dateTime.TimeOfDay;
                
                    
                    if (uneRepresentation.Show_dateTime.Date == show.Show_dateTime.Date)
                    {
                        if(uneRepresentation.Show_dateTime.TimeOfDay <= show.Show_dateTime.TimeOfDay && show.Show_dateTime.TimeOfDay < madureeFin)
                        {
                            trouve = true;
                        }
                       
                    }
                }
                if (trouve == true)
                {
                    MessageBox.Show("Vous ne pouvez pas ajouter 2 représentations au même moment.", "Ajout de la représentation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("Etes vous sur de vouloir ajouter cette représentation ?", "Ajout de la représentation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        // Appel de la méthode CreerUtilisateur de la couche BLL
                        ModuleRepresentations.CreateShow(show);
                        MessageBox.Show("La représentation a bien été ajoutée.", "Ajout de la représentation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbAjoutRepresentation.Visible = false;
                        saisieHeureShow.Text = "";
                        saisiePlacesShow.Text= "";
                        DateTime today = DateTime.Today;
                        saisieDateShow.Text = today.ToString();
                        afficherRepresentations();
                   

                        grbFiltres.Enabled = true;
                        dgvListeRepresentations.Enabled = true;
                    }
                }

            }

        }

        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            grbAjoutRepresentation.Visible = false;

            grbFiltres.Enabled = true;
            dgvListeRepresentations.Enabled = true;
        }

        //change le rpxi réel en fonction de la pièce sélectionnée dans ajoutReprésentation
        private void cbChoixPieceSaisieShow_TextChanged(object sender, EventArgs e)
        {
            //on affiche le prix
            TheaterPiece maPiece = ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPieceSaisieShow.Text);
            if (maPiece != null)
            {
                lblPrixFixeAjoutRep.Text = maPiece.TheaterPiece_seatsPrice.ToString() + " €";
            }

        }

        private void saisieDateShow_ValueChanged(object sender, EventArgs e)
        {
            //on récupère date saisie et heure à mettre en datetime         
            string mesdates = saisieDateShow.Text.ToString() + " " + saisieHeureShow.Text.ToString();
            DateTime parsedDate;
            bool retConv = DateTime.TryParse(mesdates, out parsedDate);
            if (retConv == true && saisieDateShow.Text.Trim() != "" && saisieHeureShow.Text.Trim() != "")
            {
                //on vérifie l'heure pour voir dans quelle tranche de pricerate on va 
                List<PriceRate> Lestaux = new List<PriceRate>();
                Lestaux = ModuleRepresentations.GetPriceRate();
                List<PriceRate> LestauxdansLHeure = new List<PriceRate>();
                PriceRate monTaux = null;
                foreach (PriceRate unTaux in Lestaux)
                {
                    TimeSpan debutHeure = unTaux.PriceRate_startTime;
                    TimeSpan finHeure = unTaux.PriceRate_endTime;
                    TimeSpan monHeure = TimeSpan.Parse(saisieHeureShow.Text.ToString());
                    if (debutHeure <= monHeure && monHeure <= finHeure)
                    {
                        LestauxdansLHeure.Add(unTaux);
                    }
                }
                //on vérifie le jour et on a le pricerate !!!!
                string monJour = parsedDate.ToString("dddd");

                foreach (PriceRate unTaux in LestauxdansLHeure)
                {
                    foreach (WeekDays unJour in unTaux.PriceRate_weekDays)
                    {
                        if (unJour.WeekDays_name == monJour)
                        {
                            monTaux = unTaux;
                        }
                    }

                }
                if (monTaux != null)
                {
                    float seatPrice = ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPieceSaisieShow.Text).TheaterPiece_seatsPrice;
                    float prixReel = seatPrice + (seatPrice * monTaux.PriceRate_rate);
                    lblPrixrel.Text = prixReel.ToString() + " €";
                }

            }
        }

        private void saisieHeureShow_TextChanged(object sender, EventArgs e)
        {
            //on récupère date saisie et heure à mettre en datetime         
            string mesdates = saisieDateShow.Text.ToString() + " " + saisieHeureShow.Text.ToString();
            DateTime parsedDate;
            bool retConv = DateTime.TryParse(mesdates, out parsedDate);
            if (retConv == true && saisieDateShow.Text.Trim() != "" && saisieHeureShow.Text.Trim() != "")
            {
                //on vérifie l'heure pour voir dans quelle tranche de pricerate on va 
                List<PriceRate> Lestaux = new List<PriceRate>();
                Lestaux = ModuleRepresentations.GetPriceRate();
                List<PriceRate> LestauxdansLHeure = new List<PriceRate>();
                PriceRate monTaux = null;
                foreach (PriceRate unTaux in Lestaux)
                {
                    TimeSpan debutHeure = unTaux.PriceRate_startTime;
                    TimeSpan finHeure = unTaux.PriceRate_endTime;
                    TimeSpan maSaisie;
                    if (TimeSpan.TryParse(saisieHeureShow.Text.ToString(), out maSaisie)==true)
                    {
                        TimeSpan monHeure = TimeSpan.Parse(saisieHeureShow.Text.ToString());
                        if (debutHeure <= monHeure && monHeure <= finHeure)
                        {
                            LestauxdansLHeure.Add(unTaux);
                        }
                    }
                   
                }
                //on vérifie le jour et on a le pricerate !!!!
                string monJour = parsedDate.ToString("dddd");

                foreach (PriceRate unTaux in LestauxdansLHeure)
                {
                    foreach (WeekDays unJour in unTaux.PriceRate_weekDays)
                    {
                        if (unJour.WeekDays_name == monJour)
                        {
                            monTaux = unTaux;
                        }
                    }

                }
                if (monTaux != null)
                {
                    float seatPrice = ModulePiecesTheatre.GetOneTheaterPiece(cbChoixPieceSaisieShow.Text).TheaterPiece_seatsPrice;
                    float prixReel = seatPrice + (seatPrice * monTaux.PriceRate_rate);
                    lblPrixrel.Text = prixReel.ToString() + " €";
                }
            }
        }

        #region errorProvider

        private void saisieHeureShow_Validating(object sender, CancelEventArgs e)
        {
            string error = "";
            if (ValidHeure(saisieHeureShow.Text, out error) == false)
            {
                e.Cancel = true;
                saisieHeureShow.Select(0, saisieHeureShow.Text.Length);
                errorProviderFormatHeure.SetError(saisieHeureShow, error);
            }

        }

        private void saisieHeureShow_Validated(object sender, EventArgs e)
        {
            errorProviderFormatHeure.SetError(saisieHeureShow, "");
        }

        private void saisiePlacesShow_Validated(object sender, EventArgs e)
        {
            errorProviderFormatPlaces.SetError(saisiePlacesShow, "");
        }

        private void saisiePlacesShow_Validating(object sender, CancelEventArgs e)
        {
            string error = "";
            if (ValidPlaces(saisiePlacesShow.Text, out error) == false)
            {
                e.Cancel = true;
                saisiePlacesShow.Select(0, saisieHeureShow.Text.Length);
                errorProviderFormatPlaces.SetError(saisiePlacesShow, error);
            }
        }
        #endregion errorProvider
    }
}

