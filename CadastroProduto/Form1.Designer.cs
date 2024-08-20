namespace CadastroProduto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produto = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.VlrUnitario = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorUn = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.TotalVenda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.NovaVenda = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(293, 77);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(47, 13);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "Produto:";
            this.Produto.Click += new System.EventHandler(this.Produto_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(293, 129);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(65, 13);
            this.Quantidade.TabIndex = 1;
            this.Quantidade.Text = "Quantidade:";
            // 
            // VlrUnitario
            // 
            this.VlrUnitario.AutoSize = true;
            this.VlrUnitario.Location = new System.Drawing.Point(293, 178);
            this.VlrUnitario.Name = "VlrUnitario";
            this.VlrUnitario.Size = new System.Drawing.Size(73, 13);
            this.VlrUnitario.TabIndex = 2;
            this.VlrUnitario.Text = "Valor Unitário:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(372, 74);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(160, 20);
            this.txtProduto.TabIndex = 3;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(372, 126);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtValorUn
            // 
            this.txtValorUn.Location = new System.Drawing.Point(372, 175);
            this.txtValorUn.Name = "txtValorUn";
            this.txtValorUn.Size = new System.Drawing.Size(120, 20);
            this.txtValorUn.TabIndex = 5;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(386, 217);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(80, 41);
            this.Inserir.TabIndex = 6;
            this.Inserir.Text = "Inserir Produto";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // TotalVenda
            // 
            this.TotalVenda.AutoSize = true;
            this.TotalVenda.Location = new System.Drawing.Point(293, 464);
            this.TotalVenda.Name = "TotalVenda";
            this.TotalVenda.Size = new System.Drawing.Size(82, 13);
            this.TotalVenda.TabIndex = 9;
            this.TotalVenda.Text = "Total da venda:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(450, 464);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(452, 493);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(80, 41);
            this.Fechar.TabIndex = 11;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // NovaVenda
            // 
            this.NovaVenda.Location = new System.Drawing.Point(317, 493);
            this.NovaVenda.Name = "NovaVenda";
            this.NovaVenda.Size = new System.Drawing.Size(80, 41);
            this.NovaVenda.TabIndex = 12;
            this.NovaVenda.Text = "Nova venda";
            this.NovaVenda.UseVisualStyleBackColor = true;
            this.NovaVenda.Click += new System.EventHandler(this.NovaVenda_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(296, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 160);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 606);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NovaVenda);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.TotalVenda);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.txtValorUn);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.VlrUnitario);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Produto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Label VlrUnitario;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorUn;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Label TotalVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button NovaVenda;
        private System.Windows.Forms.ListBox listBox1;
    }
}

