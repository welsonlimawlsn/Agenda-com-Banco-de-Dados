using System;
using System.Collections.Generic;
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

    }
}
