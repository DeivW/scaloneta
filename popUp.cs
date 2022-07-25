using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_RT
{
    public partial class popUp : Form
    {
        PantallaRegistrarReserva pp;
        public popUp(PantallaRegistrarReserva pp)
        {
            this.pp = pp;
            InitializeComponent();
        }
    }
}
