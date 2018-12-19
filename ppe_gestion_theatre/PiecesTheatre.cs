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

            this.currentUser = currentUser;

            List<TheaterPiece> lesPiecesTheatre = ModulePiecesTheatre.GetTheaterPieces();

            // Blocage de la génération automatique des colonnes
            //dgvListePiecesTheatre.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dgvListePiecesTheatre.DataSource = dt;

            dt.Columns.Add(new DataColumn("piece", typeof(TheaterPiece)));

            dt.Columns.Add(new DataColumn("nom", typeof(string)));
            dgvListePiecesTheatre.Columns["Nom"].HeaderText = "Nom de la pièce";

            dt.Columns.Add(new DataColumn("auteur", typeof(string)));
            dgvListePiecesTheatre.Columns["Auteur"].HeaderText = "Auteur";
            
            dt.Columns.Add(new DataColumn("public", typeof(string)));
            dgvListePiecesTheatre.Columns["Public"].HeaderText = "Type de public";

            dt.Columns.Add(new DataColumn("theme", typeof(string)));
            dgvListePiecesTheatre.Columns["Theme"].HeaderText = "Thème";

            dt.Columns.Add(new DataColumn("durée", typeof(float)));
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
            foreach (TheaterPiece unePiece in lesPiecesTheatre)
            {
                string nomPiece = unePiece.TheaterPiece_name;

                string nomAuteur = unePiece.TheaterPiece_author.Author_firstname + " " + unePiece.TheaterPiece_author.Author_lastname;

                string nomTheme = unePiece.TheaterPiece_theme.Theme_name;

                string typePublic = unePiece.TheaterPiece_publicType.PublicType_name;

                float duree = unePiece.TheaterPiece_duration;

                float prix = unePiece.TheaterPiece_seatsPrice;

                dt.Rows.Add(unePiece, nomPiece, nomAuteur, typePublic, nomTheme, duree, prix);
            }


            // La première colonne contenant l'objet ne sera pas visible
            dgvListePiecesTheatre.Columns["piece"].Visible = false;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            //List<TheaterPiece> liste = new List<TheaterPiece>();
            //liste = ModulePiecesTheatre.GetTheaterPieces();

            // Rattachement de la List à la source de données de DataGridView
            //dgvListePiecesTheatre.DataSource = liste;

            // Définit un style pour la bordure du formulaire

        }

        

        private void PiecesTheatre_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvListePiecesTheatre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvListePiecesTheatre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Récupération du numéro de la ligne (index)
            int indexRow = dgvListePiecesTheatre.CurrentRow.Index;

            // Si la ligne contient bien une valeur, on valorise les labels avec les valeurs correspondantes
            if (dgvListePiecesTheatre.Rows[indexRow].Cells[0].Value != DBNull.Value)
            {

                // Récupération de l'objet TheaterPiece 
                TheaterPiece laPiece = (TheaterPiece)dgvListePiecesTheatre.Rows[indexRow].Cells[0].Value;

                // Ajout du nom de la pièce
                lblLaPiece.Text = laPiece.TheaterPiece_name;



                // Ajout du nom du theme
                lblLeTheme.Text = laPiece.TheaterPiece_theme.Theme_name;

                // Ajout de la durée
                lblLaDuree.Text = laPiece.TheaterPiece_duration.ToString();

                // Ajout du type
                lblLeType.Text = laPiece.TheaterPiece_publicType.PublicType_name;

                // Ajout de l'auteur
                lblLeAuteur.Text = laPiece.TheaterPiece_author.Author_firstname + " " + laPiece.TheaterPiece_author.Author_lastname;

                // Ajout de la nationnalité
                //lblLaNationalite.Text = laPiece.TheaterPiece_author.Author_nationalities.

                // Ajout du nom de la compagnie
                lblLaCompagnie.Text = laPiece.TheaterPiece_company.Company_name;

                // Ajout du prix fixe
                lblLePrixFixe.Text = laPiece.TheaterPiece_seatsPrice.ToString() + " €";

                // Ajout de la description
                lblLaDescription.Text = laPiece.TheaterPiece_description;

            }
            else // Si pas de valeur dans la cellule
            {
                // On valorise chaque label avec une valeur vide
                lblLaPiece.Text = "";

                lblLeTheme.Text = "";

                lblLaDuree.Text = "";

                lblLeAuteur.Text = "";

                lblLeType.Text = "";

                lblLaDescription.Text = "";

                lblLaCompagnie.Text = "";

                lblLePrixFixe.Text = "€";

                lblLaNationalite.Text = "";

            }
        }
    }
}
