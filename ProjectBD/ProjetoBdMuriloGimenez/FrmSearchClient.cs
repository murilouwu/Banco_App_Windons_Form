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
    public partial class FrmSearchClient : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }
        public FrmSearchClient()
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

        private void FrmSearchClient_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);

        }

        private void BtnExitUser_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void TbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchClient.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);
            }
            else
            {
                this.tbClienteTableAdapter.FillByNome(this.bdCadastroDataSet.tbCliente, "%" + txtSearchClient.Text + "%");
            }
        }
    }
}
