using NewBank.Dominio.ModuloContaSalario;
using NewBank.Infra.Compartilhado;

namespace NewBank.Infra.ModuloContaSalario
{
    public class RepositorioContaSalarioEmArquivo : RepositorioBaseEmArquivo<ContaSalario>, IRepositorioContaSalario
    {
        public RepositorioContaSalarioEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<ContaSalario> ObterRegistros()
        {
            return contexto.ContasSalarios;
        }
    }
}
