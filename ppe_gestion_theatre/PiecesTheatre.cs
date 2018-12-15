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
using TheaterDAL;

namespace ppe_gestion_theatre
{
    public partial class PiecesTheatre : Form
    {
        LoginInfo currentUser;

        public PiecesTheatre(LoginInfo currentUser)
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            //dgvListePiecesTheatre.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dgvListePiecesTheatre.DataSource = dt;

            dt.Columns.Add(new DataColumn("piece", typeof(PiecesTheatre)));

            dt.Columns.Add(new DataColumn("nom", typeof(string)));
            dgvListePiecesTheatre.Columns["Nom"].HeaderText = "Nom de la pièce";

            dt.Columns.Add(new DataColumn("auteur", typeof(string)));
            dgvListePiecesTheatre.Columns["Auteur"].HeaderText = "Auteur";
            
            dt.Columns.Add(new DataColumn("public", typeof(string)));
            dgvListePiecesTheatre.Columns["Public"].HeaderText = "Type de public";

            dt.Columns.Add(new DataColumn("theme", typeof(string)));
            dgvListePiecesTheatre.Columns["Theme"].HeaderText = "Thème";

            dt.Columns.Add(new DataColumn("durée", typeof(string)));
            dgvListePiecesTheatre.Columns["Durée"].HeaderText = "Durée";

            dt.Columns.Add(new DataColumn("prix", typeof(float)));
            dgvListePiecesTheatre.Columns["Prix"].HeaderText = "Prix du siège";

            dgvListePiecesTheatre.ReadOnly = true;
        
            #region test1-dgv
            // Création d'une en-tête de colonne pour la colonne 1
            //DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            //NomColumn.DataPropertyName = "Nom";
            //NomColumn.HeaderText = "Nom de la pièce";

            // Création d'une en-tête de colonne pour la colonne 2
            //DataGridViewTextBoxColumn AuteurColumn = new DataGridViewTextBoxColumn();
            //AuteurColumn.DataPropertyName = "Auteur";
            //AuteurColumn.HeaderText = "Auteur";

            // Création d'une en-tête de colonne pour la colonne 3
            //DataGridViewTextBoxColumn ThemeColumn = new DataGridViewTextBoxColumn();
            //ThemeColumn.DataPropertyName = "Thème";
            //ThemeColumn.HeaderText = "Thème";

            // Création d'une en-tête de colonne pour la colonne 4
            //DataGridViewTextBoxColumn PublicColumn = new DataGridViewTextBoxColumn();
            //PublicColumn.DataPropertyName = "Public";
            //PublicColumn.HeaderText = "Public";

            // Création d'une en-tête de colonne pour la colonne 5
            //DataGridViewTextBoxColumn DureeColumn = new DataGridViewTextBoxColumn();
            //DureeColumn.DataPropertyName = "Durée";
            //DureeColumn.HeaderText = "Durée";

            // Création d'une en-tête de colonne pour la colonne 6
            //DataGridViewTextBoxColumn PrixColumn = new DataGridViewTextBoxColumn();
            //PrixColumn.DataPropertyName = "Prix";
            //PrixColumn.HeaderText = "Prix fixe";

            // Ajout des 6 en-têtes de colonne au datagridview
            //dgvListePiecesTheatre.Rows.Add(NomColumn);
            //dgvListePiecesTheatre.Rows.Add(AuteurColumn);
            //dgvListePiecesTheatre.Rows.Add(ThemeColumn);
            //dgvListePiecesTheatre.Rows.Add(PublicColumn);
            //dgvListePiecesTheatre.Rows.Add(DureeColumn);
            //dgvListePiecesTheatre.Rows.Add(PrixColumn); 
            #endregion

            //test dgv
            foreach (TheaterPiece unePiece in PiecesTheatreDAO.GetTheaterPieces())
            {
                dt.Rows.Add(unePiece.TheaterPiece_name, unePiece.TheaterPiece_author.Author_firstname, unePiece.TheaterPiece_theme.Theme_name, unePiece.TheaterPiece_publicType.PublicType_name, unePiece.TheaterPiece_duration, unePiece.TheaterPiece_seatsPrice);
            }

            // Définition du style apporté au datagridview
            dgvListePiecesTheatre.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvListePiecesTheatre.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            ModulePiecesTheatre.SetchaineConnexion(ConfigurationManager.ConnectionStrings["dbGestionTheatre"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            //List<TheaterPiece> liste = new List<TheaterPiece>();
            //liste = ModulePiecesTheatre.GetTheaterPieces();

            // Rattachement de la List à la source de données de DataGridView
            //dgvListePiecesTheatre.DataSource = liste;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void dgvListeReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PiecesTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
