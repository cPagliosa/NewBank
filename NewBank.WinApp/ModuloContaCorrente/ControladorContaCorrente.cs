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
            throw new NotImplementedException();
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
            List<ContaCorrente> disciplina = this.repositorioContaCorrente.SelecionarTodos();

            tabelaContaCorrente.AtualizarRegistros(disciplina);
        }
    }
}
