using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloHistorioco
{
    public class ControladorHistorioco : ControladorBase
    {
        public override string TipoCadastro { get; }
        public override string ToolTipAdicionar { get; }
        public override string ToolTipEditar { get; }
        public override string ToolTipExcluir { get; }
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
    }
}
