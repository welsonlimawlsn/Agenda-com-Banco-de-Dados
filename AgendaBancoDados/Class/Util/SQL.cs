using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AgendaBancoDados.Class.Util
{
    /// <summary>
    /// Classe para cuidar de conexões com o banco de dados.
    /// </summary>
    public class SQL
    {
        SqlConnection Connection { get; set; }
        public SQL()
        {
            this.Connection = new SqlConnection("Server=DESKTOP-R5DM9E8;Database=agenda;Trusted_Connection=True");
        }
        /// <summary>
        /// Método pra executar comandos como Update, Insert e Delete.
        /// </summary>
        /// <param name="command">O comando SQL.</param>
        /// <param name="parameters">Os parametros, passando primeiro a Tag e depois o Valor, assim por diante.</param>
        public void Command(string command, params string[] parameters)
        {
            try
            {
                this.Connection.Open();
                SqlCommand commandSql = new SqlCommand(command, this.Connection);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    commandSql.Parameters.AddWithValue(parameters[i], parameters[i + 1]);
                }
                commandSql.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                this.Close();
                MessageBox.Show(error.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para executar o Select.
        /// </summary>
        /// <param name="command">O comando SQL.</param>
        /// <param name="parameters">Os parametros, passando primeiro a Tag e depois o Valor, assim por diante.</param>
        /// <returns>Retorna um Collection com as linhas.</returns>
        public DataRowCollection Select(string command, params string[] parameters)
        {
            DataTable data = null;
            try
            {
                this.Connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, this.Connection);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(parameters[i], parameters[i+1]);
                }
                data = new DataTable();
                dataAdapter.Fill(data);
            } catch (Exception error)
            {
                this.Close();
                MessageBox.Show(error.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data.Rows;
        }
        /// <summary>
        /// Fecha a conexão com o banco de dados.
        /// </summary>
        public void Close()
        {
            if(this.Connection != null)
                this.Connection.Close();
        }
    }
}
