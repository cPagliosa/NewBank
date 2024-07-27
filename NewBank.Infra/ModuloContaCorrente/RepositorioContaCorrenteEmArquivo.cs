using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaCorrente;
using NewBank.Infra.Compartilhado;

namespace NewBank.Infra.ModuloContaCorrente
{
    public class RepositorioContaCorrenteEmArquivo : RepositorioBaseEmArquivo<ContaCorrente>, IRepositorioContaCorrente
    {
        public RepositorioContaCorrenteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<ContaCorrente> ObterRegistros()
        {
            return contexto.ContasCorrentes;
        }
    }
}
