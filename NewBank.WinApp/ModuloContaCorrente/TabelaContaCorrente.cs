﻿using NewBank.Dominio.ModoloContaCorrente;
using NewBank.Dominio.Resources;
using NewBank.WinApp.Compartilhado;

namespace NewBank.WinApp.ModuloContaCorrente
{
    public partial class TabelaContaCorrente : UserControl
    {
        public TabelaContaCorrente()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<ContaCorrente> contas)
        {
            grid.Rows.Clear();

            foreach (ContaCorrente i in contas)
                grid.Rows.Add(i.Id, i.Titular.Nome, i.Numero,i.Saldo,i.Limite);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Titular", HeaderText = Lingua.Titular },
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = Lingua.Numero },
                new DataGridViewTextBoxColumn { DataPropertyName = "Saldo", HeaderText = Lingua.Saldo },
                new DataGridViewTextBoxColumn { DataPropertyName = "Limite", HeaderText = Lingua.Limite },
            };
        }
    }
}
