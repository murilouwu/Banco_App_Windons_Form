using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoBdMuriloGimenez
{
    public partial class FrmPricipal : Form
    {
        public FrmPricipal()
        {
            InitializeComponent();
        }


        //menustrip btns
            private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //definir link
                string url = "https://github.com/murilouwu/Banco_App_Windons_Form";
                //função para execultar link
                System.Diagnostics.Process.Start(url);
            }

            private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Sair();   
            }

            private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCadUser frm = new frmCadUser();
                frm.ShowDialog();
            }
            private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCadClient frm = new frmCadClient();
                frm.ShowDialog();
            }
            private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCadFornecedor frm = new frmCadFornecedor();
                frm.ShowDialog();
            }
            private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmCadProd frm = new frmCadProd();
                frm.ShowDialog();
            }
            private void MnStripItRelUser_Click(object sender, EventArgs e)
            {
                FrmRelUser frm = new FrmRelUser();
                frm.ShowDialog();
            }

            private void MnStripItRelForne_Click(object sender, EventArgs e)
            {
                FrmRelForn frm = new FrmRelForn();
                frm.ShowDialog();
            }

            private void MnStripItRelClient_Click(object sender, EventArgs e)
            {
                FrmRelCli frm = new FrmRelCli();
                frm.ShowDialog();
            }

            private void MnStripItRelProd_Click(object sender, EventArgs e)
            {
                FrmRelProd frm = new FrmRelProd();
                frm.ShowDialog();
            }

        //btns menu
            private void BtnSobre_Click(object sender, EventArgs e)
            {
                //definir link
                string url = "https://github.com/murilouwu/Banco_App_Windons_Form";
                //função para execultar link
                System.Diagnostics.Process.Start(url);
            }
            private void BtnExit_Click(object sender, EventArgs e)
            {
                Sair();
            }
            //cadastro
            private void BtnCadUser_Click(object sender, EventArgs e)
            {
                frmCadUser frm = new frmCadUser();
                frm.ShowDialog();
            }

            private void BtnCadClie_Click(object sender, EventArgs e)
            {
                frmCadClient frm = new frmCadClient();
                frm.ShowDialog();
            }
       
            private void BtnCadFor_Click(object sender, EventArgs e)
            {
                frmCadFornecedor frm = new frmCadFornecedor();
                frm.ShowDialog();
            }
            private void BtnCadProd_Click(object sender, EventArgs e)
            {
                frmCadProd frm = new frmCadProd();
                frm.ShowDialog();
            }
            //relatorio
            private void BtnRelUser_Click(object sender, EventArgs e)
            {
                FrmRelUser frm = new FrmRelUser();
                frm.ShowDialog();
            }

            private void BtnRelProd_Click(object sender, EventArgs e)
            {
                FrmRelProd frm = new FrmRelProd();
                frm.ShowDialog();
            }

            private void BtnRelFor_Click(object sender, EventArgs e)
            {
                FrmRelForn frm = new FrmRelForn();
                frm.ShowDialog();
            }

            private void BtnRelClie_Click(object sender, EventArgs e)
            {
                FrmRelCli frm = new FrmRelCli();
                frm.ShowDialog();
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
                Application.Exit();
            }
        }
    }
}
