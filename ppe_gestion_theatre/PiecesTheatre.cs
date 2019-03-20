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
        private Company laCompagnie;
        private Author leAuteur;
        private PublicType leTypePublic;
        private Theme leTheme;

        public PiecesTheatre(LoginInfo currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;

            ListePiece();

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
            grbDetails.Text = "Détails de la pièce de théatre";
            lblLaPiece.Visible = true;
            lblLeTheme.Visible = true;
            lblLaDuree.Visible = true;
            lblLeAuteur.Visible = true;
            lblLeType.Visible = true;
            lblLaDescription.Visible = true;
            lblLaCompagnie.Visible = true;
            lblLePrixFixe.Visible = true;
            lblLaNationalite.Visible = true;

            textBoxNomPiece.Visible = false;
            textBoxPrixFixe.Visible = false;
            textBoxDuree.Visible = false;
            textBoxCommentaire.Visible = false;
            comboBoxAuteur.Visible = false;
            comboBoxCompagnie.Visible = false;
            comboBoxTheme.Visible = false;
            comboBoxPublic.Visible = false;

            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnValider.Visible = false;
            btnAnnuler.Visible = false;

            dgvListePiecesTheatre.CurrentRow.Selected = true;

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

                double doubleConvertDuree = double.Parse(laPiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                lblLaDuree.Text = convertDuree.ToString();

                // Ajout du type
                lblLeType.Text = laPiece.TheaterPiece_publicType.PublicType_name;

                // Ajout de l'auteur
                lblLeAuteur.Text = laPiece.TheaterPiece_author.Author_firstname + " " + laPiece.TheaterPiece_author.Author_lastname;

                // Ajout de la nationnalité
                lblLaNationalite.Text = "";
                int indNat = 1;

                // on affiche la(es) nationalité(s) que possède l'auteur 
                foreach (Nationality laNationalite in laPiece.TheaterPiece_author.Author_nationalities)
                {
                    lblLaNationalite.Text += laNationalite.Nationality_name;

                    if (indNat < laPiece.TheaterPiece_author.Author_nationalities.Count)
                    {
                        indNat++;
                        // si plusieurs nationalité, les deux nationalités sont séparés d'un ","
                        lblLaNationalite.Text += ", ";
                    }
                }

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grbDetails.Text = "Ajout d'une pièce de théatre";
            lblLaPiece.Visible = false;
            lblLeTheme.Visible = false;
            lblLaDuree.Visible = false;
            lblLeAuteur.Visible = false;
            lblLeType.Visible = false;
            lblLaDescription.Visible = false;
            lblLaCompagnie.Visible = false;
            lblLePrixFixe.Visible = false;
            lblLaNationalite.Visible = false;

            dgvListePiecesTheatre.Enabled = false;

            textBoxNomPiece.Visible = true;
            textBoxPrixFixe.Visible = true;
            textBoxDuree.Visible = true;
            textBoxCommentaire.Visible = true;
            comboBoxAuteur.Visible = true;
            comboBoxCompagnie.Visible = true;
            comboBoxTheme.Visible = true;
            comboBoxPublic.Visible = true;

            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnValider.Visible = true;
            btnAnnuler.Visible = true;


            List<Author> lesAuteurs = PiecesTheatreDAO.GetAuthors();
            comboBoxAuteur.DataSource = lesAuteurs;
            comboBoxAuteur.DisplayMember = "author_lastname";

            List<Theme> lesThemes = PiecesTheatreDAO.GetThemes();
            comboBoxTheme.DataSource = lesThemes;
            comboBoxTheme.DisplayMember = "theme_name";

            List<PublicType> lesTypes = PiecesTheatreDAO.GetTypesPublic();
            comboBoxPublic.DataSource = lesTypes;
            comboBoxPublic.DisplayMember = "publicType_name";

            List<Company> lesCompagnies = PiecesTheatreDAO.GetCompagnies();
            comboBoxCompagnie.DataSource = lesCompagnies;
            comboBoxCompagnie.DisplayMember = "company_name";

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (textBoxNomPiece.Text == String.Empty || textBoxDuree.Text == String.Empty || textBoxPrixFixe.Text == String.Empty)
            {
                errorProviderDuree.SetError(textBoxDuree, "Ce champ est requis !");
                errorProviderNomPiece.SetError(textBoxNomPiece, "Ce champ est requis !");
                errorProviderPrixFixe.SetError(textBoxPrixFixe, "Ce champ est requis !");
            }
            else
            {
                leAuteur = comboBoxAuteur.SelectedItem as Author;
                laCompagnie = comboBoxCompagnie.SelectedItem as Company;
                leTypePublic = comboBoxPublic.SelectedItem as PublicType;
                leTheme = comboBoxTheme.SelectedItem as Theme;

                TheaterPiece unePiece = new TheaterPiece(textBoxNomPiece.Text, textBoxCommentaire.Text, float.Parse(textBoxDuree.Text), float.Parse(textBoxPrixFixe.Text), laCompagnie, leAuteur, leTypePublic, leTheme);
                ModulePiecesTheatre.AddTheaterPiece(unePiece);

                grbDetails.Text = "Détails de la pièce de théatre";
                lblLaPiece.Visible = true;
                lblLeTheme.Visible = true;
                lblLaDuree.Visible = true;
                lblLeAuteur.Visible = true;
                lblLeType.Visible = true;
                lblLaDescription.Visible = true;
                lblLaCompagnie.Visible = true;
                lblLePrixFixe.Visible = true;
                lblLaNationalite.Visible = true;

                dgvListePiecesTheatre.Enabled = true;

                textBoxNomPiece.Visible = false;
                textBoxPrixFixe.Visible = false;
                textBoxDuree.Visible = false;
                textBoxCommentaire.Visible = false;
                comboBoxAuteur.Visible = false;
                comboBoxCompagnie.Visible = false;
                comboBoxTheme.Visible = false;
                comboBoxPublic.Visible = false;

                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
                btnValider.Visible = false;
                btnAnnuler.Visible = false;

                dgvListePiecesTheatre.CurrentRow.Selected = true;

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

                ListePiece();
                // MessageBox.Show("zer");

            }

        }

        private void ListePiece()
        {
            // Liste qui récupère la liste des pieces de théatre dans le ModulePiecesTheatre
            List<TheaterPiece> lesPiecesTheatre = ModulePiecesTheatre.GetTheaterPieces();

            DataTable dt = new DataTable();
            dgvListePiecesTheatre.DataSource = dt;

            // Ajout des colonnes necéssaires au tableau
            dt.Columns.Add(new DataColumn("piece", typeof(TheaterPiece)));

            dt.Columns.Add(new DataColumn("nom", typeof(string)));
            dgvListePiecesTheatre.Columns["Nom"].HeaderText = "Nom de la pièce";

            dt.Columns.Add(new DataColumn("auteur", typeof(string)));
            dgvListePiecesTheatre.Columns["Auteur"].HeaderText = "Auteur";

            dt.Columns.Add(new DataColumn("public", typeof(string)));
            dgvListePiecesTheatre.Columns["Public"].HeaderText = "Type de public";

            dt.Columns.Add(new DataColumn("theme", typeof(string)));
            dgvListePiecesTheatre.Columns["Theme"].HeaderText = "Thème";

            dt.Columns.Add(new DataColumn("durée", typeof(TimeSpan)));
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

            // Pour chaque piece dans la liste lesPiecesTheatres, on affiche les données dans les colonnes 
            foreach (TheaterPiece unePiece in lesPiecesTheatre)
            {
                string nomPiece = unePiece.TheaterPiece_name;

                string nomAuteur = unePiece.TheaterPiece_author.Author_firstname + " " + unePiece.TheaterPiece_author.Author_lastname;

                string nomTheme = unePiece.TheaterPiece_theme.Theme_name;

                string typePublic = unePiece.TheaterPiece_publicType.PublicType_name;

                double doubleConvertDuree = double.Parse(unePiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                string duree = convertDuree.ToString();

                float prix = unePiece.TheaterPiece_seatsPrice;

                dt.Rows.Add(unePiece, nomPiece, nomAuteur, typePublic, nomTheme, duree, prix);
            }


            // La première colonne contenant l'objet ne sera pas visible
            dgvListePiecesTheatre.Columns["piece"].Visible = false;
        }

        private void PiecesTheatre_Load(object sender, EventArgs e)
        {

        }

        private void grbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var rep = MessageBox.Show("Êtes vous sûr de vouloir annuler l'ajout de cette pièce de théatre ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (rep == DialogResult.Yes)
            {
                
                dgvListePiecesTheatre.Enabled = true;

                grbDetails.Text = "Détails de la pièce de théatre";

                #region Affiche et cache les champs concernés
                lblLaPiece.Visible = true;
                lblLeTheme.Visible = true;
                lblLaDuree.Visible = true;
                lblLeAuteur.Visible = true;
                lblLeType.Visible = true;
                lblLaDescription.Visible = true;
                lblLaCompagnie.Visible = true;
                lblLePrixFixe.Visible = true;
                lblLaNationalite.Visible = true;

                textBoxNomPiece.Visible = false;
                textBoxPrixFixe.Visible = false;
                textBoxDuree.Visible = false;
                textBoxCommentaire.Visible = false;
                comboBoxAuteur.Visible = false;
                comboBoxCompagnie.Visible = false;
                comboBoxTheme.Visible = false;
                comboBoxPublic.Visible = false;

                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
                btnValider.Visible = false;
                btnAnnuler.Visible = false;
                #endregion Affiche et cache les champs concernés

                lblLaPiece.Text = "";

                lblLeTheme.Text = "";

                lblLaDuree.Text = "";

                lblLeAuteur.Text = "";

                lblLeType.Text = "";

                lblLaDescription.Text = "";

                lblLaCompagnie.Text = "";

                lblLePrixFixe.Text = "0 €";

                lblLaNationalite.Text = "";
            }
        }
    }
}
