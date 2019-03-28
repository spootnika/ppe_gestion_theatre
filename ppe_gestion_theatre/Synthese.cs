﻿using System;
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
            List<TheaterPiece> lesPiecesTheatre = ModuleSynthese.GetTheaterPieces();


            // Pour chaque piece dans la liste lesPiecesTheatres, on affiche les données dans les colonnes 
            foreach (TheaterPiece unePiece in lesPiecesTheatre)
            {

                string nomPiece = unePiece.TheaterPiece_name;

                int lesRepresations = 10; /*ModuleSynthese.GetNbShows(unePiece);*/

                int lesSpectateurs = 50; /*ModuleSynthese.GetNbSpectators(unePiece);*/

                int lesSpectateursMoyen = lesSpectateurs / lesRepresations;

                float CA = ModuleSynthese.GetCaTotal(unePiece);

                float CAMoyen = CA / lesRepresations;

                dt.Rows.Add(nomPiece, lesRepresations, lesSpectateurs, lesSpectateursMoyen, CA, CAMoyen);
            }
            
        }

        // Chargement de la liste en fonctione des dates pour filtrer
        private void LoadDataGridView(DateTime dateDeb, DateTime dateFin)
        {
            List<TheaterPiece> lesPieces = ModuleSynthese.GetTheaterPieces();

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


            //test dgv
            foreach (TheaterPiece unePiece in lesPieces)
            {
                string nomPiece = unePiece.TheaterPiece_name;

                int nbRepres = ModuleSynthese.GetNbShows(unePiece, dateDeb, dateFin);

                int nbSpecTotal = ModuleSynthese.GetNbSpectators(unePiece, dateDeb, dateFin);

                int nbSpecMoyen = 0;

                if (nbSpecTotal == 0)
                {

                    nbSpecMoyen = 0;

                }
                else
                {
                    nbSpecMoyen = nbSpecTotal / nbRepres;
                }

                float caRealise = ModuleSynthese.GetCaTotal(unePiece, dateDeb, dateFin);

                float caMoyenRealise = 0;

                if (caRealise == 0)
                {

                    caMoyenRealise = 0;

                }
                else
                {
                    caMoyenRealise = caRealise / nbRepres;
                }


                dt.Rows.Add(nomPiece, nbRepres, nbSpecTotal, nbSpecMoyen, caRealise, caMoyenRealise);
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            dgvListeSynthese.Refresh();
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            DateTime dateDeb = dtpDateDeb.Value;
            DateTime dateFin = dtpDateFin.Value;

            LoadDataGridView(dateDeb, dateFin);
            dgvListeSynthese.Refresh();
        }
    }
}
