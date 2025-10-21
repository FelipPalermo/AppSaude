namespace AppSaude_PI.Telas
{
    partial class marcarExame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listMedicos = new ListView();
            columnHeader1 = new ColumnHeader();
            chCRM = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listPacientes = new ListView();
            chPaciente = new ColumnHeader();
            chCPFPaciente = new ColumnHeader();
            chPagamento = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            cHIdConsulta = new ColumnHeader();
            cHNomePaciente = new ColumnHeader();
            cHMedico = new ColumnHeader();
            cHValor = new ColumnHeader();
            cHDataConsulta = new ColumnHeader();
            cHPagamentoEmDia = new ColumnHeader();
            groupBox3 = new GroupBox();
            BtVoltar = new Button();
            textBox1 = new TextBox();
            btCPF = new Button();
            textBox2 = new TextBox();
            btCRM = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listMedicos
            // 
            listMedicos.Columns.AddRange(new ColumnHeader[] { columnHeader1, chCRM, columnHeader2 });
            listMedicos.Font = new Font("Segoe UI", 7F);
            listMedicos.Location = new Point(6, 22);
            listMedicos.Name = "listMedicos";
            listMedicos.Size = new Size(194, 291);
            listMedicos.TabIndex = 1;
            listMedicos.UseCompatibleStateImageBehavior = false;
            listMedicos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Medico";
            // 
            // chCRM
            // 
            chCRM.Text = "CRM";
            chCRM.TextAlign = HorizontalAlignment.Center;
            chCRM.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Horario de trabalho";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // listPacientes
            // 
            listPacientes.Columns.AddRange(new ColumnHeader[] { chPaciente, chCPFPaciente, chPagamento });
            listPacientes.Font = new Font("Segoe UI", 9F);
            listPacientes.Location = new Point(6, 22);
            listPacientes.Name = "listPacientes";
            listPacientes.Size = new Size(324, 291);
            listPacientes.TabIndex = 2;
            listPacientes.UseCompatibleStateImageBehavior = false;
            listPacientes.View = View.Details;
            // 
            // chPaciente
            // 
            chPaciente.Text = "Paciente";
            chPaciente.Width = 80;
            // 
            // chCPFPaciente
            // 
            chCPFPaciente.Text = "CPF";
            chCPFPaciente.TextAlign = HorizontalAlignment.Center;
            chCPFPaciente.Width = 120;
            // 
            // chPagamento
            // 
            chPagamento.Text = "Pagamento";
            chPagamento.TextAlign = HorizontalAlignment.Center;
            chPagamento.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listPacientes);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 323);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pacientes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listMedicos);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(357, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 323);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medicos";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cHIdConsulta, cHNomePaciente, cHMedico, cHValor, cHDataConsulta, cHPagamentoEmDia });
            listView1.Font = new Font("Segoe UI", 8F);
            listView1.Location = new Point(19, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(506, 167);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // cHIdConsulta
            // 
            cHIdConsulta.Text = "Id Consulta";
            cHIdConsulta.Width = 80;
            // 
            // cHNomePaciente
            // 
            cHNomePaciente.Text = "Paciente";
            cHNomePaciente.TextAlign = HorizontalAlignment.Center;
            cHNomePaciente.Width = 70;
            // 
            // cHMedico
            // 
            cHMedico.Text = "Medico";
            cHMedico.TextAlign = HorizontalAlignment.Center;
            cHMedico.Width = 70;
            // 
            // cHValor
            // 
            cHValor.DisplayIndex = 4;
            cHValor.Text = "Valor";
            cHValor.TextAlign = HorizontalAlignment.Center;
            cHValor.Width = 70;
            // 
            // cHDataConsulta
            // 
            cHDataConsulta.DisplayIndex = 3;
            cHDataConsulta.Text = "Data";
            cHDataConsulta.TextAlign = HorizontalAlignment.Center;
            cHDataConsulta.Width = 90;
            // 
            // cHPagamentoEmDia
            // 
            cHPagamentoEmDia.Text = "Status Pagamento";
            cHPagamentoEmDia.TextAlign = HorizontalAlignment.Center;
            cHPagamentoEmDia.Width = 120;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView1);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(18, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(539, 211);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consultas marcadas";
            // 
            // BtVoltar
            // 
            BtVoltar.Font = new Font("Segoe UI", 16F);
            BtVoltar.Location = new Point(570, 475);
            BtVoltar.Name = "BtVoltar";
            BtVoltar.Size = new Size(218, 78);
            BtVoltar.TabIndex = 7;
            BtVoltar.Text = "Voltar";
            BtVoltar.UseVisualStyleBackColor = true;
            BtVoltar.Click += BtVoltar_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(575, 74);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "CPF do paciente";
            textBox1.Size = new Size(216, 29);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btCPF
            // 
            btCPF.Location = new Point(625, 23);
            btCPF.Name = "btCPF";
            btCPF.Size = new Size(120, 45);
            btCPF.TabIndex = 9;
            btCPF.Text = "Inserir CPF";
            btCPF.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(575, 169);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "CRM do medico";
            textBox2.Size = new Size(216, 29);
            textBox2.TabIndex = 8;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btCRM
            // 
            btCRM.Location = new Point(625, 118);
            btCRM.Name = "btCRM";
            btCRM.Size = new Size(120, 45);
            btCRM.TabIndex = 9;
            btCRM.Text = "Inserir CRM";
            btCRM.UseVisualStyleBackColor = true;
            // 
            // marcarExame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(btCRM);
            Controls.Add(textBox2);
            Controls.Add(btCPF);
            Controls.Add(textBox1);
            Controls.Add(BtVoltar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "marcarExame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marcar exame";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listMedicos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listPacientes;
        private ColumnHeader chPaciente;
        private ColumnHeader chCPFPaciente;
        private ColumnHeader chPagamento;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader cHIdConsulta;
        private ColumnHeader cHNomePaciente;
        private ColumnHeader cHMedico;
        private ColumnHeader cHValor;
        private ColumnHeader cHDataConsulta;
        private ColumnHeader cHPagamentoEmDia;
        private GroupBox groupBox3;
        private Button BtVoltar;
        private TextBox textBox1;
        private Button btCPF;
        private ColumnHeader chCRM;
        private TextBox textBox2;
        private Button btCRM;
    }
}