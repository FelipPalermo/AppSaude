using AppSaude_PI.Telas;
using AppSaude_PI.Telas.Pessoas;
using AppSaude_PI.Telas.TelaConsultas;

namespace AppSaude_PI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Cadastro medico
        private void CadastrarMedico_Click(object sender, EventArgs e)
        {

            // Using chama dispose automaticamente
            // Igual with open de python
            using (var telaCadastroMedicos = new CadMedicos())
            {
                telaCadastroMedicos.ShowDialog();
            }
        }
        #endregion

        #region Cadastro Paciente
        private void CadastrarPaciente_Click(object sender, EventArgs e)
        {
            // Using chama dispose automaticamente
            // Igual with open de python
            using (var telaCadastroPaciente = new CadPacientes())
            {
                telaCadastroPaciente.ShowDialog();
            }
        }
        #endregion


        private void ListarPessoa_Click(object sender, EventArgs e)
        {
            using (ListarPacientes telaListarPacientes = new ListarPacientes())
            {
                telaListarPacientes.ShowDialog();
            }
        }

        private void CadastrarMedico_Click_1(object sender, EventArgs e)
        {
            using (var telaCadastroPaciente = new CadMedicos())
            {
                telaCadastroPaciente.ShowDialog();
            }
        }

        private void ListarMedicos_Click(object sender, EventArgs e)
        {
            using (ListarMedicos telaListarPacientes = new ListarMedicos())
            {
                using (var telaMarcarExame = new ListarMedicos())
                    telaMarcarExame.ShowDialog();
            }
        }

        private void BtAgendarExame_Click(object sender, EventArgs e)
        {
            using (marcarExame telaListarPacientes = new marcarExame())
            {
                using (var telaMarcarExame = new marcarExame())
                    telaMarcarExame.ShowDialog();
            }

        }

        private void btHistoricoExames_Click(object sender, EventArgs e)
        {
            using (HistoricoExames telaListarPacientes = new HistoricoExames())
            {
                using (var telaHistoricoExame = new HistoricoExames())
                    telaHistoricoExame.ShowDialog();
            }
        }

        private void btCancelarExame_Click(object sender, EventArgs e)
        {
            using (CancelarExame telaListarPacientes = new CancelarExame())
            {
                using (var telaCancelarExame = new CancelarExame())
                    telaCancelarExame.ShowDialog();
            }

        }
    }
}
