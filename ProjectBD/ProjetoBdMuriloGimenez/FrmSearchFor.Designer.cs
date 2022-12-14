namespace ProjetoBdMuriloGimenez
{
    partial class FrmSearchFor
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
            this.tbFonecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbFonecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFonecedorTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter();
            this.BtnExitFor = new System.Windows.Forms.Button();
            this.idfonecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmfonecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmcidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.lbSearchUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFonecedorDataGridView
            // 
            this.tbFonecedorDataGridView.AllowUserToAddRows = false;
            this.tbFonecedorDataGridView.AllowUserToDeleteRows = false;
            this.tbFonecedorDataGridView.AutoGenerateColumns = false;
            this.tbFonecedorDataGridView.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tbFonecedorDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tbFonecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFonecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfonecedorDataGridViewTextBoxColumn,
            this.nmfonecedorDataGridViewTextBoxColumn,
            this.nmenderecoDataGridViewTextBoxColumn,
            this.nmbairroDataGridViewTextBoxColumn,
            this.nmcidadeDataGridViewTextBoxColumn,
            this.sgestadoDataGridViewTextBoxColumn});
            this.tbFonecedorDataGridView.DataSource = this.tbFonecedorBindingSource;
            this.tbFonecedorDataGridView.GridColor = System.Drawing.Color.Gray;
            this.tbFonecedorDataGridView.Location = new System.Drawing.Point(65, 110);
            this.tbFonecedorDataGridView.Name = "tbFonecedorDataGridView";
            this.tbFonecedorDataGridView.ReadOnly = true;
            this.tbFonecedorDataGridView.Size = new System.Drawing.Size(644, 285);
            this.tbFonecedorDataGridView.TabIndex = 2;
            this.tbFonecedorDataGridView.DoubleClick += new System.EventHandler(this.TbFonecedorDataGridView_DoubleClick);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "BdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFonecedorBindingSource
            // 
            this.tbFonecedorBindingSource.DataMember = "tbFonecedor";
            this.tbFonecedorBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbFonecedorTableAdapter
            // 
            this.tbFonecedorTableAdapter.ClearBeforeFill = true;
            // 
            // BtnExitFor
            // 
            this.BtnExitFor.AutoSize = true;
            this.BtnExitFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnExitFor.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnExitFor.Location = new System.Drawing.Point(307, 401);
            this.BtnExitFor.Name = "BtnExitFor";
            this.BtnExitFor.Size = new System.Drawing.Size(161, 75);
            this.BtnExitFor.TabIndex = 18;
            this.BtnExitFor.Text = "Sair";
            this.BtnExitFor.UseVisualStyleBackColor = false;
            this.BtnExitFor.Click += new System.EventHandler(this.BtnExitFor_Click);
            // 
            // idfonecedorDataGridViewTextBoxColumn
            // 
            this.idfonecedorDataGridViewTextBoxColumn.DataPropertyName = "Id_fonecedor";
            this.idfonecedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idfonecedorDataGridViewTextBoxColumn.Name = "idfonecedorDataGridViewTextBoxColumn";
            this.idfonecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmfonecedorDataGridViewTextBoxColumn
            // 
            this.nmfonecedorDataGridViewTextBoxColumn.DataPropertyName = "nm_fonecedor";
            this.nmfonecedorDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nmfonecedorDataGridViewTextBoxColumn.Name = "nmfonecedorDataGridViewTextBoxColumn";
            this.nmfonecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmenderecoDataGridViewTextBoxColumn
            // 
            this.nmenderecoDataGridViewTextBoxColumn.DataPropertyName = "nm_endereco";
            this.nmenderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.nmenderecoDataGridViewTextBoxColumn.Name = "nmenderecoDataGridViewTextBoxColumn";
            this.nmenderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmbairroDataGridViewTextBoxColumn
            // 
            this.nmbairroDataGridViewTextBoxColumn.DataPropertyName = "nm_bairro";
            this.nmbairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.nmbairroDataGridViewTextBoxColumn.Name = "nmbairroDataGridViewTextBoxColumn";
            this.nmbairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmcidadeDataGridViewTextBoxColumn
            // 
            this.nmcidadeDataGridViewTextBoxColumn.DataPropertyName = "nm_cidade";
            this.nmcidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.nmcidadeDataGridViewTextBoxColumn.Name = "nmcidadeDataGridViewTextBoxColumn";
            this.nmcidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sgestadoDataGridViewTextBoxColumn
            // 
            this.sgestadoDataGridViewTextBoxColumn.DataPropertyName = "sg_estado";
            this.sgestadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.sgestadoDataGridViewTextBoxColumn.Name = "sgestadoDataGridViewTextBoxColumn";
            this.sgestadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearchFor.Location = new System.Drawing.Point(167, 50);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(454, 23);
            this.txtSearchFor.TabIndex = 20;
            this.txtSearchFor.TextChanged += new System.EventHandler(this.TxtSearchFor_TextChanged);
            // 
            // lbSearchUser
            // 
            this.lbSearchUser.AutoSize = true;
            this.lbSearchUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearchUser.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbSearchUser.Location = new System.Drawing.Point(101, 50);
            this.lbSearchUser.Name = "lbSearchUser";
            this.lbSearchUser.Size = new System.Drawing.Size(60, 23);
            this.lbSearchUser.TabIndex = 19;
            this.lbSearchUser.Text = "Nome";
            // 
            // FrmSearchFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txtSearchFor);
            this.Controls.Add(this.lbSearchUser);
            this.Controls.Add(this.BtnExitFor);
            this.Controls.Add(this.tbFonecedorDataGridView);
            this.Name = "FrmSearchFor";
            this.Text = "Pesquisa de fornecedor";
            this.Load += new System.EventHandler(this.FrmSearchFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbFonecedorDataGridView;
        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbFonecedorBindingSource;
        private BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter tbFonecedorTableAdapter;
        private System.Windows.Forms.Button BtnExitFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfonecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmfonecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmcidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.Label lbSearchUser;
    }
}