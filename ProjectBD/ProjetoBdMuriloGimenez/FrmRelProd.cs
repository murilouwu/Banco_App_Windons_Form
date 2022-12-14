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
    public partial class FrmRelProd : Form
    {
        public FrmRelProd()
        {
            InitializeComponent();
        }

        private void FrmRelProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdCadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.BdCadastroDataSet.tbProduto);

            this.reportViewer1.RefreshReport();
        }
    }
}
