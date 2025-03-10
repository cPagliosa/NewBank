﻿using NewBank.WinApp.Compartilhado;
using NewBank.Dominio.ModuloContaSalario;
using NewBank.Dominio.Resources;

namespace NewBank.WinApp.ModuloContaSalario
{
    public partial class TabelaContaSalario : UserControl
    {
        public TabelaContaSalario()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<ContaSalario> contas)
        {
            grid.Rows.Clear();

            foreach (ContaSalario i in contas)
                grid.Rows.Add(i.Id, i.Titular.Nome, i.Numero, i.Saldo);
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
            };
        }
    }
}
