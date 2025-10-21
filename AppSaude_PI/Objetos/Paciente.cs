using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSaude_PI.Objetos
{
    public class Paciente
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNaciscmento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public bool documentosOk { get; set; }
        public bool pagamentosEmDia {  get; set; }
        public DateTime dataCadastro { get; set; }

        public bool Documentos_Ok
        {
            get
            {
                // Verifica se CPF e RG têm algo "válido" (não nulo, não vazio, e não só símbolos)
                bool cpfValido = !string.IsNullOrWhiteSpace(CPF) && CPF.Any(char.IsDigit);
                bool rgValido = !string.IsNullOrWhiteSpace(RG) && RG.Any(char.IsDigit);

                return cpfValido && rgValido;
            }
        }

        }
}
