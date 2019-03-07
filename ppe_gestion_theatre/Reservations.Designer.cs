namespace ppe_gestion_theatre
{
    partial class Reservations
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvListeReservations = new System.Windows.Forms.DataGridView();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.cmbDates = new System.Windows.Forms.ComboBox();
            this.cmbHeures = new System.Windows.Forms.ComboBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.btnAnnulerAjout = new System.Windows.Forms.Button();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtNbPlaces = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbPiece = new System.Windows.Forms.ComboBox();
            this.lblLePrixTotal = new System.Windows.Forms.Label();
            this.lblLeTelephone = new System.Windows.Forms.Label();
            this.lblLeEmail = new System.Windows.Forms.Label();
            this.lblLeNbPlaces = new System.Windows.Forms.Label();
            this.lblLePrenom = new System.Windows.Forms.Label();
            this.lblLeNom = new System.Windows.Forms.Label();
            this.lblLePrixFixe = new System.Windows.Forms.Label();
            this.lblLaCompagnie = new System.Windows.Forms.Label();
            this.lblLaRepresentation = new System.Windows.Forms.Label();
            this.lblLeType = new System.Windows.Forms.Label();
            this.lblLaDuree = new System.Windows.Forms.Label();
            this.lblLeTheme = new System.Windows.Forms.Label();
            this.lblLaPiece = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblTotalPrix = new System.Windows.Forms.Label();
            this.lblTelephoneReservation = new System.Windows.Forms.Label();
            this.lblEmailReservation = new System.Windows.Forms.Label();
            this.lblPrixFixe = new System.Windows.Forms.Label();
            this.lblCompagniePiece = new System.Windows.Forms.Label();
            this.lblReprésentation = new System.Windows.Forms.Label();
            this.lblNbPlacesReservation = new System.Windows.Forms.Label();
            this.lblPrenomReservation = new System.Windows.Forms.Label();
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.lblTypePublicPiece = new System.Windows.Forms.Label();
            this.lblDureePiece = new System.Windows.Forms.Label();
            this.lblThemePiece = new System.Windows.Forms.Label();
            this.lblNomPiece = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNbPlaces = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeReservations)).BeginInit();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNbPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(135, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(426, 39);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des réservations";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(647, 22);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter une réservation";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(397, 306);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 27);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // dgvListeReservations
            // 
            this.dgvListeReservations.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvListeReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeReservations.Location = new System.Drawing.Point(19, 78);
            this.dgvListeReservations.Name = "dgvListeReservations";
            this.dgvListeReservations.Size = new System.Drawing.Size(788, 294);
            this.dgvListeReservations.TabIndex = 3;
            this.dgvListeReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeReservations_CellClick);
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.Color.White;
            this.grbDetails.Controls.Add(this.cmbDates);
            this.grbDetails.Controls.Add(this.cmbHeures);
            this.grbDetails.Controls.Add(this.lblHeure);
            this.grbDetails.Controls.Add(this.btnAnnulerAjout);
            this.grbDetails.Controls.Add(this.btnValiderAjout);
            this.grbDetails.Controls.Add(this.txtTelephone);
            this.grbDetails.Controls.Add(this.txtNbPlaces);
            this.grbDetails.Controls.Add(this.txtPrenom);
            this.grbDetails.Controls.Add(this.txtNom);
            this.grbDetails.Controls.Add(this.cmbPiece);
            this.grbDetails.Controls.Add(this.lblLePrixTotal);
            this.grbDetails.Controls.Add(this.lblLeTelephone);
            this.grbDetails.Controls.Add(this.lblLeEmail);
            this.grbDetails.Controls.Add(this.lblLeNbPlaces);
            this.grbDetails.Controls.Add(this.lblLePrenom);
            this.grbDetails.Controls.Add(this.lblLeNom);
            this.grbDetails.Controls.Add(this.lblLePrixFixe);
            this.grbDetails.Controls.Add(this.lblLaCompagnie);
            this.grbDetails.Controls.Add(this.lblLaRepresentation);
            this.grbDetails.Controls.Add(this.lblLeType);
            this.grbDetails.Controls.Add(this.lblLaDuree);
            this.grbDetails.Controls.Add(this.lblLeTheme);
            this.grbDetails.Controls.Add(this.lblLaPiece);
            this.grbDetails.Controls.Add(this.btnModifier);
            this.grbDetails.Controls.Add(this.lblTotalPrix);
            this.grbDetails.Controls.Add(this.btnSupprimer);
            this.grbDetails.Controls.Add(this.lblTelephoneReservation);
            this.grbDetails.Controls.Add(this.lblEmailReservation);
            this.grbDetails.Controls.Add(this.lblPrixFixe);
            this.grbDetails.Controls.Add(this.lblCompagniePiece);
            this.grbDetails.Controls.Add(this.lblReprésentation);
            this.grbDetails.Controls.Add(this.lblNbPlacesReservation);
            this.grbDetails.Controls.Add(this.lblPrenomReservation);
            this.grbDetails.Controls.Add(this.lblNomReservation);
            this.grbDetails.Controls.Add(this.lblTypePublicPiece);
            this.grbDetails.Controls.Add(this.lblDureePiece);
            this.grbDetails.Controls.Add(this.lblThemePiece);
            this.grbDetails.Controls.Add(this.lblNomPiece);
            this.grbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetails.ForeColor = System.Drawing.Color.SteelBlue;
            this.grbDetails.Location = new System.Drawing.Point(19, 406);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(788, 346);
            this.grbDetails.TabIndex = 4;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Détails de la réservation";
            // 
            // cmbDates
            // 
            this.cmbDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDates.FormattingEnabled = true;
            this.cmbDates.Location = new System.Drawing.Point(527, 24);
            this.cmbDates.Name = "cmbDates";
            this.cmbDates.Size = new System.Drawing.Size(218, 24);
            this.cmbDates.TabIndex = 38;
            this.cmbDates.Visible = false;
            this.cmbDates.SelectedIndexChanged += new System.EventHandler(this.cmbDates_SelectedIndexChanged);
            // 
            // cmbHeures
            // 
            this.cmbHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHeures.FormattingEnabled = true;
            this.cmbHeures.Location = new System.Drawing.Point(527, 55);
            this.cmbHeures.Name = "cmbHeures";
            this.cmbHeures.Size = new System.Drawing.Size(218, 24);
            this.cmbHeures.TabIndex = 37;
            this.cmbHeures.Visible = false;
            this.cmbHeures.SelectedValueChanged += new System.EventHandler(this.cmbHeures_SelectedValueChanged);
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.ForeColor = System.Drawing.Color.Black;
            this.lblHeure.Location = new System.Drawing.Point(463, 59);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(58, 16);
            this.lblHeure.TabIndex = 36;
            this.lblHeure.Text = "Heure :";
            // 
            // btnAnnulerAjout
            // 
            this.btnAnnulerAjout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerAjout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnulerAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAjout.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerAjout.Location = new System.Drawing.Point(397, 306);
            this.btnAnnulerAjout.Name = "btnAnnulerAjout";
            this.btnAnnulerAjout.Size = new System.Drawing.Size(88, 27);
            this.btnAnnulerAjout.TabIndex = 35;
            this.btnAnnulerAjout.Text = "Annuler";
            this.btnAnnulerAjout.UseVisualStyleBackColor = false;
            this.btnAnnulerAjout.Visible = false;
            this.btnAnnulerAjout.Click += new System.EventHandler(this.btnAnnulerAjout_Click);
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnValiderAjout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderAjout.ForeColor = System.Drawing.Color.White;
            this.btnValiderAjout.Location = new System.Drawing.Point(316, 306);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(75, 27);
            this.btnValiderAjout.TabIndex = 34;
            this.btnValiderAjout.Text = "Valider";
            this.btnValiderAjout.UseVisualStyleBackColor = false;
            this.btnValiderAjout.Visible = false;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(589, 226);
            this.txtTelephone.MaxLength = 10;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(156, 22);
            this.txtTelephone.TabIndex = 33;
            this.txtTelephone.Visible = false;
            this.txtTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelephone_Validating);
            this.txtTelephone.Validated += new System.EventHandler(this.txtTelephone_Validated);
            // 
            // txtNbPlaces
            // 
            this.txtNbPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbPlaces.Location = new System.Drawing.Point(163, 261);
            this.txtNbPlaces.Name = "txtNbPlaces";
            this.txtNbPlaces.Size = new System.Drawing.Size(272, 22);
            this.txtNbPlaces.TabIndex = 31;
            this.txtNbPlaces.Visible = false;
            this.txtNbPlaces.TextChanged += new System.EventHandler(this.txtNbPlaces_TextChanged);
            this.txtNbPlaces.Validating += new System.ComponentModel.CancelEventHandler(this.txtNbPlaces_Validating);
            this.txtNbPlaces.Validated += new System.EventHandler(this.txtNbPlaces_Validated);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(89, 226);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(346, 22);
            this.txtPrenom.TabIndex = 30;
            this.txtPrenom.Visible = false;
            this.txtPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenom_Validating);
            this.txtPrenom.Validated += new System.EventHandler(this.txtPrenom_Validated);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(70, 196);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(365, 22);
            this.txtNom.TabIndex = 29;
            this.txtNom.Visible = false;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            this.txtNom.Validated += new System.EventHandler(this.txtNom_Validated);
            // 
            // cmbPiece
            // 
            this.cmbPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Location = new System.Drawing.Point(70, 29);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(365, 24);
            this.cmbPiece.TabIndex = 27;
            this.cmbPiece.Visible = false;
            this.cmbPiece.SelectedIndexChanged += new System.EventHandler(this.cmbPiece_SelectedIndexChanged);
            // 
            // lblLePrixTotal
            // 
            this.lblLePrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLePrixTotal.Location = new System.Drawing.Point(582, 264);
            this.lblLePrixTotal.Name = "lblLePrixTotal";
            this.lblLePrixTotal.Size = new System.Drawing.Size(167, 16);
            this.lblLePrixTotal.TabIndex = 26;
            this.lblLePrixTotal.Text = "0 €";
            // 
            // lblLeTelephone
            // 
            this.lblLeTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeTelephone.ForeColor = System.Drawing.Color.Black;
            this.lblLeTelephone.Location = new System.Drawing.Point(600, 229);
            this.lblLeTelephone.Name = "lblLeTelephone";
            this.lblLeTelephone.Size = new System.Drawing.Size(149, 16);
            this.lblLeTelephone.TabIndex = 25;
            // 
            // lblLeEmail
            // 
            this.lblLeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeEmail.ForeColor = System.Drawing.Color.Black;
            this.lblLeEmail.Location = new System.Drawing.Point(590, 202);
            this.lblLeEmail.Name = "lblLeEmail";
            this.lblLeEmail.Size = new System.Drawing.Size(159, 16);
            this.lblLeEmail.TabIndex = 24;
            // 
            // lblLeNbPlaces
            // 
            this.lblLeNbPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeNbPlaces.ForeColor = System.Drawing.Color.Black;
            this.lblLeNbPlaces.Location = new System.Drawing.Point(163, 264);
            this.lblLeNbPlaces.Name = "lblLeNbPlaces";
            this.lblLeNbPlaces.Size = new System.Drawing.Size(278, 16);
            this.lblLeNbPlaces.TabIndex = 23;
            // 
            // lblLePrenom
            // 
            this.lblLePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrenom.ForeColor = System.Drawing.Color.Black;
            this.lblLePrenom.Location = new System.Drawing.Point(88, 229);
            this.lblLePrenom.Name = "lblLePrenom";
            this.lblLePrenom.Size = new System.Drawing.Size(353, 16);
            this.lblLePrenom.TabIndex = 22;
            // 
            // lblLeNom
            // 
            this.lblLeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeNom.ForeColor = System.Drawing.Color.Black;
            this.lblLeNom.Location = new System.Drawing.Point(67, 202);
            this.lblLeNom.Name = "lblLeNom";
            this.lblLeNom.Size = new System.Drawing.Size(374, 16);
            this.lblLeNom.TabIndex = 21;
            // 
            // lblLePrixFixe
            // 
            this.lblLePrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblLePrixFixe.Location = new System.Drawing.Point(539, 115);
            this.lblLePrixFixe.Name = "lblLePrixFixe";
            this.lblLePrixFixe.Size = new System.Drawing.Size(210, 16);
            this.lblLePrixFixe.TabIndex = 20;
            this.lblLePrixFixe.Text = "€";
            // 
            // lblLaCompagnie
            // 
            this.lblLaCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaCompagnie.ForeColor = System.Drawing.Color.Black;
            this.lblLaCompagnie.Location = new System.Drawing.Point(564, 87);
            this.lblLaCompagnie.Name = "lblLaCompagnie";
            this.lblLaCompagnie.Size = new System.Drawing.Size(185, 16);
            this.lblLaCompagnie.TabIndex = 19;
            // 
            // lblLaRepresentation
            // 
            this.lblLaRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaRepresentation.ForeColor = System.Drawing.Color.Black;
            this.lblLaRepresentation.Location = new System.Drawing.Point(591, 32);
            this.lblLaRepresentation.Name = "lblLaRepresentation";
            this.lblLaRepresentation.Size = new System.Drawing.Size(158, 43);
            this.lblLaRepresentation.TabIndex = 18;
            // 
            // lblLeType
            // 
            this.lblLeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeType.ForeColor = System.Drawing.Color.Black;
            this.lblLeType.Location = new System.Drawing.Point(139, 115);
            this.lblLeType.Name = "lblLeType";
            this.lblLeType.Size = new System.Drawing.Size(302, 16);
            this.lblLeType.TabIndex = 17;
            // 
            // lblLaDuree
            // 
            this.lblLaDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDuree.ForeColor = System.Drawing.Color.Black;
            this.lblLaDuree.Location = new System.Drawing.Point(77, 87);
            this.lblLaDuree.Name = "lblLaDuree";
            this.lblLaDuree.Size = new System.Drawing.Size(364, 16);
            this.lblLaDuree.TabIndex = 16;
            // 
            // lblLeTheme
            // 
            this.lblLeTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeTheme.ForeColor = System.Drawing.Color.Black;
            this.lblLeTheme.Location = new System.Drawing.Point(83, 59);
            this.lblLeTheme.Name = "lblLeTheme";
            this.lblLeTheme.Size = new System.Drawing.Size(358, 16);
            this.lblLeTheme.TabIndex = 15;
            // 
            // lblLaPiece
            // 
            this.lblLaPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaPiece.ForeColor = System.Drawing.Color.Black;
            this.lblLaPiece.Location = new System.Drawing.Point(75, 32);
            this.lblLaPiece.Name = "lblLaPiece";
            this.lblLaPiece.Size = new System.Drawing.Size(366, 16);
            this.lblLaPiece.TabIndex = 14;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(316, 306);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 27);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrix
            // 
            this.lblTotalPrix.AutoSize = true;
            this.lblTotalPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrix.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrix.Location = new System.Drawing.Point(463, 264);
            this.lblTotalPrix.Name = "lblTotalPrix";
            this.lblTotalPrix.Size = new System.Drawing.Size(113, 16);
            this.lblTotalPrix.TabIndex = 12;
            this.lblTotalPrix.Text = "Total à payer : ";
            // 
            // lblTelephoneReservation
            // 
            this.lblTelephoneReservation.AutoSize = true;
            this.lblTelephoneReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneReservation.ForeColor = System.Drawing.Color.Black;
            this.lblTelephoneReservation.Location = new System.Drawing.Point(463, 229);
            this.lblTelephoneReservation.Name = "lblTelephoneReservation";
            this.lblTelephoneReservation.Size = new System.Drawing.Size(131, 16);
            this.lblTelephoneReservation.TabIndex = 11;
            this.lblTelephoneReservation.Text = "N° de téléphone : ";
            // 
            // lblEmailReservation
            // 
            this.lblEmailReservation.AutoSize = true;
            this.lblEmailReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailReservation.ForeColor = System.Drawing.Color.Black;
            this.lblEmailReservation.Location = new System.Drawing.Point(463, 202);
            this.lblEmailReservation.Name = "lblEmailReservation";
            this.lblEmailReservation.Size = new System.Drawing.Size(121, 16);
            this.lblEmailReservation.TabIndex = 10;
            this.lblEmailReservation.Text = "Adresse e-mail :";
            // 
            // lblPrixFixe
            // 
            this.lblPrixFixe.AutoSize = true;
            this.lblPrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblPrixFixe.Location = new System.Drawing.Point(463, 115);
            this.lblPrixFixe.Name = "lblPrixFixe";
            this.lblPrixFixe.Size = new System.Drawing.Size(70, 16);
            this.lblPrixFixe.TabIndex = 9;
            this.lblPrixFixe.Text = "Prix fixe :";
            // 
            // lblCompagniePiece
            // 
            this.lblCompagniePiece.AutoSize = true;
            this.lblCompagniePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompagniePiece.ForeColor = System.Drawing.Color.Black;
            this.lblCompagniePiece.Location = new System.Drawing.Point(463, 87);
            this.lblCompagniePiece.Name = "lblCompagniePiece";
            this.lblCompagniePiece.Size = new System.Drawing.Size(95, 16);
            this.lblCompagniePiece.TabIndex = 8;
            this.lblCompagniePiece.Text = "Compagnie :";
            // 
            // lblReprésentation
            // 
            this.lblReprésentation.AutoSize = true;
            this.lblReprésentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprésentation.ForeColor = System.Drawing.Color.Black;
            this.lblReprésentation.Location = new System.Drawing.Point(463, 32);
            this.lblReprésentation.Name = "lblReprésentation";
            this.lblReprésentation.Size = new System.Drawing.Size(122, 16);
            this.lblReprésentation.TabIndex = 7;
            this.lblReprésentation.Text = "Représentation :";
            // 
            // lblNbPlacesReservation
            // 
            this.lblNbPlacesReservation.AutoSize = true;
            this.lblNbPlacesReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPlacesReservation.ForeColor = System.Drawing.Color.Black;
            this.lblNbPlacesReservation.Location = new System.Drawing.Point(13, 264);
            this.lblNbPlacesReservation.Name = "lblNbPlacesReservation";
            this.lblNbPlacesReservation.Size = new System.Drawing.Size(144, 16);
            this.lblNbPlacesReservation.TabIndex = 6;
            this.lblNbPlacesReservation.Text = "Nombre de places :";
            // 
            // lblPrenomReservation
            // 
            this.lblPrenomReservation.AutoSize = true;
            this.lblPrenomReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomReservation.ForeColor = System.Drawing.Color.Black;
            this.lblPrenomReservation.Location = new System.Drawing.Point(13, 229);
            this.lblPrenomReservation.Name = "lblPrenomReservation";
            this.lblPrenomReservation.Size = new System.Drawing.Size(69, 16);
            this.lblPrenomReservation.TabIndex = 5;
            this.lblPrenomReservation.Text = "Prénom :";
            // 
            // lblNomReservation
            // 
            this.lblNomReservation.AutoSize = true;
            this.lblNomReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomReservation.ForeColor = System.Drawing.Color.Black;
            this.lblNomReservation.Location = new System.Drawing.Point(13, 202);
            this.lblNomReservation.Name = "lblNomReservation";
            this.lblNomReservation.Size = new System.Drawing.Size(48, 16);
            this.lblNomReservation.TabIndex = 4;
            this.lblNomReservation.Text = "Nom :";
            // 
            // lblTypePublicPiece
            // 
            this.lblTypePublicPiece.AutoSize = true;
            this.lblTypePublicPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypePublicPiece.ForeColor = System.Drawing.Color.Black;
            this.lblTypePublicPiece.Location = new System.Drawing.Point(13, 115);
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
            this.lblDureePiece.Location = new System.Drawing.Point(13, 87);
            this.lblDureePiece.Name = "lblDureePiece";
            this.lblDureePiece.Size = new System.Drawing.Size(58, 16);
            this.lblDureePiece.TabIndex = 2;
            this.lblDureePiece.Text = "Durée :";
            // 
            // lblThemePiece
            // 
            this.lblThemePiece.AutoSize = true;
            this.lblThemePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemePiece.ForeColor = System.Drawing.Color.Black;
            this.lblThemePiece.Location = new System.Drawing.Point(13, 59);
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
            this.lblNomPiece.Location = new System.Drawing.Point(13, 32);
            this.lblNomPiece.Name = "lblNomPiece";
            this.lblNomPiece.Size = new System.Drawing.Size(56, 16);
            this.lblNomPiece.TabIndex = 0;
            this.lblNomPiece.Text = "Pièce :";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(19, 22);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(69, 29);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(604, 605);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 22);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Visible = false;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // errNom
            // 
            this.errNom.ContainerControl = this;
            // 
            // errPrenom
            // 
            this.errPrenom.ContainerControl = this;
            // 
            // errNbPlaces
            // 
            this.errNbPlaces.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.ContainerControl = this;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(819, 764);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.dgvListeReservations);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTitre);
            this.Name = "Reservations";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeReservations)).EndInit();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNbPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dgvListeReservations;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblTotalPrix;
        private System.Windows.Forms.Label lblTelephoneReservation;
        private System.Windows.Forms.Label lblEmailReservation;
        private System.Windows.Forms.Label lblPrixFixe;
        private System.Windows.Forms.Label lblCompagniePiece;
        private System.Windows.Forms.Label lblReprésentation;
        private System.Windows.Forms.Label lblNbPlacesReservation;
        private System.Windows.Forms.Label lblPrenomReservation;
        private System.Windows.Forms.Label lblNomReservation;
        private System.Windows.Forms.Label lblTypePublicPiece;
        private System.Windows.Forms.Label lblDureePiece;
        private System.Windows.Forms.Label lblThemePiece;
        private System.Windows.Forms.Label lblNomPiece;
        private System.Windows.Forms.Label lblLePrixTotal;
        private System.Windows.Forms.Label lblLeTelephone;
        private System.Windows.Forms.Label lblLeEmail;
        private System.Windows.Forms.Label lblLeNbPlaces;
        private System.Windows.Forms.Label lblLePrenom;
        private System.Windows.Forms.Label lblLeNom;
        private System.Windows.Forms.Label lblLePrixFixe;
        private System.Windows.Forms.Label lblLaCompagnie;
        private System.Windows.Forms.Label lblLaRepresentation;
        private System.Windows.Forms.Label lblLeType;
        private System.Windows.Forms.Label lblLaDuree;
        private System.Windows.Forms.Label lblLeTheme;
        private System.Windows.Forms.Label lblLaPiece;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAnnulerAjout;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtNbPlaces;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbPiece;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbHeures;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.ComboBox cmbDates;
        private System.Windows.Forms.ErrorProvider errNom;
        private System.Windows.Forms.ErrorProvider errPrenom;
        private System.Windows.Forms.ErrorProvider errNbPlaces;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errPhone;
    }
}