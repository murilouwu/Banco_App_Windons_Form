using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBdMuriloGimenez
{
    public partial class frmCadProd : Form
    {
        //tbProduto
        public frmCadProd()
        {
            InitializeComponent();
        }
        private void frmCadProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);
            Desabilitar();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //btns
            var btnP = button1;
            var btn0 = BtnNewProd; //btn novo
            var btn1 = BtnSaveProd; //btn save
            //text
            var txt0 = nm_produtoTextBox;
            var txt1 = sg_unidadeTextBox;
            var txt2 = vl_precoTextBox;
            var txt3 = vl_sellTextBox;
            var txt4 = qt_estoqueTextBox;

            btnP.Enabled = false;
            int num = 0;
            for (int i = 0; i < 50; i++)
            {
                int nlv = i < 10 ? i : (i - (10 * num));
                btn0.PerformClick();
                txt0.Text = i.ToString() + "--NameProduct";
                txt1.Text = nlv.ToString();
                txt2.Text = i.ToString();
                txt3.Text = i.ToString();
                txt4.Text = i.ToString();
                btn1.PerformClick();
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49)
                {
                    num += 1;
                }
            };
        }
        private void BtnAnteriorProd_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void BtnProsimoProd_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void BtnNewProd_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.AddNew();
            Habilitar();
        }

        private void BtnAlterProd_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void BtnExcluirProd_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.RemoveCurrent();
            tbProdutoTableAdapter.Update(bdCadastroDataSet.tbProduto);
        }

        private void BtnSaveProd_Click(object sender, EventArgs e)
        {
            Validate();
            tbProdutoBindingSource.EndEdit();
            tbProdutoTableAdapter.Update(bdCadastroDataSet.tbProduto);
            Desabilitar();
        }

        private void BtnCancelProd_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
            Desabilitar();
        }

        private void BtnPesProd_Click(object sender, EventArgs e)
        {
            int cod = 0, reg = 0;
            FrmSearchProd frm = new FrmSearchProd();
            frm.ShowDialog();
            cod = frm.getCodigo();
            if (cod > 0)
            {
                reg = tbProdutoBindingSource.Find("cd_produto", cod);
                tbProdutoBindingSource.Position = reg;
            }
        }

        private void BtnPrintProd_Click(object sender, EventArgs e)
        {
            PpdDadosProdutoView.ShowDialog();
        }
            private void PdocDadosProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //texto para imprimir
                string strDados;
                //titulo
                string titulo = "-------------  FICHA DE PRODUTO  -------------" + (char)10 + (char)10 + (char)10 + (char)10;
                //dados
                string[] dados = new string[6] { cd_produtoTextBox.Text, nm_produtoTextBox.Text, sg_unidadeTextBox.Text, vl_precoTextBox.Text, vl_sellTextBox.Text, qt_estoqueTextBox.Text};

                //blocos para colocar textos
                string[] label = new string[6] { "Código: " + dados[0], "Nome: " + dados[1], "Unidade: " + dados[2], "Custo: " + dados[3], "Venda: " + dados[4], "Estoque: " + dados[5] };

                //gravar texto na variavel
                strDados = titulo + label[0] + (char)10 + (char)10 + label[1] + (char)10 + (char)10 + label[2] + (char)10 + (char)10 + label[3] + (char)10 + (char)10 + label[4] + (char)10 + (char)10 + label[5];

                //definir obj para impressão
                Graphics objImpressao = e.Graphics;

                //mostrar
                objImpressao.DrawString(strDados, new Font("Hobo Std", 15, FontStyle.Bold), Brushes.Black, 50, 50);
            }

        private void BtnExitProd_Click(object sender, EventArgs e)
        {
            Sair();
        }

        //funções
        public void Habilitar()
        {
            //desabilitar Botoes
            BtnAnteriorProd.Enabled = false;
            BtnProsimoProd.Enabled = false;
            BtnNewProd.Enabled = false;
            BtnAlterProd.Enabled = false;
            BtnExcluirProd.Enabled = false;
            BtnPesProd.Enabled = false;
            BtnPrintProd.Enabled = false;
            BtnExitProd.Enabled = false;

            //Habilitar textBox
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = true;
            sg_unidadeTextBox.Enabled = true;
            vl_precoTextBox.Enabled = true;
            vl_sellTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = false;

            //Habilitar Botoes
            BtnSaveProd.Enabled = true;
            BtnCancelProd.Enabled = true;
        }
        public void Desabilitar()
        {
            //habilitar Botoes
            BtnAnteriorProd.Enabled = true;
            BtnProsimoProd.Enabled = true;
            BtnNewProd.Enabled = true;
            BtnPrintProd.Enabled = true;
            BtnPesProd.Enabled = true;
            BtnAlterProd.Enabled = true;
            BtnExcluirProd.Enabled = true;
            BtnExitProd.Enabled = true;

            //desabilitar textBox
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            sg_unidadeTextBox.Enabled = false;
            vl_precoTextBox.Enabled = false;
            vl_sellTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;

            //desabilitar Botoes
            BtnSaveProd.Enabled = false;
            BtnCancelProd.Enabled = false;
        }
        public void Sair()
        {
            //definisões de texto
            string text = "Certeza absoluta que deseja sair";
            string titulo = "Sair";
            //MessageBox
            var result = MessageBox.Show(text, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //fechar caso escolha o botão Yes
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        //input number simulado :)
        private void vl_precoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void vl_sellTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void qt_estoqueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
