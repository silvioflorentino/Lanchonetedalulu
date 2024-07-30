namespace Lanchonetedalulu.View
{
    partial class TelaADM
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            manipularToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            manipularToolStripMenuItem1 = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem2 = new ToolStripMenuItem();
            manipularToolStripMenuItem2 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, produtosToolStripMenuItem, clienteToolStripMenuItem, funcionarioToolStripMenuItem, pDVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, manipularToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(128, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // manipularToolStripMenuItem
            // 
            manipularToolStripMenuItem.Name = "manipularToolStripMenuItem";
            manipularToolStripMenuItem.Size = new Size(128, 22);
            manipularToolStripMenuItem.Text = "Manipular";
            manipularToolStripMenuItem.Click += manipularToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, manipularToolStripMenuItem1 });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(180, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // manipularToolStripMenuItem1
            // 
            manipularToolStripMenuItem1.Name = "manipularToolStripMenuItem1";
            manipularToolStripMenuItem1.Size = new Size(180, 22);
            manipularToolStripMenuItem1.Text = "Manipular";
            manipularToolStripMenuItem1.Click += manipularToolStripMenuItem1_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem2, manipularToolStripMenuItem2 });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(82, 20);
            funcionarioToolStripMenuItem.Text = "Funcionário";
            // 
            // cadastrarToolStripMenuItem2
            // 
            cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            cadastrarToolStripMenuItem2.Size = new Size(128, 22);
            cadastrarToolStripMenuItem2.Text = "Cadastrar";
            cadastrarToolStripMenuItem2.Click += cadastrarToolStripMenuItem2_Click;
            // 
            // manipularToolStripMenuItem2
            // 
            manipularToolStripMenuItem2.Name = "manipularToolStripMenuItem2";
            manipularToolStripMenuItem2.Size = new Size(128, 22);
            manipularToolStripMenuItem2.Text = "Manipular";
            manipularToolStripMenuItem2.Click += manipularToolStripMenuItem2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(41, 20);
            pDVToolStripMenuItem.Text = "PDV";
            pDVToolStripMenuItem.Click += pDVToolStripMenuItem_Click_1;
            // 
            // TelaADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "TelaADM";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimenticios - SGPA";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem manipularToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem manipularToolStripMenuItem1;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem2;
        private ToolStripMenuItem manipularToolStripMenuItem2;
        private ToolStripMenuItem pDVToolStripMenuItem;
    }
}