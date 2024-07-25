using NewBank.Dominio.ModuloConta;

namespace NewBank.Dominio.ModuloContaSalario
{
    public class ContaSalario : Conta
    {
        public ContaSalario() { }

        public ContaSalario(Titular titular, int numero)
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Saldo = 0;
        }
    }
}
