using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using AppSaude_PI.Telas.Pessoas;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppSaude_PI
{
    public partial class AltPaciente : Form
    {
        public Paciente objPaciente;
        public AltPaciente(Paciente p)
        {

            InitializeComponent();
            this.objPaciente = p;

        }
        

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltPaciente_Load(object sender, EventArgs e)
        {
            TBNome.Text = objPaciente.Nome;
            Nascimento.Value = objPaciente.DataNaciscmento;
            TBSexo.Text = objPaciente.Sexo;
            MTTelefone.Text = objPaciente.Telefone;
            MTRg.Text = objPaciente.RG;
            MTCpf.Text = objPaciente.CPF;
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(MTCpf.Text, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                MessageBox.Show("CPF incorreto");
                MTCpf.Focus();
                return;
            }
            if (!Regex.IsMatch(MTRg.Text, @"^\d{2}\.\d{3}.\d{3}-\d{1}"))
            {
                MessageBox.Show("RG incorreto");
                MTRg.Focus();
                return;
            }

            Paciente paciente = new Paciente()
            {
                id = objPaciente.id,
                Nome = TBNome.Text,
                DataNaciscmento = Nascimento.Value,
                Sexo = TBSexo.Text,
                Telefone = MTTelefone.Text,
                RG = MTRg.Text,
                CPF = MTCpf.Text
            };

            if (!string.IsNullOrWhiteSpace(paciente.CPF) && paciente.CPF.Any(char.IsDigit) &&
                !string.IsNullOrWhiteSpace(paciente.RG) && paciente.RG.Any(char.IsDigit))
            {
                paciente.documentosOk = true;
            }

            SQLConn.alterarPaciente(paciente);

            ListarPacientes listaForm = Application.OpenForms.OfType<ListarPacientes>().FirstOrDefault();
            if (listaForm != null)
            {
                listaForm.ListarPacientes_Load_1(sender, e);
            }
            this.Close();
        }

        private void BTExcluir_Click(object sender, EventArgs e)
        {
            SQLConn.delSql("DELETE FROM pacientes WHERE id_paciente = @id", 
                cmd => cmd.Parameters.AddWithValue("@id", objPaciente.id));

            // Retorna uma lista com os formularios abertos e pega o primeiro / default 
            // que esitver aberto
            ListarPacientes listaForm = Application.OpenForms.OfType<ListarPacientes>().FirstOrDefault();
            if (listaForm != null)
            {
                listaForm.ListarPacientes_Load_1(sender, e);
            }

            this.Close();

        }
    }
}
