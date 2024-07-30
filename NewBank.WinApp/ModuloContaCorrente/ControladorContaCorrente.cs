using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloContaCorrente
{
    public class ControladorContaCorrente : ControladorBase
    {
        private IRepositorioContaCorrente repositorioContaCorrente;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaCorrente tabelaContaCorrente;

        public override string TipoCadastro { get { return "Conta Corrente"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar uma nova Conta Corrente"; } }
        public override string ToolTipEditar { get { return "Editar uma Conta Corrente"; } }
        public override string ToolTipExcluir { get { return "Excluir uma Conta Corrente"; } }



        public ControladorContaCorrente(IRepositorioContaCorrente repositorioContaCorrente,IRepositorioHistorioco repositorioHistorioco,IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaCorrente = repositorioContaCorrente;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaCorrente == null)
                tabelaContaCorrente = new TabelaContaCorrente();

            CarregarDadosTabela();

            return tabelaContaCorrente;
        }

        public override void Adicionar()
        {
            TelaContaCorrenteForm telaContaCorrente = new TelaContaCorrenteForm();

            DialogResult resultado = telaContaCorrente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaCorrente novaConta = telaContaCorrente.ContaCorrente;

            this.repositorioContaCorrente.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta corrente do titular: \"{novaConta.Titular.Nome}\" foi criada com sucesso!");
        }

        public override void Editar()
        {
            TelaContaCorrenteForm telaContaCorrente = new TelaContaCorrenteForm();

            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma conta selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaContaCorrente.ContaCorrente = contaSelecionada;

            DialogResult resultado = telaContaCorrente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaCorrente contaEditada = telaContaCorrente.ContaCorrente;

            repositorioContaCorrente.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta corrente do titular: \"{contaSelecionada.Titular.Nome}\" foi editada com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaContaCorrente.ObterRegistroSelecionado();

            ContaCorrente contaSelecionada = repositorioContaCorrente.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma conta selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir a conta do titular:  \"{contaSelecionada.Titular.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioContaCorrente.Excluir(contaSelecionada.Id);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta corrente do titular: \"{contaSelecionada.Titular.Nome}\" foi excluida com sucesso!");
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
            List<ContaCorrente> disciplina = this.repositorioContaCorrente.SelecionarTodos();

            tabelaContaCorrente.AtualizarRegistros(disciplina);
        }
    }
}
