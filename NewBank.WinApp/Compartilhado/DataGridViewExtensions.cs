namespace NewBank.WinApp.Compartilhado
{
    public static class DataGridViewExtensions
    {
        public static void ConfigurarGridZebrado(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(57, 62, 70),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(0, 173, 181),
                SelectionBackColor = Color.FromArgb(0, 173, 181),
                SelectionForeColor = Color.FromArgb(238, 238, 238)
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(238, 238, 238),
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(0, 173, 181),
                SelectionBackColor = Color.FromArgb(0, 173, 181),
                SelectionForeColor = Color.FromArgb(238, 238, 238)
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;
            grid.RowHeadersVisible = false;
        }

        public static int SelecionarId(this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            object valorSelecionado = grid
                .SelectedRows[0]
                .Cells[0]
                .Value;

            if (valorSelecionado == null)
                return -1;

            return (int)valorSelecionado;
        }
    }
}
