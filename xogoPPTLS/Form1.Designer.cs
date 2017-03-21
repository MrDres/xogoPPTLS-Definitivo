namespace xogoPPTLS
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mibtnEmpezar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miIdioma = new System.Windows.Forms.ToolStripDropDownButton();
            this.miCastellano = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsa = new System.Windows.Forms.ToolStripMenuItem();
            this.miGallego = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstrucciones = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMostrar = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrdenador = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.pbOrdenador = new System.Windows.Forms.PictureBox();
            this.lblMarcadorPlayer = new System.Windows.Forms.Label();
            this.lblPlayerPunt = new System.Windows.Forms.Label();
            this.lblPCPunt = new System.Windows.Forms.Label();
            this.lblMarcadorPC = new System.Windows.Forms.Label();
            this.tlEleccionbtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnSpock = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnLagarto = new System.Windows.Forms.Button();
            this.btnTijeras = new System.Windows.Forms.Button();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInstruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrdenador)).BeginInit();
            this.tlEleccionbtn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mibtnEmpezar,
            this.toolStripSeparator1,
            this.miIdioma,
            this.miInstrucciones});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // mibtnEmpezar
            // 
            resources.ApplyResources(this.mibtnEmpezar, "mibtnEmpezar");
            this.mibtnEmpezar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mibtnEmpezar.Image = global::xogoPPTLS.Properties.Resources.play;
            this.mibtnEmpezar.Name = "mibtnEmpezar";
            this.mibtnEmpezar.Click += new System.EventHandler(this.mibtnEmpezar_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // miIdioma
            // 
            resources.ApplyResources(this.miIdioma, "miIdioma");
            this.miIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCastellano,
            this.miUsa,
            this.miGallego});
            this.miIdioma.Image = global::xogoPPTLS.Properties.Resources.idioma;
            this.miIdioma.Name = "miIdioma";
            // 
            // miCastellano
            // 
            resources.ApplyResources(this.miCastellano, "miCastellano");
            this.miCastellano.Image = global::xogoPPTLS.Properties.Resources.es;
            this.miCastellano.Name = "miCastellano";
            this.miCastellano.Click += new System.EventHandler(this.miCastellano_Click);
            // 
            // miUsa
            // 
            resources.ApplyResources(this.miUsa, "miUsa");
            this.miUsa.Image = global::xogoPPTLS.Properties.Resources.us;
            this.miUsa.Name = "miUsa";
            this.miUsa.Click += new System.EventHandler(this.miUsa_Click_1);
            // 
            // miGallego
            // 
            resources.ApplyResources(this.miGallego, "miGallego");
            this.miGallego.Image = global::xogoPPTLS.Properties.Resources._Galicia;
            this.miGallego.Name = "miGallego";
            this.miGallego.Click += new System.EventHandler(this.miGallego_Click);
            // 
            // miInstrucciones
            // 
            resources.ApplyResources(this.miInstrucciones, "miInstrucciones");
            this.miInstrucciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miInstrucciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miInstrucciones.Image = global::xogoPPTLS.Properties.Resources.pregunta;
            this.miInstrucciones.Name = "miInstrucciones";
            this.miInstrucciones.Click += new System.EventHandler(this.miInstrucciones_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblSeleccion);
            this.panel1.Name = "panel1";
            // 
            // lblSeleccion
            // 
            resources.ApplyResources(this.lblSeleccion, "lblSeleccion");
            this.lblSeleccion.ForeColor = System.Drawing.Color.White;
            this.lblSeleccion.Name = "lblSeleccion";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BackgroundImage = global::xogoPPTLS.Properties.Resources.Instrucciones;
            this.panel2.Controls.Add(this.tabMostrar);
            this.panel2.Controls.Add(this.tlEleccionbtn);
            this.panel2.Name = "panel2";
            // 
            // tabMostrar
            // 
            resources.ApplyResources(this.tabMostrar, "tabMostrar");
            this.tabMostrar.Controls.Add(this.lblOrdenador, 2, 0);
            this.tabMostrar.Controls.Add(this.lblJugador, 0, 0);
            this.tabMostrar.Controls.Add(this.lblVs, 1, 3);
            this.tabMostrar.Controls.Add(this.pbJugador, 0, 3);
            this.tabMostrar.Controls.Add(this.pbOrdenador, 2, 3);
            this.tabMostrar.Controls.Add(this.lblMarcadorPlayer, 0, 2);
            this.tabMostrar.Controls.Add(this.lblPlayerPunt, 0, 1);
            this.tabMostrar.Controls.Add(this.lblPCPunt, 2, 1);
            this.tabMostrar.Controls.Add(this.lblMarcadorPC, 2, 2);
            this.tabMostrar.Name = "tabMostrar";
            // 
            // lblOrdenador
            // 
            resources.ApplyResources(this.lblOrdenador, "lblOrdenador");
            this.lblOrdenador.Name = "lblOrdenador";
            // 
            // lblJugador
            // 
            resources.ApplyResources(this.lblJugador, "lblJugador");
            this.lblJugador.Name = "lblJugador";
            // 
            // lblVs
            // 
            resources.ApplyResources(this.lblVs, "lblVs");
            this.lblVs.Name = "lblVs";
            // 
            // pbJugador
            // 
            resources.ApplyResources(this.pbJugador, "pbJugador");
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.TabStop = false;
            // 
            // pbOrdenador
            // 
            resources.ApplyResources(this.pbOrdenador, "pbOrdenador");
            this.pbOrdenador.Name = "pbOrdenador";
            this.pbOrdenador.TabStop = false;
            // 
            // lblMarcadorPlayer
            // 
            resources.ApplyResources(this.lblMarcadorPlayer, "lblMarcadorPlayer");
            this.lblMarcadorPlayer.Name = "lblMarcadorPlayer";
            // 
            // lblPlayerPunt
            // 
            resources.ApplyResources(this.lblPlayerPunt, "lblPlayerPunt");
            this.lblPlayerPunt.Name = "lblPlayerPunt";
            // 
            // lblPCPunt
            // 
            resources.ApplyResources(this.lblPCPunt, "lblPCPunt");
            this.lblPCPunt.Name = "lblPCPunt";
            // 
            // lblMarcadorPC
            // 
            resources.ApplyResources(this.lblMarcadorPC, "lblMarcadorPC");
            this.lblMarcadorPC.Name = "lblMarcadorPC";
            // 
            // tlEleccionbtn
            // 
            resources.ApplyResources(this.tlEleccionbtn, "tlEleccionbtn");
            this.tlEleccionbtn.Controls.Add(this.btnSpock, 4, 0);
            this.tlEleccionbtn.Controls.Add(this.btnPapel, 1, 0);
            this.tlEleccionbtn.Controls.Add(this.btnLagarto, 3, 0);
            this.tlEleccionbtn.Controls.Add(this.btnTijeras, 2, 0);
            this.tlEleccionbtn.Controls.Add(this.btnPiedra, 0, 0);
            this.tlEleccionbtn.Name = "tlEleccionbtn";
            // 
            // btnSpock
            // 
            resources.ApplyResources(this.btnSpock, "btnSpock");
            this.btnSpock.BackColor = System.Drawing.Color.Transparent;
            this.btnSpock.Image = global::xogoPPTLS.Properties.Resources.spocksmallsinletra;
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.UseVisualStyleBackColor = false;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // btnPapel
            // 
            resources.ApplyResources(this.btnPapel, "btnPapel");
            this.btnPapel.BackColor = System.Drawing.Color.Transparent;
            this.btnPapel.Image = global::xogoPPTLS.Properties.Resources.papelsmallsinletra;
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnLagarto
            // 
            resources.ApplyResources(this.btnLagarto, "btnLagarto");
            this.btnLagarto.BackColor = System.Drawing.Color.Transparent;
            this.btnLagarto.Image = global::xogoPPTLS.Properties.Resources.lagartosmallsinletra;
            this.btnLagarto.Name = "btnLagarto";
            this.btnLagarto.UseVisualStyleBackColor = false;
            this.btnLagarto.Click += new System.EventHandler(this.btnLagarto_Click);
            // 
            // btnTijeras
            // 
            resources.ApplyResources(this.btnTijeras, "btnTijeras");
            this.btnTijeras.BackColor = System.Drawing.Color.Transparent;
            this.btnTijeras.Image = global::xogoPPTLS.Properties.Resources.tijerasmallsinletra;
            this.btnTijeras.Name = "btnTijeras";
            this.btnTijeras.UseVisualStyleBackColor = false;
            this.btnTijeras.Click += new System.EventHandler(this.btnTijeras_Click);
            // 
            // btnPiedra
            // 
            resources.ApplyResources(this.btnPiedra, "btnPiedra");
            this.btnPiedra.BackColor = System.Drawing.Color.Transparent;
            this.btnPiedra.Image = global::xogoPPTLS.Properties.Resources.piedrasmallsinletra;
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.UseVisualStyleBackColor = false;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStart,
            this.tsMatch,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsStart
            // 
            resources.ApplyResources(this.tsStart, "tsStart");
            this.tsStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.tsStart.Name = "tsStart";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            resources.ApplyResources(this.nuevoJuegoToolStripMenuItem, "nuevoJuegoToolStripMenuItem");
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            resources.ApplyResources(this.guardarToolStripMenuItem, "guardarToolStripMenuItem");
            this.guardarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            resources.ApplyResources(this.cerrarToolStripMenuItem, "cerrarToolStripMenuItem");
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsMatch
            // 
            resources.ApplyResources(this.tsMatch, "tsMatch");
            this.tsMatch.Name = "tsMatch";
            // 
            // ayudaToolStripMenuItem
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verInstruccionesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            // 
            // verInstruccionesToolStripMenuItem
            // 
            resources.ApplyResources(this.verInstruccionesToolStripMenuItem, "verInstruccionesToolStripMenuItem");
            this.verInstruccionesToolStripMenuItem.Name = "verInstruccionesToolStripMenuItem";
            this.verInstruccionesToolStripMenuItem.Click += new System.EventHandler(this.verInstruccionesToolStripMenuItem_Click);
            // 
            // Game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabMostrar.ResumeLayout(false);
            this.tabMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrdenador)).EndInit();
            this.tlEleccionbtn.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mibtnEmpezar;
        private System.Windows.Forms.ToolStripDropDownButton miIdioma;
        private System.Windows.Forms.ToolStripMenuItem miCastellano;
        private System.Windows.Forms.ToolStripMenuItem miUsa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miGallego;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlEleccionbtn;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnSpock;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnLagarto;
        private System.Windows.Forms.Button btnTijeras;
        private System.Windows.Forms.ToolStripButton miInstrucciones;
        private System.Windows.Forms.TableLayoutPanel tabMostrar;
        private System.Windows.Forms.Label lblOrdenador;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.PictureBox pbOrdenador;
        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.Label lblMarcadorPlayer;
        private System.Windows.Forms.Label lblPlayerPunt;
        private System.Windows.Forms.Label lblPCPunt;
        private System.Windows.Forms.Label lblMarcadorPC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsStart;
        private System.Windows.Forms.ToolStripMenuItem tsMatch;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInstruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

