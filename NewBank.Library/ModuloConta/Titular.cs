using NewBank.Dominio.Compartilhado;

namespace NewBank.Dominio.ModuloConta
{
    public class Titular : EntidadeBase
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Titular() { }

        public Titular(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Titular novo = (Titular)registroAtualizado;

            this.Nome = novo.Nome;
            this.Endereco = novo.Endereco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (this.Nome.Length < 3)
                erros.Add("O campo \\\"Nome\\\" necessita de ao menos 3 caractere");

            if(this.Endereco.Length < 3)
                erros.Add("O campo \\\"Endereço\\\" necessita de ao menos 3 caractere");

            return erros;
        }
    }
}
