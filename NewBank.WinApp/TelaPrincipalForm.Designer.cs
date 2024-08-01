namespace NewBank.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            telasToolStripMenuItem = new ToolStripMenuItem();
            stripMenuCorrente = new ToolStripMenuItem();
            stripMenuSalario = new ToolStripMenuItem();
            stripMenuPoupanca = new ToolStripMenuItem();
            opçoesToolStripMenuItem = new ToolStripMenuItem();
            linguaToolStripMenuItem = new ToolStripMenuItem();
            ptbrToolStripMenuItem = new ToolStripMenuItem();
            enusToolStripMenuItem = new ToolStripMenuItem();
            esToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnOperacao = new ToolStripButton();
            btnHistorico = new ToolStripButton();
            Separator2 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(57, 62, 70);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telasToolStripMenuItem, opçoesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // telasToolStripMenuItem
            // 
            telasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuCorrente, stripMenuSalario, stripMenuPoupanca });
            telasToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            telasToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            telasToolStripMenuItem.Name = "telasToolStripMenuItem";
            telasToolStripMenuItem.Size = new Size(88, 32);
            telasToolStripMenuItem.Text = "Contas";
            // 
            // stripMenuCorrente
            // 
            stripMenuCorrente.BackColor = Color.FromArgb(57, 62, 70);
            stripMenuCorrente.ForeColor = Color.FromArgb(0, 173, 181);
            stripMenuCorrente.Name = "stripMenuCorrente";
            stripMenuCorrente.Size = new Size(186, 32);
            stripMenuCorrente.Text = "Corrente";
            stripMenuCorrente.Click += stripMenuDisciplina_Click;
            // 
            // stripMenuSalario
            // 
            stripMenuSalario.BackColor = Color.FromArgb(57, 62, 70);
            stripMenuSalario.ForeColor = Color.FromArgb(0, 173, 181);
            stripMenuSalario.Name = "stripMenuSalario";
            stripMenuSalario.Size = new Size(186, 32);
            stripMenuSalario.Text = "Salario";
            stripMenuSalario.Click += stripMenuMateria_Click;
            // 
            // stripMenuPoupanca
            // 
            stripMenuPoupanca.BackColor = Color.FromArgb(57, 62, 70);
            stripMenuPoupanca.ForeColor = Color.FromArgb(0, 173, 181);
            stripMenuPoupanca.Name = "stripMenuPoupanca";
            stripMenuPoupanca.Size = new Size(186, 32);
            stripMenuPoupanca.Text = "Poupança";
            stripMenuPoupanca.Click += stripMenuQuestoes_Click;
            // 
            // opçoesToolStripMenuItem
            // 
            opçoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { linguaToolStripMenuItem });
            opçoesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opçoesToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            opçoesToolStripMenuItem.Name = "opçoesToolStripMenuItem";
            opçoesToolStripMenuItem.Size = new Size(94, 32);
            opçoesToolStripMenuItem.Text = "Opçoes";
            // 
            // linguaToolStripMenuItem
            // 
            linguaToolStripMenuItem.BackColor = Color.FromArgb(57, 62, 70);
            linguaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ptbrToolStripMenuItem, enusToolStripMenuItem, esToolStripMenuItem });
            linguaToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            linguaToolStripMenuItem.Name = "linguaToolStripMenuItem";
            linguaToolStripMenuItem.Size = new Size(159, 32);
            linguaToolStripMenuItem.Text = "Lingua";
            // 
            // ptbrToolStripMenuItem
            // 
            ptbrToolStripMenuItem.BackColor = Color.FromArgb(57, 62, 70);
            ptbrToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            ptbrToolStripMenuItem.Name = "ptbrToolStripMenuItem";
            ptbrToolStripMenuItem.Size = new Size(192, 32);
            ptbrToolStripMenuItem.Text = "Portugues";
            ptbrToolStripMenuItem.Click += ptbrToolStripMenuItem_Click;
            // 
            // enusToolStripMenuItem
            // 
            enusToolStripMenuItem.BackColor = Color.FromArgb(57, 62, 70);
            enusToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            enusToolStripMenuItem.Name = "enusToolStripMenuItem";
            enusToolStripMenuItem.Size = new Size(192, 32);
            enusToolStripMenuItem.Text = "Ingles";
            enusToolStripMenuItem.Click += enusToolStripMenuItem_Click;
            // 
            // esToolStripMenuItem
            // 
            esToolStripMenuItem.BackColor = Color.FromArgb(57, 62, 70);
            esToolStripMenuItem.ForeColor = Color.FromArgb(0, 173, 181);
            esToolStripMenuItem.Name = "esToolStripMenuItem";
            esToolStripMenuItem.Size = new Size(192, 32);
            esToolStripMenuItem.Text = "Frances";
            esToolStripMenuItem.Click += esToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(34, 40, 49);
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEditar, btnExcluir, toolStripSeparator1, btnOperacao, btnHistorico, Separator2, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(905, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.adicionar_ficheiro__2_;
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(44, 44);
            btnAdd.Text = "toolStripButton1";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(44, 51);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.arquivo;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(44, 51);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(0, 173, 181);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // btnOperacao
            // 
            btnOperacao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOperacao.Image = Properties.Resources.money_management;
            btnOperacao.Name = "btnOperacao";
            btnOperacao.Size = new Size(44, 51);
            btnOperacao.Text = "Dublicar teste";
            btnOperacao.Click += btnDuplicar_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHistorico.Image = Properties.Resources.simbolo_de_ferramentas_de_organizacao_e_administracao_de_horario_de_calendario_e_relogio;
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(44, 51);
            btnHistorico.Text = "Historico";
            btnHistorico.Click += btnPDF_Click;
            // 
            // Separator2
            // 
            Separator2.Name = "Separator2";
            Separator2.Size = new Size(6, 54);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoCadastro.ForeColor = Color.FromArgb(0, 173, 181);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(122, 51);
            lblTipoCadastro.Text = "New Bank";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(34, 40, 49);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(905, 34);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.ForeColor = Color.FromArgb(0, 173, 181);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(98, 28);
            statusLabelPrincipal.Text = "New Bank";
            // 
            // pnlRegistros
            // 
            pnlRegistros.BackColor = Color.FromArgb(57, 62, 70);
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 90);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(905, 437);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            ClientSize = new Size(905, 561);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Bank";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem telasToolStripMenuItem;
        private ToolStripMenuItem stripMenuCorrente;
        private ToolStripMenuItem stripMenuSalario;
        private ToolStripMenuItem stripMenuPoupanca;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private Panel pnlRegistros;
        private ToolStripButton btnOperacao;
        private ToolStripButton btnHistorico;
        private ToolStripSeparator Separator2;
        private ToolStripMenuItem opçoesToolStripMenuItem;
        private ToolStripMenuItem linguaToolStripMenuItem;
        private ToolStripMenuItem ptbrToolStripMenuItem;
        private ToolStripMenuItem enusToolStripMenuItem;
        private ToolStripMenuItem esToolStripMenuItem;
    }
}
