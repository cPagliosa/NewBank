using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.ModuloOperacao;

namespace NewBank.WinApp.ModuloOperacao
{
    public partial class TelaOperacaoForm : Form
    {
        private ContaCorrente corrente;
        private ContaSalario salario;
        private ContaPoupanca poupanca;
        private Operacao operacao;
        private int tipo;

        public Operacao Operacao
        {
            get
            {
                return this.operacao;
            }
        }

        public ContaCorrente Corrente
        {
            get
            {
                return this.corrente;
            }
        }

        public ContaSalario Salario
        {
            get
            {
                return this.salario;
            }
        }

        ContaPoupanca Poupanca
        {
            get
            {
                return this.poupanca;
            }
        }

        public TelaOperacaoForm(ContaCorrente corrente, ContaSalario salario, ContaPoupanca poupanca, int tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
            this.corrente = corrente;
            this.salario = salario;
            this.poupanca = poupanca;

            if (this.tipo == 2)
                this.btnConta.Visible = false;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (!this.Sacar())
            {
                DialogResult = DialogResult.None;
                return;
            }
            this.Extrato("Sacar");
            DialogResult = DialogResult.OK;

        }

        private void bntDepositar_Click(object sender, EventArgs e)
        {
            if (!this.Depositar())
            {
                DialogResult = DialogResult.None;
                return;
            }
            this.Extrato("Deposito");
            DialogResult = DialogResult.OK;
        }
        
        private void btnConta_Click(object sender, EventArgs e)
        {
            if (!this.Depositar())
            {
                DialogResult = DialogResult.None;
                return;
            }
            this.Extrato("Pagamento online");
            DialogResult = DialogResult.OK;
        }

        private bool Sacar()
        {
            switch (tipo)
            {
                case 1:
                    if (this.corrente.sacar(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
                case 2:
                    if (this.salario.sacar(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
                case 3:
                    if (this.poupanca.sacar(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
            }

            return false;
        }

        private bool Depositar()
        {
            switch (tipo)
            {
                case 1:
                    if (this.corrente.depositar(Convert.ToDecimal(this.txtValor.Text)))
                    {

                        return true;
                    }


                    return false;
                case 2:
                    if (this.salario.depositar(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
                case 3:
                    if (this.poupanca.depositar(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
            }

            return false;
        }

        private bool PagarOnline()
        {
            switch (tipo)
            {
                case 1:
                    if (this.corrente.PagarOnline(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
                case 2:
                    break;
                case 3:
                    if (this.poupanca.PagarOnline(Convert.ToDecimal(this.txtValor.Text)))
                        return true;

                    return false;
            }

            return false;
        }

        private void Extrato(string decricao)
        {
            switch (tipo)
            {
                case 1:
                    Operacao operacao1 = new Operacao(decricao, Convert.ToDecimal(this.txtValor.Text), DateTime.Now, corrente);
                    this.operacao = operacao1;
                    break;
                case 2:
                    Operacao operacao2 = new Operacao(decricao, Convert.ToDecimal(this.txtValor.Text), DateTime.Now, salario);
                    this.operacao = operacao2;
                    break;
                case 3:
                    Operacao operacao3 = new Operacao(decricao, Convert.ToDecimal(this.txtValor.Text), DateTime.Now, poupanca);
                    this.operacao = operacao3;
                    break;
            }
        }
    }
    }

