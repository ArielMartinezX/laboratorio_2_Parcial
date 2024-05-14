using Entidades;

namespace MartinezCarlosAriel
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Paciente paciente = lstPacientes.SelectedItem as Paciente;
            PersonalMedico medico = lstMedicos.SelectedItem as PersonalMedico;

            if (medico == null || paciente == null)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                paciente.Diagnostico = "Paciente curado";
                Consulta consulta = medico + paciente;
                lstMedicos.SelectedIndex = -1;
                lstPacientes.SelectedIndex = -1;

                MessageBox.Show($"{consulta.ToString()}", "Atencion finalizada", MessageBoxButtons.OK);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbInfoMedico.Clear();
            PersonalMedico medico = lstMedicos.SelectedItem as PersonalMedico;
            if (medico is not null)
            {
                rtbInfoMedico.Text = Persona.FichaPersonal(medico);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
