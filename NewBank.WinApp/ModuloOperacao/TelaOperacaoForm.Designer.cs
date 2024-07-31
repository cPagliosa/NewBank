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
            lblTitulo = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            btnConta = new Button();
            bntDepositar = new Button();
            btnSacar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(btnConta);
            panel1.Controls.Add(bntDepositar);
            panel1.Controls.Add(btnSacar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 264);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 173, 181);
            lblTitulo.Location = new Point(11, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 79);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = Color.FromArgb(0, 173, 181);
            lblValor.Location = new Point(11, 124);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(69, 32);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(238, 238, 238);
            txtValor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValor.ForeColor = Color.FromArgb(0, 173, 181);
            txtValor.Location = new Point(85, 121);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(391, 39);
            txtValor.TabIndex = 1;
            // 
            // btnConta
            // 
            btnConta.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConta.ForeColor = Color.FromArgb(0, 173, 181);
            btnConta.Location = new Point(11, 206);
            btnConta.Name = "btnConta";
            btnConta.Size = new Size(172, 45);
            btnConta.TabIndex = 0;
            btnConta.Text = "Pagar Online";
            btnConta.UseVisualStyleBackColor = true;
            btnConta.Click += btnConta_Click;
            // 
            // bntDepositar
            // 
            bntDepositar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDepositar.ForeColor = Color.FromArgb(0, 173, 181);
            bntDepositar.Location = new Point(202, 206);
            bntDepositar.Name = "bntDepositar";
            bntDepositar.Size = new Size(129, 45);
            bntDepositar.TabIndex = 0;
            bntDepositar.Text = "Depositar";
            bntDepositar.UseVisualStyleBackColor = true;
            bntDepositar.Click += bntDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacar.ForeColor = Color.FromArgb(0, 173, 181);
            btnSacar.Location = new Point(347, 206);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(129, 45);
            btnSacar.TabIndex = 0;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaOperacaoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSacar;
        private TextBox txtValor;
        private Button bntDepositar;
        private Label lblValor;
        private Label lblTitulo;
        private Button btnConta;
    }
}