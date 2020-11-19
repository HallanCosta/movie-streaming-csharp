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
    public partial class frmBaixarYoutube : Form
    {
        public frmBaixarYoutube()
        {
            InitializeComponent();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            frmBaixarVideo frmBaixarVideo = new frmBaixarVideo(txtUrl.Text);
            frmBaixarVideo.ShowDialog();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            frmBaixarMusica frmBaixarMusica = new frmBaixarMusica(txtUrl.Text);
            frmBaixarMusica.ShowDialog();
        }
    }
}
