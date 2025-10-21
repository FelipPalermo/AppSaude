namespace AppSaude_PI.Telas.Pessoas
{
    partial class ListarMedicos
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
            listViewMedicos = new ListView();
            columnNome = new ColumnHeader();
            columnHeaderCelular = new ColumnHeader();
            columnHeaderCRM = new ColumnHeader();
            columnHeaderCPF = new ColumnHeader();
            columnHeaderSexo = new ColumnHeader();
            columnHeaderHorarioTrabalho = new ColumnHeader();
            columnHeaderDataRegistro = new ColumnHeader();
            BtAlterar = new Button();
            BtVoltar = new Button();
            BtExcluir = new Button();
            SuspendLayout();
            // 
            // listViewMedicos
            // 
            listViewMedicos.BackColor = SystemColors.Window;
            listViewMedicos.BorderStyle = BorderStyle.FixedSingle;
            listViewMedicos.CausesValidation = false;
            listViewMedicos.Columns.AddRange(new ColumnHeader[] { columnNome, columnHeaderCelular, columnHeaderCRM, columnHeaderCPF, columnHeaderSexo, columnHeaderHorarioTrabalho, columnHeaderDataRegistro });
            listViewMedicos.Location = new Point(12, 12);
            listViewMedicos.Name = "listViewMedicos";
            listViewMedicos.Size = new Size(616, 572);
            listViewMedicos.TabIndex = 1;
            listViewMedicos.UseCompatibleStateImageBehavior = false;
            listViewMedicos.View = View.Details;
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
            // columnHeaderCRM
            // 
            columnHeaderCRM.Text = "CRM";
            columnHeaderCRM.TextAlign = HorizontalAlignment.Center;
            columnHeaderCRM.Width = 95;
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
            // columnHeaderHorarioTrabalho
            // 
            columnHeaderHorarioTrabalho.Text = "Horario de trabalho";
            columnHeaderHorarioTrabalho.TextAlign = HorizontalAlignment.Center;
            columnHeaderHorarioTrabalho.Width = 120;
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
            BtVoltar.Location = new Point(638, 108);
            BtVoltar.Name = "BtVoltar";
            BtVoltar.Size = new Size(150, 42);
            BtVoltar.TabIndex = 2;
            BtVoltar.Text = "Voltar";
            BtVoltar.UseVisualStyleBackColor = true;
            BtVoltar.Click += BtVoltar_Click;
            // 
            // BtExcluir
            // 
            BtExcluir.Location = new Point(638, 60);
            BtExcluir.Name = "BtExcluir";
            BtExcluir.Size = new Size(150, 42);
            BtExcluir.TabIndex = 2;
            BtExcluir.Text = "Excluir";
            BtExcluir.UseVisualStyleBackColor = true;
            BtExcluir.Click += BtExcluir_Click;
            // 
            // ListarMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(BtVoltar);
            Controls.Add(BtExcluir);
            Controls.Add(BtAlterar);
            Controls.Add(listViewMedicos);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ListarMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarPacientes";
            Load += ListarMedicos_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewMedicos;
        private ColumnHeader columnNome;
        private ColumnHeader columnHeaderSexo;
        private ColumnHeader columnHeaderCPF;
        private ColumnHeader columnHeaderDataRegistro;
        private ColumnHeader columnHeaderCRM;
        private Button BtAlterar;
        private Button BtVoltar;
        private ColumnHeader columnHeaderCelular;
        private Button BtExcluir;
        private ColumnHeader columnHeaderHorarioTrabalho;
    }
}