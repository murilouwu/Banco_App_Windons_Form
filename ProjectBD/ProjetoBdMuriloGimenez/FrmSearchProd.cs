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
    public partial class FrmSearchProd : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
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
                codigo = 0;
            }
        }
        public FrmSearchProd()
        {
            InitializeComponent();
        }

        private void FrmSearchProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);

        }

        private void BtnExitProduto_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void TbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbProdutoDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtSearchProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduto.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);
            }
            else
            {
                this.tbProdutoTableAdapter.FillByNome(this.bdCadastroDataSet.tbProduto, "%" + txtSearchProduto.Text + "%");
            }
        }
    }
}
