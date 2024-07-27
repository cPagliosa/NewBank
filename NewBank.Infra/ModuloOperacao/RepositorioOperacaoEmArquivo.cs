using NewBank.Dominio.ModuloOperacao;
using NewBank.Infra.Compartilhado;

namespace NewBank.Infra.ModuloOperacao
{
    public class RepositorioOperacaoEmArquivo : RepositorioBaseEmArquivo<Operacao>, IRepositorioOperacao
    {
        public RepositorioOperacaoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Operacao> ObterRegistros()
        {
            return contexto.Operacoes;
        }
    }
}
