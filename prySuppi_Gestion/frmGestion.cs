using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_Gestion
{
    public partial class frmGestion : Form
    {
        clsUsuario objUsuario;
        public frmGestion()
        {
            InitializeComponent();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            objUsuario = new clsUsuario();
            lblConexion.Text = objUsuario.estadoConexion;
        }
    }
}
