using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStreaming
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void btnAnimes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAnimes>().Count() > 0)
            {

                MessageBox.Show("Tela para assistir animes já está aberta!",
                        "Animes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                      );

                return;
            }

            frmAnimes frmAnimes = new frmAnimes();
            frmAnimes.Show();

        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFilmes>().Count() > 0)
            {

                MessageBox.Show("Tela para assistir filmes já está aberta!",
                        "Filmes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                      );

                return;
            }

            frmFilmes frmFilmes = new frmFilmes();
            frmFilmes.Show();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmBaixarYoutube>().Count() > 0)
            {

                MessageBox.Show("Tela para assistir youtube já está aberta!",
                        "Youtube",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                      );

                return;
            }

            frmBaixarYoutube frmBaixarYoutube = new frmBaixarYoutube();
            frmBaixarYoutube.Show();
        }

        private void btnAssistirYoutube_Click(object sender, EventArgs e)
        {
            frmAssistirYoutube frmAssistirYoutube = new frmAssistirYoutube();
            frmAssistirYoutube.Show();
        }
    }
}
