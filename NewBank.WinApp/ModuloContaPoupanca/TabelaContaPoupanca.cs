﻿using NewBank.Dominio.ModoloContaCorrente;
using NewBank.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using NewBank.Dominio.ModuloContaPoupanca;
using NewBank.Dominio.Resources;

namespace NewBank.WinApp.ModuloContaPoupanca
{
    public partial class TabelaContaPoupanca : UserControl
    {
        public TabelaContaPoupanca()
        {
            InitializeComponent();

            this.grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<ContaPoupanca> contas)
        {
            grid.Rows.Clear();

            foreach (ContaPoupanca i in contas)
                grid.Rows.Add(i.Id, i.Titular.Nome, i.Numero, i.Saldo,i.Taxa);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Taxa", HeaderText = Lingua.Taxa },
            };
        }
    }
}
