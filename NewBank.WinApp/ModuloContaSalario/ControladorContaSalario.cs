
using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;
using NewBank.WinApp.ModuloContaCorrente;

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
            List<ContaSalario> disciplina = this.repositorioContaSalario.SelecionarTodos();

            tabelaContaSalario.AtualizarRegistros(disciplina);
        }
    }
}
