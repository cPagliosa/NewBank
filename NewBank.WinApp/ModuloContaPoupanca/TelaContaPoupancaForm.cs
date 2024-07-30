using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloConta;
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
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Titular.Nome;
                this.txtEndereco.Text = value.Titular.Endereco;
                this.txtNumero.Text = value.Numero.ToString();
                this.txtTaxa.Text = value.Taxa.ToString();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.EntradaDados();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                this.txtNome.Text = null;
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void EntradaDados()
        {
            Titular titular = new Titular(
                this.txtNome.Text,
                this.txtEndereco.Text
            );
            contaPoupanca = new ContaPoupanca(
                titular,
                Convert.ToInt32(this.txtNumero.Text),
                Convert.ToDecimal(this.txtTaxa.Text)
            );

            this.erros = contaPoupanca.Validar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
