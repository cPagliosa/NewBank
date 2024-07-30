using NewBank.Dominio.ModoloContaCorrente;

namespace NewBank.WinApp.ModuloContaCorrente
{
    public partial class TelaContaCorrenteForm : Form
    {
        private List<string> erros;
        private ContaCorrente contaCorrente;

        public ContaCorrente ContaCorrente
        {
            set
            {

            }
            get
            {
                return this.contaCorrente;
            }
        }
        public TelaContaCorrenteForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
