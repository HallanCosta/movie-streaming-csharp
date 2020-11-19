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
    public partial class frmEpisodios : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
                 "Persist Security Info = False;" + //usado para não pedir confirmação da senha
                 "server=localhost;" + //onde está o banco de dados
                 "database=movie_streaming;" + // nome do banco de dados
                 "uid=root;" + //nome do usuário
                 "pwd=" // senha do usuário do banco
             );

        int id = 0;
        bool anime = true;

        public frmEpisodios(string nome, int id, bool anime)
        {
            InitializeComponent();
            this.Text = $"Episodios de {nome}";

            this.id = id;
            this.anime = anime;

            carregar_episodios();
        }

        public void carregar_episodios()
        {
            
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand commandoSQL = mConn.CreateCommand();

                    commandoSQL.CommandText = this.anime 
                        ? $"SELECT * FROM stream_animes WHERE id_anime = {this.id}" 
                        : $"SELECT * FROM stream_filmes WHERE id_filme = {this.id}";

                    commandoSQL.Connection = mConn;

                    MySqlDataReader dados = commandoSQL.ExecuteReader();

                    string[] episodios;
                    

                    while (dados.Read())
                    {
                        episodios = new string[]
                        {
                            dados["numero"].ToString(),
                            dados["streaming_url"].ToString()
                        };

                        Button botao = new Button
                        {
                            Name = $"btnEpisodio{episodios[0]}",
                            Size = new Size(956, 61),
                            Text = $"Episodio {episodios[0]}",
                            Font = new Font("Arial", 22),
                            BackColor = Color.White,
                            AccessibleName = episodios[0]
                        };

                        botao.Click += botao_clicado;

                        flpCenter.Controls.Add(botao);
                    }

                }

                mConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao tentar se conectar com banco de dados.\n\n\n{err.Message}");
            }

            
        }

        private void frmEpisodios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.anime)
            {
                frmAnimes frmAnimes = new frmAnimes();
                frmAnimes.Show();
            }
            else
            {
                frmFilmes frmFilmes = new frmFilmes();
                frmFilmes.Show();
            }
            
        }

        private void botao_clicado(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            int numero = Convert.ToInt32(botao.AccessibleName);

            frmStreaming frmStreaming = new frmStreaming(this.id, numero, true);
            frmStreaming.Show();
        }
        
    }
}
