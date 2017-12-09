﻿using AgendaBancoDados.Class.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaBancoDados.Class.Agenda
{
    class Pessoa : Contato, ISalvavel
    {
        public Empresa Empresa { get; set; }
        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void SalvarEdicao()
        {
            throw new NotImplementedException();
        }

        public void SalvarNovo()
        {
            SQL sql = new SQL();
            sql.Command("INSERT INTO pessoa (nome, telefone, whatsapp, email, endereco) VALUES (@Nome, @Telefone, @Whatsapp, @Email, @Endereco)",
                        "@Nome", this.Nome,
                        "@Telefone", this.Telefone,
                        "@Whatsapp", this.Whatsapp,
                        "@Email", this.Email,
                        "@Endereco", this.Endereco);
            sql.Close();
        }
    }
}
