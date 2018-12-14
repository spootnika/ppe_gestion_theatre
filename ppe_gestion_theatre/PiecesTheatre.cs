using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TheaterBLL; // Référence la couche BLL
using TheaterBO; // Référence la couche BO

namespace ppe_gestion_theatre
{
    public partial class PiecesTheatre : Form
    {
        public PiecesTheatre(LoginInfo currentUser)
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            dgvListePiecesTheatre.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom de la pièce";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn AuteurColumn = new DataGridViewTextBoxColumn();
            AuteurColumn.DataPropertyName = "Auteur";
            AuteurColumn.HeaderText = "Auteur";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn ThemeColumn = new DataGridViewTextBoxColumn();
            ThemeColumn.DataPropertyName = "Thème";
            ThemeColumn.HeaderText = "Thème";
            
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn PublicColumn = new DataGridViewTextBoxColumn();
            PublicColumn.DataPropertyName = "Public";
            PublicColumn.HeaderText = "Public";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn DureeColumn = new DataGridViewTextBoxColumn();
            DureeColumn.DataPropertyName = "Durée";
            DureeColumn.HeaderText = "Durée";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn PrixColumn = new DataGridViewTextBoxColumn();
            PrixColumn.DataPropertyName = "Prix";
            PrixColumn.HeaderText = "Prix fixe";

            // Ajout des 6 en-têtes de colonne au datagridview
            //dgvListePiecesTheatre.Add(NomColumn);
            //dgvListePiecesTheatre.Add(AuteurColumn);
            //dgvListePiecesTheatre.Add(ThemeColumn);
            //dgvListePiecesTheatre.Add(PublicColumn);
            //dgvListePiecesTheatre.Add(DureeColumn);
            //dgvListePiecesTheatre.Add(PrixColumn);

            // Définition du style apporté au datagridview
            dgvListePiecesTheatre.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvListePiecesTheatre.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            ModulePiecesTheatre.SetchaineConnexion(ConfigurationManager.ConnectionStrings["PièceThéatre"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<TheaterPiece> liste = new List<TheaterPiece>();
            liste = ModulePiecesTheatre.GetTheaterPieces();

            // Rattachement de la List à la source de données de DataGridView
            dgvListePiecesTheatre.DataSource = liste;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void dgvListeReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
