using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheaterBLL;
using TheaterBO;

namespace ppe_gestion_theatre
{
    public partial class Representations : Form
    {
        LoginInfo currentUser;
        public Representations(LoginInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // récupération de la liste des représentations
            List<Show> lesRepresentations = ModuleRepresentations.GetShows();

            // Structure de la dgv
            DataTable table = new DataTable();
            dgvListeRepresentations.DataSource = table;


            // Ajout des colonnes
            table.Columns.Add(new DataColumn("représentation", typeof(Show)));

            table.Columns.Add(new DataColumn("piece", typeof(string)));
            dgvListeRepresentations.Columns["piece"].HeaderText = "Nom Pièce";

            able.Columns.Add(new DataColumn("date", typeof(string)));
            dgvListeRepresentations.Columns["date"].HeaderText = "Date";

            table.Columns.Add(new DataColumn("heure", typeof(string)));
            dgvListeRepresentations.Columns["heure"].HeaderText = "Heure";

            table.Columns.Add(new DataColumn("place", typeof(string)));
            dgvListeRepresentations.Columns["place"].HeaderText = "Place";


            table.Columns.Add(new DataColumn("placesRestantes", typeof(string)));
            dgvListeRepresentations.Columns["placesRestantes"].HeaderText = "Places restantes";

            table.Columns.Add(new DataColumn("duree", typeof(string)));
            dgvListeRepresentations.Columns["duree"].HeaderText = "Duree";

            table.Columns.Add(new DataColumn("tarif", typeof(string)));
            dgvListeRepresentations.Columns["tarif"].HeaderText = "Tarif";

            dgvListeRepresentations.ReadOnly = true;
        }

        private void Representations_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
