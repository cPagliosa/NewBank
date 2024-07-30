
namespace Gerador_de_Testes.ModoloDisciplina
{
    partial class TelaDisciplinaForm
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
            txtNome = new TextBox();
            label2 = new Label();
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
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 297);
            panel1.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(0, 173, 181);
            btnGravar.Location = new Point(484, 236);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 48);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(0, 173, 181);
            btnCancelar.Location = new Point(631, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(238, 238, 238);
            txtNome.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(0, 173, 181);
            txtNome.Location = new Point(273, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 39);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 173, 181);
            label2.Location = new Point(28, 137);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 0;
            label2.Text = "Nome da Disciplina";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(238, 238, 238);
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(0, 173, 181);
            txtId.Location = new Point(71, 41);
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
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 319);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaDisciplinaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private Button btnCancelar;
        private Button btnGravar;
    }
}