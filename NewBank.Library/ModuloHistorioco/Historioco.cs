using NewBank.Dominio.Compartilhado;
using NewBank.Dominio.ModuloConta;
using NewBank.Dominio.ModuloOperacao;

namespace NewBank.Dominio.ModuloHistorioco
{
    public class Historioco : EntidadeBase
    {
        public Titular Titular { get; set; }
        public List<Operacao> Operacoes { get; set; }

        public Historioco() { }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Historioco novo = (Historioco)registroAtualizado;

            this.Titular = novo.Titular;
            this.Operacoes = novo.Operacoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (this.Titular == null)
                erros.Add("O campo \\\"Titular\\\" é obrigatorio");

            return erros;
        }
    }
}
