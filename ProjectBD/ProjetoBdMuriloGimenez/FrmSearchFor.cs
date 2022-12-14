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
    public partial class FrmSearchFor : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }
        public FrmSearchFor()
        {
            InitializeComponent();
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

        private void FrmSearchFor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbFonecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFonecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFonecedor);

        }

        private void BtnExitFor_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void TbFonecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbFonecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtSearchFor_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFor.Text == "")
            {
                this.tbFonecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFonecedor);
            }
            else
            {
                this.tbFonecedorTableAdapter.FillByNome(this.bdCadastroDataSet.tbFonecedor, "%" + txtSearchFor.Text + "%");
            }
        }
    }
}
