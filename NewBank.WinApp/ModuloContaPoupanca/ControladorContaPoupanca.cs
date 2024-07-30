
using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloContaCorrente;

namespace NewBank.WinApp.ModuloContaPoupanca
{
    public class ControladorContaPoupanca : ControladorBase
    {
        private IRepositorioContaPoupanca repositorioContaPoupanca;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaPoupanca tabelaContaPoupanca;

        public override string TipoCadastro { get { return "Conta Poupança"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar uma nova Conta Poupança"; } }
        public override string ToolTipEditar { get { return "Editar uma Conta Poupança"; } }
        public override string ToolTipExcluir { get { return "Excluir uma Conta Poupança"; } }

        public ControladorContaPoupanca(IRepositorioContaPoupanca repositorioContaPoupanca, IRepositorioHistorioco repositorioHistorioco, IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaPoupanca = repositorioContaPoupanca;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaPoupanca == null)
                tabelaContaPoupanca = new TabelaContaPoupanca();
            CarregarDadosTabela();

            return tabelaContaPoupanca;
        }

        public override void Adicionar()
        {
            TelaContaPoupancaForm telaContaPoupanca = new TelaContaPoupancaForm();

            DialogResult resultado = telaContaPoupanca.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaPoupanca novaConta = telaContaPoupanca.ContaPoupanca;

            this.repositorioContaPoupanca.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta poupaça do titular: \"{novaConta.Titular.Nome}\" foi criada com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void PDF()
        {
            throw new NotImplementedException();
        }

        public override void Operacao()
        {
            throw new NotImplementedException();
        }

        private void CarregarDadosTabela()
        {
            List<ContaPoupanca> disciplina = this.repositorioContaPoupanca.SelecionarTodos();

            tabelaContaPoupanca.AtualizarRegistros(disciplina);
        }
    }
}
