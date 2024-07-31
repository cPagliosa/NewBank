using NewBank.Dominio.ModuloHistorioco;
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloHistorioco
{
    public class ControladorHistorioco : ControladorBase
    {
        private Historioco historioco;
        private TabelaHistorico tabelaHistorico;

        public override string TipoCadastro { get { return "Historioco"; } }
        public override string ToolTipAdicionar { get { return ""; } }
        public override string ToolTipEditar { get { return ""; } }
        public override string ToolTipExcluir { get { return ""; } }

        public ControladorHistorioco(Historioco historioco)
        {
            this.historioco = historioco;
        }
        public override UserControl ObterListagem()
        {
            if (tabelaHistorico == null)
                tabelaHistorico = new TabelaHistorico();
            CarregarDadosTabela();

            return tabelaHistorico;
        }

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Historioco()
        {
            throw new NotImplementedException();
        }

        public override void Operacao()
        {
            throw new NotImplementedException();
        }

        private void CarregarDadosTabela()
        {
            List<Operacao> disciplina = this.historioco.Operacoes;

            tabelaHistorico.AtualizarRegistros(disciplina);
        }
    }
}
