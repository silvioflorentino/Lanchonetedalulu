namespace Lanchonetedalulu.View
{
    partial class TelaCadastrarFuncionario
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
            btn_SalvarFuncionario = new Button();
            tbx_EmailFuncionario = new TextBox();
            tbx_FoneFuncionario = new TextBox();
            tbx_NomeFuncionario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_SalvarFuncionario
            // 
            btn_SalvarFuncionario.Location = new Point(33, 266);
            btn_SalvarFuncionario.Name = "btn_SalvarFuncionario";
            btn_SalvarFuncionario.Size = new Size(379, 68);
            btn_SalvarFuncionario.TabIndex = 18;
            btn_SalvarFuncionario.Text = "Salvar";
            btn_SalvarFuncionario.UseVisualStyleBackColor = true;
            // 
            // tbx_EmailFuncionario
            // 
            tbx_EmailFuncionario.Font = new Font("Segoe UI", 14.25F);
            tbx_EmailFuncionario.Location = new Point(96, 188);
            tbx_EmailFuncionario.Name = "tbx_EmailFuncionario";
            tbx_EmailFuncionario.Size = new Size(305, 33);
            tbx_EmailFuncionario.TabIndex = 17;
            // 
            // tbx_FoneFuncionario
            // 
            tbx_FoneFuncionario.Font = new Font("Segoe UI", 14.25F);
            tbx_FoneFuncionario.Location = new Point(96, 146);
            tbx_FoneFuncionario.Name = "tbx_FoneFuncionario";
            tbx_FoneFuncionario.Size = new Size(156, 33);
            tbx_FoneFuncionario.TabIndex = 16;
            // 
            // tbx_NomeFuncionario
            // 
            tbx_NomeFuncionario.Font = new Font("Segoe UI", 14.25F);
            tbx_NomeFuncionario.Location = new Point(96, 97);
            tbx_NomeFuncionario.Name = "tbx_NomeFuncionario";
            tbx_NomeFuncionario.Size = new Size(305, 33);
            tbx_NomeFuncionario.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(20, 196);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 14;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(20, 149);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 13;
            label3.Text = "Fone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 12;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 34);
            label1.Name = "label1";
            label1.Size = new Size(293, 32);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de Funcionário";
            // 
            // TelaCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 372);
            Controls.Add(btn_SalvarFuncionario);
            Controls.Add(tbx_EmailFuncionario);
            Controls.Add(tbx_FoneFuncionario);
            Controls.Add(tbx_NomeFuncionario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastrarFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimenticios - SGPA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_SalvarFuncionario;
        private TextBox tbx_EmailFuncionario;
        private TextBox tbx_FoneFuncionario;
        private TextBox tbx_NomeFuncionario;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}