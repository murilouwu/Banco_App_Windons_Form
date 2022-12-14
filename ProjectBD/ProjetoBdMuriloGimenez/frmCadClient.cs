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
    public partial class frmCadClient : Form
    {
        public frmCadClient()
        {
            InitializeComponent();
        }
        private void frmCadClient_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);
            Desabilitar();
        }

        //funções
        public void Habilitar()
        {
            //desabilitar Botoes
            BtnAnteriorClient.Enabled = false;
            BtnProsimoClient.Enabled = false;
            BtnNewClient.Enabled = false;
            BtnAlterClient.Enabled = false;
            BtnExcluirClient.Enabled = false;
            BtnPesClient.Enabled = false;
            BtnPrintClient.Enabled = false;
            BtnExitClient.Enabled = false;

            //Habilitar textBox
            cdClientTextBox.Enabled = false;
            TxtNameClient.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;

            //Habilitar Botoes
            BtnSaveClient.Enabled = true;
            BtnCancelClient.Enabled = true;
        }
        public void Desabilitar()
        {
            //habilitar Botoes
            BtnAnteriorClient.Enabled = true;
            BtnProsimoClient.Enabled = true;
            BtnNewClient.Enabled = true;
            BtnPrintClient.Enabled = true;
            BtnPesClient.Enabled = true;
            BtnAlterClient.Enabled = true;
            BtnExcluirClient.Enabled = true;
            BtnExitClient.Enabled = true;

            //desabilitar textBox
            cdClientTextBox.Enabled = false;
            TxtNameClient.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;

            //desabilitar Botoes
            BtnSaveClient.Enabled = false;
            BtnCancelClient.Enabled = false;
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
        public bool validaCpf(string cpf)
        {
            bool res = false;
            int dig1 = 0, dig2 = 0;
            dig1 += int.Parse(cpf.Substring(10, 1)) * 2;
            dig1 += int.Parse(cpf.Substring(9, 1)) * 3;
            dig1 += int.Parse(cpf.Substring(8, 1)) * 4;
            dig1 += int.Parse(cpf.Substring(6, 1)) * 5;
            dig1 += int.Parse(cpf.Substring(5, 1)) * 6;
            dig1 += int.Parse(cpf.Substring(4, 1)) * 7;
            dig1 += int.Parse(cpf.Substring(2, 1)) * 8;
            dig1 += int.Parse(cpf.Substring(1, 1)) * 9;
            dig1 += int.Parse(cpf.Substring(0, 1)) * 10;
            dig1 = dig1 % 11;
            dig1 = dig1 < 2 ? 0 : 11 - dig1;
            dig2 += int.Parse(cpf.Substring(12, 1)) * 2;
            dig2 += int.Parse(cpf.Substring(10, 1)) * 3;
            dig2 += int.Parse(cpf.Substring(9, 1)) * 4;
            dig2 += int.Parse(cpf.Substring(8, 1)) * 5;
            dig2 += int.Parse(cpf.Substring(6, 1)) * 6;
            dig2 += int.Parse(cpf.Substring(5, 1)) * 7;
            dig2 += int.Parse(cpf.Substring(4, 1)) * 8;
            dig2 += int.Parse(cpf.Substring(2, 1)) * 9;
            dig2 += int.Parse(cpf.Substring(1, 1)) * 10;
            dig2 += int.Parse(cpf.Substring(0, 1)) * 11;
            dig2 = dig2 % 11;
            dig2 = dig2 < 2 ? 0 : 11 - dig2;
            if (dig1 == int.Parse(cpf.Substring(12,1)) && dig2 == int.Parse(cpf.Substring(13, 1))) 
            {
                res = true;
            }
            return res;
        }

        private void BtnExitClient_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //btns
            var btnP = button1;
            var btn0 = BtnNewClient; //btn novo
            var btn1 = BtnSaveClient; //btn save
            //text
            var txt0 = TxtNameClient;
            var txt1 = nm_enderecoTextBox;
            var txt2 = cd_numeroTextBox;
            var txt3 = nm_bairroTextBox;
            var txt4 = nm_cidadeTextBox;
            var txt5 = sg_estadoTextBox;
            var txt6 = cd_cepTextBox;
            var txt7 = cd_telefoneTextBox;
            var txt8 = cd_cpfTextBox;
            var txt9 = cd_rgTextBox;
            
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
                txt0.Text = i.ToString() + "--NameClient";
                txt1.Text = i.ToString() + "--Rua";
                txt2.Text = nlv.ToString();
                txt3.Text = i.ToString() + "--Bairro";
                txt4.Text = i.ToString() + "--City";
                txt5.Text = state[nlv];
                txt6.Text = "11111111";
                txt7.Text = "123456789012345";
                txt8.Text = "11111111111";
                txt9.Text = "111111111111";
                btn1.PerformClick();
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49)
                {
                    num += 1;
                }
            };
        }
        private void BtnAnteriorClient_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void BtnProsimoClient_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void BtnNewClient_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilitar();
        }

        private void BtnAlterClient_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void BtnExcluirClient_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(bdCadastroDataSet.tbCliente);
        }

        private void BtnPesClient_Click(object sender, EventArgs e)
        {
            int cod = 0, reg = 0;
            FrmSearchClient frm = new FrmSearchClient();
            frm.ShowDialog();
            cod = frm.getCodigo();
            if (cod > 0)
            {
                reg = tbClienteBindingSource.Find("cdClient", cod);
                tbClienteBindingSource.Position = reg;
            }
        }

        private void BtnPrintClient_Click(object sender, EventArgs e)
        {
            PpdDadosClientView.ShowDialog();
        }
            private void PdocDadosClient_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //texto para imprimir
                string strDados;
                //titulo
                string titulo = "-------------  FICHA DE CLIENTE  -------------" + (char)10 + (char)10 + (char)10 + (char)10;
                //dados
                string[] dados = new string[6] { cdClientTextBox.Text, TxtNameClient.Text, nm_enderecoTextBox.Text, nm_bairroTextBox.Text, nm_cidadeTextBox.Text, sg_estadoTextBox.Text };

                //blocos para colocar textos
                string[] label = new string[6] { "Código: " + dados[0], "Nome: " + dados[1], "Endereço: " + dados[2], "Bairro: " + dados[3], "Cidade: " + dados[4], "Estado: " + dados[5] };

                //gravar texto na variavel
                strDados = titulo + label[0] + (char)10 + (char)10 + label[1] + (char)10 + (char)10 + label[2] + (char)10 + (char)10 + label[3] + (char)10 + (char)10 + label[4] + (char)10 + (char)10 + label[5];

                //definir obj para impressão
                Graphics objImpressao = e.Graphics;

                //mostrar
                objImpressao.DrawString(strDados, new Font("Hobo Std", 15, FontStyle.Bold), Brushes.Black, 50, 50);
            }

        private void BtnCancelClient_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            Desabilitar();
        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            if (validaCpf(cd_cpfTextBox.Text))
            {
                Validate();
                tbClienteBindingSource.EndEdit();
                tbClienteTableAdapter.Update(bdCadastroDataSet.tbCliente);
                Desabilitar();
            }else{
                string text, titulo;
                titulo = "Erro de digitação";
                text = "Cpf invalido Bro";
                MessageBox.Show(text, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cd_cpfTextBox.Focus();
            }
            
        }

        //input number simulado :)
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

        private void cd_cpfTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cd_rgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
