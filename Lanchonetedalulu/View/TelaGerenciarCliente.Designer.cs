namespace Lanchonetedalulu.View
{
    partial class TelaGerenciarCliente
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(26, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 344);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(664, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Cliente, Fone, CPF });
            dataGridView1.Location = new Point(38, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Fone
            // 
            Fone.HeaderText = "Fone";
            Fone.Name = "Fone";
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // button1
            // 
            button1.Location = new Point(38, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 18);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome do Cliente";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(664, 316);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar & Excluir";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(17, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 232);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado da Pesquisa:";
            // 
            // button4
            // 
            button4.Location = new Point(524, 190);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(443, 190);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(35, 44);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Código:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(35, 90);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 7;
            label5.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(35, 139);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 8;
            label6.Text = "Fone:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox6.Location = new Point(339, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 33);
            textBox6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(292, 133);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 9;
            label7.Text = "CPF:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox5.Location = new Point(123, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 33);
            textBox5.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(123, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 33);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox4.Location = new Point(123, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(407, 33);
            textBox4.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(390, 31);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(243, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 29);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 34);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 3;
            label3.Text = "Digite o Código do Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 25);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 3;
            label1.Text = "Manipulando Clientes";
            // 
            // TelaGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(731, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimenticios - SGPA";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn CPF;
    }
}