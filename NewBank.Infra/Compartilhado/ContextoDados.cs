using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.Infra.Compartilhado.Extensoes;


namespace NewBank.Infra.Compartilhado
{
    public class ContextoDados
    {
        private string caminho = $"C:\\temp\\NewBank\\dados.json";

        public List<ContaCorrente> ContasCorrentes { get; set; }
        public List<ContaSalario> ContasSalarios { get; set; }
        public List<ContaPoupanca> ContasPoupancas { get; set; }
        public List<Operacao> Operacoes { get; set; }
        public List<Historioco> Historiocos { get; set; }

        public ContextoDados()
        {
            ContasCorrentes = new List<ContaCorrente>();
            ContasSalarios = new List<ContaSalario>();
            Operacoes = new List<Operacao>();
            ContasPoupancas = new List<ContaPoupanca>();
            Historiocos = new List<Historioco>();

        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Serializar(this, preservarReferencias: true);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            ContextoDados ctx = arquivo.Deserializar<ContextoDados>(preservarReferencias: true);

            if (ctx == null)
                return;

            ContasCorrentes = ctx.ContasCorrentes;
            ContasSalarios = ctx.ContasSalarios;
            ContasPoupancas = ctx.ContasPoupancas;
            Operacoes = ctx.Operacoes;
            Historiocos = ctx.Historiocos;
        }
    }
}
