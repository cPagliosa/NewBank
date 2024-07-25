using NewBank.Dominio.ModuloConta;

namespace NewBank.Dominio.ModoloContaCorrente
{
    public class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }

        public ContaCorrente() { }

        public ContaCorrente(Titular titular, int numero, decimal limite)
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Limite = limite;
            this.Saldo = 0;
        }

        public override bool sacar(decimal valor)
        {
            if (this.Saldo <= 0)
            {
                if (this.Limite > valor)
                {
                    this.Saldo -= valor;
                    return true;
                }
            }
            else if (this.Saldo - valor >= this.Saldo + this.Limite)
            {
                this.Saldo -= valor;
                return true;
            }

            return false;
            
        }

        public bool PagarOnline(decimal valor)
        {
            return this.sacar(valor);
        }
    }
}
