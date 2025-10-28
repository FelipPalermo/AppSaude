using AppSaude_PI.MySQL;
using AppSaude_PI.Objetos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppSaude_PI.Telas
{
    public class retConsultas()
    {
        static public List<Medico> medicosConsultas()
        {
            string query = "select id_medico, nome, CRM, horarioTrabalho from medicos";
            List<Medico> medicos = SQLConn.SqlGetList(query, reader => new Medico
            {
                id = reader.GetInt32("id_medico"),
                Nome = reader.GetString("nome"),
                CRM = reader.GetString("crm"),
                horarioTrabalho = reader.GetString("horarioTrabalho"),

            });

            return medicos;
        }
        static public List<Paciente> pacienteConsultas()
        {
            string query = "select id_paciente, nome, cpf, pagamentos_em_dia from pacientes";
            List<Paciente> pacientes = SQLConn.SqlGetList(query, reader => new Paciente
            {
                id = reader.GetInt32("id_paciente"),
                Nome = reader.GetString("nome"),
                CPF = reader.GetString("cpf"),
                pagamentosEmDia = reader.GetBoolean("pagamentos_em_dia")

            });

            return pacientes;
        }

        static public List<Consultas> listConsultas()
        {
            string query = "SELECT id_consulta, nomePaciente, nomeMedico,  data_consulta, descricao, valor, pagamento, ativa from consultas";
            List<Consultas> lConsultas = SQLConn.SqlGetList(query, reader => new Consultas
            {
                id = reader.GetInt32("id_consulta"),
                pacienteNome = reader.GetString("nomePaciente"),
                medicoNome = reader.GetString("nomeMedico"),
                dataConsulta = reader.GetDateTime("data_consulta"),
                descricao = reader.GetString("Descricao"),
                valor = reader.GetDecimal("valor"),
                pagamento = reader.GetBoolean("pagamento"),
                ativa = reader.GetBoolean("ativa")
            });

            return lConsultas;
        }

        static public List<Consultas> listConsultasAtivas()
        {
            string query = "SELECT id_consulta, nomePaciente, nomeMedico,  data_consulta, descricao, valor, pagamento, ativa from consultas " +
                "Where ativa = true";
            List<Consultas> lConsultas = SQLConn.SqlGetList(query, reader => new Consultas
            {
                id = reader.GetInt32("id_consulta"),
                pacienteNome = reader.GetString("nomePaciente"),
                medicoNome = reader.GetString("nomeMedico"),
                dataConsulta = reader.GetDateTime("data_consulta"),
                descricao = reader.GetString("Descricao"),
                valor = reader.GetDecimal("valor"),
                pagamento = reader.GetBoolean("pagamento"),
                ativa = reader.GetBoolean("ativa")

            });

            return lConsultas;
        }
        static public List<Consultas> listConsultasPessoa(int id)
        {

            string query = "SELECT id_consulta, nomePaciente, nomeMedico,  data_consulta, descricao, valor, pagamento, ativa " +
                $"from consultas where id_paciente = {id};";
            List<Consultas> lConsultas = SQLConn.SqlGetList(query, reader => new Consultas
            {
                id = reader.GetInt32("id_consulta"),
                pacienteNome = reader.GetString("nomePaciente"),
                medicoNome = reader.GetString("nomeMedico"),
                dataConsulta = reader.GetDateTime("data_consulta"),
                descricao = reader.GetString("Descricao"),
                valor = reader.GetDecimal("valor"),
                pagamento = reader.GetBoolean("pagamento"),
                ativa = reader.GetBoolean("ativa")
            });

            return lConsultas;
        }

    }
}
