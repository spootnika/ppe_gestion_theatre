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
                int places = uneReservation.Spectator_seatsBooked;
                float taux = uneReservation.Spectator_show.Show_priceRate.PriceRate_rate;
                float prixHT = uneReservation.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice * places;
                float total = prixHT + (prixHT * taux);

                table.Rows.Add(uneReservation, piece, representation, duree, theme, typePublic, nom, places, total);
            }

            dgvListeReservations.Columns["reservation"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            // Ouverture de la nouvelle fenêtre
            Menu frmMenu = new Menu(currentUser);
            this.Hide(); // le formulaire est caché
            frmMenu.ShowDialog(); // ouverture du formulaire 
        }

        private void dgvListeReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvListeReservations.CurrentRow.Index;
            
            if (dgvListeReservations.Rows[indexRow].Cells[0].Value != DBNull.Value) {

                Spectator laReserv = (Spectator)dgvListeReservations.Rows[indexRow].Cells[0].Value;


                lblLaPiece.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_name;

                lblLeTheme.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_theme.Theme_name;

                lblLaDuree.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_duration.ToString();

                lblLeType.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_publicType.PublicType_name;

                lblLaRepresentation.Text = laReserv.Spectator_show.Show_dateTime.ToString("MM/dd/yyyy à H:mm");

                lblLaCompagnie.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_company.Company_name;

                lblLePrixFixe.Text = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice.ToString() + " €";

                lblLeNom.Text = laReserv.Spectator_lastname;

                lblLePrenom.Text = laReserv.Spectator_firstname;

                lblLeNbPlaces.Text = laReserv.Spectator_seatsBooked.ToString();

                lblLeEmail.Text = laReserv.Spectator_email;

                lblLeTelephone.Text = laReserv.Spectator_phone;

                float prixFixe = laReserv.Spectator_show.Show_theaterPiece.TheaterPiece_seatsPrice;
                int places = laReserv.Spectator_seatsBooked;
                float taux = laReserv.Spectator_show.Show_priceRate.PriceRate_rate;
                float prixHT = prixFixe * places;
                float total = prixHT + (prixHT * taux);

                lblLePrixTotal.Text = total.ToString() + " €";
            }
            else
            {


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
    }
}
