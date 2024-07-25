using NewBank.Dominio.ModuloConta;
using System.ComponentModel;

namespace NewBank.Dominio.ModuloContaPoupanca
{
    public class ContaPoupanca : Conta
    {
        public decimal Taxa { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(Titular titular, int numero, decimal taxa)
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Taxa = taxa;
            this.Saldo = 0;
        }

        public bool PagarOnline(decimal valor)
        {
            return this.sacar(valor);
        }
    }
}
