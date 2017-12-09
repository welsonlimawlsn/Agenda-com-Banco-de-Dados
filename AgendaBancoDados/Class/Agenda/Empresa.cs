using AgendaBancoDados.Class.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaBancoDados.Class.Agenda
{
    class Empresa : Contato, ISalvavel
    {
        public void Excluir()
        {
            throw new NotImplementedException();
        }
        public void SalvarEdicao()
        {
            using (SQL sql = new SQL())
            {
                sql.Command("UPDATE empresa SET nome = @Nome, telefone = @Telefone, whatsapp = @Whatsapp, email = @Email, endereco = @Endereco WHERE id_empresa = @Id",
                        "@Nome", this.Nome,
                        "@Telefone", this.Telefone,
                        "@Whatsapp", this.Whatsapp,
                        "@Email", this.Email,
                        "@Endereco", this.Endereco,
                        "@Id", this.Id.ToString());
            }
        }

        public void SalvarNovo()
        {
            SQL sql = new SQL();
            sql.Command("INSERT INTO empresa (nome, telefone, whatsapp, email, endereco) VALUES (@Nome, @Telefone, @Whatsapp, @Email, @Endereco)",
                        "@Nome", this.Nome,
                        "@Telefone", this.Telefone,
                        "@Whatsapp", this.Whatsapp,
                        "@Email", this.Email,
                        "@Endereco", this.Endereco);
            sql.Close();
        }
    }
}
