namespace ppe_gestion_theatre
{
    partial class Representations
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLePrix = new System.Windows.Forms.Label();
            this.lblLHeure = new System.Windows.Forms.Label();
            this.lblLaDate = new System.Windows.Forms.Label();
            this.lblLePrixTotal = new System.Windows.Forms.Label();
            this.lblLeNbPlaces = new System.Windows.Forms.Label();
            this.lblLePrixFixe = new System.Windows.Forms.Label();
            this.lblLesPlaces = new System.Windows.Forms.Label();
            this.lblLaPiece = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblPrixFixe = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlacesRestantes = new System.Windows.Forms.Label();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblNomPiece = new System.Windows.Forms.Label();
            this.grbFiltres = new System.Windows.Forms.GroupBox();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDeb = new System.Windows.Forms.Label();
            this.lblPiece = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDateDeb = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.cbChoixPiece = new System.Windows.Forms.ComboBox();
            this.lblLesPlacesRest = new System.Windows.Forms.Label();
            this.dgvListeRepresentations = new System.Windows.Forms.DataGridView();
            this.grbDetails.SuspendLayout();
            this.grbFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeRepresentations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(29, 33);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(69, 29);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(656, 33);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(182, 29);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter une représentation";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(163, 23);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(478, 39);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Gestion des représentations";
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.Color.White;
            this.grbDetails.Controls.Add(this.lblLesPlacesRest);
            this.grbDetails.Controls.Add(this.button4);
            this.grbDetails.Controls.Add(this.button3);
            this.grbDetails.Controls.Add(this.lblLePrix);
            this.grbDetails.Controls.Add(this.lblLHeure);
            this.grbDetails.Controls.Add(this.lblLaDate);
            this.grbDetails.Controls.Add(this.lblLePrixTotal);
            this.grbDetails.Controls.Add(this.lblLeNbPlaces);
            this.grbDetails.Controls.Add(this.lblLePrixFixe);
            this.grbDetails.Controls.Add(this.lblLesPlaces);
            this.grbDetails.Controls.Add(this.lblLaPiece);
            this.grbDetails.Controls.Add(this.btnModifier);
            this.grbDetails.Controls.Add(this.btnSupprimer);
            this.grbDetails.Controls.Add(this.lblPrixFixe);
            this.grbDetails.Controls.Add(this.lblHeure);
            this.grbDetails.Controls.Add(this.lblDate);
            this.grbDetails.Controls.Add(this.lblPlacesRestantes);
            this.grbDetails.Controls.Add(this.lblPlaces);
            this.grbDetails.Controls.Add(this.lblNomPiece);
            this.grbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetails.ForeColor = System.Drawing.Color.SteelBlue;
            this.grbDetails.Location = new System.Drawing.Point(57, 412);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(743, 206);
            this.grbDetails.TabIndex = 10;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Détails de la représentation";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(353, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 31;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(272, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 30;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblLePrix
            // 
            this.lblLePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrix.ForeColor = System.Drawing.Color.Black;
            this.lblLePrix.Location = new System.Drawing.Point(539, 103);
            this.lblLePrix.Name = "lblLePrix";
            this.lblLePrix.Size = new System.Drawing.Size(188, 16);
            this.lblLePrix.TabIndex = 29;
            // 
            // lblLHeure
            // 
            this.lblLHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLHeure.ForeColor = System.Drawing.Color.Black;
            this.lblLHeure.Location = new System.Drawing.Point(518, 71);
            this.lblLHeure.Name = "lblLHeure";
            this.lblLHeure.Size = new System.Drawing.Size(188, 16);
            this.lblLHeure.TabIndex = 28;
            // 
            // lblLaDate
            // 
            this.lblLaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDate.ForeColor = System.Drawing.Color.Black;
            this.lblLaDate.Location = new System.Drawing.Point(518, 32);
            this.lblLaDate.Name = "lblLaDate";
            this.lblLaDate.Size = new System.Drawing.Size(188, 16);
            this.lblLaDate.TabIndex = 27;
            // 
            // lblLePrixTotal
            // 
            this.lblLePrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLePrixTotal.Location = new System.Drawing.Point(582, 264);
            this.lblLePrixTotal.Name = "lblLePrixTotal";
            this.lblLePrixTotal.Size = new System.Drawing.Size(167, 16);
            this.lblLePrixTotal.TabIndex = 26;
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
            // lblLePrixFixe
            // 
            this.lblLePrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblLePrixFixe.Location = new System.Drawing.Point(518, 115);
            this.lblLePrixFixe.Name = "lblLePrixFixe";
            this.lblLePrixFixe.Size = new System.Drawing.Size(210, 16);
            this.lblLePrixFixe.TabIndex = 20;
            // 
            // lblLesPlaces
            // 
            this.lblLesPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesPlaces.ForeColor = System.Drawing.Color.Black;
            this.lblLesPlaces.Location = new System.Drawing.Point(76, 71);
            this.lblLesPlaces.Name = "lblLesPlaces";
            this.lblLesPlaces.Size = new System.Drawing.Size(284, 16);
            this.lblLesPlaces.TabIndex = 15;
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
            this.btnModifier.Location = new System.Drawing.Point(285, 306);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 27);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(366, 306);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 27);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // lblPrixFixe
            // 
            this.lblPrixFixe.AutoSize = true;
            this.lblPrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblPrixFixe.Location = new System.Drawing.Point(447, 115);
            this.lblPrixFixe.Name = "lblPrixFixe";
            this.lblPrixFixe.Size = new System.Drawing.Size(70, 16);
            this.lblPrixFixe.TabIndex = 9;
            this.lblPrixFixe.Text = "Prix fixe :";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.ForeColor = System.Drawing.Color.Black;
            this.lblHeure.Location = new System.Drawing.Point(447, 71);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(58, 16);
            this.lblHeure.TabIndex = 8;
            this.lblHeure.Text = "Heure :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(447, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date :";
            // 
            // lblPlacesRestantes
            // 
            this.lblPlacesRestantes.AutoSize = true;
            this.lblPlacesRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacesRestantes.ForeColor = System.Drawing.Color.Black;
            this.lblPlacesRestantes.Location = new System.Drawing.Point(13, 115);
            this.lblPlacesRestantes.Name = "lblPlacesRestantes";
            this.lblPlacesRestantes.Size = new System.Drawing.Size(132, 16);
            this.lblPlacesRestantes.TabIndex = 2;
            this.lblPlacesRestantes.Text = "Places restantes :";
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaces.ForeColor = System.Drawing.Color.Black;
            this.lblPlaces.Location = new System.Drawing.Point(13, 71);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(64, 16);
            this.lblPlaces.TabIndex = 1;
            this.lblPlaces.Text = "Places :";
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
            // grbFiltres
            // 
            this.grbFiltres.BackColor = System.Drawing.Color.White;
            this.grbFiltres.Controls.Add(this.cbChoixPiece);
            this.grbFiltres.Controls.Add(this.dtpDateFin);
            this.grbFiltres.Controls.Add(this.dtpDateDeb);
            this.grbFiltres.Controls.Add(this.btnFiltrer);
            this.grbFiltres.Controls.Add(this.lblDateFin);
            this.grbFiltres.Controls.Add(this.lblDateDeb);
            this.grbFiltres.Controls.Add(this.lblPiece);
            this.grbFiltres.Controls.Add(this.button1);
            this.grbFiltres.Controls.Add(this.button2);
            this.grbFiltres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltres.ForeColor = System.Drawing.Color.SteelBlue;
            this.grbFiltres.Location = new System.Drawing.Point(57, 104);
            this.grbFiltres.Name = "grbFiltres";
            this.grbFiltres.Size = new System.Drawing.Size(743, 92);
            this.grbFiltres.TabIndex = 11;
            this.grbFiltres.TabStop = false;
            this.grbFiltres.Text = "Filtres";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFiltrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFiltrer.Location = new System.Drawing.Point(658, 43);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(69, 29);
            this.btnFiltrer.TabIndex = 30;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.Black;
            this.lblDateFin.Location = new System.Drawing.Point(447, 32);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(25, 16);
            this.lblDateFin.TabIndex = 29;
            this.lblDateFin.Text = "au";
            // 
            // lblDateDeb
            // 
            this.lblDateDeb.AutoSize = true;
            this.lblDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeb.ForeColor = System.Drawing.Color.Black;
            this.lblDateDeb.Location = new System.Drawing.Point(293, 32);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(27, 16);
            this.lblDateDeb.TabIndex = 28;
            this.lblDateDeb.Text = "Du";
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.ForeColor = System.Drawing.Color.Black;
            this.lblPiece.Location = new System.Drawing.Point(37, 32);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(56, 16);
            this.lblPiece.TabIndex = 27;
            this.lblPiece.Text = "Pièce :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(366, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dtpDateDeb
            // 
            this.dtpDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDeb.Location = new System.Drawing.Point(327, 32);
            this.dtpDateDeb.Name = "dtpDateDeb";
            this.dtpDateDeb.Size = new System.Drawing.Size(114, 22);
            this.dtpDateDeb.TabIndex = 31;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Location = new System.Drawing.Point(478, 32);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(114, 22);
            this.dtpDateFin.TabIndex = 32;
            // 
            // cbChoixPiece
            // 
            this.cbChoixPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoixPiece.FormattingEnabled = true;
            this.cbChoixPiece.Location = new System.Drawing.Point(100, 32);
            this.cbChoixPiece.Name = "cbChoixPiece";
            this.cbChoixPiece.Size = new System.Drawing.Size(187, 24);
            this.cbChoixPiece.TabIndex = 33;
            // 
            // lblLesPlacesRest
            // 
            this.lblLesPlacesRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesPlacesRest.ForeColor = System.Drawing.Color.Black;
            this.lblLesPlacesRest.Location = new System.Drawing.Point(151, 117);
            this.lblLesPlacesRest.Name = "lblLesPlacesRest";
            this.lblLesPlacesRest.Size = new System.Drawing.Size(290, 16);
            this.lblLesPlacesRest.TabIndex = 32;
            // 
            // dgvListeRepresentations
            // 
            this.dgvListeRepresentations.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvListeRepresentations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeRepresentations.Location = new System.Drawing.Point(57, 202);
            this.dgvListeRepresentations.Name = "dgvListeRepresentations";
            this.dgvListeRepresentations.Size = new System.Drawing.Size(743, 192);
            this.dgvListeRepresentations.TabIndex = 9;
            this.dgvListeRepresentations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeRepresentations_CellClick);
            // 
            // Representations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 630);
            this.Controls.Add(this.grbFiltres);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.dgvListeRepresentations);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnMenu);
            this.Name = "Representations";
            this.Text = "Representations";
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.grbFiltres.ResumeLayout(false);
            this.grbFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeRepresentations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblLePrixTotal;
        private System.Windows.Forms.Label lblLeNbPlaces;
        private System.Windows.Forms.Label lblLePrixFixe;
        private System.Windows.Forms.Label lblLesPlaces;
        private System.Windows.Forms.Label lblLaPiece;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblPrixFixe;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPlacesRestantes;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Label lblNomPiece;
        private System.Windows.Forms.Label lblLePrix;
        private System.Windows.Forms.Label lblLHeure;
        private System.Windows.Forms.Label lblLaDate;
        private System.Windows.Forms.GroupBox grbFiltres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDeb;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbChoixPiece;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDeb;
        private System.Windows.Forms.Label lblLesPlacesRest;
        private System.Windows.Forms.DataGridView dgvListeRepresentations;
    }
}