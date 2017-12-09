namespace AgendaBancoDados.Formularios
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            this.listBoxEmpresas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoalToolStripMenuItem,
            this.comercialToolStripMenuItem});
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.contatosToolStripMenuItem.Text = "Novo";
            // 
            // pessoalToolStripMenuItem
            // 
            this.pessoalToolStripMenuItem.Name = "pessoalToolStripMenuItem";
            this.pessoalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pessoalToolStripMenuItem.Text = "Pessoal";
            this.pessoalToolStripMenuItem.Click += new System.EventHandler(this.pessoalToolStripMenuItem_Click);
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comercialToolStripMenuItem.Text = "Comercial";
            this.comercialToolStripMenuItem.Click += new System.EventHandler(this.comercialToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pessoas:";
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.Location = new System.Drawing.Point(15, 41);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(241, 134);
            this.listBoxPessoas.TabIndex = 2;
            this.listBoxPessoas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPessoas_MouseDoubleClick);
            // 
            // listBoxEmpresas
            // 
            this.listBoxEmpresas.FormattingEnabled = true;
            this.listBoxEmpresas.Location = new System.Drawing.Point(262, 41);
            this.listBoxEmpresas.Name = "listBoxEmpresas";
            this.listBoxEmpresas.Size = new System.Drawing.Size(241, 134);
            this.listBoxEmpresas.TabIndex = 4;
            this.listBoxEmpresas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEmpresas_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresas:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 189);
            this.Controls.Add(this.listBoxEmpresas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPessoas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPessoas;
        private System.Windows.Forms.ListBox listBoxEmpresas;
        private System.Windows.Forms.Label label2;
    }
}