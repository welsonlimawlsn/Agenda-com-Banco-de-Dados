using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AgendaBancoDados.Class.Util
{
    public class SQL
    {
        SqlConnection Connection { get; set; }
        public SQL()
        {
            this.Connection = new SqlConnection("Server=DESKTOP-R5DM9E8;Database=agenda;Trusted_Connection=True");
        }
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
        public DataRowCollection Select(string command, params string[] parameters)
        {
            DataTable data = null;
            try
            {
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
        public void Close()
        {
            if(this.Connection != null)
                this.Connection.Close();
        }
    }
}
