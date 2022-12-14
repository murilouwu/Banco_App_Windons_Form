namespace ProjetoBdMuriloGimenez
{
    partial class FrmSearchProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnExitProduto = new System.Windows.Forms.Button();
            this.txtSearchProduto = new System.Windows.Forms.TextBox();
            this.lbSearchUser = new System.Windows.Forms.Label();
            this.tbProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.cdprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgunidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlprecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExitProduto
            // 
            this.BtnExitProduto.AutoSize = true;
            this.BtnExitProduto.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnExitProduto.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitProduto.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnExitProduto.Location = new System.Drawing.Point(315, 352);
            this.BtnExitProduto.Name = "BtnExitProduto";
            this.BtnExitProduto.Size = new System.Drawing.Size(161, 75);
            this.BtnExitProduto.TabIndex = 21;
            this.BtnExitProduto.Text = "Sair";
            this.BtnExitProduto.UseVisualStyleBackColor = false;
            this.BtnExitProduto.Click += new System.EventHandler(this.BtnExitProduto_Click);
            // 
            // txtSearchProduto
            // 
            this.txtSearchProduto.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearchProduto.Location = new System.Drawing.Point(198, 7);
            this.txtSearchProduto.Name = "txtSearchProduto";
            this.txtSearchProduto.Size = new System.Drawing.Size(454, 23);
            this.txtSearchProduto.TabIndex = 20;
            this.txtSearchProduto.TextChanged += new System.EventHandler(this.TxtSearchProduto_TextChanged);
            // 
            // lbSearchUser
            // 
            this.lbSearchUser.AutoSize = true;
            this.lbSearchUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearchUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbSearchUser.Location = new System.Drawing.Point(132, 7);
            this.lbSearchUser.Name = "lbSearchUser";
            this.lbSearchUser.Size = new System.Drawing.Size(60, 23);
            this.lbSearchUser.TabIndex = 19;
            this.lbSearchUser.Text = "Nome";
            // 
            // tbProdutoDataGridView
            // 
            this.tbProdutoDataGridView.AllowUserToAddRows = false;
            this.tbProdutoDataGridView.AllowUserToDeleteRows = false;
            this.tbProdutoDataGridView.AutoGenerateColumns = false;
            this.tbProdutoDataGridView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.tbProdutoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tbProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdprodutoDataGridViewTextBoxColumn,
            this.nmprodutoDataGridViewTextBoxColumn,
            this.sgunidadeDataGridViewTextBoxColumn,
            this.vlprecoDataGridViewTextBoxColumn,
            this.vlsellDataGridViewTextBoxColumn,
            this.qtestoqueDataGridViewTextBoxColumn});
            this.tbProdutoDataGridView.DataSource = this.tbProdutoBindingSource;
            this.tbProdutoDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbProdutoDataGridView.Location = new System.Drawing.Point(74, 49);
            this.tbProdutoDataGridView.Name = "tbProdutoDataGridView";
            this.tbProdutoDataGridView.ReadOnly = true;
            this.tbProdutoDataGridView.Size = new System.Drawing.Size(643, 285);
            this.tbProdutoDataGridView.TabIndex = 18;
            this.tbProdutoDataGridView.DoubleClick += new System.EventHandler(this.TbProdutoDataGridView_DoubleClick);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "BdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // cdprodutoDataGridViewTextBoxColumn
            // 
            this.cdprodutoDataGridViewTextBoxColumn.DataPropertyName = "cd_produto";
            this.cdprodutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cdprodutoDataGridViewTextBoxColumn.Name = "cdprodutoDataGridViewTextBoxColumn";
            this.cdprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmprodutoDataGridViewTextBoxColumn
            // 
            this.nmprodutoDataGridViewTextBoxColumn.DataPropertyName = "nm_produto";
            this.nmprodutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nmprodutoDataGridViewTextBoxColumn.Name = "nmprodutoDataGridViewTextBoxColumn";
            this.nmprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sgunidadeDataGridViewTextBoxColumn
            // 
            this.sgunidadeDataGridViewTextBoxColumn.DataPropertyName = "sg_unidade";
            this.sgunidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.sgunidadeDataGridViewTextBoxColumn.Name = "sgunidadeDataGridViewTextBoxColumn";
            this.sgunidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlprecoDataGridViewTextBoxColumn
            // 
            this.vlprecoDataGridViewTextBoxColumn.DataPropertyName = "vl_preco";
            this.vlprecoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.vlprecoDataGridViewTextBoxColumn.Name = "vlprecoDataGridViewTextBoxColumn";
            this.vlprecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlsellDataGridViewTextBoxColumn
            // 
            this.vlsellDataGridViewTextBoxColumn.DataPropertyName = "vl_sell";
            this.vlsellDataGridViewTextBoxColumn.HeaderText = "Venda";
            this.vlsellDataGridViewTextBoxColumn.Name = "vlsellDataGridViewTextBoxColumn";
            this.vlsellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtestoqueDataGridViewTextBoxColumn
            // 
            this.qtestoqueDataGridViewTextBoxColumn.DataPropertyName = "qt_estoque";
            this.qtestoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.qtestoqueDataGridViewTextBoxColumn.Name = "qtestoqueDataGridViewTextBoxColumn";
            this.qtestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSearchProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExitProduto);
            this.Controls.Add(this.txtSearchProduto);
            this.Controls.Add(this.lbSearchUser);
            this.Controls.Add(this.tbProdutoDataGridView);
            this.Name = "FrmSearchProd";
            this.Text = "FrmSearchProd";
            this.Load += new System.EventHandler(this.FrmSearchProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExitProduto;
        private System.Windows.Forms.TextBox txtSearchProduto;
        private System.Windows.Forms.Label lbSearchUser;
        private System.Windows.Forms.DataGridView tbProdutoDataGridView;
        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private BdCadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgunidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtestoqueDataGridViewTextBoxColumn;
    }
}