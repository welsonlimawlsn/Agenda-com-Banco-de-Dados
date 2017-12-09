using AgendaBancoDados.Class.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace AgendaBancoDados
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            SQL sql = new SQL();
            //sql.Command("INSERT INTO contatos (nome, telefone) VALUES (@Nome, @Telefone)", "@Nome", "Nome da Pessoa", "@Telefone", "(00) 0 0000-0000");
            foreach(DataRow line in sql.Select("SELECT * FROM contatos"))
            {
                Console.WriteLine(line["nome"] + " - " + line["telefone"]);
            }
            sql.Close();
        }
    }
}
