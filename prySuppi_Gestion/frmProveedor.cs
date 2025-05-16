using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_Gestion
{
    public partial class frmProveedor : Form
    {
        clsUsuario clsUsuario = new clsUsuario();
        public frmProveedor(string nombre)
        {
            InitializeComponent();
            nmbreUsuario = nombre;
        }

        string nmbreUsuario = "";
        private void frmProveedor_Load(object sender, EventArgs e)
        {

            dgvProveedores.Rows.Clear();

            lblUsuario.Text = "Usuario: " + nmbreUsuario;
            lblFechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
   

            using (StreamReader reader = new StreamReader("../../Archivos/datosProveedor.txt"))
            {
                string content = reader.ReadLine();
                int cont = 0;
            
                while (content != null) {
                    string[] data = content.Split('	');
                    if (cont == 0)
                    {
                        dgvProveedores.Columns.Add("Nº", data[0]);
                        dgvProveedores.Columns.Add("Entidad", data[1]);
                        dgvProveedores.Columns.Add("APERTURA", data[2]);
                        dgvProveedores.Columns.Add("Nº EXPTE.", data[3]);
                        dgvProveedores.Columns.Add("JUZG.", data[4]);
                        dgvProveedores.Columns.Add("JURISD", data[5]);
                        dgvProveedores.Columns.Add("DIRECCION", data[6]);
                        dgvProveedores.Columns.Add("LIQUIDADOR RESPONSABLE", data[7]);

                    } else {
                        
                        Console.WriteLine(data);
                        dgvProveedores.Rows.Add(data);
                    }
                   
                    content = reader.ReadLine();
                    cont++;
                }
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
