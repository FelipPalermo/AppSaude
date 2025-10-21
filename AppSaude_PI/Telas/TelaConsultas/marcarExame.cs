using AppSaude_PI.Objetos;
using AppSaude_PI.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSaude_PI.Telas
{
    public partial class marcarExame : Form
    {

        internal void loadMedicos()
        {
            List<Medico> medicos = retConsultas.medicosConsultas();

            foreach (var m in medicos)
            {
                try
                {
                    ListViewItem item = new ListViewItem(m.Nome);
                    item.SubItems.Add(m.CRM);
                    item.SubItems.Add(m.horarioTrabalho);

                    item.Tag = m;
                    listMedicos.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal void loadPacientes()
        {
            List<Paciente> pacientes = retConsultas.pacienteConsultas();

            foreach (var p in pacientes)
            {
                try
                {
                    ListViewItem item = new ListViewItem(p.Nome);
                    item.SubItems.Add(p.CPF);

                    if (!p.pagamentosEmDia == true)
                    {
                        item.SubItems.Add("Atrasado");
                    }
                    else
                    {
                        item.SubItems.Add("Em dia");
                    }

                    item.Tag = p;
                    listPacientes.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

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
                    item.SubItems.Add(c.dataConsulta.ToString());
                    item.SubItems.Add(c.valor.ToString());
                    if (c.pagamento)
                    {
                        item.SubItems.Add("Pago");
                    }
                    else
                    {
                        item.SubItems.Add("Em Aberto");
                    }

                    item.Tag = c;
                    listPacientes.Items.Add(item);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public marcarExame()
        {
            InitializeComponent();
            this.loadMedicos();
            this.loadPacientes();
            this.loadConsultas();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
