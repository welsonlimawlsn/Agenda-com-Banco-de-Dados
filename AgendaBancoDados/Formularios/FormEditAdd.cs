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
            Salvar, Editar, Visualizar
        }
        public FormEditAdd(ISalvavel contato, AcaoFormulario acaoFormulario)
        {
            InitializeComponent();
            this.Contato = contato;
            this.Acao = acaoFormulario;
            if(acaoFormulario == AcaoFormulario.Editar)
            {
                buttonExcluir.Enabled = true;
            } else if (acaoFormulario == AcaoFormulario.Visualizar)
            {
                textBoxNome.ReadOnly = true;
                textBoxTelefone.ReadOnly = true;
                textBoxWhatsapp.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxEndereco.ReadOnly = true;
                buttonEditar.Enabled = true;
                buttonSalvar.Enabled = false;
                textBoxNome.Text = ((Contato)contato).Nome;
                textBoxTelefone.Text = ((Contato)contato).Telefone;
                textBoxWhatsapp.Text = ((Contato)contato).Whatsapp;
                textBoxEmail.Text = ((Contato)contato).Email;
                textBoxEndereco.Text = ((Contato)contato).Endereco;
            }
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
            } else if (Acao == AcaoFormulario.Editar)
            {
                Contato.SalvarEdicao();
            }
            MessageBox.Show("Contato salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Contato.Excluir();
            MessageBox.Show("Contato excluido com sucesso!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Acao = AcaoFormulario.Editar;
            textBoxNome.ReadOnly = false;
            textBoxTelefone.ReadOnly = false;
            textBoxWhatsapp.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxEndereco.ReadOnly = false;
            buttonEditar.Enabled = false;
            buttonSalvar.Enabled = true;
            buttonExcluir.Enabled = true;
        }
    }
}
