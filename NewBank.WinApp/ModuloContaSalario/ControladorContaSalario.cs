
using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloContaCorrente;
using NewBank.WinApp.ModuloContaPoupanca;

namespace NewBank.WinApp.ModuloContaSalario
{
    public class ControladorContaSalario : ControladorBase
    {
        private IRepositorioContaSalario repositorioContaSalario;
        private IRepositorioHistorioco repositorioHistorioco;
        private TabelaContaSalario tabelaContaSalario;

        public override string TipoCadastro { get { return "Conta Salario"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar uma nova Conta Salario"; } }
        public override string ToolTipEditar { get { return "Editar uma Conta Salario"; } }
        public override string ToolTipExcluir { get { return "Excluir uma Conta Salario"; } }

        public ControladorContaSalario(IRepositorioContaSalario repositorioContaSalario, IRepositorioHistorioco repositorioHistorioco, IRepositorioOperacao repositorioOperacao)
        {
            this.repositorioContaSalario = repositorioContaSalario;
            this.repositorioHistorioco = repositorioHistorioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaContaSalario == null)
                tabelaContaSalario = new TabelaContaSalario();

            CarregarDadosTabela();

            return tabelaContaSalario;
        }

        public override void Adicionar()
        {
            TelaContaSalarioForm telaContaSalario = new TelaContaSalarioForm();

            DialogResult resultado = telaContaSalario.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaSalario novaConta = telaContaSalario.ContaSalario;

            this.repositorioContaSalario.Cadastrar(novaConta);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta salario do titular: \"{novaConta.Titular.Nome}\" foi criada com sucesso!");
        }

        public override void Editar()
        {
            TelaContaSalarioForm telaContaSalario = new TelaContaSalarioForm();

            int idSelecionado = tabelaContaSalario.ObterRegistroSelecionado();

            ContaSalario contaSelecionada = repositorioContaSalario.SelecionarPorId(idSelecionado);

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

            telaContaSalario.ContaSalario = contaSelecionada;

            DialogResult resultado = telaContaSalario.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            ContaSalario contaEditada = telaContaSalario.ContaSalario;

            repositorioContaSalario.Editar(contaSelecionada.Id, contaEditada);

            CarregarDadosTabela();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma conta salario do titular: \"{novaConta.Titular.Nome}\" foi editada com sucesso!");
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
            List<ContaSalario> disciplina = this.repositorioContaSalario.SelecionarTodos();

            tabelaContaSalario.AtualizarRegistros(disciplina);
        }
    }
}
