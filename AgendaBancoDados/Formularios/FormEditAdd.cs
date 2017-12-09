using AgendaBancoDados.Class.Agenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaBancoDados.Formularios
{
    public partial class FormEditAdd : Form
    {
        ISalvavel Contato { get; set; }
        AcaoFormulario Acao { get; set; }
        public enum AcaoFormulario
        {
            Salvar, Editar
        }
        public FormEditAdd(ISalvavel contato, AcaoFormulario acaoFormulario)
        {
            InitializeComponent();
            this.Contato = contato;
            this.Acao = acaoFormulario;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ((Contato)Contato).Nome = textBoxNome.Text;
            ((Contato)Contato).Telefone = textBoxTelefone.Text;
            ((Contato)Contato).Whatsapp = textBoxWhatsapp.Text;
            ((Contato)Contato).Email = textBoxEmail.Text;
            ((Contato)Contato).Endereco = textBoxEndereco.Text;
            if (Acao == AcaoFormulario.Salvar)
            {
                Contato.SalvarNovo();
                MessageBox.Show("Contato salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
