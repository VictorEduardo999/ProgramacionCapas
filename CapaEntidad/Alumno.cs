using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class Alumno : Persona
    {
        //Constructores
        public Alumno() // Constructor si parametros
        { }

        public Alumno(String Codigos)
        {
            this.codigo = Codigos;
        }

        public Alumno(String Codigos, string Telefonos)
        {
            this.codigo = Codigos;
            this.telefono = Telefonos;
        }

        private string codigo;
        private string telefono;

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string DevolverDatosAlumno()
        {
            return "Codigo: " + this.codigo +  " Telefono: " + this.telefono;
        }
    }
}