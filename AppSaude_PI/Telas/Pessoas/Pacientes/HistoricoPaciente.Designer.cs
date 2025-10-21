namespace AppSaude_PI.Telas.Pessoas.Pacientes
{
    partial class HistoricoPaciente
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
            listView1 = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderPaciente = new ColumnHeader();
            columnHeaderMedico = new ColumnHeader();
            columnHeaderDescricao = new ColumnHeader();
            Valor = new ColumnHeader();
            columnHeaderPago = new ColumnHeader();
            BtVoltar = new Button();
            BtAlterarConsulta = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderPaciente, columnHeaderMedico, columnHeaderDescricao, Valor, columnHeaderPago });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(693, 329);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderID
            // 
            columnHeaderID.Text = "Id";
            // 
            // columnHeaderPaciente
            // 
            columnHeaderPaciente.Text = "Paciente";
            columnHeaderPaciente.TextAlign = HorizontalAlignment.Center;
            columnHeaderPaciente.Width = 120;
            // 
            // columnHeaderMedico
            // 
            columnHeaderMedico.Text = "Medico";
            columnHeaderMedico.TextAlign = HorizontalAlignment.Center;
            columnHeaderMedico.Width = 120;
            // 
            // columnHeaderDescricao
            // 
            columnHeaderDescricao.Text = "Descricao";
            columnHeaderDescricao.TextAlign = HorizontalAlignment.Center;
            columnHeaderDescricao.Width = 240;
            // 
            // Valor
            // 
            Valor.Text = "Valor";
            Valor.TextAlign = HorizontalAlignment.Center;
            Valor.Width = 70;
            // 
            // columnHeaderPago
            // 
            columnHeaderPago.Text = "Pagamento";
            columnHeaderPago.TextAlign = HorizontalAlignment.Center;
            columnHeaderPago.Width = 80;
            // 
            // BtVoltar
            // 
            BtVoltar.Location = new Point(12, 347);
            BtVoltar.Name = "BtVoltar";
            BtVoltar.Size = new Size(114, 43);
            BtVoltar.TabIndex = 1;
            BtVoltar.Text = "Voltar";
            BtVoltar.UseVisualStyleBackColor = true;
            BtVoltar.Click += BtVoltar_Click;
            // 
            // BtAlterarConsulta
            // 
            BtAlterarConsulta.Location = new Point(132, 347);
            BtAlterarConsulta.Name = "BtAlterarConsulta";
            BtAlterarConsulta.Size = new Size(114, 43);
            BtAlterarConsulta.TabIndex = 1;
            BtAlterarConsulta.Text = "Alterar";
            BtAlterarConsulta.UseVisualStyleBackColor = true;
            BtAlterarConsulta.Click += BtVoltar_Click;
            // 
            // HistoricoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 398);
            Controls.Add(BtAlterarConsulta);
            Controls.Add(BtVoltar);
            Controls.Add(listView1);
            Name = "HistoricoPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historico Paciente";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderPaciente;
        private ColumnHeader columnHeaderMedico;
        private ColumnHeader columnHeaderDescricao;
        private ColumnHeader Valor;
        private ColumnHeader columnHeaderPago;
        private Button BtVoltar;
        private Button BtAlterarConsulta;
    }
}