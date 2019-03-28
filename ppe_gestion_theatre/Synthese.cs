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
    public partial class Synthese : Form
    {
        LoginInfo currentUser;
        public Synthese(LoginInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            LoadDataGridView();

            dgvListeSynthese.ClearSelection();
        }

        private void Synthese_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Chargement de la liste sans filtre
        private void LoadDataGridView()
        {

            DataTable dt = new DataTable();
            dgvListeSynthese.DataSource = dt;

            dt.Columns.Add(new DataColumn("piece", typeof(string)));
            dgvListeSynthese.Columns["piece"].HeaderText = "Pièce";

            dt.Columns.Add(new DataColumn("nbRepres", typeof(int)));
            dgvListeSynthese.Columns["nbRepres"].HeaderText = "Nombre représentations";

            dt.Columns.Add(new DataColumn("nbSpecTotal", typeof(int)));
            dgvListeSynthese.Columns["nbSpecTotal"].HeaderText = "Nombre total de spectateurs";

            dt.Columns.Add(new DataColumn("nbSpecMoyen", typeof(int)));
            dgvListeSynthese.Columns["nbSpecMoyen"].HeaderText = "Nombre moyen de spectateurs";

            dt.Columns.Add(new DataColumn("caRealise", typeof(float)));
            dgvListeSynthese.Columns["caRealise"].HeaderText = "CA réalisé";

            dt.Columns.Add(new DataColumn("caMoyenRealise", typeof(float)));
            dgvListeSynthese.Columns["caMoyenRealise"].HeaderText = "CA moyen réalisé";

            dgvListeSynthese.ReadOnly = true;

            // Liste qui récupère la liste des pieces de théatre dans le ModulePiecesTheatre
            List<TheaterPiece> lesPiecesTheatre = ModulePiecesTheatre.GetTheaterPieces();


            // Pour chaque piece dans la liste lesPiecesTheatres, on affiche les données dans les colonnes 
            foreach (TheaterPiece unePiece in lesPiecesTheatre)
            {

                string nomPiece = unePiece.TheaterPiece_name;

                int lesRepresations = ModuleSynthese.GetNbShows(unePiece);

                int lesSpectateurs = ModuleSynthese.GetNbSpectators(unePiece);

                int lesSpectateursMoyen = ModuleSynthese.GetNbSpectators(unePiece) / ModuleSynthese.GetNbShows(unePiece);

                float CA = ModuleSynthese.GetCaTotal(unePiece);

                float CAMoyen = ModuleSynthese.GetCaTotal(unePiece) / ModuleSynthese.GetNbShows(unePiece);

                dt.Rows.Add(nomPiece, lesRepresations, lesSpectateurs, lesSpectateursMoyen, CA, CAMoyen);
            }
            
        }

        // Chargement de la liste en fonctione des dates pour filtrer
        private void LoadDataGridView(DateTime dateDeb, DateTime dateFin)
        {

        }
    }
}
