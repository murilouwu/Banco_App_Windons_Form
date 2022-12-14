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
    public partial class FrmLogin : Form
    {
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
                Application.Exit();
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSairLogin_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void BtnEntrarLogin_Click(object sender, EventArgs e)
        {
            tbUsuarioTableAdapter.FillLogin(bdCadastroDataSet.tbUsuario, nm_login.Text, cd_senha.Text);
            if (tbUsuarioBindingSource.Count > 0 || (nm_login.Text == "adm" && cd_senha.Text == "123"))
            {
                FrmPricipal frm = new FrmPricipal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("o login ou senha são invalidos", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nm_login.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);

        }
    }
}
