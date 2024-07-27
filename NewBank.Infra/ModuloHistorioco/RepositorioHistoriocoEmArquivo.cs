using NewBank.Dominio.ModuloHistorioco;
using NewBank.Infra.Compartilhado;

namespace NewBank.Infra.ModuloHistorioco
{
    public class RepositorioHistoriocoEmArquivo : RepositorioBaseEmArquivo<Historioco>, IRepositorioHistorioco
    {
        public RepositorioHistoriocoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Historioco> ObterRegistros()
        {
            return contexto.Historiocos;
        }
    }
}
