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
    public partial class frmAssistirStreamingYoutube : Form
    {
        public frmAssistirStreamingYoutube(string url)
        {
            InitializeComponent();

            string[] video = url.Split('=');
            string streaming = $"https://www.youtube.com/embed/{video[1]}";

            string html = "<html>";
            html += "<head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "</head>";
            html += "<body style='text-align: center'>";
            html += $"<iframe id='video' src= '{streaming}' width='720' height='480' frameborder='0' allowfullscreen></iframe>";
            html += "</body>";
            html += "</html>";

            this.wbStreaming.DocumentText = string.Format(html);
        }
        
    }
}
