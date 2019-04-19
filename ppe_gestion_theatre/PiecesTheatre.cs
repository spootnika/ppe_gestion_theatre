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
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;

            grbDetails.Text = "Détails de la pièce de théatre";
            lblLaPiece.Visible = true;
            lblLeTheme.Visible = true;
            lblLaDuree.Visible = true;
            lblLeAuteur.Visible = true;
            lblLeType.Visible = true;
            lblLaDescription.Visible = true;
            lblLaCompagnie.Visible = true;
            lblLePrixFixe.Visible = true;
            lblLaNationalite.Text = string.Empty;
            lblLaNationalite.Visible = true;
            lblIdPiece.Visible = false;

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

                // Ajout id de la piece
                lblIdPiece.Text = laPiece.TheaterPiece_id.ToString();



                // Ajout du nom du theme
                lblLeTheme.Text = laPiece.TheaterPiece_theme.Theme_name;

                // Ajout de la durée

                //TimeSpan dureeTS = TimeSpan.FromMinutes(double.Parse(textBoxDuree.Text));
                //float dureeFl = (float)dureeTS.TotalHours;
                //TheaterPiece unePiece = new TheaterPiece(textBoxNomPiece.Text, textBoxCommentaire.Text, dureeFl, float.Parse(textBoxPrixFixe.Text), laCompagnie, leAuteur, leTypePublic, leTheme);
                //ModulePiecesTheatre.AddTheaterPiece(unePiece);

                TimeSpan dureeTS = TimeSpan.FromHours(double.Parse(laPiece.TheaterPiece_duration.ToString()));

                float convertDuree = (float)dureeTS.TotalMinutes;

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
            lblLaNationalite.Text = string.Empty;
            //lblLaNationalite.Visible = false;

            dgvListePiecesTheatre.Enabled = false;

            textBoxNomPiece.Visible = true;
            textBoxPrixFixe.Visible = true;
            textBoxDuree.Visible = true;
            textBoxCommentaire.Visible = true;
            comboBoxAuteur.Visible = true;
            comboBoxCompagnie.Visible = true;
            comboBoxTheme.Visible = true;
            comboBoxPublic.Visible = true;

            textBoxNomPiece.Text = "";
            textBoxPrixFixe.Text = "";
            textBoxDuree.Text = "";
            textBoxCommentaire.Text = "";

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
                var rep = MessageBox.Show("Êtes vous sûr de vouloir valider ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rep == DialogResult.Yes)
                {
                    leAuteur = comboBoxAuteur.SelectedItem as Author;
                    laCompagnie = comboBoxCompagnie.SelectedItem as Company;
                    leTypePublic = comboBoxPublic.SelectedItem as PublicType;
                    leTheme = comboBoxTheme.SelectedItem as Theme;


                    if (grbDetails.Text == "Modifier cette pièce de théatre")
                    {
                        TimeSpan dureeTS = TimeSpan.FromMinutes(double.Parse(textBoxDuree.Text));
                        float dureeFl = (float)dureeTS.TotalHours;
                        TheaterPiece unePiece = new TheaterPiece(int.Parse(lblIdPiece.Text), textBoxNomPiece.Text, textBoxCommentaire.Text, dureeFl, float.Parse(textBoxPrixFixe.Text), laCompagnie, leAuteur, leTypePublic, leTheme);
                        ModulePiecesTheatre.EditTheaterPiece(unePiece);
                    }
                    else if (grbDetails.Text == "Ajout d'une pièce de théatre")
                    {
                        TimeSpan dureeTS = TimeSpan.FromMinutes(double.Parse(textBoxDuree.Text));
                        float dureeFl = (float)dureeTS.TotalHours;
                        TheaterPiece unePiece = new TheaterPiece(textBoxNomPiece.Text, textBoxCommentaire.Text, dureeFl, float.Parse(textBoxPrixFixe.Text), laCompagnie, leAuteur, leTypePublic, leTheme);
                        ModulePiecesTheatre.AddTheaterPiece(unePiece);
                    }


                    grbDetails.Text = "Détails de la pièce de théatre";
                    lblLaPiece.Visible = true;
                    lblLeTheme.Visible = true;
                    lblLaDuree.Visible = true;
                    lblLeAuteur.Visible = true;
                    lblLeType.Visible = true;
                    lblLaDescription.Visible = true;
                    lblLaCompagnie.Visible = true;
                    lblLePrixFixe.Visible = true;
                    lblLaNationalite.Text = string.Empty;
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

                    btnAjouter.Enabled = true;
                }
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
            dt.Columns.Add(new DataColumn("idPiece", typeof(int)));

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
           
            // Pour chaque piece dans la liste lesPiecesTheatres, on affiche les données dans les colonnes 
            foreach (TheaterPiece unePiece in lesPiecesTheatre)
            {
                int idPiece = unePiece.TheaterPiece_id;

                string nomPiece = unePiece.TheaterPiece_name;

                string nomAuteur = unePiece.TheaterPiece_author.Author_firstname + " " + unePiece.TheaterPiece_author.Author_lastname;

                string nomTheme = unePiece.TheaterPiece_theme.Theme_name;

                string typePublic = unePiece.TheaterPiece_publicType.PublicType_name;

                double doubleConvertDuree = double.Parse(unePiece.TheaterPiece_duration.ToString());

                TimeSpan convertDuree = TimeSpan.FromHours(doubleConvertDuree);

                string duree = convertDuree.ToString();

                float prix = unePiece.TheaterPiece_seatsPrice;

                dt.Rows.Add(unePiece, idPiece, nomPiece, nomAuteur, typePublic, nomTheme, duree, prix);
            }


            // La première colonne contenant l'objet ne sera pas visible
            dgvListePiecesTheatre.Columns["piece"].Visible = false;
            dgvListePiecesTheatre.Columns["idPiece"].Visible = false;
            // dgvListePiecesTheatre.Columns["idPiece"].Visible = false;
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
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;

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
                lblLaNationalite.Text = string.Empty;
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

                btnAjouter.Enabled = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            // Récupération du numéro de la ligne (index)
            int indexRow = dgvListePiecesTheatre.CurrentRow.Index;

            // Si la ligne contient bien une valeur, on valorise les labels avec les valeurs correspondantes
            if (dgvListePiecesTheatre.Rows[indexRow].Cells[0].Value != DBNull.Value)
            {
                TheaterPiece maPieceEditee = (TheaterPiece)dgvListePiecesTheatre.Rows[indexRow].Cells[0].Value;


                grbDetails.Text = "Modifier cette pièce de théatre";


                textBoxNomPiece.Text = maPieceEditee.TheaterPiece_name.ToString();
                textBoxPrixFixe.Text = maPieceEditee.TheaterPiece_seatsPrice.ToString();
                textBoxDuree.Text = lblLaDuree.Text;
                textBoxCommentaire.Text = maPieceEditee.TheaterPiece_description.ToString();



                lblLaPiece.Visible = false;
                lblLeTheme.Visible = false;
                lblLaDuree.Visible = false;
                lblLeAuteur.Visible = false;
                lblLeType.Visible = false;
                lblLaDescription.Visible = false;
                lblLaCompagnie.Visible = false;
                lblLePrixFixe.Visible = false;
                lblLaNationalite.Text = string.Empty;
                //lblLaNationalite.Visible = false;

                dgvListePiecesTheatre.Enabled = false;

                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
                btnValider.Visible = true;
                btnAnnuler.Visible = true;

                btnAjouter.Enabled = false;

                textBoxNomPiece.Visible = true;
                textBoxPrixFixe.Visible = true;
                textBoxDuree.Visible = true;
                textBoxCommentaire.Visible = true;
                comboBoxAuteur.Visible = true;
                comboBoxCompagnie.Visible = true;
                comboBoxTheme.Visible = true;
                comboBoxPublic.Visible = true;


                List<Author> lesAuteurs = PiecesTheatreDAO.GetAuthors();
                comboBoxAuteur.DataSource = lesAuteurs;
                comboBoxAuteur.DisplayMember = "author_lastname";

                int indAuteur = 0;
                bool trouveAuteur = false;
                while (trouveAuteur == false && indAuteur < comboBoxAuteur.Items.Count)
                {
                    Author monAuteur = comboBoxAuteur.Items[indAuteur] as Author;
                    if (monAuteur.Author_id == maPieceEditee.TheaterPiece_author.Author_id)
                    {
                        comboBoxAuteur.SelectedIndex = indAuteur;
                        trouveAuteur = true;
                    }
                    else
                    {
                        indAuteur++;
                    }
                }


                List<Theme> lesThemes = PiecesTheatreDAO.GetThemes();
                comboBoxTheme.DataSource = lesThemes;
                comboBoxTheme.DisplayMember = "theme_name";

                int indTheme = 0;
                bool trouveTheme = false;
                while (trouveTheme == false && indTheme < comboBoxTheme.Items.Count)
                {
                    Theme monTheme = comboBoxTheme.Items[indTheme] as Theme;
                    if (monTheme.Theme_id == maPieceEditee.TheaterPiece_theme.Theme_id)
                    {
                        comboBoxTheme.SelectedIndex = indTheme;
                        trouveTheme = true;
                    }
                    else
                    {
                        indTheme++;
                    }
                }

                List<PublicType> lesTypes = PiecesTheatreDAO.GetTypesPublic();
                comboBoxPublic.DataSource = lesTypes;
                comboBoxPublic.DisplayMember = "publicType_name";

                int indType = 0;
                bool trouveType = false;
                while (trouveType == false && indType < comboBoxPublic.Items.Count)
                {
                    PublicType monType = comboBoxPublic.Items[indType] as PublicType;
                    if (monType.PublicType_id == maPieceEditee.TheaterPiece_publicType.PublicType_id)
                    {
                        comboBoxPublic.SelectedIndex = indType;
                        trouveType = true;
                    }
                    else
                    {
                        indType++;
                    }
                }

                List<Company> lesCompagnies = PiecesTheatreDAO.GetCompagnies();
                comboBoxCompagnie.DataSource = lesCompagnies;
                comboBoxCompagnie.DisplayMember = "company_name";

                int indCompagnie = 0;
                bool trouveCompagnie = false;
                while (trouveCompagnie == false && indCompagnie < comboBoxCompagnie.Items.Count)
                {
                    Company maCompagnie = comboBoxCompagnie.Items[indCompagnie] as Company;
                    if (maCompagnie.Company_id == maPieceEditee.TheaterPiece_company.Company_id)
                    {
                        comboBoxCompagnie.SelectedIndex = indCompagnie;
                        trouveCompagnie = true;
                    }
                    else
                    {
                        indCompagnie++;
                    }
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
            var rep = MessageBox.Show("Êtes vous sûr de vouloir supprimer cette pièce de théatre ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (rep == DialogResult.Yes)
            {
                TheaterPiece unePiece = new TheaterPiece(int.Parse(lblIdPiece.Text));

                ModulePiecesTheatre.RemoveTheaterPiece(unePiece);
                List<Show> lesShows = ModuleRepresentations.GetShows();

                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
            } else
            {
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;

            }

            ListePiece();
        }

        private void lblPrixFixe_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAuteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLaNationalite.Text = string.Empty;
            Author auteur = comboBoxAuteur.SelectedItem as Author;

            int indNat = 1;
            foreach (Nationality laNationalite in auteur.Author_nationalities)
            {
                lblLaNationalite.Text += laNationalite.Nationality_name;

                if (indNat < auteur.Author_nationalities.Count)
                {
                    indNat++;
                    // si plusieurs nationalité, les deux nationalités sont séparés d'un ","
                    lblLaNationalite.Text += ", ";
                }
            }
        }
    }
}
