﻿using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.ModuloConta;
using NewBank.Dominio.ModuloContaSalario;

namespace NewBank.WinApp.ModuloContaSalario
{
    public partial class TelaContaSalarioForm : Form
    {
        private List<string> erros;
        private ContaSalario contaSalario;

        public ContaSalario ContaSalario
        {
            set
            {
                this.txtId.Text = value.Id.ToString();
                this.txtNome.Text = value.Titular.Nome;
                this.txtEndereco.Text = value.Titular.Endereco;
                this.txtNumero.Text = value.Numero.ToString();
            }
            get
            {
                return this.contaSalario;
            }
        }
        public TelaContaSalarioForm()
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
            contaSalario = new ContaSalario(
                titular,
                Convert.ToInt32(this.txtNumero.Text)
            );

            this.erros = contaSalario.Validar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
