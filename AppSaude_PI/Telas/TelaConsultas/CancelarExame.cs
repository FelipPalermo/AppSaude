using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSaude_PI.Objetos;
using System.Windows.Forms;
using AppSaude_PI.MySQL;

namespace AppSaude_PI.Telas.TelaConsultas
{
    public partial class CancelarExame : Form
    {
        internal void loadConsultas()
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
                    item.SubItems.Add(c.dataConsulta.ToString());

                    if (c.pagamento)
                    {
                        item.SubItems.Add("Pago");
                    }
                    else
                    {
                        item.SubItems.Add("Em Aberto");
                    }
                    item.SubItems.Add(c.descricao);

                    item.Tag = c;
                    listaConsultas.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public CancelarExame()
        {
            InitializeComponent();
            loadConsultas();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            DialogResult dialogBoxYesNo = MessageBox.Show("Deseja realmente cancelar o exame?", 
                "Cancelar exame", MessageBoxButtons.YesNo);

            if (dialogBoxYesNo == DialogResult.Yes)
            {
                ListViewItem consultaSelecionada = listaConsultas.SelectedItems[0];
                Consultas consultaSel = (Consultas)consultaSelecionada.Tag;

                SQLConn.delSql("UPDATE consultas SET ativa = FALSE WHERE id_consulta = @id",
                cmd => cmd.Parameters.AddWithValue("@id", consultaSel.id));

                listaConsultas.Items.Clear();
                loadConsultas();
            } else
            {
                return; 
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
