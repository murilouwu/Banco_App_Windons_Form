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
    public partial class FrmRelForn : Form
    {
        public FrmRelForn()
        {
            InitializeComponent();
        }

        private void FrmRelForn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdCadastroDataSet.tbFonecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFonecedorTableAdapter.Fill(this.BdCadastroDataSet.tbFonecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
