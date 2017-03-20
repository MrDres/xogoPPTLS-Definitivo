namespace xogoPPTLS
{
    partial class WinLoseModalControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pbModalWinLose = new System.Windows.Forms.PictureBox();
            this.lblResultadoModal = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModalWinLose)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pbModalWinLose);
            this.MainPanel.Controls.Add(this.lblResultadoModal);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(284, 267);
            this.MainPanel.TabIndex = 0;
            // 
            // pbModalWinLose
            // 
            this.pbModalWinLose.BackColor = System.Drawing.Color.Orange;
            this.pbModalWinLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbModalWinLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbModalWinLose.Location = new System.Drawing.Point(0, 54);
            this.pbModalWinLose.Name = "pbModalWinLose";
            this.pbModalWinLose.Size = new System.Drawing.Size(284, 213);
            this.pbModalWinLose.TabIndex = 1;
            this.pbModalWinLose.TabStop = false;
            // 
            // lblResultadoModal
            // 
            this.lblResultadoModal.BackColor = System.Drawing.Color.Black;
            this.lblResultadoModal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResultadoModal.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoModal.ForeColor = System.Drawing.Color.White;
            this.lblResultadoModal.Location = new System.Drawing.Point(0, 0);
            this.lblResultadoModal.Name = "lblResultadoModal";
            this.lblResultadoModal.Size = new System.Drawing.Size(284, 54);
            this.lblResultadoModal.TabIndex = 0;
            this.lblResultadoModal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinLoseModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(284, 267);
            this.MinimumSize = new System.Drawing.Size(284, 267);
            this.Name = "WinLoseModalControl";
            this.Size = new System.Drawing.Size(284, 267);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbModalWinLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.PictureBox pbModalWinLose;
        public System.Windows.Forms.Label lblResultadoModal;
    }
}
