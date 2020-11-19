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
    public partial class frmAssistirYoutube : Form
    {
        public frmAssistirYoutube()
        {
            InitializeComponent();
        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            frmAssistirStreamingYoutube frmStreamingYoutube = new frmAssistirStreamingYoutube(this.txtUrl.Text);
            frmStreamingYoutube.Show();
        }
    }
}
