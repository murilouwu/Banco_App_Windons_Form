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
    public partial class frmCadUser : Form
    {
        public frmCadUser()
        {
            InitializeComponent();
        }

        private void frmCadUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);

            
            Desabilitar();

        }

        private void BtnExitUser_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void BtnAdd10User_Click(object sender, EventArgs e)
        {
            //btns
            var btnP = BtnAdd10User;
            var btn0 = BtnNewUser; //btn novo
            var btn1 = BtnSaveUser; //btn save
            //text
            var txt0 = TxtNameUser;
            var txt1 = TxtNivelUser;
            var txt2 = TxtLogUser;
            var txt3 = TxtPassUser;

            btnP.Enabled = false;
            int num = 0;
            for (int i = 0; i<50; i++)
            {
                int nlv = i < 10 ? i:(i-(10*num));
                btn0.PerformClick();
                txt0.Text = i.ToString() + "--NameUser";
                txt1.Text = nlv.ToString();
                txt2.Text = i.ToString() + "--loginUser";
                txt3.Text = i.ToString() + "--SenhaUser";
                btn1.PerformClick();
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49)
                {
                    num += 1;
                }
            };
        }

        private void BtnAnteriorUser_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void BtnProsimoUser_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
            Habilitar();
        }

        private void BtnAlterUser_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void BtnExcluirUser_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.RemoveCurrent();
            tbUsuarioTableAdapter.Update(bdCadastroDataSet.tbUsuario);
        }

        private void BtnPesUser_Click(object sender, EventArgs e)
        {
            int cod = 0, reg =0;
            FrmSearchUser frm = new FrmSearchUser();
            frm.ShowDialog();
            cod = frm.getCodigo();
            if (cod > 0)
            {
                reg = tbUsuarioBindingSource.Find("cd_usuario", cod);
                tbUsuarioBindingSource.Position = reg;
            }
        }

        private void BtnPrintUser_Click(object sender, EventArgs e)
        {
            PpdDadosUserView.ShowDialog();
        }
            private void PdocDadosUser_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //texto para imprimir
                string strDados;
                //titulo
                string titulo = "-------------  FICHA DE USUÁRIO  -------------" + (char)10 + (char)10 + (char)10 + (char)10;
                //dados
                string[] dados = new string[4] { TxtCodUser.Text, TxtNameUser.Text, TxtNivelUser.Text, TxtLogUser.Text };
                
                //blocos para colocar textos
                string[] label = new string[4] { "Código: "+ dados[0], "Nome: "+ dados[1], "Nível: "+ dados[2], "Login: "+ dados[3] };

                //gravar texto na variavel
                strDados = titulo + label[0] + (char)10 + (char)10 + label[1] + (char)10 + (char)10 + label[2] + (char)10 + (char)10 + label[3];

                //definir obj para impressão
                Graphics objImpressao = e.Graphics;

                //mostrar
                objImpressao.DrawString(strDados, new Font("Hobo Std", 15, FontStyle.Bold), Brushes.Black, 50, 50);
            }

        private void BtnCancelUser_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilitar();
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarioBindingSource.EndEdit();
            tbUsuarioTableAdapter.Update(bdCadastroDataSet.tbUsuario);
            Desabilitar();
        }

        //funções
        public void Habilitar()
        {
            //desabilitar Botoes
            BtnAnteriorUser.Enabled = false;
            BtnProsimoUser.Enabled = false;
            BtnNewUser.Enabled = false;
            BtnAlterUser.Enabled = false;
            BtnExcluirUser.Enabled = false;
            BtnPesUser.Enabled = false;
            BtnPrintUser.Enabled = false;
            BtnExitUser.Enabled = false;

            //Habilitar textBox
            TxtCodUser.Enabled = false;
            TxtNameUser.Enabled = true;
            TxtNivelUser.Enabled = true;
            TxtLogUser.Enabled = true;
            TxtPassUser.Enabled = true;

            //Habilitar Botoes
            BtnSaveUser.Enabled = true;
            BtnCancelUser.Enabled = true;
        }
        public void Desabilitar()
        {
            //habilitar Botoes
            BtnAnteriorUser.Enabled = true;
            BtnProsimoUser.Enabled = true;
            BtnNewUser.Enabled = true;
            BtnPrintUser.Enabled = true;
            BtnPesUser.Enabled = true;
            BtnAlterUser.Enabled = true;
            BtnExcluirUser.Enabled = true;
            BtnExitUser.Enabled = true;

            //desabilitar textBox
            TxtCodUser.Enabled = false;
            TxtNameUser.Enabled = false;
            TxtNivelUser.Enabled = false;
            TxtLogUser.Enabled = false;
            TxtPassUser.Enabled = false;

            //desabilitar Botoes
            BtnSaveUser.Enabled = false;
            BtnCancelUser.Enabled = false;
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

        private void TxtNivelUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
