using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloConta;
using NewBank.Dominio.Resources;
using System;

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
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Titular.Nome;
                this.txtEndereco.Text = value.Titular.Endereco;
                this.txtNumero.Text = value.Numero.ToString();
                this.txtLimite.Text = value.Limite.ToString();
                
            }
            get
            {
                return this.contaCorrente;
            }
        }
        public TelaContaCorrenteForm()
        {
            InitializeComponent();
            LocalizeForm();
        }

        private void LocalizeForm()
        {
            // Defina textos localizados para os controles do formulário
            this.Text = Lingua.ContaCorrente;
            this.lblNome.Text = Lingua.Nome;
            this.lblEndereco.Text = Lingua.Endereco;
            this.lblLimite.Text = Lingua.Limite;
            this.lblNumero.Text = Lingua.Numero;
            this.btnCancelar.Text = Lingua.Cancelar;
            this.btnGravar.Text = Lingua.Gravar;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.EntradaDados();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
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

            contaCorrente = new ContaCorrente(
                titular,
                Convert.ToInt32(this.txtNumero.Text),
                Convert.ToDecimal(this.txtLimite.Text)
                );

            this.erros = contaCorrente.Validar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
