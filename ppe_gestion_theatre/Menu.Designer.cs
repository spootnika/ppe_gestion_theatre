namespace ppe_gestion_theatre
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnTheaterPiece = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnSynthesis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(64, 29);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblConnect_Click);
            // 
            // btnTheaterPiece
            // 
            this.btnTheaterPiece.Location = new System.Drawing.Point(40, 74);
            this.btnTheaterPiece.Name = "btnTheaterPiece";
            this.btnTheaterPiece.Size = new System.Drawing.Size(98, 29);
            this.btnTheaterPiece.TabIndex = 7;
            this.btnTheaterPiece.Text = "Pièces de théâtre";
            this.btnTheaterPiece.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(165, 74);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(98, 29);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Représentations";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(40, 132);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(98, 29);
            this.btnBooking.TabIndex = 9;
            this.btnBooking.Text = "Réservation";
            this.btnBooking.UseVisualStyleBackColor = true;
            // 
            // btnSynthesis
            // 
            this.btnSynthesis.Location = new System.Drawing.Point(165, 132);
            this.btnSynthesis.Name = "btnSynthesis";
            this.btnSynthesis.Size = new System.Drawing.Size(98, 29);
            this.btnSynthesis.TabIndex = 10;
            this.btnSynthesis.Text = "Synthèse";
            this.btnSynthesis.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 197);
            this.Controls.Add(this.btnSynthesis);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnTheaterPiece);
            this.Controls.Add(this.lblMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnTheaterPiece;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnSynthesis;
    }
}