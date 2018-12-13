using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe_gestion_theatre
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            Reservations.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Blocage de la génération automatique des colonnes
            dgvDataUsers.AutoGenerateColumns = false;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Identifiant";


            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom de l'utilisateur";


            // Ajout des 2 en-têtes de colonne au datagridview
            dgvDataUsers.Columns.Add(IdColumn);
            dgvDataUsers.Columns.Add(NomColumn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
