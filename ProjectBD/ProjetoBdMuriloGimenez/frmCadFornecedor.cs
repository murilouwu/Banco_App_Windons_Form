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
    public partial class frmCadFornecedor : Form
    {
        //tbFonecedorBindingSource tbFonecedorTableAdapter tbFonecedor
        public frmCadFornecedor()
        {
            InitializeComponent();
        }
        
        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbFonecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFonecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFonecedor);
            Desabilitar();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //btns
            var btnP = button1;
            var btn0 = BtnNewFor; //btn novo
            var btn1 = BtnSaveFor; //btn save
            //text
            var txt0 = nm_fonecedorTextBox;
            var txt1 = nm_enderecoTextBox;
            var txt2 = cd_numeroTextBox;
            var txt3 = nm_bairroTextBox;
            var txt4 = nm_cidadeTextBox;
            var txt5 = sg_estadoTextBox;
            var txt6 = cd_cepTextBox;
            var txt7 = cd_telefoneTextBox;
            var txt8 = cd_cnpjTextBox;
            var txt9 = cd_ieTextBox;
            //estados
            string[] state = new string[10]
            {
                "SP",
                "RJ",
                "AC",
                "AM",
                "MG",
                "RR",
                "MT",
                "PA",
                "RN",
                "RS"
            };
            btnP.Enabled = false;
            int num = 0;
            for (int i = 0; i < 50; i++)
            {
                int nlv = i < 10 ? i : (i - (10 * num));
                btn0.PerformClick();
                txt0.Text = i.ToString() + "--NameForne";
                txt1.Text = i.ToString() + "--Rua";
                txt2.Text = nlv.ToString();
                txt3.Text = i.ToString() + "--Bairro";
                txt4.Text = i.ToString() + "--City";
                txt5.Text = state[nlv];
                txt6.Text = "111111111";
                txt7.Text = "111151140028922";
                txt8.Text = "123456789012345678";
                txt9.Text = "abcdefghijklmno";
                btn1.PerformClick();
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49)
                {
                    num += 1;
                }
            }
        }
        private void BtnAnteriorFor_Click(object sender, EventArgs e)
        {
            tbFonecedorBindingSource.MovePrevious();
        }

        private void BtnSaveFor_Click(object sender, EventArgs e)
        {
            Validate();
            tbFonecedorBindingSource.EndEdit();
            tbFonecedorTableAdapter.Update(bdCadastroDataSet.tbFonecedor);
            Desabilitar();
        }

        private void BtnNewFor_Click(object sender, EventArgs e)
        {
            tbFonecedorBindingSource.AddNew();
            Habilitar();
        }

        private void BtnPesFor_Click(object sender, EventArgs e)
        {
            int cod = 0, reg = 0;
            FrmSearchFor frm = new FrmSearchFor();
            frm.ShowDialog();
            cod = frm.getCodigo();
            if (cod > 0)
            {
                reg = tbFonecedorBindingSource.Find("Id_fonecedor", cod);
                tbFonecedorBindingSource.Position = reg;
            }
        }

        private void BtnExcluirFor_Click(object sender, EventArgs e)
        {
            tbFonecedorBindingSource.RemoveCurrent();
            tbFonecedorTableAdapter.Update(bdCadastroDataSet.tbFonecedor);
        }

        private void BtnProsimoFor_Click(object sender, EventArgs e)
        {
            tbFonecedorBindingSource.MoveNext();
        }

        private void BtnCancelFor_Click(object sender, EventArgs e)
        {
            tbFonecedorBindingSource.CancelEdit();
            Desabilitar();
        }

        private void BtnAlterFor_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void BtnPrintFor_Click(object sender, EventArgs e)
        {
            PpdDadosClientView.ShowDialog();
        }
            private void PdocDadosProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //texto para imprimir
                string strDados;
                //titulo
                string titulo = "-------------  FICHA DO FORNECEDOR  -------------" + (char)10 + (char)10 + (char)10 + (char)10;
                //dados
                string[] dados = new string[6] { id_fonecedorTextBox.Text, nm_fonecedorTextBox.Text, nm_enderecoTextBox.Text, nm_bairroTextBox.Text, nm_cidadeTextBox.Text, sg_estadoTextBox.Text};

                //blocos para colocar textos
                string[] label = new string[6] { "Código: " + dados[0], "Nome: " + dados[1], "Endereço: " + dados[2], "Bairro: " + dados[3], "cidade: " + dados[4], "Estado: " + dados[5] };

                //gravar texto na variavel
                strDados = titulo + label[0] + (char)10 + (char)10 + label[1] + (char)10 + (char)10 + label[2] + (char)10 + (char)10 + label[3] + (char)10 + (char)10 + label[4] + (char)10 + (char)10 + label[5];

                //definir obj para impressão
                Graphics objImpressao = e.Graphics;

                //mostrar
                objImpressao.DrawString(strDados, new Font("Hobo Std", 15, FontStyle.Bold), Brushes.Black, 50, 50);
            }

        private void BtnExitFor_Click(object sender, EventArgs e)
        {
            Sair();
        }

        //funções
        public void Habilitar()
        {
            //desabilitar Botoes
            BtnAnteriorFor.Enabled = false;
            BtnProsimoFor.Enabled = false;
            BtnNewFor.Enabled = false;
            BtnAlterFor.Enabled = false;
            BtnExcluirFor.Enabled = false;
            BtnPesFor.Enabled = false;
            BtnPrintFor.Enabled = false;
            BtnExitFor.Enabled = false;

            //Habilitar textBox
            id_fonecedorTextBox.Enabled = false;
            nm_fonecedorTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;

            //Habilitar Botoes
            BtnSaveFor.Enabled = true;
            BtnCancelFor.Enabled = true;
        }
        public void Desabilitar()
        {
            //habilitar Botoes
            BtnAnteriorFor.Enabled = true;
            BtnProsimoFor.Enabled = true;
            BtnNewFor.Enabled = true;
            BtnPrintFor.Enabled = true;
            BtnPesFor.Enabled = true;
            BtnAlterFor.Enabled = true;
            BtnExcluirFor.Enabled = true;
            BtnExitFor.Enabled = true;

            //desabilitar textBox
            id_fonecedorTextBox.Enabled = false;
            nm_fonecedorTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;

            //desabilitar Botoes
            BtnSaveFor.Enabled = false;
            BtnCancelFor.Enabled = false;
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

        private void cd_numeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cd_cepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
