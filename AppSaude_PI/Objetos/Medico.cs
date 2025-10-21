using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSaude_PI.Objetos
{
    public class Medico
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasciscmento { get; set; }
        public String Sexo { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string RG { get; set; }
        public string CPF { get; set; }
        public string CRM { get; set; }
        public string horarioTrabalho { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}
