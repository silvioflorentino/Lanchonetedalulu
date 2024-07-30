namespace Lanchonetedalulu.View
{
    partial class TelaCadastrarCliente
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
            label1 = new Label();
            btn_SalvarCliente = new Button();
            tbx_CPFCliente = new TextBox();
            tbx_FoneCliente = new TextBox();
            tbx_NomeCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 29);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de Cliente";
            // 
            // btn_SalvarCliente
            // 
            btn_SalvarCliente.Location = new Point(56, 249);
            btn_SalvarCliente.Name = "btn_SalvarCliente";
            btn_SalvarCliente.Size = new Size(379, 68);
            btn_SalvarCliente.TabIndex = 25;
            btn_SalvarCliente.Text = "Salvar";
            btn_SalvarCliente.UseVisualStyleBackColor = true;
            // 
            // tbx_CPFCliente
            // 
            tbx_CPFCliente.Font = new Font("Segoe UI", 14.25F);
            tbx_CPFCliente.Location = new Point(119, 171);
            tbx_CPFCliente.Name = "tbx_CPFCliente";
            tbx_CPFCliente.Size = new Size(214, 33);
            tbx_CPFCliente.TabIndex = 24;
            // 
            // tbx_FoneCliente
            // 
            tbx_FoneCliente.Font = new Font("Segoe UI", 14.25F);
            tbx_FoneCliente.Location = new Point(119, 129);
            tbx_FoneCliente.Name = "tbx_FoneCliente";
            tbx_FoneCliente.Size = new Size(156, 33);
            tbx_FoneCliente.TabIndex = 23;
            // 
            // tbx_NomeCliente
            // 
            tbx_NomeCliente.Font = new Font("Segoe UI", 14.25F);
            tbx_NomeCliente.Location = new Point(119, 80);
            tbx_NomeCliente.Name = "tbx_NomeCliente";
            tbx_NomeCliente.Size = new Size(305, 33);
            tbx_NomeCliente.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(43, 179);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 21;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(43, 132);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 20;
            label3.Text = "Fone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
            // 
            // TelaCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(479, 396);
            Controls.Add(btn_SalvarCliente);
            Controls.Add(tbx_CPFCliente);
            Controls.Add(tbx_FoneCliente);
            Controls.Add(tbx_NomeCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastrarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimenticios - SGPA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_SalvarCliente;
        private TextBox tbx_CPFCliente;
        private TextBox tbx_FoneCliente;
        private TextBox tbx_NomeCliente;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}