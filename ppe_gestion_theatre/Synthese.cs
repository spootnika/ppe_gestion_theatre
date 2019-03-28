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

        }

        // Chargement de la liste en fonctione des dates pour filtrer
        private void LoadDataGridView(DateTime dateDeb, DateTime dateFin)
        {

        }
    }
}
