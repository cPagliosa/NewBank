using iTextSharp.text;
using iTextSharp.text.pdf;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloHistorioco
{
    public partial class TelaHistoricoForm : Form
    {
        private Operacao operacao;

        public List<Operacao> Operacoes { get; set; }

        public TelaHistoricoForm()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Operacao> contas)
        {
            grid.Rows.Clear();
            foreach (Operacao i in contas)
                grid.Rows.Add(i.Conta.Numero, i.Data, i.Descricao, i.Valor, i.Conta.Saldo);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Conta", HeaderText = "Conta" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Decricao", HeaderText = "Decricão" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Saldo", HeaderText = "Saldo final" },
            };
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document extratoPdf = new Document(PageSize.A4);
            extratoPdf.SetMargins(40, 40, 40, 80);
            extratoPdf.AddCreationDate();

            this.GerarPdf(extratoPdf);
        }

        private void GerarPdf(Document doc)
        {
            this.operacao = Operacoes[0];

            string caminho = @"C:\temp\NewBank\" + $"{operacao.Conta.Titular.Nome}_Extrato.pdf"; ;

            PdfWriter branco = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados);

            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;

            paragrafo.Add(this.extrato());

            doc.Add(paragrafo);

            doc.Close();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O extrato foi criado com sucesso! no local: {caminho}");
        }

        private string extrato()
        {
            string extrato = $"Extrato das contas do titular: {operacao.Conta.Titular.Nome}\nSaldo atual: {operacao.Conta.Saldo}\n\n";
            foreach (Operacao o in Operacoes)
            {
                extrato += $"*************************************************\n";
                extrato += $"Numero da conta: {o.Conta.Numero}\nData: {o.Data}\nDescrição: {o.Descricao}\nValor: {o.Valor}\n";
            }
            return extrato;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
