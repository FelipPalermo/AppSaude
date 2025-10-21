using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AppSaude_PI
{
    public partial class CadPacientes : Form
    {
        public CadPacientes()
        {
            InitializeComponent();
            TBSexo.SelectedIndex = 0;
        }


        private void BTCadastrar_Click(object sender, EventArgs e)
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

            string query = @"INSERT INTO pacientes 
                 (nome, cpf, rg, sexo, DataNascimento, telefone, documentos_ok) 
                 VALUES (@nome, @cpf, @rg, @sexo, @DataNascimento, @telefone, @docok)";

            SQLConn.SqlInsert(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@nome", TBNome.Text);
                cmd.Parameters.AddWithValue("@cpf", MTCpf.Text);
                cmd.Parameters.AddWithValue("@rg", MTRg.Text);
                cmd.Parameters.AddWithValue("@sexo", TBSexo.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", Nascimento.Value);
                cmd.Parameters.AddWithValue("@telefone", MTTelefone.Text);
                cmd.Parameters.AddWithValue("@docok", true);

            }, $"Paciente {TBNome.Text} inserido com sucesso!");
        }

        private void CadPaciente_Load(object sender, EventArgs e)
        {
            TBSexo.SelectedIndex = 0;
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTLimpar_Click(object sender, EventArgs e)
        {
            TBNome.Text = "";
            Nascimento.Value = DateTime.Now;
            TBSexo.SelectedIndex = 0;
            MTTelefone.Text = "";
            MTRg.Text = "";
            MTCpf.Text = "";

        }
    }
}
