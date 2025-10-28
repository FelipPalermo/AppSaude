using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSaude_PI.Objetos
{
    public class Consultas
    {
        public int id { get; set; }
        public int idPacinte { get; set; }
        public int idMedico { get; set; }
        public string pacienteNome { get; set; }
        public string medicoNome { get; set; }
        public string descricao  { get; set; }
        public decimal valor { get; set; }
        public DateTime dataConsulta { get; set; }
        public bool pagamento { get; set; }
        public bool ativa { get; set; }

    }
}
