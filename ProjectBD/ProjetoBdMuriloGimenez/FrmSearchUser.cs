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
    public partial class FrmSearchUser : Form
    {
        private int codigo;
        public int getCodigo()
        {
            return codigo;
        }
        public FrmSearchUser()
        {
            InitializeComponent();
        }
        //funções
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

        private void FrmSearchUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);

        }

        private void BtnExitUser_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text == "")
            {
                this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);
            }
            else
            {
                this.tbUsuarioTableAdapter.FillByNome(this.bdCadastroDataSet.tbUsuario, "%" + txtSearchUser.Text + "%");
            }
        }
    }
}
