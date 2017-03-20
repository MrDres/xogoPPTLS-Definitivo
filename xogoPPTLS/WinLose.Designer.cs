namespace xogoPPTLS
{
    partial class WinLose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLose));
            this.winLoseModalControl1 = new xogoPPTLS.WinLoseModalControl();
            this.SuspendLayout();
            // 
            // winLoseModalControl1
            // 
            this.winLoseModalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winLoseModalControl1.Location = new System.Drawing.Point(0, 0);
            this.winLoseModalControl1.MaximumSize = new System.Drawing.Size(284, 267);
            this.winLoseModalControl1.MinimumSize = new System.Drawing.Size(284, 267);
            this.winLoseModalControl1.Name = "winLoseModalControl1";
            this.winLoseModalControl1.Size = new System.Drawing.Size(284, 267);
            this.winLoseModalControl1.TabIndex = 0;
            // 
            // WinLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 267);
            this.Controls.Add(this.winLoseModalControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 306);
            this.Name = "WinLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Juego";
            this.ResumeLayout(false);

        }

        #endregion

        public WinLoseModalControl winLoseModalControl1;
    }
}