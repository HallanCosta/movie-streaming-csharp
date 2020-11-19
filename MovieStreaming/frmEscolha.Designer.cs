namespace MovieStreaming
{
    partial class frmEscolha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAssistirYoutube = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.btnAnimes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 79);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(2, -29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Streaming";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 353);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAssistirYoutube, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBaixar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFilmes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnimes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAssistirYoutube
            // 
            this.btnAssistirYoutube.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistirYoutube.Location = new System.Drawing.Point(381, 179);
            this.btnAssistirYoutube.Name = "btnAssistirYoutube";
            this.btnAssistirYoutube.Size = new System.Drawing.Size(372, 168);
            this.btnAssistirYoutube.TabIndex = 3;
            this.btnAssistirYoutube.Text = "Assistir Youtube";
            this.btnAssistirYoutube.UseVisualStyleBackColor = true;
            this.btnAssistirYoutube.Click += new System.EventHandler(this.btnAssistirYoutube_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.Location = new System.Drawing.Point(3, 179);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(372, 168);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "Baixar no Youtube";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnFilmes
            // 
            this.btnFilmes.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.Location = new System.Drawing.Point(381, 3);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(372, 168);
            this.btnFilmes.TabIndex = 1;
            this.btnFilmes.Text = "Assistir Filmes";
            this.btnFilmes.UseVisualStyleBackColor = true;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // btnAnimes
            // 
            this.btnAnimes.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimes.Location = new System.Drawing.Point(3, 3);
            this.btnAnimes.Name = "btnAnimes";
            this.btnAnimes.Size = new System.Drawing.Size(372, 168);
            this.btnAnimes.TabIndex = 0;
            this.btnAnimes.Text = "Assistir Animes";
            this.btnAnimes.UseVisualStyleBackColor = true;
            this.btnAnimes.Click += new System.EventHandler(this.btnAnimes_Click);
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(762, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streaming";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAssistirYoutube;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnAnimes;
    }
}

