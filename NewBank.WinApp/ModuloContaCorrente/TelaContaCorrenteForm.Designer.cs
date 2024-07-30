namespace NewBank.WinApp.ModuloContaCorrente
{
    partial class TelaContaCorrenteForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            txtId = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtLimite = new TextBox();
            lblLimite = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(320, 345);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(467, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(238, 238, 238);
            txtNome.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(0, 173, 181);
            txtNome.Location = new Point(136, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(461, 39);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(0, 173, 181);
            lblNome.Location = new Point(46, 112);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(84, 32);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(238, 238, 238);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(0, 173, 181);
            txtId.Location = new Point(136, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 39);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 173, 181);
            label1.Location = new Point(93, 54);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtEndereco);
            panel1.Controls.Add(lblEndereco);
            panel1.Controls.Add(txtLimite);
            panel1.Controls.Add(lblLimite);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 406);
            panel1.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(238, 238, 238);
            txtEndereco.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.FromArgb(0, 173, 181);
            txtEndereco.Location = new Point(136, 163);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(461, 39);
            txtEndereco.TabIndex = 1;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.ForeColor = Color.FromArgb(0, 173, 181);
            lblEndereco.Location = new Point(10, 166);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(120, 32);
            lblEndereco.TabIndex = 0;
            lblEndereco.Text = "Endereço";
            // 
            // txtLimite
            // 
            txtLimite.BackColor = Color.FromArgb(238, 238, 238);
            txtLimite.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLimite.ForeColor = Color.FromArgb(0, 173, 181);
            txtLimite.Location = new Point(136, 282);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(152, 39);
            txtLimite.TabIndex = 3;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimite.ForeColor = Color.FromArgb(0, 173, 181);
            lblLimite.Location = new Point(43, 285);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(87, 32);
            lblLimite.TabIndex = 0;
            lblLimite.Text = "Limite";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(238, 238, 238);
            txtNumero.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero.ForeColor = Color.FromArgb(0, 173, 181);
            txtNumero.Location = new Point(231, 224);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(219, 39);
            txtNumero.TabIndex = 2;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.FromArgb(0, 173, 181);
            lblNumero.Location = new Point(9, 224);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(216, 32);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero da conta";
            // 
            // TelaContaCorrenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(658, 430);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContaCorrenteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaContaCorrenteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtId;
        private Label label1;
        private Panel panel1;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtLimite;
        private Label lblLimite;
    }
}