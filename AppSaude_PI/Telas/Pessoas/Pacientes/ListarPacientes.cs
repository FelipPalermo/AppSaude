using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using AppSaude_PI.Telas.Pacientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppSaude_PI.Telas.Pessoas
{
    public partial class ListarPacientes : Form
    {

        public ListarPacientes()
        {
            InitializeComponent();
            listViewPacientes.FullRowSelect = true;
            listViewPacientes.GridLines = true;
            listViewPacientes.View = View.Details;
        }

        #region Listar pacientes
        public void ListarPacientes_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pacientes";

            List<Paciente> pacientes = SQLConn.SqlGetList(query, reader => new Paciente
            {
                id = reader.GetInt32("id_paciente"),
                Nome = reader.GetString("nome"),
                CPF = reader.GetString("cpf"),
                RG = reader.GetString("rg"),
                Sexo = reader.GetString("sexo"),
                documentosOk = reader.GetBoolean("documentos_ok"),
                pagamentosEmDia = reader.GetBoolean("pagamentos_em_dia"),
                dataCadastro = reader.GetDateTime("data_cadastro"),
                DataNaciscmento = reader.GetDateTime("DataNascimento"),
                Telefone = reader.GetString("telefone")
            });

            listViewPacientes.Items.Clear();


            foreach (var p in pacientes)
            {
                try
                {

                    ListViewItem item = new ListViewItem(p.Nome);
                    item.SubItems.Add(p.Telefone);
                    item.SubItems.Add(p.RG);
                    item.SubItems.Add(p.CPF);
                    item.SubItems.Add(p.Sexo);
                    item.SubItems.Add(p.pagamentosEmDia ? "Sim" : "Não");
                    item.SubItems.Add(p.documentosOk ? "Sim" : "Não");
                    item.SubItems.Add(p.dataCadastro.ToString());

                    item.Tag = p;
                    listViewPacientes.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Alterar
        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (listViewPacientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um paciente primeiro");
                return;
            }
            else if (listViewPacientes.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um por vez!");
                return;
            }


            ListViewItem itemSelecionado = listViewPacientes.SelectedItems[0];
            Paciente pacienteSelecionado = (Paciente)itemSelecionado.Tag;


            using (AltPaciente telaAltCadastro = new AltPaciente(pacienteSelecionado))
            {
                telaAltCadastro.ShowDialog();
            }
        }
        #endregion

        private void BtAtualziar_Click(object sender, EventArgs e)
        {
            this.ListarPacientes_Load_1(sender, e);
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewPacientes.SelectedItems)
            {
                Paciente pacienteSelecionado = (Paciente)item.Tag;

                SQLConn.delSql("DELETE FROM pacientes WHERE id_paciente = @id",
                cmd => cmd.Parameters.AddWithValue("@id", pacienteSelecionado.id));
            }
            this.ListarPacientes_Load_1(sender, e);

        }

        private void BtHistorico_Click(object sender, EventArgs e)
        {
            if (listViewPacientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um paciente primeiro");
                return;
            }
            else if (listViewPacientes.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um por vez!");
                return;
            }

            ListViewItem itemSelecionado = listViewPacientes.SelectedItems[0];
            Paciente pacienteSelecionado = (Paciente)itemSelecionado.Tag;


            using (HistoricoPessoa telaHistorico = new HistoricoPessoa(pacienteSelecionado.id))
            {
                telaHistorico.ShowDialog();
            }

        }
    }
}

