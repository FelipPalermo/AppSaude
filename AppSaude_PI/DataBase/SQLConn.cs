using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppSaude_PI.Objetos;
using MySql.Data.MySqlClient;

namespace AppSaude_PI.MySQL
{

    static internal class SQLConn
    {
        private static string SQLConnString = "server=localhost;user=root;password=0000;database=appsaude";
        
        #region Inserir pacientes
        static public void SqlInsert(string query, Action<MySqlCommand> addParam, string successString)
        {
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(SQLConnString))
                using (MySqlCommand cmd = new MySqlCommand(query, SqlConn))
                {

                    SqlConn.Open();
                    addParam?.Invoke(cmd);


                    cmd.ExecuteNonQuery();

                    if (!string.IsNullOrWhiteSpace(successString))
                    {
                        MessageBox.Show(successString);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("CPF ou RG já registrado no sistema");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Retornar todos os pacientes
        static public List<T> SqlGetList<T>(string query, Func<MySqlDataReader, T> map)
        {
            List<T> pacientList = new List<T>();

            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(SQLConnString))
                {
                    SqlConn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, SqlConn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pacientList.Add(map(reader));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pacientList;
        }
        #endregion

        #region Alterar paciente
        static public void alterarPaciente(Paciente p)
        {
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(SQLConnString))
                {


                    string insertString = $"Update pacientes " +
                        $"SET nome = @nome," +
                        $"cpf = @cpf," +
                        $"rg = @rg," +
                        $"sexo = @sexo," +
                        $"DataNascimento = @DataNascimento," +
                        $"telefone = @telefone," +
                        $"documentos_ok = @docok " +
                        $"WHERE id_paciente = @id;";


                    MySqlCommand SqlCommand = new MySqlCommand(insertString, SqlConn);
                    SqlCommand.Parameters.AddWithValue("@nome", p.Nome);
                    SqlCommand.Parameters.AddWithValue("@cpf", p.CPF);
                    SqlCommand.Parameters.AddWithValue("@rg", p.RG);
                    SqlCommand.Parameters.AddWithValue("@sexo", p.Sexo);
                    SqlCommand.Parameters.AddWithValue("@DataNascimento", p.DataNaciscmento);
                    SqlCommand.Parameters.AddWithValue("@telefone", p.Telefone);
                    SqlCommand.Parameters.AddWithValue("@id", p.id);
                    SqlCommand.Parameters.AddWithValue("@docok", p.documentosOk);


                    SqlConn.Open();
                    SqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Os dados do paciente foram alterado!");

                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Esse CPF ou RG já está registrado no sistema!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Alterar Medico
        static public void alterarMedico(Medico m)
        {
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(SQLConnString))
                {


                    string insertString = $"Update medicos " +
                        $"SET nome = @nome," +
                        $"cpf = @cpf," +
                        $"rg = @rg," +
                        $"sexo = @sexo," +
                        $"DataNascimento = @DataNascimento," +
                        $"telefone = @telefone," +
                        $"horarioTrabalho = @horarioTrabalho " +
                        $"WHERE id_medico = @id;";


                    MySqlCommand SqlCommand = new MySqlCommand(insertString, SqlConn);
                    SqlCommand.Parameters.AddWithValue("@nome", m.Nome);
                    SqlCommand.Parameters.AddWithValue("@cpf", m.CPF);
                    SqlCommand.Parameters.AddWithValue("@rg", m.RG);
                    SqlCommand.Parameters.AddWithValue("@sexo", m.Sexo);
                    SqlCommand.Parameters.AddWithValue("@DataNascimento", m.DataNasciscmento);
                    SqlCommand.Parameters.AddWithValue("@telefone", m.Telefone);
                    SqlCommand.Parameters.AddWithValue("@id", m.id);
                    SqlCommand.Parameters.AddWithValue("@horarioTrabalho", m.horarioTrabalho);


                    SqlConn.Open();
                    SqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Os dados do paciente foram alterado!");

                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Esse CPF ou RG já está registrado no sistema!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion      

        #region Deletar paciente
        // Funcao levemente abstraida
        static public void delSql(string query, Action<MySqlCommand> parameter = null)
        {
            using (MySqlConnection SqlConn = new MySqlConnection(SQLConnString))
            {
                SqlConn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, SqlConn))
                {
                    parameter?.Invoke(cmd);
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
