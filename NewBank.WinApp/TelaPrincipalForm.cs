using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.Dominio.Resources;
using NewBank.Infra.Compartilhado;
using NewBank.Infra.ModuloContaCorrente;
using NewBank.Infra.ModuloContaPoupanca;
using NewBank.Infra.ModuloContaSalario;
using NewBank.Infra.ModuloHistorioco;
using NewBank.Infra.ModuloOperacao;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloContaCorrente;
using NewBank.WinApp.ModuloContaPoupanca;
using NewBank.WinApp.ModuloContaSalario;
using NewBank.WinApp.Properties;
using System.Globalization;

namespace NewBank.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        ContextoDados contexto;

        //Repositorios
        IRepositorioContaCorrente repositorioContaCorrente;
        IRepositorioContaSalario repositorioContaSalario;
        IRepositorioContaPoupanca repositorioContaPoupanca;
        IRepositorioHistorioco repositorioHistorioco;
        IRepositorioOperacao repositorioOperacao;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();
            LocalizeForm();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            this.btnOperacao.Visible = false;
            this.btnHistorico.Visible = false;
            this.Separator2.Visible = false;

            contexto = new ContextoDados(carregarDados: true);

            this.repositorioContaCorrente = new RepositorioContaCorrenteEmArquivo(contexto);
            this.repositorioContaSalario = new RepositorioContaSalarioEmArquivo(contexto);
            this.repositorioContaPoupanca = new RepositorioContaPoupancaEmArquivo(contexto);
            this.repositorioHistorioco = new RepositorioHistoriocoEmArquivo(contexto);
            this.repositorioOperacao = new RepositorioOperacaoEmArquivo(contexto);

        }

        private void LocalizeForm()
        {
            // Defina textos localizados para os controles do formulário
            this.telasToolStripMenuItem.Text = Lingua.MenuContas;
            this.opçoesToolStripMenuItem.Text = Lingua.MenuOpcao;
            this.linguaToolStripMenuItem.Text = Lingua.MenuLingua;
            this.stripMenuCorrente.Text = Lingua.Corrente;
            this.stripMenuSalario.Text = Lingua.Salario;
            this.stripMenuPoupanca.Text = Lingua.Poupanca;
            this.linguaToolStripMenuItem.Text = Lingua.MenuLingua;
            this.ptbrToolStripMenuItem.Text = Lingua.pt;
            this.esToolStripMenuItem.Text = Lingua.en;
            this.esToolStripMenuItem.Text = Lingua.fr;
        }

        private void ChangeLanguage(string cultureCode)
        {
            // Definir a nova cultura
            CultureInfo newCulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentUICulture = newCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;

            // Recarregar textos localizados
            LocalizeForm();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdd.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdd.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }


        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        //Telas
        private void stripMenuDisciplina_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorContaCorrente(repositorioContaCorrente, repositorioHistorioco, repositorioOperacao);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }

        private void stripMenuMateria_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorContaSalario(repositorioContaSalario, repositorioHistorioco, repositorioOperacao);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }

        private void stripMenuQuestoes_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorContaPoupanca(repositorioContaPoupanca, repositorioHistorioco, repositorioOperacao);

            ConfigurarTelaPrincipal(controlador);
            DesiblitarMenus();
        }


        //Botões
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.controlador.Excluir();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            this.controlador.Operacao();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            this.controlador.Historioco();
        }

        private void DesiblitarMenus()
        {
            this.btnOperacao.Visible = true;
            this.btnHistorico.Visible = true;
            this.Separator2.Visible = true;
        }

        private void ptbrToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ChangeLanguage("pt-BR");
        }

        private void enusToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ChangeLanguage("en-US");
        }

        private void esToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr-FR");
        }
    }
}
