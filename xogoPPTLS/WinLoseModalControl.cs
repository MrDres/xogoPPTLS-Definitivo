using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xogoPPTLS
{
    public partial class WinLoseModalControl : UserControl
    {
        public string _mensaje { get; internal set; }

        public WinLoseModalControl()
        {
            InitializeComponent();
        }

       

        public void cambiarEtiqueta(object sender, EventArgs e)
        {
            lblResultadoModal.Text = _mensaje;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void btnModAceptar_Click(object sender, EventArgs e)
        {

        }
    }

   
}
