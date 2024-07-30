namespace NewBank.WinApp.ModuloContaPoupanca
{
    partial class TelaContaPoupancaForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtTaxa = new TextBox();
            lblTaxa = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 62, 70);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtEndereco);
            panel1.Controls.Add(lblEndereco);
            panel1.Controls.Add(txtTaxa);
            panel1.Controls.Add(lblTaxa);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 406);
            panel1.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(320, 345);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(467, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(238, 238, 238);
            txtEndereco.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.FromArgb(0, 173, 181);
            txtEndereco.Location = new Point(136, 163);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(461, 39);
            txtEndereco.TabIndex = 0;
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
            // txtTaxa
            // 
            txtTaxa.BackColor = Color.FromArgb(238, 238, 238);
            txtTaxa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTaxa.ForeColor = Color.FromArgb(0, 173, 181);
            txtTaxa.Location = new Point(136, 282);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(152, 39);
            txtTaxa.TabIndex = 0;
            // 
            // lblTaxa
            // 
            lblTaxa.AutoSize = true;
            lblTaxa.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxa.ForeColor = Color.FromArgb(0, 173, 181);
            lblTaxa.Location = new Point(60, 285);
            lblTaxa.Name = "lblTaxa";
            lblTaxa.Size = new Size(70, 32);
            lblTaxa.TabIndex = 0;
            lblTaxa.Text = "Taxa";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(238, 238, 238);
            txtNumero.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero.ForeColor = Color.FromArgb(0, 173, 181);
            txtNumero.Location = new Point(231, 224);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(219, 39);
            txtNumero.TabIndex = 0;
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
            // TelaContaPoupancaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(655, 427);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContaPoupancaForm";
            Text = "TelaContaPoupancaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtTaxa;
        private Label lblTaxa;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtId;
        private Label label1;
    }
}