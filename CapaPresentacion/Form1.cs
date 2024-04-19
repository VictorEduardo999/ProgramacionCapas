using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Persona persona = new Persona();
        private static Alumno alumno = new Alumno();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Apellidos = txtApellido.Text;
            persona.Nombres = txtNombre.Text;
            persona.Edad = Convert.ToInt32(txtEdad.Text);
            MessageBox.Show("Se registro correctamente el objeto Persona");
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.DevolverDatos());

        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            alumno.Codigo = txtCodigoAl.Text;
            alumno.Telefono = txtTelefonoAl.Text;
            MessageBox.Show("Se registro correctamente el objeto Alumno");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReportar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.DevolverDatosAlumno());

        }
    }
}
