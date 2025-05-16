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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
 

            if(objUsuario.estadoConexion == "Usuario EXISTE")
            {
                try
                {
                    frmProveedor frmProveedor = new frmProveedor(txtUsuario.Text);
                    frmProveedor.Show();
                } catch
                {
                    MessageBox.Show("Error al iniciar sesión: " + objUsuario.estadoConexion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión: " + objUsuario.estadoConexion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
