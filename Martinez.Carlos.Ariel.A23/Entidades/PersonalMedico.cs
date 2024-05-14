using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 FichaExtra: debe armar una ficha con todos los datos del objeto con el formato:

¿Finalizó residencia? {SI/NO}
ATENCIONES:
{Fichas de la lista de CONSULTAS}

5. El operador + agregará nuevas consultas a la lista, tomando como fecha de inicio de la misma el
método Now de la clase DateTime.
 */
namespace Entidades
{
    public class PersonalMedico : Persona
    {

        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido , nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {(this.esResidente ? "SI" : "NO")}");
            sb.AppendLine($"ATENCIONES:");
            foreach (Consulta consulta in this.consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);

            return consulta;
        }

    }
}
