using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSaude_PI.Objetos;

namespace AppSaude_PI.Telas.Pacientes
{
    public partial class HistoricoPessoa : Form
    {

        public int id_pessoa;
        public HistoricoPessoa(int id_pessoa)
        {
            InitializeComponent();
            this.id_pessoa = id_pessoa;
            loadConsultas();

        }

        internal void loadConsultas()
        {
            List<Consultas> lconsultas = retConsultas.listConsultasPessoa(id_pessoa);

            foreach (var c in lconsultas)
            {
                try
                {
                    ListViewItem item = new ListViewItem(c.id.ToString());
                    item.SubItems.Add(c.pacienteNome);
                    item.SubItems.Add(c.medicoNome);
                    item.SubItems.Add(c.valor.ToString());

                    if (c.pagamento)
                    {
                        item.SubItems.Add("Pago");
                    }
                    else
                    {
                        item.SubItems.Add("Em Aberto");
                    }

                    item.SubItems.Add(c.dataConsulta.ToString());

                    if (c.ativa)
                    {
                        item.SubItems.Add("Ativo");
                    }
                    else
                    {
                        item.SubItems.Add("Cancelado");
                    }

                    item.Tag = c;
                    listaConsultas.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
