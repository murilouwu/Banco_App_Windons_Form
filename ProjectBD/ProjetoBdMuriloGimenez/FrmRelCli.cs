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
    public partial class FrmRelCli : Form
    {
        public FrmRelCli()
        {
            InitializeComponent();
        }

        private void FrmRelCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.BdCadastroDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
