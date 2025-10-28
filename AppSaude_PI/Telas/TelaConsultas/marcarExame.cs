using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using AppSaude_PI.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
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

                    if (!p.pagamentosEmDia)
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

        public marcarExame()
        {
            InitializeComponent();
            this.loadMedicos();
            this.loadPacientes();
            this.loadConsultas();
            BTdataConsulta.Format = DateTimePickerFormat.Custom;
            BTdataConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
            BTdataConsulta.ShowUpDown = true;

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCRM_Click(object sender, EventArgs e)
        {
            try
            {
            ListViewItem itemSelecionado = listMedicos.SelectedItems[0];
            Medico medicoSelecionado = (Medico)itemSelecionado.Tag;
            tbCRM.Text = medicoSelecionado.CRM;
            }catch (Exception ex)
            {
                MessageBox.Show("Por favor, selecione um medico");
            }
        }

        private void btCPF_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itemSelecionado = listPacientes.SelectedItems[0];
                Paciente medicoSelecionado = (Paciente)itemSelecionado.Tag;
                tbCPF.Text = medicoSelecionado.CPF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, selecione um paciente");
            }
        }
        
        private DateTime? verificaData(Medico medicoSelecionado)
        {
            DateTime dataConsulta = BTdataConsulta.Value;
            if (dataConsulta < DateTime.Now)
            {
                MessageBox.Show("Você não pode marcar consultas no passado!");
                return null;
            }

            string[] horariosMedico = medicoSelecionado.horarioTrabalho.Split('-');
            TimeSpan horarioInicio = TimeSpan.ParseExact(horariosMedico[0], "hh\\:mm", CultureInfo.InvariantCulture);            
            TimeSpan horarioFim = TimeSpan.ParseExact(horariosMedico[1], "hh\\:mm", CultureInfo.InvariantCulture);
            TimeSpan horaConsulta = dataConsulta.TimeOfDay;
            
            if (horaConsulta < horarioInicio || horaConsulta > horarioFim)
            {
                MessageBox.Show($"O medico {medicoSelecionado.Nome} não trabalha nesse horario!");
                return null; 
            }
            return dataConsulta;
        }

        private void BtmarcarConsulta_Click(object sender, EventArgs e)
        {

            #region Regex CPF / CRM
            if (!Regex.IsMatch(tbCPF.Text, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                MessageBox.Show("CPF incorreto");
                btCPF.Focus();
                return;
            }

            if (!Regex.IsMatch(tbCRM.Text, @"^\d{6}$"))
            {
                MessageBox.Show("CRM incorreto");
                btCRM.Focus();
                return;
            }
            #endregion

            #region Query SQL
            
            string queryMedico = $"select id_medico, nome, CRM, horarioTrabalho from medicos where crm = '{tbCRM.Text}';";
            string queryPaciente = $"select id_paciente, nome, cpf from pacientes where cpf = '{tbCPF.Text}';";

            Paciente pacienteSelecionado = SQLConn.SqlGetOne(queryPaciente, reader => new Paciente
            {
                id = reader.GetInt32("id_paciente"),
                Nome = reader.GetString("nome"),
                CPF = reader.GetString("CPF")
            });
            
            Medico medicoSelecionado = SQLConn.SqlGetOne(queryMedico, reader => new Medico
            {
                id = reader.GetInt32("id_medico"),
                Nome = reader.GetString("nome"),
                CRM = reader.GetString("crm"),
                horarioTrabalho = reader.GetString("horarioTrabalho")
            });

            if (medicoSelecionado == null)
            {
                MessageBox.Show("Medico nao encontrado!");
                return;
            }
            if (pacienteSelecionado == null)
            {
                MessageBox.Show("Paciente não encontrado!");
                return;
            }
            #endregion

            char[] trimReais = { 'R', '$', ' ' };
            if (!double.TryParse(tbValor.Text.Trim(trimReais).Replace(',', '.'), out double valor))
            {
                MessageBox.Show("Insira um valor correto!");
                return;
            }

            DateTime? dataConsulta = verificaData(medicoSelecionado); 
            if (dataConsulta == null)
            {
                return;
            }

            #region Insercao de dados
            string inserirExameQuery = @"INSERT INTO  consultas
                 (id_paciente, id_medico, data_consulta, descricao, valor, pagamento, nomePaciente, nomeMedico)
                 VALUES (@id_paciente, @id_medico, @data_consulta, @descricao, @valor, @pagamento, @nomePaciente, @nomeMedico)";

            SQLConn.SqlInsert(inserirExameQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_paciente", pacienteSelecionado.id);
                cmd.Parameters.AddWithValue("@id_medico", medicoSelecionado.id);
                cmd.Parameters.AddWithValue("@data_consulta", dataConsulta);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@nomePaciente", pacienteSelecionado.Nome);
                cmd.Parameters.AddWithValue("@nomeMedico", medicoSelecionado.Nome);
                cmd.Parameters.AddWithValue("@pagamento", cbValorPago.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@descricao", tbDescricao.Text);
            }, $"Exame marcado!");

            listaConsultas.Items.Clear();
            loadConsultas();
        }
        #endregion
    }
}
