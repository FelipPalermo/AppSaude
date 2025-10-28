namespace AppSaude_PI.Telas.TelaConsultas
{
    partial class HistoricoExames
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
            listaConsultas = new ListView();
            chIdConsulta = new ColumnHeader();
            chPaciente = new ColumnHeader();
            chMedico = new ColumnHeader();
            chValor = new ColumnHeader();
            chStatusPagamento = new ColumnHeader();
            chData = new ColumnHeader();
            chStatus = new ColumnHeader();
            btVoltar = new Button();
            cbApenasAtivos = new CheckBox();
            SuspendLayout();
            // 
            // listaConsultas
            // 
            listaConsultas.Columns.AddRange(new ColumnHeader[] { chIdConsulta, chPaciente, chMedico, chValor, chStatusPagamento, chData, chStatus });
            listaConsultas.Location = new Point(12, 12);
            listaConsultas.Name = "listaConsultas";
            listaConsultas.Size = new Size(604, 572);
            listaConsultas.TabIndex = 0;
            listaConsultas.UseCompatibleStateImageBehavior = false;
            listaConsultas.View = View.Details;
            // 
            // chIdConsulta
            // 
            chIdConsulta.Text = "Id consulta";
            chIdConsulta.Width = 100;
            // 
            // chPaciente
            // 
            chPaciente.Text = "Paciente";
            chPaciente.TextAlign = HorizontalAlignment.Center;
            chPaciente.Width = 100;
            // 
            // chMedico
            // 
            chMedico.Text = "Medico";
            chMedico.TextAlign = HorizontalAlignment.Center;
            chMedico.Width = 100;
            // 
            // chValor
            // 
            chValor.Text = "Valor";
            chValor.Width = 80;
            // 
            // chStatusPagamento
            // 
            chStatusPagamento.Text = "Status de pagamento";
            chStatusPagamento.TextAlign = HorizontalAlignment.Center;
            chStatusPagamento.Width = 160;
            // 
            // chData
            // 
            chData.Text = "Data";
            chData.TextAlign = HorizontalAlignment.Center;
            chData.Width = 140;
            // 
            // chStatus
            // 
            chStatus.Text = "Status";
            chStatus.TextAlign = HorizontalAlignment.Center;
            chStatus.Width = 80;
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Segoe UI", 16F);
            btVoltar.Location = new Point(624, 12);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(164, 91);
            btVoltar.TabIndex = 1;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // cbApenasAtivos
            // 
            cbApenasAtivos.AutoSize = true;
            cbApenasAtivos.Font = new Font("Segoe UI", 9F);
            cbApenasAtivos.Location = new Point(632, 109);
            cbApenasAtivos.Name = "cbApenasAtivos";
            cbApenasAtivos.Size = new Size(151, 19);
            cbApenasAtivos.TabIndex = 2;
            cbApenasAtivos.Text = "Apenas consultas ativas";
            cbApenasAtivos.UseVisualStyleBackColor = true;
            cbApenasAtivos.CheckedChanged += cbApenasAtivos_CheckedChanged;
            // 
            // HistoricoExames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(cbApenasAtivos);
            Controls.Add(btVoltar);
            Controls.Add(listaConsultas);
            Name = "HistoricoExames";
            Text = "HistoricoExames";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listaConsultas;
        private ColumnHeader chIdConsulta;
        private ColumnHeader chPaciente;
        private ColumnHeader chMedico;
        private ColumnHeader chStatusPagamento;
        private ColumnHeader chData;
        private Button btVoltar;
        private ColumnHeader chStatus;
        private ColumnHeader chValor;
        private CheckBox cbApenasAtivos;
    }
}