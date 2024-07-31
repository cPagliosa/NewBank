namespace NewBank.WinApp.ModuloHistorioco
{
    partial class TelaHistoricoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnPdf = new Button();
            btnVoltar = new Button();
            grid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(btnPdf);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(grid);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnPdf
            // 
            btnPdf.FlatAppearance.BorderSize = 0;
            btnPdf.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.ForeColor = Color.FromArgb(0, 173, 181);
            btnPdf.Location = new Point(437, 365);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(151, 48);
            btnPdf.TabIndex = 6;
            btnPdf.Text = "Gerar pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(0, 173, 181);
            btnVoltar.Location = new Point(633, 365);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(130, 48);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Cancelar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // grid
            // 
            grid.BackgroundColor = Color.FromArgb(57, 62, 70);
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(3, 3);
            grid.Name = "grid";
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(770, 342);
            grid.TabIndex = 0;
            // 
            // TelaHistoricoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaHistoricoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaHistoricoForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grid;
        private Button btnPdf;
        private Button btnVoltar;
    }
}