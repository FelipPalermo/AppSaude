namespace AppSaude_PI.Telas.Pessoas
{
    partial class ListarPacientes
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
            listViewPacientes = new ListView();
            columnNome = new ColumnHeader();
            columnHeaderCelular = new ColumnHeader();
            columnHeaderRG = new ColumnHeader();
            columnHeaderCPF = new ColumnHeader();
            columnHeaderSexo = new ColumnHeader();
            columnHeaderPagamentos = new ColumnHeader();
            columnHeaderDocumentos = new ColumnHeader();
            columnHeaderDataRegistro = new ColumnHeader();
            BtAlterar = new Button();
            BtVoltar = new Button();
            BtExcluir = new Button();
            BtHistorico = new Button();
            SuspendLayout();
            // 
            // listViewPacientes
            // 
            listViewPacientes.BackColor = SystemColors.Window;
            listViewPacientes.BorderStyle = BorderStyle.FixedSingle;
            listViewPacientes.CausesValidation = false;
            listViewPacientes.Columns.AddRange(new ColumnHeader[] { columnNome, columnHeaderCelular, columnHeaderRG, columnHeaderCPF, columnHeaderSexo, columnHeaderPagamentos, columnHeaderDocumentos, columnHeaderDataRegistro });
            listViewPacientes.Location = new Point(12, 12);
            listViewPacientes.Name = "listViewPacientes";
            listViewPacientes.Size = new Size(616, 572);
            listViewPacientes.TabIndex = 1;
            listViewPacientes.UseCompatibleStateImageBehavior = false;
            listViewPacientes.View = View.Details;
            // 
            // columnNome
            // 
            columnNome.Text = "Nome";
            columnNome.Width = 90;
            // 
            // columnHeaderCelular
            // 
            columnHeaderCelular.Text = "Celular";
            columnHeaderCelular.TextAlign = HorizontalAlignment.Center;
            columnHeaderCelular.Width = 110;
            // 
            // columnHeaderRG
            // 
            columnHeaderRG.Text = "RG";
            columnHeaderRG.TextAlign = HorizontalAlignment.Center;
            columnHeaderRG.Width = 95;
            // 
            // columnHeaderCPF
            // 
            columnHeaderCPF.Text = "CPF";
            columnHeaderCPF.TextAlign = HorizontalAlignment.Center;
            columnHeaderCPF.Width = 95;
            // 
            // columnHeaderSexo
            // 
            columnHeaderSexo.Text = "Sexo";
            columnHeaderSexo.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeaderPagamentos
            // 
            columnHeaderPagamentos.Tag = "";
            columnHeaderPagamentos.Text = " Pagamentos";
            columnHeaderPagamentos.TextAlign = HorizontalAlignment.Center;
            columnHeaderPagamentos.Width = 90;
            // 
            // columnHeaderDocumentos
            // 
            columnHeaderDocumentos.Tag = "";
            columnHeaderDocumentos.Text = "Documentos";
            columnHeaderDocumentos.TextAlign = HorizontalAlignment.Center;
            columnHeaderDocumentos.Width = 90;
            // 
            // columnHeaderDataRegistro
            // 
            columnHeaderDataRegistro.Text = "Data de registro";
            columnHeaderDataRegistro.Width = 95;
            // 
            // BtAlterar
            // 
            BtAlterar.Location = new Point(638, 12);
            BtAlterar.Name = "BtAlterar";
            BtAlterar.Size = new Size(150, 42);
            BtAlterar.TabIndex = 2;
            BtAlterar.Text = "Alterar";
            BtAlterar.UseVisualStyleBackColor = true;
            BtAlterar.Click += BtAlterar_Click;
            // 
            // BtVoltar
            // 
            BtVoltar.Location = new Point(638, 156);
            BtVoltar.Name = "BtVoltar";
            BtVoltar.Size = new Size(150, 42);
            BtVoltar.TabIndex = 2;
            BtVoltar.Text = "Voltar";
            BtVoltar.UseVisualStyleBackColor = true;
            BtVoltar.Click += BtVoltar_Click;
            // 
            // BtExcluir
            // 
            BtExcluir.Location = new Point(638, 108);
            BtExcluir.Name = "BtExcluir";
            BtExcluir.Size = new Size(150, 42);
            BtExcluir.TabIndex = 2;
            BtExcluir.Text = "Excluir";
            BtExcluir.UseVisualStyleBackColor = true;
            BtExcluir.Click += BtExcluir_Click;
            // 
            // BtHistorico
            // 
            BtHistorico.Location = new Point(638, 60);
            BtHistorico.Name = "BtHistorico";
            BtHistorico.Size = new Size(150, 42);
            BtHistorico.TabIndex = 2;
            BtHistorico.Text = "Historico";
            BtHistorico.UseVisualStyleBackColor = true;
            // 
            // ListarPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(BtVoltar);
            Controls.Add(BtHistorico);
            Controls.Add(BtExcluir);
            Controls.Add(BtAlterar);
            Controls.Add(listViewPacientes);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ListarPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarPacientes";
            Load += ListarPacientes_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewPacientes;
        private ColumnHeader columnNome;
        private ColumnHeader columnHeaderSexo;
        private ColumnHeader columnHeaderCPF;
        private ColumnHeader columnHeaderPagamentos;
        private ColumnHeader columnHeaderDocumentos;
        private ColumnHeader columnHeaderDataRegistro;
        private ColumnHeader columnHeaderRG;
        private Button BtAlterar;
        private Button BtVoltar;
        private ColumnHeader columnHeaderCelular;
        private Button BtExcluir;
        private Button BtHistorico;
    }
}