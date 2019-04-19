namespace ppe_gestion_theatre
{
    partial class PiecesTheatre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.lblIdPiece = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.comboBoxCompagnie = new System.Windows.Forms.ComboBox();
            this.comboBoxPublic = new System.Windows.Forms.ComboBox();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.comboBoxAuteur = new System.Windows.Forms.ComboBox();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.textBoxPrixFixe = new System.Windows.Forms.TextBox();
            this.textBoxNomPiece = new System.Windows.Forms.TextBox();
            this.lblLaNationalite = new System.Windows.Forms.Label();
            this.lblNationalite = new System.Windows.Forms.Label();
            this.lblLaDescription = new System.Windows.Forms.Label();
            this.lblLePrixFixe = new System.Windows.Forms.Label();
            this.lblLaCompagnie = new System.Windows.Forms.Label();
            this.lblLeAuteur = new System.Windows.Forms.Label();
            this.lblLeType = new System.Windows.Forms.Label();
            this.lblLaDuree = new System.Windows.Forms.Label();
            this.lblLeTheme = new System.Windows.Forms.Label();
            this.lblLaPiece = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblPrixFixe = new System.Windows.Forms.Label();
            this.lblCompagniePiece = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypePublicPiece = new System.Windows.Forms.Label();
            this.lblDureePiece = new System.Windows.Forms.Label();
            this.lblThemePiece = new System.Windows.Forms.Label();
            this.lblNomPiece = new System.Windows.Forms.Label();
            this.dgvListePiecesTheatre = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.errorProviderNomPiece = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDuree = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrixFixe = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePiecesTheatre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrixFixe)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.Color.White;
            this.grbDetails.Controls.Add(this.lblIdPiece);
            this.grbDetails.Controls.Add(this.btnAnnuler);
            this.grbDetails.Controls.Add(this.btnValider);
            this.grbDetails.Controls.Add(this.comboBoxCompagnie);
            this.grbDetails.Controls.Add(this.comboBoxPublic);
            this.grbDetails.Controls.Add(this.comboBoxTheme);
            this.grbDetails.Controls.Add(this.comboBoxAuteur);
            this.grbDetails.Controls.Add(this.textBoxCommentaire);
            this.grbDetails.Controls.Add(this.textBoxDuree);
            this.grbDetails.Controls.Add(this.textBoxPrixFixe);
            this.grbDetails.Controls.Add(this.textBoxNomPiece);
            this.grbDetails.Controls.Add(this.lblLaNationalite);
            this.grbDetails.Controls.Add(this.lblNationalite);
            this.grbDetails.Controls.Add(this.lblLaDescription);
            this.grbDetails.Controls.Add(this.lblLePrixFixe);
            this.grbDetails.Controls.Add(this.lblLaCompagnie);
            this.grbDetails.Controls.Add(this.lblLeAuteur);
            this.grbDetails.Controls.Add(this.lblLeType);
            this.grbDetails.Controls.Add(this.lblLaDuree);
            this.grbDetails.Controls.Add(this.lblLeTheme);
            this.grbDetails.Controls.Add(this.lblLaPiece);
            this.grbDetails.Controls.Add(this.btnModifier);
            this.grbDetails.Controls.Add(this.btnSupprimer);
            this.grbDetails.Controls.Add(this.lblPrixFixe);
            this.grbDetails.Controls.Add(this.lblCompagniePiece);
            this.grbDetails.Controls.Add(this.lblAuteur);
            this.grbDetails.Controls.Add(this.lblDescription);
            this.grbDetails.Controls.Add(this.lblTypePublicPiece);
            this.grbDetails.Controls.Add(this.lblDureePiece);
            this.grbDetails.Controls.Add(this.lblThemePiece);
            this.grbDetails.Controls.Add(this.lblNomPiece);
            this.grbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetails.ForeColor = System.Drawing.Color.SteelBlue;
            this.grbDetails.Location = new System.Drawing.Point(23, 396);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(755, 346);
            this.grbDetails.TabIndex = 6;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Détails de la pièce de théatre";
            this.grbDetails.Enter += new System.EventHandler(this.grbDetails_Enter);
            // 
            // lblIdPiece
            // 
            this.lblIdPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPiece.ForeColor = System.Drawing.Color.Black;
            this.lblIdPiece.Location = new System.Drawing.Point(11, 303);
            this.lblIdPiece.Name = "lblIdPiece";
            this.lblIdPiece.Size = new System.Drawing.Size(167, 22);
            this.lblIdPiece.TabIndex = 38;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(378, 298);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(88, 27);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.SteelBlue;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(297, 298);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 27);
            this.btnValider.TabIndex = 36;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // comboBoxCompagnie
            // 
            this.comboBoxCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxCompagnie.FormattingEnabled = true;
            this.comboBoxCompagnie.Location = new System.Drawing.Point(558, 104);
            this.comboBoxCompagnie.Name = "comboBoxCompagnie";
            this.comboBoxCompagnie.Size = new System.Drawing.Size(164, 24);
            this.comboBoxCompagnie.TabIndex = 35;
            this.comboBoxCompagnie.Visible = false;
            // 
            // comboBoxPublic
            // 
            this.comboBoxPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxPublic.FormattingEnabled = true;
            this.comboBoxPublic.Location = new System.Drawing.Point(133, 134);
            this.comboBoxPublic.Name = "comboBoxPublic";
            this.comboBoxPublic.Size = new System.Drawing.Size(155, 24);
            this.comboBoxPublic.TabIndex = 34;
            this.comboBoxPublic.Visible = false;
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(133, 71);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(155, 24);
            this.comboBoxTheme.TabIndex = 33;
            this.comboBoxTheme.Visible = false;
            // 
            // comboBoxAuteur
            // 
            this.comboBoxAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxAuteur.FormattingEnabled = true;
            this.comboBoxAuteur.Location = new System.Drawing.Point(558, 37);
            this.comboBoxAuteur.Name = "comboBoxAuteur";
            this.comboBoxAuteur.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAuteur.TabIndex = 32;
            this.comboBoxAuteur.Visible = false;
            this.comboBoxAuteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuteur_SelectedIndexChanged);
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxCommentaire.Location = new System.Drawing.Point(133, 187);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(433, 92);
            this.textBoxCommentaire.TabIndex = 30;
            this.textBoxCommentaire.Visible = false;
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxDuree.Location = new System.Drawing.Point(133, 104);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(155, 22);
            this.textBoxDuree.TabIndex = 26;
            this.textBoxDuree.Visible = false;
            // 
            // textBoxPrixFixe
            // 
            this.textBoxPrixFixe.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixFixe.Location = new System.Drawing.Point(558, 136);
            this.textBoxPrixFixe.Name = "textBoxPrixFixe";
            this.textBoxPrixFixe.Size = new System.Drawing.Size(164, 26);
            this.textBoxPrixFixe.TabIndex = 25;
            this.textBoxPrixFixe.Visible = false;
            // 
            // textBoxNomPiece
            // 
            this.textBoxNomPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomPiece.Location = new System.Drawing.Point(133, 39);
            this.textBoxNomPiece.Name = "textBoxNomPiece";
            this.textBoxNomPiece.Size = new System.Drawing.Size(155, 22);
            this.textBoxNomPiece.TabIndex = 24;
            this.textBoxNomPiece.Visible = false;
            // 
            // lblLaNationalite
            // 
            this.lblLaNationalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaNationalite.ForeColor = System.Drawing.Color.Black;
            this.lblLaNationalite.Location = new System.Drawing.Point(555, 78);
            this.lblLaNationalite.Name = "lblLaNationalite";
            this.lblLaNationalite.Size = new System.Drawing.Size(185, 32);
            this.lblLaNationalite.TabIndex = 23;
            // 
            // lblNationalite
            // 
            this.lblNationalite.AutoSize = true;
            this.lblNationalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalite.ForeColor = System.Drawing.Color.Black;
            this.lblNationalite.Location = new System.Drawing.Point(457, 78);
            this.lblNationalite.Name = "lblNationalite";
            this.lblNationalite.Size = new System.Drawing.Size(91, 16);
            this.lblNationalite.TabIndex = 22;
            this.lblNationalite.Text = "Nationalité :";
            // 
            // lblLaDescription
            // 
            this.lblLaDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDescription.ForeColor = System.Drawing.Color.Black;
            this.lblLaDescription.Location = new System.Drawing.Point(112, 190);
            this.lblLaDescription.Name = "lblLaDescription";
            this.lblLaDescription.Size = new System.Drawing.Size(374, 86);
            this.lblLaDescription.TabIndex = 21;
            // 
            // lblLePrixFixe
            // 
            this.lblLePrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblLePrixFixe.Location = new System.Drawing.Point(554, 142);
            this.lblLePrixFixe.Name = "lblLePrixFixe";
            this.lblLePrixFixe.Size = new System.Drawing.Size(189, 16);
            this.lblLePrixFixe.TabIndex = 20;
            // 
            // lblLaCompagnie
            // 
            this.lblLaCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaCompagnie.ForeColor = System.Drawing.Color.Black;
            this.lblLaCompagnie.Location = new System.Drawing.Point(555, 110);
            this.lblLaCompagnie.Name = "lblLaCompagnie";
            this.lblLaCompagnie.Size = new System.Drawing.Size(185, 16);
            this.lblLaCompagnie.TabIndex = 19;
            // 
            // lblLeAuteur
            // 
            this.lblLeAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeAuteur.ForeColor = System.Drawing.Color.Black;
            this.lblLeAuteur.Location = new System.Drawing.Point(539, 45);
            this.lblLeAuteur.Name = "lblLeAuteur";
            this.lblLeAuteur.Size = new System.Drawing.Size(158, 16);
            this.lblLeAuteur.TabIndex = 18;
            // 
            // lblLeType
            // 
            this.lblLeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeType.ForeColor = System.Drawing.Color.Black;
            this.lblLeType.Location = new System.Drawing.Point(133, 142);
            this.lblLeType.Name = "lblLeType";
            this.lblLeType.Size = new System.Drawing.Size(271, 16);
            this.lblLeType.TabIndex = 17;
            // 
            // lblLaDuree
            // 
            this.lblLaDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDuree.ForeColor = System.Drawing.Color.Black;
            this.lblLaDuree.Location = new System.Drawing.Point(133, 110);
            this.lblLaDuree.Name = "lblLaDuree";
            this.lblLaDuree.Size = new System.Drawing.Size(302, 18);
            this.lblLaDuree.TabIndex = 16;
            // 
            // lblLeTheme
            // 
            this.lblLeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeTheme.ForeColor = System.Drawing.Color.Black;
            this.lblLeTheme.Location = new System.Drawing.Point(77, 78);
            this.lblLeTheme.Name = "lblLeTheme";
            this.lblLeTheme.Size = new System.Drawing.Size(358, 16);
            this.lblLeTheme.TabIndex = 15;
            // 
            // lblLaPiece
            // 
            this.lblLaPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaPiece.ForeColor = System.Drawing.Color.Black;
            this.lblLaPiece.Location = new System.Drawing.Point(69, 45);
            this.lblLaPiece.Name = "lblLaPiece";
            this.lblLaPiece.Size = new System.Drawing.Size(366, 16);
            this.lblLaPiece.TabIndex = 14;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(297, 298);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 27);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(378, 298);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 27);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblPrixFixe
            // 
            this.lblPrixFixe.AutoSize = true;
            this.lblPrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblPrixFixe.Location = new System.Drawing.Point(456, 142);
            this.lblPrixFixe.Name = "lblPrixFixe";
            this.lblPrixFixe.Size = new System.Drawing.Size(92, 16);
            this.lblPrixFixe.TabIndex = 9;
            this.lblPrixFixe.Text = "Prix fixe (€) :";
            this.lblPrixFixe.Click += new System.EventHandler(this.lblPrixFixe_Click);
            // 
            // lblCompagniePiece
            // 
            this.lblCompagniePiece.AutoSize = true;
            this.lblCompagniePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompagniePiece.ForeColor = System.Drawing.Color.Black;
            this.lblCompagniePiece.Location = new System.Drawing.Point(457, 110);
            this.lblCompagniePiece.Name = "lblCompagniePiece";
            this.lblCompagniePiece.Size = new System.Drawing.Size(95, 16);
            this.lblCompagniePiece.TabIndex = 8;
            this.lblCompagniePiece.Text = "Compagnie :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.ForeColor = System.Drawing.Color.Black;
            this.lblAuteur.Location = new System.Drawing.Point(457, 45);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(60, 16);
            this.lblAuteur.TabIndex = 7;
            this.lblAuteur.Text = "Auteur :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(11, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description :";
            // 
            // lblTypePublicPiece
            // 
            this.lblTypePublicPiece.AutoSize = true;
            this.lblTypePublicPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypePublicPiece.ForeColor = System.Drawing.Color.Black;
            this.lblTypePublicPiece.Location = new System.Drawing.Point(7, 142);
            this.lblTypePublicPiece.Name = "lblTypePublicPiece";
            this.lblTypePublicPiece.Size = new System.Drawing.Size(120, 16);
            this.lblTypePublicPiece.TabIndex = 3;
            this.lblTypePublicPiece.Text = "Type de public :";
            // 
            // lblDureePiece
            // 
            this.lblDureePiece.AutoSize = true;
            this.lblDureePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureePiece.ForeColor = System.Drawing.Color.Black;
            this.lblDureePiece.Location = new System.Drawing.Point(7, 110);
            this.lblDureePiece.Name = "lblDureePiece";
            this.lblDureePiece.Size = new System.Drawing.Size(117, 16);
            this.lblDureePiece.TabIndex = 2;
            this.lblDureePiece.Text = "Durée (en min) :";
            // 
            // lblThemePiece
            // 
            this.lblThemePiece.AutoSize = true;
            this.lblThemePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemePiece.ForeColor = System.Drawing.Color.Black;
            this.lblThemePiece.Location = new System.Drawing.Point(7, 78);
            this.lblThemePiece.Name = "lblThemePiece";
            this.lblThemePiece.Size = new System.Drawing.Size(64, 16);
            this.lblThemePiece.TabIndex = 1;
            this.lblThemePiece.Text = "Thème :";
            // 
            // lblNomPiece
            // 
            this.lblNomPiece.AutoSize = true;
            this.lblNomPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPiece.ForeColor = System.Drawing.Color.Black;
            this.lblNomPiece.Location = new System.Drawing.Point(7, 45);
            this.lblNomPiece.Name = "lblNomPiece";
            this.lblNomPiece.Size = new System.Drawing.Size(56, 16);
            this.lblNomPiece.TabIndex = 0;
            this.lblNomPiece.Text = "Pièce :";
            // 
            // dgvListePiecesTheatre
            // 
            this.dgvListePiecesTheatre.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvListePiecesTheatre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePiecesTheatre.Location = new System.Drawing.Point(23, 82);
            this.dgvListePiecesTheatre.Name = "dgvListePiecesTheatre";
            this.dgvListePiecesTheatre.Size = new System.Drawing.Size(755, 294);
            this.dgvListePiecesTheatre.TabIndex = 5;
            this.dgvListePiecesTheatre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListePiecesTheatre_CellClick);
            this.dgvListePiecesTheatre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListePiecesTheatre_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(664, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 29);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(162, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(455, 39);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Gestion des pièces théatre";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(25, 34);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(69, 29);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // errorProviderNomPiece
            // 
            this.errorProviderNomPiece.ContainerControl = this;
            // 
            // errorProviderDuree
            // 
            this.errorProviderDuree.ContainerControl = this;
            // 
            // errorProviderPrixFixe
            // 
            this.errorProviderPrixFixe.ContainerControl = this;
            // 
            // PiecesTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 754);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.dgvListePiecesTheatre);
            this.Name = "PiecesTheatre";
            this.Text = "PiecesTheatre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PiecesTheatre_FormClosing);
            this.Load += new System.EventHandler(this.PiecesTheatre_Load);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePiecesTheatre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDuree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrixFixe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblLePrixFixe;
        private System.Windows.Forms.Label lblLaCompagnie;
        private System.Windows.Forms.Label lblLeAuteur;
        private System.Windows.Forms.Label lblLeType;
        private System.Windows.Forms.Label lblLaDuree;
        private System.Windows.Forms.Label lblLeTheme;
        private System.Windows.Forms.Label lblLaPiece;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblPrixFixe;
        private System.Windows.Forms.Label lblCompagniePiece;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTypePublicPiece;
        private System.Windows.Forms.Label lblDureePiece;
        private System.Windows.Forms.Label lblThemePiece;
        private System.Windows.Forms.Label lblNomPiece;
        private System.Windows.Forms.DataGridView dgvListePiecesTheatre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblLaDescription;
        private System.Windows.Forms.Label lblLaNationalite;
        private System.Windows.Forms.Label lblNationalite;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox textBoxNomPiece;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.TextBox textBoxPrixFixe;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.ComboBox comboBoxCompagnie;
        private System.Windows.Forms.ComboBox comboBoxPublic;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.ComboBox comboBoxAuteur;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ErrorProvider errorProviderNomPiece;
        private System.Windows.Forms.ErrorProvider errorProviderDuree;
        private System.Windows.Forms.ErrorProvider errorProviderPrixFixe;
        private System.Windows.Forms.Label lblIdPiece;
    }
}