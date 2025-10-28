namespace AppSaude_PI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CadastrarPaciente = new Button();
            CadastrarMedico = new Button();
            ListarPessoa = new Button();
            ListarMedicos = new Button();
            gbPessoas = new GroupBox();
            BtAgendarExame = new Button();
            btPagarExame = new Button();
            btHistoricoExames = new Button();
            btCancelarExame = new Button();
            gbExames = new GroupBox();
            gbPessoas.SuspendLayout();
            gbExames.SuspendLayout();
            SuspendLayout();
            // 
            // CadastrarPaciente
            // 
            CadastrarPaciente.Font = new Font("Segoe UI", 10F);
            CadastrarPaciente.Location = new Point(27, 22);
            CadastrarPaciente.Name = "CadastrarPaciente";
            CadastrarPaciente.Size = new Size(159, 45);
            CadastrarPaciente.TabIndex = 0;
            CadastrarPaciente.Text = "Cadastrar Paciente";
            CadastrarPaciente.UseVisualStyleBackColor = true;
            CadastrarPaciente.Click += CadastrarPaciente_Click;
            // 
            // CadastrarMedico
            // 
            CadastrarMedico.Font = new Font("Segoe UI", 10F);
            CadastrarMedico.Location = new Point(192, 22);
            CadastrarMedico.Name = "CadastrarMedico";
            CadastrarMedico.Size = new Size(159, 45);
            CadastrarMedico.TabIndex = 0;
            CadastrarMedico.Text = "Cadastrar Médico";
            CadastrarMedico.UseVisualStyleBackColor = true;
            CadastrarMedico.Click += CadastrarMedico_Click_1;
            // 
            // ListarPessoa
            // 
            ListarPessoa.Font = new Font("Segoe UI", 10F);
            ListarPessoa.Location = new Point(27, 73);
            ListarPessoa.Name = "ListarPessoa";
            ListarPessoa.Size = new Size(159, 45);
            ListarPessoa.TabIndex = 0;
            ListarPessoa.Text = "Listar Pacientes";
            ListarPessoa.UseVisualStyleBackColor = true;
            ListarPessoa.Click += ListarPessoa_Click;
            // 
            // ListarMedicos
            // 
            ListarMedicos.Font = new Font("Segoe UI", 10F);
            ListarMedicos.Location = new Point(192, 73);
            ListarMedicos.Name = "ListarMedicos";
            ListarMedicos.Size = new Size(159, 45);
            ListarMedicos.TabIndex = 0;
            ListarMedicos.Text = "Listar Médicos";
            ListarMedicos.UseVisualStyleBackColor = true;
            ListarMedicos.Click += ListarMedicos_Click;
            // 
            // gbPessoas
            // 
            gbPessoas.Controls.Add(ListarMedicos);
            gbPessoas.Controls.Add(CadastrarMedico);
            gbPessoas.Controls.Add(ListarPessoa);
            gbPessoas.Controls.Add(CadastrarPaciente);
            gbPessoas.Location = new Point(12, 12);
            gbPessoas.Name = "gbPessoas";
            gbPessoas.Size = new Size(375, 135);
            gbPessoas.TabIndex = 1;
            gbPessoas.TabStop = false;
            gbPessoas.Text = "Pessoas";
            // 
            // BtAgendarExame
            // 
            BtAgendarExame.Font = new Font("Segoe UI", 10F);
            BtAgendarExame.Location = new Point(31, 22);
            BtAgendarExame.Name = "BtAgendarExame";
            BtAgendarExame.Size = new Size(159, 45);
            BtAgendarExame.TabIndex = 0;
            BtAgendarExame.Text = "Agendar Exame";
            BtAgendarExame.UseVisualStyleBackColor = true;
            BtAgendarExame.Click += BtAgendarExame_Click;
            // 
            // btPagarExame
            // 
            btPagarExame.Font = new Font("Segoe UI", 10F);
            btPagarExame.Location = new Point(31, 73);
            btPagarExame.Name = "btPagarExame";
            btPagarExame.Size = new Size(159, 45);
            btPagarExame.TabIndex = 0;
            btPagarExame.Text = "Pagar Exame";
            btPagarExame.UseVisualStyleBackColor = true;
            // 
            // btHistoricoExames
            // 
            btHistoricoExames.Font = new Font("Segoe UI", 10F);
            btHistoricoExames.Location = new Point(196, 22);
            btHistoricoExames.Name = "btHistoricoExames";
            btHistoricoExames.Size = new Size(159, 45);
            btHistoricoExames.TabIndex = 0;
            btHistoricoExames.Text = "Historico de exames";
            btHistoricoExames.UseVisualStyleBackColor = true;
            btHistoricoExames.Click += btHistoricoExames_Click;
            // 
            // btCancelarExame
            // 
            btCancelarExame.Font = new Font("Segoe UI", 10F);
            btCancelarExame.Location = new Point(196, 73);
            btCancelarExame.Name = "btCancelarExame";
            btCancelarExame.Size = new Size(159, 45);
            btCancelarExame.TabIndex = 0;
            btCancelarExame.Text = "Cancelar exame";
            btCancelarExame.UseVisualStyleBackColor = true;
            btCancelarExame.Click += btCancelarExame_Click;
            // 
            // gbExames
            // 
            gbExames.Controls.Add(btHistoricoExames);
            gbExames.Controls.Add(BtAgendarExame);
            gbExames.Controls.Add(btPagarExame);
            gbExames.Controls.Add(btCancelarExame);
            gbExames.Location = new Point(413, 12);
            gbExames.Name = "gbExames";
            gbExames.Size = new Size(375, 135);
            gbExames.TabIndex = 1;
            gbExames.TabStop = false;
            gbExames.Text = "Exames";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(gbExames);
            Controls.Add(gbPessoas);
            Name = "Home";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            gbPessoas.ResumeLayout(false);
            gbExames.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CadastrarPaciente;
        private Button CadastrarMedico;
        private Button ListarPessoa;
        private Button ListarMedicos;
        private GroupBox gbPessoas;
        private Button BtAgendarExame;
        private Button btPagarExame;
        private Button btHistoricoExames;
        private Button btCancelarExame;
        private GroupBox gbExames;
    }
}
