using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContratarEmpleado.BSS;
using ContratarEmpleado.MODELOS;
using ContratarEmpleado.VISTA.PersonaVista;

namespace ContratarEmpleado.VISTA.EmpleadoVista
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void buttonSELECCIONAR_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
        EmpleadoBss bssuser = new EmpleadoBss();

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IdPersona = Convert.ToInt32(IdPersonaSeleccionada);
            empleado.Puesto = textBox2.Text;
            empleado.Salario= Convert.ToDecimal( textBox3.Text);
            empleado.FechaDeContratacion = dateTimePicker1.Value;

            bssuser.InsertarEmpleadoBss(empleado);
            MessageBox.Show("Empleado contratado");

        }
    }
}
