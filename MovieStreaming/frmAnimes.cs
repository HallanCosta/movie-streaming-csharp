using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MovieStreaming
{
    public partial class frmAnimes : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
                 "Persist Security Info = False;" + //usado para não pedir confirmação da senha
                 "server=localhost;" + //onde está o banco de dados
                 "database=movie_streaming;" + // nome do banco de dados
                 "uid=root;" + //nome do usuário
                 "pwd=" // senha do usuário do banco
             );

        /*private MySqlConnection mConn = new MySqlConnection(
                 "Persist Security Info = False;" + //usado para não pedir confirmação da senha
                 "server=85.10.205.173;" + //onde está o banco de dados
                 "database=movie_streaming;" + // nome do banco de dados
                 "uid=rootinho;" + //nome do usuário
                 "pwd=rootinho123" // senha do usuário do banco
             );*/

        public frmAnimes()
        {
            InitializeComponent();
            carrega_animes();
        }

        public void carrega_animes()
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand commandoSQL = mConn.CreateCommand();

                    commandoSQL.CommandText = $"SELECT * FROM animes";

                    commandoSQL.Connection = mConn;

                    MySqlDataReader dados = commandoSQL.ExecuteReader();

                    int i = 1;
                    string[] animes;

                    while (dados.Read())
                    {
                        animes = new string[]
                        {
                            dados["id"].ToString(),
                            dados["nome"].ToString(),
                            dados["imagem"].ToString()
                        };

                        var tableLayoutAnime = new TableLayoutPanel
                        {
                            Name = $"tableLayoutAnime{i}",
                            ColumnCount = 1,
                            RowCount = 2,
                            Size = new Size(190, 377)
                        };

                        tableLayoutAnime.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                        tableLayoutAnime.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                        var lblNome = new Label
                        {
                            Text = $"{animes[1].ToString()}",
                            BackColor = Color.White,
                            Size = new Size(188, 54),
                            Font = new Font("Verdana", 12),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        var pbImagem = new PictureBox
                        {
                            BackColor = Color.Black,
                            ImageLocation = $"{animes[2].ToString()}",
                            Name = $"pbImagem{i}",
                            Size = new Size(185, 278),
                            SizeMode = PictureBoxSizeMode.AutoSize,
                            BorderStyle = BorderStyle.Fixed3D,
                            AccessibleName = animes[0].ToString(),
                            AccessibleDescription = animes[1].ToString()
                        };

                        pbImagem.Click += anime_selecionado;

                        tableLayoutAnime.Controls.Add(lblNome, 1, 1);
                        tableLayoutAnime.Controls.Add(pbImagem, 1, 2);

                        flowLayoutAnimes.Controls.Add(tableLayoutAnime);

                        pbImagem.BringToFront();
                    }
                  
                }

                mConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao tentar se conectar com banco de dados.\n\n\n{err.Message}");
            }
        }

        public void anime_selecionado(object sender, EventArgs e)
        {
            PictureBox pbImagem = sender as PictureBox;

            string nome = pbImagem.AccessibleDescription;
            int id_anime = Convert.ToInt32(pbImagem.AccessibleName);

            //MessageBox.Show(pbImagem.AccessibleDescription);
            //MessageBox.Show(pbImagem.AccessibleName);

            frmEpisodios frmEpisodios = new frmEpisodios(nome, id_anime, true);
            this.Visible = false;
            frmEpisodios.Show();
        }
    }
}
