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
    public partial class frmStreaming : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
                 "Persist Security Info = False;" + //usado para não pedir confirmação da senha
                 "server=localhost;" + //onde está o banco de dados
                 "database=movie_streaming;" + // nome do banco de dados
                 "uid=root;" + //nome do usuário
                 "pwd=" // senha do usuário do banco
             );

        private string url;
         
        public frmStreaming(int id, int numero, bool anime)
        {
            InitializeComponent();

            Streaming(id, numero, anime);
        }

        public void Streaming(int id, int numero, bool anime)
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {

                    MySqlCommand comandoSQL = mConn.CreateCommand();
                    comandoSQL.CommandText = anime 
                        ? $"SELECT * FROM stream_animes WHERE numero = {numero} AND id_anime = {id}"
                        : $"SELECT * FROM stream_filmes WHERE id_filme = {id}";

                    comandoSQL.Connection = mConn;

                    MySqlDataReader dados = comandoSQL.ExecuteReader();

                    dados.Read();

                    if (anime)
                    {
                        this.url = dados[2].ToString();
                    }
                    else
                    {
                        string[] filme = dados[2].ToString().Split('=');

                        this.url = $"https://www.youtube.com/embed/{filme[1]}";
                    }

                    string html = "<html>";
                    html += "<head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "</head>";
                    html += "<body style='text-align: center'>";
                    html += $"<iframe id='video' src= '{this.url}' width='720' height='480' frameborder='0' allowfullscreen></iframe>";
                    html += "</body>";
                    html += "</html>";

                    this.wbStreaming.DocumentText = string.Format(html);
                }

                mConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao tentar se conectar com banco de dados.\n\n\n{err.Message}");
            }
        }
    }
}
