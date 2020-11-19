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
    public partial class frmBaixarVideo : Form
    {
        private string url;
        private int resolucao;
        private string formato;

        public frmBaixarVideo(string url)
        {
            InitializeComponent();

            this.url = url;
        }

        private void frmBaixarVideo_Load(object sender, EventArgs e)
        {
            cmbResolucao.SelectedIndex = 0;
            cmbFormato.SelectedIndex = 0;
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
                string[] numero_resolucao = cmbResolucao.Text.Split('p');
                this.resolucao = Convert.ToInt32(numero_resolucao[0]);
                this.formato = cmbFormato.Text;

                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { Description = "Selecione um diretório" })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        configuracao_enquanto_baixa();

                        lblStatus.Text = "Baixando....";
                        lblStatus.ForeColor = Color.Red;

                        var youtube = YouTube.Default;
                        var videos = await youtube.GetAllVideosAsync(this.url);

                        var video = videos.FirstOrDefault(v => v.Resolution == this.resolucao);

                        lblStatus.ForeColor = Color.Gold;
                        lblStatus.Text = "Gravando no diretório...";

                        File.WriteAllBytes(folderBrowser.SelectedPath + @"\" + video.FullName + $".{this.formato.ToLower()}", await video.GetBytesAsync());

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
                MessageBox.Show("Ocorreu um erro, tente outro video! " + err.Message);
                this.Close();
            }

        }

        private void baixar_barra_progresso(object sender, EventArgs e)
        {
            MessageBox.Show("Baixado com sucesso!");
        }
    }
}
