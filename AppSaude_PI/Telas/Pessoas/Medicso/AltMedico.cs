using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using AppSaude_PI.Telas.Pessoas;
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
    public partial class AltMedico : Form
    {
        public Medico objMedico;
        public AltMedico(Medico m)
        {

            InitializeComponent();
            this.objMedico = m;

        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltMedico_Load(object sender, EventArgs e)
        {
            TBNome.Text = objMedico.Nome;
            Nascimento.Value = objMedico.DataNasciscmento;
            TBSexo.Text = objMedico.Sexo;
            MTTelefone.Text = objMedico.Telefone;
            MTCRM.Text = objMedico.RG;
            MTCpf.Text = objMedico.CPF;
            TBHorarioTrabalho.Text = objMedico.horarioTrabalho;
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(MTCpf.Text, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                MessageBox.Show("CPF incorreto");
                MTCpf.Focus();
                return;
            }
            if (!Regex.IsMatch(MTCRM.Text, @"^\d{6}$"))
            {
                MessageBox.Show("CRM incorreto");
                MTCRM.Focus();
                return;
            }

            Medico medico = new Medico()
            {
                id = objMedico.id,
                Nome = TBNome.Text,
                DataNasciscmento = Nascimento.Value,
                Sexo = TBSexo.Text,
                Telefone = MTTelefone.Text,
                CRM = MTCRM.Text,
                CPF = MTCpf.Text,
                horarioTrabalho = TBHorarioTrabalho.Text,

            };

            SQLConn.alterarMedico(medico);
            this.Close();
        }

        private void BTExcluir_Click(object sender, EventArgs e)
        {
            SQLConn.delSql("DELETE FROM medicos WHERE id_medico = @id", 
                cmd => cmd.Parameters.AddWithValue("@id", objMedico.id));

            // Retorna uma lista com os formularios abertos e pega o primeiro / default 
            // que esitver aberto
            ListarMedicos listaForm = Application.OpenForms.OfType<ListarMedicos>().FirstOrDefault();
            if (listaForm != null)
            {
                listaForm.ListarMedicos_Load_1(sender, e);
            }

            this.Close();

        }
    }
}
