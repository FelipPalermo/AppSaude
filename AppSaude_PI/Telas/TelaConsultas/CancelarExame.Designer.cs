namespace AppSaude_PI.Telas.TelaConsultas
{
    partial class CancelarExame
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
            btVoltar = new Button();
            listaConsultas = new ListView();
            chIdConsulta = new ColumnHeader();
            chPaciente = new ColumnHeader();
            chMedico = new ColumnHeader();
            chStatusPagamento = new ColumnHeader();
            chData = new ColumnHeader();
            btExcluir = new Button();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Font = new Font("Segoe UI", 16F);
            btVoltar.Location = new Point(626, 118);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(164, 91);
            btVoltar.TabIndex = 3;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // listaConsultas
            // 
            listaConsultas.Columns.AddRange(new ColumnHeader[] { chIdConsulta, chPaciente, chMedico, chStatusPagamento, chData });
            listaConsultas.Location = new Point(12, 12);
            listaConsultas.Name = "listaConsultas";
            listaConsultas.Size = new Size(604, 572);
            listaConsultas.TabIndex = 2;
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
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 12F);
            btExcluir.Location = new Point(626, 12);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(164, 91);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Cancelar consulta";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // CancelarExame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(btExcluir);
            Controls.Add(btVoltar);
            Controls.Add(listaConsultas);
            Name = "CancelarExame";
            Text = "CancelarExame";
            ResumeLayout(false);
        }

        #endregion

        private Button btVoltar;
        private ListView listaConsultas;
        private ColumnHeader chIdConsulta;
        private ColumnHeader chPaciente;
        private ColumnHeader chMedico;
        private ColumnHeader chStatusPagamento;
        private ColumnHeader chData;
        private Button btExcluir;
    }
}