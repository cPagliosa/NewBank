using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Infra.Compartilhado;

namespace NewBank.Infra.ModuloContaPoupanca
{
    public class RepositorioContaPoupancaEmArquivo : RepositorioBaseEmArquivo<ContaPoupanca>, IRepositorioContaPoupanca
    {
        public RepositorioContaPoupancaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<ContaPoupanca> ObterRegistros()
        {
            return contexto.ContasPoupancas;
        }
    }
}
