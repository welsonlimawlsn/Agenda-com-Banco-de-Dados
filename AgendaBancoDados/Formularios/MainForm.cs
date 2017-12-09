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
        }

        private void pessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAdd formEditAdd = new FormEditAdd(new Pessoa(), FormEditAdd.AcaoFormulario.Salvar);
            formEditAdd.ShowDialog();
        }

        private void comercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAdd formEditAdd = new FormEditAdd(new Empresa(), FormEditAdd.AcaoFormulario.Salvar);
            formEditAdd.ShowDialog();
        }
    }
}
