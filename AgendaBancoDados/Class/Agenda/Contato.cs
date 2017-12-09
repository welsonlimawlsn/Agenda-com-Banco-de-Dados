using AgendaBancoDados.Class.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AgendaBancoDados.Class.Agenda
{
    public abstract class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public override string ToString()
        {
            return this.Nome;
        }
        public static List<Contato> GetTodosContatos<T>() where T : Contato
        {
            SQL sql = new SQL();
            List<Contato> lista = new List<Contato>();
            if (typeof(T) == typeof(Pessoa))
            {
                foreach (DataRow linha in sql.Select("SELECT * FROM pessoa"))
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = int.Parse(linha["id_pessoa"].ToString());
                    pessoa.Nome = linha["nome"].ToString();
                    pessoa.Telefone = linha["telefone"].ToString();
                    pessoa.Whatsapp = linha["whatsapp"].ToString();
                    pessoa.Email = linha["email"].ToString();
                    pessoa.Endereco = linha["endereco"].ToString();
                    lista.Add(pessoa);
                }

            } else if (typeof(T) == typeof(Empresa))
            {
                foreach (DataRow linha in sql.Select("SELECT * FROM empresa"))
                {
                    Empresa empresa = new Empresa();
                    empresa.Id = int.Parse(linha["id_empresa"].ToString());
                    empresa.Nome = linha["nome"].ToString();
                    empresa.Telefone = linha["telefone"].ToString();
                    empresa.Whatsapp = linha["whatsapp"].ToString();
                    empresa.Email = linha["email"].ToString();
                    empresa.Endereco = linha["endereco"].ToString();
                    lista.Add(empresa);
                }
            }
            sql.Close();
            return lista;
        }
    }
}
