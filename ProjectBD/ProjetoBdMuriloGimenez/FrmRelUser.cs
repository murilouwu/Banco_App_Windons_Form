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
    public partial class FrmRelUser : Form
    {
        public FrmRelUser()
        {
            InitializeComponent();
        }

        private void FrmRelUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.BdCadastroDataSet.tbUsuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
