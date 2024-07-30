using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloHistorioco
{
    public partial class TabelaHistorico : UserControl
    {
        public TabelaHistorico()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Operacao> Operacoes)
        {
            grid.Rows.Clear();

            foreach (Operacao i in Operacoes)
                grid.Rows.Add(i.Id, i.Data,i.Descricao,i.Valor);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
            };
        }
    }
}
