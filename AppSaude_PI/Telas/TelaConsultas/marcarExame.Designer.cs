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
            listaConsultas = new ListView();
            cHIdConsulta = new ColumnHeader();
            cHNomePaciente = new ColumnHeader();
            cHMedico = new ColumnHeader();
            cHValor = new ColumnHeader();
            cHDataConsulta = new ColumnHeader();
            cHPagamentoEmDia = new ColumnHeader();
            groupBox3 = new GroupBox();
            BtVoltar = new Button();
            tbCPF = new TextBox();
            btCPF = new Button();
            tbCRM = new TextBox();
            btCRM = new Button();
            BTdataConsulta = new DateTimePicker();
            label1 = new Label();
            BtmarcarConsulta = new Button();
            txtValor = new Label();
            tbValor = new TextBox();
            tbDescricao = new TextBox();
            txtDescricao = new Label();
            cbValorPago = new CheckBox();
            chDescricao = new ColumnHeader();
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
            listMedicos.Size = new Size(197, 291);
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
            groupBox2.Size = new Size(212, 323);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medicos";
            // 
            // listaConsultas
            // 
            listaConsultas.Columns.AddRange(new ColumnHeader[] { cHIdConsulta, cHNomePaciente, cHMedico, cHValor, cHDataConsulta, cHPagamentoEmDia, chDescricao });
            listaConsultas.Font = new Font("Segoe UI", 8F);
            listaConsultas.Location = new Point(19, 28);
            listaConsultas.Name = "listaConsultas";
            listaConsultas.Size = new Size(506, 167);
            listaConsultas.TabIndex = 5;
            listaConsultas.UseCompatibleStateImageBehavior = false;
            listaConsultas.View = View.Details;
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
            groupBox3.Controls.Add(listaConsultas);
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
            // tbCPF
            // 
            tbCPF.Font = new Font("Segoe UI", 12F);
            tbCPF.Location = new Point(671, 22);
            tbCPF.Name = "tbCPF";
            tbCPF.PlaceholderText = "CPF do paciente";
            tbCPF.Size = new Size(122, 29);
            tbCPF.TabIndex = 8;
            tbCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // btCPF
            // 
            btCPF.Location = new Point(575, 22);
            btCPF.Name = "btCPF";
            btCPF.Size = new Size(92, 30);
            btCPF.TabIndex = 9;
            btCPF.Text = "Inserir CPF";
            btCPF.UseVisualStyleBackColor = true;
            btCPF.Click += btCPF_Click;
            // 
            // tbCRM
            // 
            tbCRM.Font = new Font("Segoe UI", 12F);
            tbCRM.Location = new Point(671, 57);
            tbCRM.Name = "tbCRM";
            tbCRM.PlaceholderText = "CRM do medico";
            tbCRM.Size = new Size(122, 29);
            tbCRM.TabIndex = 8;
            tbCRM.TextAlign = HorizontalAlignment.Center;
            // 
            // btCRM
            // 
            btCRM.Location = new Point(576, 57);
            btCRM.Name = "btCRM";
            btCRM.Size = new Size(91, 30);
            btCRM.TabIndex = 9;
            btCRM.Text = "Inserir CRM";
            btCRM.UseVisualStyleBackColor = true;
            btCRM.Click += btCRM_Click;
            // 
            // BTdataConsulta
            // 
            BTdataConsulta.Location = new Point(577, 125);
            BTdataConsulta.Name = "BTdataConsulta";
            BTdataConsulta.Size = new Size(216, 23);
            BTdataConsulta.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(637, 101);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 11;
            label1.Text = "Data e hora";
            // 
            // BtmarcarConsulta
            // 
            BtmarcarConsulta.Font = new Font("Segoe UI", 16F);
            BtmarcarConsulta.Location = new Point(570, 386);
            BtmarcarConsulta.Name = "BtmarcarConsulta";
            BtmarcarConsulta.Size = new Size(218, 78);
            BtmarcarConsulta.TabIndex = 7;
            BtmarcarConsulta.Text = "Marcar Consulta";
            BtmarcarConsulta.UseVisualStyleBackColor = true;
            BtmarcarConsulta.Click += BtmarcarConsulta_Click;
            // 
            // txtValor
            // 
            txtValor.AutoSize = true;
            txtValor.Font = new Font("Segoe UI", 16F);
            txtValor.Location = new Point(652, 152);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(62, 30);
            txtValor.TabIndex = 12;
            txtValor.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(576, 185);
            tbValor.Name = "tbValor";
            tbValor.PlaceholderText = "R$00,00";
            tbValor.Size = new Size(214, 23);
            tbValor.TabIndex = 13;
            tbValor.TextAlign = HorizontalAlignment.Center;
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(578, 308);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(213, 23);
            tbDescricao.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.AutoSize = true;
            txtDescricao.Font = new Font("Segoe UI", 16F);
            txtDescricao.Location = new Point(631, 275);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(106, 30);
            txtDescricao.TabIndex = 12;
            txtDescricao.Text = "Descrição";
            // 
            // cbValorPago
            // 
            cbValorPago.AutoSize = true;
            cbValorPago.Font = new Font("Segoe UI", 12F);
            cbValorPago.Location = new Point(598, 214);
            cbValorPago.Name = "cbValorPago";
            cbValorPago.Size = new Size(172, 25);
            cbValorPago.TabIndex = 15;
            cbValorPago.Text = "Pagamento efetuado";
            cbValorPago.UseVisualStyleBackColor = true;
            // 
            // chDescricao
            // 
            chDescricao.Text = "Descricao";
            chDescricao.TextAlign = HorizontalAlignment.Center;
            // 
            // marcarExame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 596);
            Controls.Add(cbValorPago);
            Controls.Add(tbDescricao);
            Controls.Add(tbValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(BTdataConsulta);
            Controls.Add(btCRM);
            Controls.Add(tbCRM);
            Controls.Add(btCPF);
            Controls.Add(tbCPF);
            Controls.Add(BtmarcarConsulta);
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
        private ListView listaConsultas;
        private ColumnHeader cHIdConsulta;
        private ColumnHeader cHNomePaciente;
        private ColumnHeader cHMedico;
        private ColumnHeader cHValor;
        private ColumnHeader cHDataConsulta;
        private ColumnHeader cHPagamentoEmDia;
        private GroupBox groupBox3;
        private Button BtVoltar;
        private TextBox tbCPF;
        private Button btCPF;
        private ColumnHeader chCRM;
        private TextBox tbCRM;
        private Button btCRM;
        private DateTimePicker BTdataConsulta;
        private Label label1;
        private Button BtmarcarConsulta;
        private Label txtValor;
        private TextBox tbValor;
        private TextBox tbDescricao;
        private Label txtDescricao;
        private CheckBox cbValorPago;
        private ColumnHeader chDescricao;
    }
}