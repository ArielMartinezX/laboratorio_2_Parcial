using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia)
            : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get { return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1; }
        }

        public string NombreCompleto
        {
            get { return $"{this.apellido} {this.nombre}"; }
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());

            return sb.ToString();
        }

        public abstract string FichaExtra();
   
    }
}
