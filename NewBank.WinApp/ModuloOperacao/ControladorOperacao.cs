
using NewBank.Dominio.ModuloOperacao;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloOperacao
{
    public class ControladorOperacao : ControladorBase

    {
        public override string TipoCadastro { get; }
        public override string ToolTipAdicionar { get; }
        public override string ToolTipEditar { get; }
        public override string ToolTipExcluir { get; }

        public ControladorOperacao(IRepositorioOperacao repositorioOperacao)
        {
            
        }
        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
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

        public override void PDF()
        {
            throw new NotImplementedException();
        }

        public override void Operacao()
        {
            throw new NotImplementedException();
        }
    }
}
