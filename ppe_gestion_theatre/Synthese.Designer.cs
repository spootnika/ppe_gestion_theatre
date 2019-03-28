namespace ppe_gestion_theatre
{
    partial class Synthese
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
            this.grbFiltres = new System.Windows.Forms.GroupBox();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDeb = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDeb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dgvListeSynthese = new System.Windows.Forms.DataGridView();
            this.grbFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSynthese)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFiltres
            // 
            this.grbFiltres.BackColor = System.Drawing.Color.White;
            this.grbFiltres.Controls.Add(this.btnReinitialiser);
            this.grbFiltres.Controls.Add(this.dtpDateFin);
            this.grbFiltres.Controls.Add(this.dtpDateDeb);
            this.grbFiltres.Controls.Add(this.btnFiltrer);
            this.grbFiltres.Controls.Add(this.lblDateFin);
            this.grbFiltres.Controls.Add(this.lblDateDeb);
            this.grbFiltres.Controls.Add(this.button1);
            this.grbFiltres.Controls.Add(this.button2);
            this.grbFiltres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltres.ForeColor = System.Drawing.Color.SteelBlue;
            this.grbFiltres.Location = new System.Drawing.Point(13, 68);
            this.grbFiltres.Name = "grbFiltres";
            this.grbFiltres.Size = new System.Drawing.Size(849, 72);
            this.grbFiltres.TabIndex = 12;
            this.grbFiltres.TabStop = false;
            this.grbFiltres.Text = "Filtres";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReinitialiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReinitialiser.Location = new System.Drawing.Point(662, 30);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(86, 26);
            this.btnReinitialiser.TabIndex = 34;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpDateFin.Location = new System.Drawing.Point(311, 33);
            this.dtpDateFin.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(199, 22);
            this.dtpDateFin.TabIndex = 32;
            this.dtpDateFin.Value = new System.DateTime(2018, 12, 19, 10, 2, 14, 0);
            // 
            // dtpDateDeb
            // 
            this.dtpDateDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpDateDeb.Location = new System.Drawing.Point(75, 33);
            this.dtpDateDeb.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDateDeb.Name = "dtpDateDeb";
            this.dtpDateDeb.Size = new System.Drawing.Size(199, 22);
            this.dtpDateDeb.TabIndex = 31;
            this.dtpDateDeb.Value = new System.DateTime(2018, 12, 19, 10, 1, 25, 0);
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFiltrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFiltrer.Location = new System.Drawing.Point(763, 30);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(69, 26);
            this.btnFiltrer.TabIndex = 30;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.Black;
            this.lblDateFin.Location = new System.Drawing.Point(280, 35);
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
            this.lblDateDeb.Location = new System.Drawing.Point(42, 35);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(27, 16);
            this.lblDateDeb.TabIndex = 28;
            this.lblDateDeb.Text = "Du";
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
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(142, 14);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(170, 39);
            this.lblTitre.TabIndex = 15;
            this.lblTitre.Text = "Synthèse";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(13, 22);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(69, 29);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // dgvListeSynthese
            // 
            this.dgvListeSynthese.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvListeSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeSynthese.Location = new System.Drawing.Point(13, 146);
            this.dgvListeSynthese.Name = "dgvListeSynthese";
            this.dgvListeSynthese.Size = new System.Drawing.Size(849, 374);
            this.dgvListeSynthese.TabIndex = 16;
            // 
            // Synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 532);
            this.Controls.Add(this.dgvListeSynthese);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grbFiltres);
            this.Name = "Synthese";
            this.Text = "Synthese";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Synthese_FormClosing);
            this.grbFiltres.ResumeLayout(false);
            this.grbFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSynthese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltres;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDeb;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDeb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvListeSynthese;
    }
}