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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvListeReservations = new System.Windows.Forms.DataGridView();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.lblNomPiece = new System.Windows.Forms.Label();
            this.lblThemePiece = new System.Windows.Forms.Label();
            this.lblDureePiece = new System.Windows.Forms.Label();
            this.lblTypePublicPiece = new System.Windows.Forms.Label();
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.lblPrenomReservation = new System.Windows.Forms.Label();
            this.lblNbPlacesReservation = new System.Windows.Forms.Label();
            this.lblReprésentation = new System.Windows.Forms.Label();
            this.lblCompagniePiece = new System.Windows.Forms.Label();
            this.lblPrixFixe = new System.Windows.Forms.Label();
            this.lblEmailReservation = new System.Windows.Forms.Label();
            this.lblTelephoneReservation = new System.Windows.Forms.Label();
            this.lblTotalPrix = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblLaPiece = new System.Windows.Forms.Label();
            this.lblLeTheme = new System.Windows.Forms.Label();
            this.lblLaDuree = new System.Windows.Forms.Label();
            this.lblLeType = new System.Windows.Forms.Label();
            this.lblLaRepresentation = new System.Windows.Forms.Label();
            this.lblLaCompagnie = new System.Windows.Forms.Label();
            this.lblLePrixFixe = new System.Windows.Forms.Label();
            this.lblLeNom = new System.Windows.Forms.Label();
            this.lblLePrenom = new System.Windows.Forms.Label();
            this.lblLeNbPlaces = new System.Windows.Forms.Label();
            this.lblLeEmail = new System.Windows.Forms.Label();
            this.lblLeTelephone = new System.Windows.Forms.Label();
            this.lblLePrixTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeReservations)).BeginInit();
            this.grbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(426, 39);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des réservations";
            this.lblTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(577, 22);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter une réservation";
            this.btnAjouter.UseVisualStyleBackColor = false;
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
            this.btnSupprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvListeReservations
            // 
            this.dgvListeReservations.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvListeReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeReservations.Location = new System.Drawing.Point(19, 78);
            this.dgvListeReservations.Name = "dgvListeReservations";
            this.dgvListeReservations.Size = new System.Drawing.Size(755, 294);
            this.dgvListeReservations.TabIndex = 3;
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.Color.White;
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
            this.grbDetails.Size = new System.Drawing.Size(755, 346);
            this.grbDetails.TabIndex = 4;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Détails de la réservation";
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
            // lblLaPiece
            // 
            this.lblLaPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaPiece.ForeColor = System.Drawing.Color.Black;
            this.lblLaPiece.Location = new System.Drawing.Point(75, 32);
            this.lblLaPiece.Name = "lblLaPiece";
            this.lblLaPiece.Size = new System.Drawing.Size(366, 16);
            this.lblLaPiece.TabIndex = 14;
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
            // lblLaDuree
            // 
            this.lblLaDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDuree.ForeColor = System.Drawing.Color.Black;
            this.lblLaDuree.Location = new System.Drawing.Point(77, 87);
            this.lblLaDuree.Name = "lblLaDuree";
            this.lblLaDuree.Size = new System.Drawing.Size(364, 16);
            this.lblLaDuree.TabIndex = 16;
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
            // lblLaRepresentation
            // 
            this.lblLaRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaRepresentation.ForeColor = System.Drawing.Color.Black;
            this.lblLaRepresentation.Location = new System.Drawing.Point(591, 32);
            this.lblLaRepresentation.Name = "lblLaRepresentation";
            this.lblLaRepresentation.Size = new System.Drawing.Size(158, 43);
            this.lblLaRepresentation.TabIndex = 18;
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
            // lblLePrixFixe
            // 
            this.lblLePrixFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixFixe.ForeColor = System.Drawing.Color.Black;
            this.lblLePrixFixe.Location = new System.Drawing.Point(539, 115);
            this.lblLePrixFixe.Name = "lblLePrixFixe";
            this.lblLePrixFixe.Size = new System.Drawing.Size(210, 16);
            this.lblLePrixFixe.TabIndex = 20;
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
            // lblLePrenom
            // 
            this.lblLePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrenom.ForeColor = System.Drawing.Color.Black;
            this.lblLePrenom.Location = new System.Drawing.Point(88, 229);
            this.lblLePrenom.Name = "lblLePrenom";
            this.lblLePrenom.Size = new System.Drawing.Size(353, 16);
            this.lblLePrenom.TabIndex = 22;
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
            // lblLeEmail
            // 
            this.lblLeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeEmail.ForeColor = System.Drawing.Color.Black;
            this.lblLeEmail.Location = new System.Drawing.Point(590, 202);
            this.lblLeEmail.Name = "lblLeEmail";
            this.lblLeEmail.Size = new System.Drawing.Size(159, 16);
            this.lblLeEmail.TabIndex = 24;
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
            // lblLePrixTotal
            // 
            this.lblLePrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLePrixTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLePrixTotal.Location = new System.Drawing.Point(582, 264);
            this.lblLePrixTotal.Name = "lblLePrixTotal";
            this.lblLePrixTotal.Size = new System.Drawing.Size(167, 16);
            this.lblLePrixTotal.TabIndex = 26;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.dgvListeReservations);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTitre);
            this.Name = "Reservations";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeReservations)).EndInit();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
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
    }
}