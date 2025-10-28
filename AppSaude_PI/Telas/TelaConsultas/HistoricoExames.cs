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

namespace AppSaude_PI.Telas.TelaConsultas
{
    public partial class HistoricoExames : Form
    {
        internal void loadConsultas()
        {
            List<Consultas> lconsultas = retConsultas.listConsultas();

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
        internal void loadConsultasAtivas()
        {
            List<Consultas> lconsultas = retConsultas.listConsultasAtivas();

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
        public HistoricoExames()
        {
            InitializeComponent();
            loadConsultas();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbApenasAtivos_CheckedChanged(object sender, EventArgs e)
        {
            
            listaConsultas.Items.Clear();

            if (cbApenasAtivos.Checked)
            {
                loadConsultasAtivas();
            }else
            {
                loadConsultas();
            }
        }
    }
}
