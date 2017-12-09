using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaBancoDados.Class.Agenda
{
    public interface ISalvavel
    {
        void SalvarNovo();
        void SalvarEdicao();
        void Excluir();
    }
}
