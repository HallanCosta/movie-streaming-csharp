namespace MovieStreaming
{
    partial class frmAssistirStreamingYoutube
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
            this.wbStreaming = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbStreaming
            // 
            this.wbStreaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbStreaming.Location = new System.Drawing.Point(0, 0);
            this.wbStreaming.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbStreaming.Name = "wbStreaming";
            this.wbStreaming.Size = new System.Drawing.Size(1356, 749);
            this.wbStreaming.TabIndex = 0;
            // 
            // frmStreamingYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 749);
            this.Controls.Add(this.wbStreaming);
            this.Name = "frmStreamingYoutube";
            this.Text = "frmStreamingYoutube";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbStreaming;
    }
}