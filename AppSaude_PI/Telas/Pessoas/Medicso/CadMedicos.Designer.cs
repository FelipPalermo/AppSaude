namespace AppSaude_PI
{
    partial class CadMedicos
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
            TxtNome = new Label();
            TxtDataNascimento = new Label();
            TxtCRM = new Label();
            TxtCPF = new Label();
            TxtSexo = new Label();
            TxtTelefone = new Label();
            textBox1 = new TextBox();
            Nascimento = new DateTimePicker();
            MTTelefone = new MaskedTextBox();
            TBSexo = new ComboBox();
            MTCRM = new MaskedTextBox();
            MTCpf = new MaskedTextBox();
            TBNome = new TextBox();
            BTLimpar = new Button();
            BTVoltar = new Button();
            BTCadastrar = new Button();
            TxtHorarioTrabalho = new Label();
            TBHorarioTrabalho = new TextBox();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.AutoSize = true;
            TxtNome.Font = new Font("Segoe UI", 16F);
            TxtNome.Location = new Point(36, 29);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(73, 30);
            TxtNome.TabIndex = 0;
            TxtNome.Text = "Nome";
            // 
            // TxtDataNascimento
            // 
            TxtDataNascimento.AutoSize = true;
            TxtDataNascimento.Font = new Font("Segoe UI", 16F);
            TxtDataNascimento.Location = new Point(36, 84);
            TxtDataNascimento.Name = "TxtDataNascimento";
            TxtDataNascimento.Size = new Size(204, 30);
            TxtDataNascimento.TabIndex = 0;
            TxtDataNascimento.Text = "Data de nascimento";
            // 
            // TxtCRM
            // 
            TxtCRM.AutoSize = true;
            TxtCRM.Font = new Font("Segoe UI", 16F);
            TxtCRM.Location = new Point(36, 249);
            TxtCRM.Name = "TxtCRM";
            TxtCRM.Size = new Size(60, 30);
            TxtCRM.TabIndex = 0;
            TxtCRM.Text = "CRM";
            // 
            // TxtCPF
            // 
            TxtCPF.AutoSize = true;
            TxtCPF.Font = new Font("Segoe UI", 16F);
            TxtCPF.Location = new Point(36, 304);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(50, 30);
            TxtCPF.TabIndex = 0;
            TxtCPF.Text = "CPF";
            // 
            // TxtSexo
            // 
            TxtSexo.AutoSize = true;
            TxtSexo.Font = new Font("Segoe UI", 16F);
            TxtSexo.Location = new Point(36, 139);
            TxtSexo.Name = "TxtSexo";
            TxtSexo.Size = new Size(60, 30);
            TxtSexo.TabIndex = 0;
            TxtSexo.Text = "Sexo";
            // 
            // TxtTelefone
            // 
            TxtTelefone.AutoSize = true;
            TxtTelefone.Font = new Font("Segoe UI", 16F);
            TxtTelefone.Location = new Point(36, 194);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(96, 30);
            TxtTelefone.TabIndex = 0;
            TxtTelefone.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(178, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 36);
            textBox1.TabIndex = 1;
            // 
            // Nascimento
            // 
            Nascimento.Font = new Font("Segoe UI", 16F);
            Nascimento.Location = new Point(246, 84);
            Nascimento.Name = "Nascimento";
            Nascimento.Size = new Size(418, 36);
            Nascimento.TabIndex = 2;
            // 
            // MTTelefone
            // 
            MTTelefone.Font = new Font("Segoe UI", 16F);
            MTTelefone.Location = new Point(178, 191);
            MTTelefone.Mask = "(00) 00000-0000";
            MTTelefone.Name = "MTTelefone";
            MTTelefone.Size = new Size(486, 36);
            MTTelefone.TabIndex = 3;
            // 
            // TBSexo
            // 
            TBSexo.AutoCompleteCustomSource.AddRange(new string[] { "Homem", "Mulher", "Outro" });
            TBSexo.Font = new Font("Segoe UI", 16F);
            TBSexo.FormattingEnabled = true;
            TBSexo.Items.AddRange(new object[] { "Homem", "Mulher", "Outro" });
            TBSexo.Location = new Point(178, 136);
            TBSexo.Name = "TBSexo";
            TBSexo.Size = new Size(486, 38);
            TBSexo.TabIndex = 4;
            // 
            // MTCRM
            // 
            MTCRM.Font = new Font("Segoe UI", 16F);
            MTCRM.Location = new Point(178, 246);
            MTCRM.Mask = "000000";
            MTCRM.Name = "MTCRM";
            MTCRM.Size = new Size(486, 36);
            MTCRM.TabIndex = 3;
            // 
            // MTCpf
            // 
            MTCpf.Font = new Font("Segoe UI", 16F);
            MTCpf.Location = new Point(178, 301);
            MTCpf.Mask = "999.999.999-99";
            MTCpf.Name = "MTCpf";
            MTCpf.Size = new Size(486, 36);
            MTCpf.TabIndex = 3;
            // 
            // TBNome
            // 
            TBNome.Font = new Font("Segoe UI", 16F);
            TBNome.Location = new Point(178, 29);
            TBNome.Name = "TBNome";
            TBNome.Size = new Size(486, 36);
            TBNome.TabIndex = 1;
            // 
            // BTLimpar
            // 
            BTLimpar.Font = new Font("Segoe UI", 16F);
            BTLimpar.Location = new Point(257, 459);
            BTLimpar.Name = "BTLimpar";
            BTLimpar.Size = new Size(228, 134);
            BTLimpar.TabIndex = 5;
            BTLimpar.Text = "Limpar";
            BTLimpar.UseVisualStyleBackColor = true;
            BTLimpar.Click += BTLimpar_Click;
            // 
            // BTVoltar
            // 
            BTVoltar.Font = new Font("Segoe UI", 16F);
            BTVoltar.Location = new Point(12, 459);
            BTVoltar.Name = "BTVoltar";
            BTVoltar.Size = new Size(228, 134);
            BTVoltar.TabIndex = 5;
            BTVoltar.Text = "Voltar";
            BTVoltar.UseVisualStyleBackColor = true;
            BTVoltar.Click += BTVoltar_Click;
            // 
            // BTCadastrar
            // 
            BTCadastrar.Font = new Font("Segoe UI", 16F);
            BTCadastrar.Location = new Point(502, 459);
            BTCadastrar.Name = "BTCadastrar";
            BTCadastrar.Size = new Size(228, 134);
            BTCadastrar.TabIndex = 5;
            BTCadastrar.Text = "Cadastrar";
            BTCadastrar.UseVisualStyleBackColor = true;
            BTCadastrar.Click += BTCadastrar_Click;
            // 
            // TxtHorarioTrabalho
            // 
            TxtHorarioTrabalho.AutoSize = true;
            TxtHorarioTrabalho.Font = new Font("Segoe UI", 16F);
            TxtHorarioTrabalho.Location = new Point(36, 363);
            TxtHorarioTrabalho.Name = "TxtHorarioTrabalho";
            TxtHorarioTrabalho.Size = new Size(204, 30);
            TxtHorarioTrabalho.TabIndex = 6;
            TxtHorarioTrabalho.Text = "Horario de trabalho";
            // 
            // TBHorarioTrabalho
            // 
            TBHorarioTrabalho.Font = new Font("Segoe UI", 16F);
            TBHorarioTrabalho.Location = new Point(246, 363);
            TBHorarioTrabalho.Name = "TBHorarioTrabalho";
            TBHorarioTrabalho.Size = new Size(418, 36);
            TBHorarioTrabalho.TabIndex = 7;
            TBHorarioTrabalho.TextAlign = HorizontalAlignment.Center;
            // 
            // CadMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 605);
            Controls.Add(TBHorarioTrabalho);
            Controls.Add(TxtHorarioTrabalho);
            Controls.Add(BTVoltar);
            Controls.Add(BTCadastrar);
            Controls.Add(BTLimpar);
            Controls.Add(TBSexo);
            Controls.Add(MTCpf);
            Controls.Add(MTCRM);
            Controls.Add(MTTelefone);
            Controls.Add(Nascimento);
            Controls.Add(TBNome);
            Controls.Add(textBox1);
            Controls.Add(TxtTelefone);
            Controls.Add(TxtSexo);
            Controls.Add(TxtCPF);
            Controls.Add(TxtCRM);
            Controls.Add(TxtDataNascimento);
            Controls.Add(TxtNome);
            Name = "CadMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtNome;
        private Label TxtDataNascimento;
        private Label TxtCRM;
        private Label TxtCPF;
        private Label TxtSexo;
        private Label TxtTelefone;
        private TextBox textBox1;
        private DateTimePicker Nascimento;
        private MaskedTextBox MTTelefone;
        private ComboBox TBSexo;
        private MaskedTextBox MTCRM;
        private MaskedTextBox MTCpf;
        private TextBox TBNome;
        private Button BTLimpar;
        private Button BTVoltar;
        private Button BTCadastrar;
        private Label TxtHorarioTrabalho;
        private TextBox TBHorarioTrabalho;
    }
}