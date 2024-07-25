using System.ComponentModel;
using NewBank.Dominio.Compartilhado;

namespace NewBank.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public int Numero { get; set; }

        public Titular Titular { get; set; }

        public decimal Saldo { get; set; }

        public Conta() { }

        public Conta(int numero, Titular titular, decimal saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public Conta(int numero, Titular titular)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = 0;
        }

        public virtual bool sacar(decimal valor)
        {
            if (this.Saldo - valor >= 0)
            {
                this.Saldo -= valor;
                return true;
            }
            else 
                return false;
        }

        public bool depositar(decimal valor)
        {
            this.Saldo += valor;
            return true;
        }
        
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta nova = (Conta)registroAtualizado;

            this.Numero = nova.Numero;
            this.Titular = nova.Titular;
            this.Saldo = nova.Saldo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if(this.Titular == null)
                erros.Add("O campo \\\"Titular\\\" é obrigatorio");

            if (Convert.ToString(this.Numero).Length < 3)
                erros.Add("O campo \\\"Numero\\\" necessita de ao menos 3 caractere");

            return erros;
        }
    }
}
