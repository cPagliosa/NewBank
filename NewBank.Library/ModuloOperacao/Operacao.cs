using NewBank.Dominio.Compartilhado;
using NewBank.Dominio.ModuloConta;

namespace NewBank.Dominio.ModuloOperacao
{
    public class Operacao : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Conta Conta { get; set; }

        public Operacao() { }

        public Operacao(string descricao,decimal valor,DateTime data, Conta conta)
        {
            this.Descricao = descricao;
            this.Valor = valor;
            this.Data = data;
            this.Conta = conta;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Operacao nova = (Operacao)registroAtualizado;

            this.Descricao = nova.Descricao;
            this.Valor = nova.Valor;
            this.Data = nova.Data;
            this.Conta = nova.Conta;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (this.Descricao.Length == 0)
                erros.Add("O campo \\\"Titular\\\" é obrigatorio");

            if (Convert.ToString(this.Valor).Length == 0)
                erros.Add("O campo \\\"Numero\\\" é obrigatorio");

            if (Convert.ToString(this.Data).Length == 0)
                erros.Add("O campo \\\"Data\\\" é obrigatorio");
            
            if (this.Conta == null)
                erros.Add("O campo \\\"Conta\\\" é obrigatorio");

            return erros;
        }
    }
}
