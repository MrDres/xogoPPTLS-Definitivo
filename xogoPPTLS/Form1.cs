using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace xogoPPTLS
{
    public partial class Game : Form
    {
        int eleccion1, eleccion2, marcador1 = 0, marcador2 = 0;
        String perder = xogoPPTLS.Resources.StringResources.perder;
        String ganar = xogoPPTLS.Resources.StringResources.ganar;
        String empatar = xogoPPTLS.Resources.StringResources.empatar;
        String guardar = xogoPPTLS.Resources.StringResources.guardar;
        String cerrar = xogoPPTLS.Resources.StringResources.cerrar;
        String cerrarTitulo = xogoPPTLS.Resources.StringResources.cerrarTitulo;
        Random r = new Random();
        



        public Game()
        {


            //Thread.CurrentThread.CurrentCulture = new CultureInfo("");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("");            
            InitializeComponent();






        }


        private void miInstrucciones_Click(object sender, EventArgs e)
        {
            //Abrimos una página web con el navegador con las instrucciones de este juego.
            System.Diagnostics.Process.Start("http://es.wikihow.com/jugar-piedra,-papel,-tijera,-lagarto,-spock");
        }

        private void mibtnEmpezar_Click(object sender, EventArgs e)
        {
            //Al pulsar el boton empezar lo que hacemos es darle visibilidad a la etiqueta de Titulo y tambien a la tabla que tiene dentro los botones.
            empezar();
           


          
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            //Al clickar en el boton piedra se asigna valor al jugador eleccion1 y se asigna otro random al npc eleccion2

            eleccion1 = 1;
            eleccion2 = r.Next(1, 5);
            imagenJugador(eleccion1);
            imagenOrdenador(eleccion2);
            resultado(eleccion1, eleccion2);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            eleccion1 = 2;
            eleccion2 = r.Next(1, 5);
            imagenJugador(eleccion1);
            imagenOrdenador(eleccion2);
            resultado(eleccion1, eleccion2);
        }

        private void btnTijeras_Click(object sender, EventArgs e)
        {
            eleccion1 = 3;
            eleccion2 = r.Next(1, 5);
            imagenJugador(eleccion1);
            imagenOrdenador(eleccion2);
            resultado(eleccion1, eleccion2);
        }

        private void btnLagarto_Click(object sender, EventArgs e)
        {
            eleccion1 = 4;
            eleccion2 = r.Next(1, 5);
            imagenJugador(eleccion1);
            imagenOrdenador(eleccion2);
            resultado(eleccion1, eleccion2);
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            eleccion1 = 5;
            eleccion2 = r.Next(1, 5);
            imagenJugador(eleccion1);
            imagenOrdenador(eleccion2);
            resultado(eleccion1, eleccion2);


        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(cerrar, cerrarTitulo, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
           
        }

        
        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empezar();

        }

        private void verInstruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://es.wikihow.com/jugar-piedra,-papel,-tijera,-lagarto,-spock");
        }

        //PARTE LÓGICA DEL PROGRAMA

        private void resultado(int eleccion1, int eleccion2)
        {
            if (eleccion1 == eleccion2)
            {
                WinLose win = new WinLose();
                win.winLoseModalControl1.lblResultadoModal.Text = empatar;
                win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.Empate;
                win.ShowDialog();
                // MessageBox.Show("EMPATE", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                switch (eleccion1)
                {
                    case 1:
                        if (eleccion2 == 3 || eleccion2 == 4)
                        {
                            marcador1++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = ganar;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.ganarsimpson;
                            win.ShowDialog();
                            //MessageBox.Show("VICTORIA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                            lblMarcadorPlayer.Text = marcador1.ToString();

                        }
                        else
                        {
                            marcador2++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text =perder;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.simsponsperder;
                            win.ShowDialog();
                            //MessageBox.Show("DERROTA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPC.Text = marcador2.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;

                        }
                        break;
                    case 2:
                        if (eleccion2 == 1 || eleccion2 == 5)
                        {
                            marcador1++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = ganar;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.ganarsimpson;
                            win.ShowDialog();
                            //MessageBox.Show("VICTORIA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPlayer.Text = marcador1.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                        }
                        else
                        {
                            marcador2++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = perder;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.simsponsperder;
                            win.ShowDialog();
                            //MessageBox.Show("DERROTA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPC.Text = marcador2.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                        }
                        break;
                    case 3:
                        if (eleccion2 == 2 || eleccion2 == 4)
                        {
                            marcador1++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = ganar;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.ganarsimpson;
                            win.ShowDialog();
                            //MessageBox.Show("VICTORIA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                            lblMarcadorPlayer.Text = marcador1.ToString();
                        }
                        else
                        {
                            marcador2++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text =perder;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.simsponsperder;
                            win.ShowDialog();
                            //MessageBox.Show("DERROTA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPC.Text = marcador2.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;

                        }
                        break;
                    case 4:
                        if (eleccion2 == 2 || eleccion2 == 5)
                        {
                            marcador1++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = ganar;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.ganarsimpson;
                            win.ShowDialog();
                            //MessageBox.Show("VICTORIA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                            lblMarcadorPlayer.Text = marcador1.ToString();
                        }
                        else
                        {
                            marcador2++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = perder;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.simsponsperder;
                            win.ShowDialog();
                            //MessageBox.Show("DERROTA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPC.Text = marcador2.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                        }
                        break;
                    case 5:
                        if (eleccion2 == 1 || eleccion2 == 3)
                        {
                            marcador1++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = ganar;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.ganarsimpson;
                            win.ShowDialog(); 
                            //MessageBox.Show("VICTORIA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;
                            lblMarcadorPlayer.Text = marcador1.ToString();
                        }
                        else
                        {
                            marcador2++;
                            WinLose win = new WinLose();
                            win.winLoseModalControl1.lblResultadoModal.Text = perder;
                            win.winLoseModalControl1.pbModalWinLose.Image = xogoPPTLS.Properties.Resources.simsponsperder;
                            win.ShowDialog();
                            //MessageBox.Show("DERROTA", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            lblMarcadorPC.Text = marcador2.ToString();
                            pbJugador.Image = null;
                            pbOrdenador.Image = null;

                        }
                        break;
                }
            }


        }

        public void empezar()
        {
            lblSeleccion.Visible = true;
            tlEleccionbtn.Visible = true;
            tabMostrar.Visible = true;
            panel1.Visible = true;
            marcador1 =0;
            marcador2 = 0;
            lblMarcadorPC.Text = marcador2.ToString();
            lblMarcadorPlayer.Text = marcador2.ToString();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guardar);
        }

        //CARGA DE LAS IMAGENES DE LO SELECCIONADO  1º Jugador imagenJugador(), 2º Ordenador imagenOrdenador().

        private void imagenJugador(int eleccion1)
        {
            switch (eleccion1)
            {
                case 1:
                    pbJugador.Image = xogoPPTLS.Properties.Resources.piedrasmallsinletra;
                    break;
                case 2:
                    pbJugador.Image = xogoPPTLS.Properties.Resources.papelsmallsinletra;
                    break;
                case 3:
                    pbJugador.Image = xogoPPTLS.Properties.Resources.tijerasmallsinletra;
                    break;
                case 4:
                    pbJugador.Image = xogoPPTLS.Properties.Resources.lagartosmallsinletra;
                    break;
                case 5:
                    pbJugador.Image = xogoPPTLS.Properties.Resources.spocksmallsinletra;
                    break;
            }
        }



        private void imagenOrdenador(int eleccion2)
        {
            switch (eleccion2)
            {
                case 1:
                    pbOrdenador.Image = xogoPPTLS.Properties.Resources.piedrasmallsinletra;
                    break;
                case 2:
                    pbOrdenador.Image = xogoPPTLS.Properties.Resources.papelsmallsinletra;
                    break;
                case 3:
                    pbOrdenador.Image = xogoPPTLS.Properties.Resources.tijerasmallsinletra;
                    break;
                case 4:
                    pbOrdenador.Image = xogoPPTLS.Properties.Resources.lagartosmallsinletra;
                    break;
                case 5:
                    pbOrdenador.Image = xogoPPTLS.Properties.Resources.spocksmallsinletra;
                    break;
            }
        }

      


        //PARTE DE CODIGO DE LOCALIZACIÓN DEL PROGRAMA

        private void miUsa_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.Controls.Clear();            
            this.InitializeComponent();
            aplicarIdiomas();

        }

        private void miGallego_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("gl-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("gl-ES");
            this.Controls.Clear();
            this.InitializeComponent();
            aplicarIdiomas();
            

        }


        private void miCastellano_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            this.Controls.Clear();
            this.InitializeComponent();
            aplicarIdiomas();
            

        }
        private void aplicarIdiomas()
        {
            perder = xogoPPTLS.Resources.StringResources.perder;
            ganar = xogoPPTLS.Resources.StringResources.ganar;
            empatar = xogoPPTLS.Resources.StringResources.empatar;
            guardar = xogoPPTLS.Resources.StringResources.guardar;
            cerrar = xogoPPTLS.Resources.StringResources.cerrar;
            cerrarTitulo = xogoPPTLS.Resources.StringResources.cerrarTitulo;


        }

    }
}
