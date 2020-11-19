using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using VideoLibrary;

namespace MovieStreaming
{
    public partial class frmBaixarMusica : Form
    {
        private string url;

        public frmBaixarMusica(string url)
        {
            InitializeComponent();

            this.url = url;
        }

        private void configuracao_enquanto_baixa()
        {
            this.TopMost = !this.TopMost;
            this.MinimizeBox = !this.MinimizeBox;
            this.MaximizeBox = !this.MaximizeBox;
        }

        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { Description = "Selecione um diretório" })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        configuracao_enquanto_baixa();

                        lblStatus.Text = "Baixando....";
                        lblStatus.ForeColor = Color.Red;

                        var youtube = YouTube.Default;
                        var video = await youtube.GetVideoAsync(this.url);

                        lblStatus.ForeColor = Color.Gold;
                        lblStatus.Text = "Gravando no diretório...";

                        File.WriteAllBytes(folderBrowser.SelectedPath + @"\" + video.FullName + ".mp3", await video.GetBytesAsync());

                        configuracao_enquanto_baixa();

                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = "Finalizado";

                        MessageBox.Show(
                                "Baixado com sucesso!",
                                "Finalizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk
                            );

                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                configuracao_enquanto_baixa();
                MessageBox.Show("Ocorreu um erro, tente outra música! " + err.Message);
                this.Close();
            } 
        }
    }
}
