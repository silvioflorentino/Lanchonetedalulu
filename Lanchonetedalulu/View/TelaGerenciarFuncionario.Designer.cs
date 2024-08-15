namespace Lanchonetedalulu.View
{
    partial class TelaGerenciarFuncionario
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
            dataGridViewFuncionario = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            tbxNomeFuncionario = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(49, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 344);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewFuncionario);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(tbxNomeFuncionario);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(664, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionario
            // 
            dataGridViewFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionario.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, Fone, Email });
            dataGridViewFuncionario.Location = new Point(38, 111);
            dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            dataGridViewFuncionario.Size = new Size(539, 150);
            dataGridViewFuncionario.TabIndex = 3;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Fone
            // 
            Fone.HeaderText = "Fone";
            Fone.Name = "Fone";
            // 
            // Email
            // 
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(38, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbxNomeFuncionario
            // 
            tbxNomeFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNomeFuncionario.Location = new Point(38, 38);
            tbxNomeFuncionario.Name = "tbxNomeFuncionario";
            tbxNomeFuncionario.Size = new Size(463, 29);
            tbxNomeFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 18);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome do Funcionário";
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
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
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
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox6.Location = new Point(444, 87);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 33);
            textBox6.TabIndex = 18;
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
            button3.Click += button3_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(384, 90);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 14;
            label8.Text = "Fone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(35, 139);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 8;
            label6.Text = "E-mail:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox5.Location = new Point(123, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(436, 33);
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
            textBox4.Location = new Point(125, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 33);
            textBox4.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(427, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(272, 28);
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
            label3.Size = new Size(226, 21);
            label3.TabIndex = 3;
            label3.Text = "Digite o Código do Funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 19);
            label1.Name = "label1";
            label1.Size = new Size(277, 30);
            label1.TabIndex = 3;
            label1.Text = "Manipulando Funcionários";
            // 
            // TelaGerenciarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(773, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciarFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimenticios - SGPA";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).EndInit();
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
        private DataGridView dataGridViewFuncionario;
        private Button btnBuscar;
        private TextBox tbxNomeFuncionario;
        private Label label2;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn Email;
        private TextBox textBox6;
    }
}