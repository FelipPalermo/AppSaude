using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSaude_PI.Telas.Pessoas.Pacientes
{
    public partial class HistoricoPaciente : Form
    {
        public HistoricoPaciente()
        {
            InitializeComponent();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
