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

        private void listBoxPessoas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxPessoas.SelectedIndex != -1)
            {
                FormEditAdd formEditAdd = new FormEditAdd((Pessoa)listBoxPessoas.SelectedItem, FormEditAdd.AcaoFormulario.Editar);
                formEditAdd.ShowDialog();
            }
        }

        private void listBoxEmpresas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxEmpresas.SelectedIndex != -1)
            {
                FormEditAdd formEditAdd = new FormEditAdd((Empresa)listBoxEmpresas.SelectedItem, FormEditAdd.AcaoFormulario.Editar);
                formEditAdd.ShowDialog();
            }
        }
    }
}
