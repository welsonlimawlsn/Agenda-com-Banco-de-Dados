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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CarregarListas();
        }

        private void pessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAdd formEditAdd = new FormEditAdd(new Pessoa(), FormEditAdd.AcaoFormulario.Salvar);
            formEditAdd.ShowDialog();
            CarregarListas();
        }

        private void comercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAdd formEditAdd = new FormEditAdd(new Empresa(), FormEditAdd.AcaoFormulario.Salvar);
            formEditAdd.ShowDialog();
            CarregarListas();
        }
        void CarregarListas()
        {
            listBoxEmpresas.Items.Clear();
            listBoxPessoas.Items.Clear();

            listBoxEmpresas.Items.AddRange(Contato.GetTodosContatos<Empresa>().ToArray());
            listBoxPessoas.Items.AddRange(Contato.GetTodosContatos<Pessoa>().ToArray());
        }
    }
}
