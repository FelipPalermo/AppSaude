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


namespace AppSaude_PI.Telas.Pessoas
{
    public partial class ListarMedicos : Form
    {

        public ListarMedicos()
        {
            InitializeComponent();
            listViewMedicos.FullRowSelect = true;
            listViewMedicos.GridLines = true;
            listViewMedicos.View = View.Details;
        }

        #region Listar medicos
        public void ListarMedicos_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM medicos";

            List<Medico> medicos = SQLConn.SqlGetList(query, reader => new Medico
            {
                id = reader.GetInt32("id_medico"),
                Nome = reader.GetString("nome"),
                CPF = reader.GetString("cpf"),
                CRM = reader.GetString("CRM"),
                Sexo = reader.GetString("sexo"),
                Telefone = reader.GetString("Telefone"),
                DataNasciscmento = reader.GetDateTime("dataNascimento"),
                horarioTrabalho = reader.GetString("horarioTrabalho"),
                dataCadastro = reader.GetDateTime("data_cadastro")
            });

            listViewMedicos.Items.Clear();


            foreach (var m in medicos)
            {
                try
                {

                    ListViewItem item = new ListViewItem(m.Nome);
                    item.SubItems.Add(m.Telefone);
                    item.SubItems.Add(m.CRM);
                    item.SubItems.Add(m.CPF);
                    item.SubItems.Add(m.Sexo);
                    item.SubItems.Add(m.horarioTrabalho);
                    item.SubItems.Add(m.dataCadastro.ToString());

                    item.Tag = m;
                    listViewMedicos.Items.Add(item);

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
            if (listViewMedicos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um Medico primeiro");
                return;
            }
            else if (listViewMedicos.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um por vez!");
                return;
            }


            ListViewItem itemSelecionado = listViewMedicos.SelectedItems[0];
            Medico medicoSelecionado = (Medico)itemSelecionado.Tag;


            using (AltMedico telaAltCadastro = new AltMedico(medicoSelecionado))
            {
                telaAltCadastro.ShowDialog();
            }
        }
        #endregion

        private void BtAtualziar_Click(object sender, EventArgs e)
        {
            this.ListarMedicos_Load_1(sender, e);
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewMedicos.SelectedItems)
            {
                Medico medicoSelecionado = (Medico)item.Tag;

                SQLConn.delSql("DELETE FROM medicos WHERE id_medico = @id",
                cmd => cmd.Parameters.AddWithValue("@id", medicoSelecionado.id));
            }
            this.ListarMedicos_Load_1(sender, e);

        }
    }
}

