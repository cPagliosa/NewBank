using NewBank.Dominio.ModuloContaPoupanca;

namespace NewBank.WinApp.ModuloContaPoupanca
{
    public partial class TelaContaPoupancaForm : Form
    {
        private List<string> erros;
        private ContaPoupanca contaPoupanca;

        public ContaPoupanca ContaPoupanca
        {
            set
            {

            }
            get
            {
                return this.contaPoupanca;
            }
        }
        public TelaContaPoupancaForm()
        {
            InitializeComponent();
        }
    }
}
