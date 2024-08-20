using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {

        Double total;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            //entrada
            double Quantidade = double.Parse(txtQuantidade.Text);
            double VlrUnitario = double.Parse(txtValorUn.Text);

            //processamento
            total += Quantidade * VlrUnitario;

            //saída
            lblTotal.Text = total.ToString("C");

            //insere os produtos na listbox
            listBox1.Items.Add(txtProduto.Text + " / " + txtQuantidade.Text + " / " + VlrUnitario.ToString("C"));
        }

        private void NovaVenda_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            listBox1.ClearSelected();
            txtValorUn.Clear();
            txtQuantidade.Clear();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Produto_Click(object sender, EventArgs e)
        {

        }
    }
}
