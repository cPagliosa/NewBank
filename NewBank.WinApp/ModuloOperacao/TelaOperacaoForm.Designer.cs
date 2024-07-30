namespace NewBank.WinApp.ModuloOperacao
{
    partial class TelaOperacaoForm
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
            btnSacar = new Button();
            bntDepositar = new Button();
            textBox1 = new TextBox();
            lblValor = new Label();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(bntDepositar);
            panel1.Controls.Add(btnSacar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 264);
            panel1.TabIndex = 0;
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacar.ForeColor = Color.FromArgb(0, 173, 181);
            btnSacar.Location = new Point(347, 206);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(129, 45);
            btnSacar.TabIndex = 0;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // bntDepositar
            // 
            bntDepositar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDepositar.ForeColor = Color.FromArgb(0, 173, 181);
            bntDepositar.Location = new Point(202, 206);
            bntDepositar.Name = "bntDepositar";
            bntDepositar.Size = new Size(129, 45);
            bntDepositar.TabIndex = 0;
            bntDepositar.Text = "Depositar";
            bntDepositar.UseVisualStyleBackColor = true;
            bntDepositar.Click += bntDepositar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(238, 238, 238);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 173, 181);
            textBox1.Location = new Point(75, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 34);
            textBox1.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = Color.FromArgb(0, 173, 181);
            lblValor.Location = new Point(11, 124);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(58, 28);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 173, 181);
            lblTitulo.Location = new Point(11, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 79);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaOperacaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(517, 288);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaOperacaoForm";
            Text = "TelaOperacaoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSacar;
        private TextBox textBox1;
        private Button bntDepositar;
        private Label lblValor;
        private Label lblTitulo;
    }
}