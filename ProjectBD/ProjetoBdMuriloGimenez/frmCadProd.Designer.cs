
namespace ProjetoBdMuriloGimenez
{
    partial class frmCadProd
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
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label sg_unidadeLabel;
            System.Windows.Forms.Label vl_precoLabel;
            System.Windows.Forms.Label vl_sellLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProd));
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.tableAdapterManager = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.sg_unidadeTextBox = new System.Windows.Forms.TextBox();
            this.vl_precoTextBox = new System.Windows.Forms.TextBox();
            this.vl_sellTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancelProd = new System.Windows.Forms.Button();
            this.BtnPrintProd = new System.Windows.Forms.Button();
            this.BtnPesProd = new System.Windows.Forms.Button();
            this.BtnExitProd = new System.Windows.Forms.Button();
            this.BtnSaveProd = new System.Windows.Forms.Button();
            this.BtnProsimoProd = new System.Windows.Forms.Button();
            this.BtnAlterProd = new System.Windows.Forms.Button();
            this.BtnNewProd = new System.Windows.Forms.Button();
            this.BtnExcluirProd = new System.Windows.Forms.Button();
            this.BtnAnteriorProd = new System.Windows.Forms.Button();
            this.PdocDadosProduto = new System.Drawing.Printing.PrintDocument();
            this.PpdDadosProdutoView = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            sg_unidadeLabel = new System.Windows.Forms.Label();
            vl_precoLabel = new System.Windows.Forms.Label();
            vl_sellLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            cd_produtoLabel.Location = new System.Drawing.Point(33, 39);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(34, 19);
            cd_produtoLabel.TabIndex = 1;
            cd_produtoLabel.Text = "CD";
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            nm_produtoLabel.Location = new System.Drawing.Point(33, 83);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(55, 19);
            nm_produtoLabel.TabIndex = 3;
            nm_produtoLabel.Text = "Nome";
            // 
            // sg_unidadeLabel
            // 
            sg_unidadeLabel.AutoSize = true;
            sg_unidadeLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_unidadeLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            sg_unidadeLabel.Location = new System.Drawing.Point(33, 127);
            sg_unidadeLabel.Name = "sg_unidadeLabel";
            sg_unidadeLabel.Size = new System.Drawing.Size(157, 19);
            sg_unidadeLabel.TabIndex = 5;
            sg_unidadeLabel.Text = "Estado da Unidade";
            // 
            // vl_precoLabel
            // 
            vl_precoLabel.AutoSize = true;
            vl_precoLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_precoLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            vl_precoLabel.Location = new System.Drawing.Point(33, 171);
            vl_precoLabel.Name = "vl_precoLabel";
            vl_precoLabel.Size = new System.Drawing.Size(55, 19);
            vl_precoLabel.TabIndex = 7;
            vl_precoLabel.Text = "Preço";
            // 
            // vl_sellLabel
            // 
            vl_sellLabel.AutoSize = true;
            vl_sellLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_sellLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            vl_sellLabel.Location = new System.Drawing.Point(33, 215);
            vl_sellLabel.Name = "vl_sellLabel";
            vl_sellLabel.Size = new System.Drawing.Size(58, 19);
            vl_sellLabel.TabIndex = 9;
            vl_sellLabel.Text = "Venda";
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            qt_estoqueLabel.Location = new System.Drawing.Point(33, 259);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(74, 19);
            qt_estoqueLabel.TabIndex = 11;
            qt_estoqueLabel.Text = "Estoque";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFonecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = this.tbProdutoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_produtoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cd_produtoTextBox.Location = new System.Drawing.Point(159, 36);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(53, 27);
            this.cd_produtoTextBox.TabIndex = 2;
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_produtoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nm_produtoTextBox.Location = new System.Drawing.Point(159, 79);
            this.nm_produtoTextBox.MaxLength = 50;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(472, 27);
            this.nm_produtoTextBox.TabIndex = 4;
            // 
            // sg_unidadeTextBox
            // 
            this.sg_unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "sg_unidade", true));
            this.sg_unidadeTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_unidadeTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sg_unidadeTextBox.Location = new System.Drawing.Point(218, 124);
            this.sg_unidadeTextBox.MaxLength = 2;
            this.sg_unidadeTextBox.Name = "sg_unidadeTextBox";
            this.sg_unidadeTextBox.Size = new System.Drawing.Size(53, 27);
            this.sg_unidadeTextBox.TabIndex = 6;
            // 
            // vl_precoTextBox
            // 
            this.vl_precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_preco", true));
            this.vl_precoTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_precoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vl_precoTextBox.Location = new System.Drawing.Point(159, 165);
            this.vl_precoTextBox.Name = "vl_precoTextBox";
            this.vl_precoTextBox.Size = new System.Drawing.Size(472, 27);
            this.vl_precoTextBox.TabIndex = 8;
            this.vl_precoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vl_precoTextBox_KeyPress);
            // 
            // vl_sellTextBox
            // 
            this.vl_sellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_sell", true));
            this.vl_sellTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_sellTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vl_sellTextBox.Location = new System.Drawing.Point(159, 208);
            this.vl_sellTextBox.Name = "vl_sellTextBox";
            this.vl_sellTextBox.Size = new System.Drawing.Size(472, 27);
            this.vl_sellTextBox.TabIndex = 10;
            this.vl_sellTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vl_sellTextBox_KeyPress);
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_estoqueTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(159, 251);
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(472, 27);
            this.qt_estoqueTextBox.TabIndex = 12;
            this.qt_estoqueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qt_estoqueTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(649, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 294);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancelProd
            // 
            this.BtnCancelProd.AutoSize = true;
            this.BtnCancelProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnCancelProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnCancelProd.Location = new System.Drawing.Point(252, 406);
            this.BtnCancelProd.Name = "BtnCancelProd";
            this.BtnCancelProd.Size = new System.Drawing.Size(115, 32);
            this.BtnCancelProd.TabIndex = 44;
            this.BtnCancelProd.Text = "Cancelar";
            this.BtnCancelProd.UseVisualStyleBackColor = false;
            this.BtnCancelProd.Click += new System.EventHandler(this.BtnCancelProd_Click);
            // 
            // BtnPrintProd
            // 
            this.BtnPrintProd.AutoSize = true;
            this.BtnPrintProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnPrintProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnPrintProd.Location = new System.Drawing.Point(682, 406);
            this.BtnPrintProd.Name = "BtnPrintProd";
            this.BtnPrintProd.Size = new System.Drawing.Size(115, 32);
            this.BtnPrintProd.TabIndex = 43;
            this.BtnPrintProd.Text = "Imprimir";
            this.BtnPrintProd.UseVisualStyleBackColor = false;
            this.BtnPrintProd.Click += new System.EventHandler(this.BtnPrintProd_Click);
            // 
            // BtnPesProd
            // 
            this.BtnPesProd.AutoSize = true;
            this.BtnPesProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnPesProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnPesProd.Location = new System.Drawing.Point(467, 406);
            this.BtnPesProd.Name = "BtnPesProd";
            this.BtnPesProd.Size = new System.Drawing.Size(115, 32);
            this.BtnPesProd.TabIndex = 42;
            this.BtnPesProd.Text = "Pesquisar";
            this.BtnPesProd.UseVisualStyleBackColor = false;
            this.BtnPesProd.Click += new System.EventHandler(this.BtnPesProd_Click);
            // 
            // BtnExitProd
            // 
            this.BtnExitProd.AutoSize = true;
            this.BtnExitProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnExitProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnExitProd.Location = new System.Drawing.Point(897, 406);
            this.BtnExitProd.Name = "BtnExitProd";
            this.BtnExitProd.Size = new System.Drawing.Size(115, 32);
            this.BtnExitProd.TabIndex = 41;
            this.BtnExitProd.Text = "Sair";
            this.BtnExitProd.UseVisualStyleBackColor = false;
            this.BtnExitProd.Click += new System.EventHandler(this.BtnExitProd_Click);
            // 
            // BtnSaveProd
            // 
            this.BtnSaveProd.AutoSize = true;
            this.BtnSaveProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnSaveProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnSaveProd.Location = new System.Drawing.Point(37, 406);
            this.BtnSaveProd.Name = "BtnSaveProd";
            this.BtnSaveProd.Size = new System.Drawing.Size(115, 32);
            this.BtnSaveProd.TabIndex = 40;
            this.BtnSaveProd.Text = "Salvar";
            this.BtnSaveProd.UseVisualStyleBackColor = false;
            this.BtnSaveProd.Click += new System.EventHandler(this.BtnSaveProd_Click);
            // 
            // BtnProsimoProd
            // 
            this.BtnProsimoProd.AutoSize = true;
            this.BtnProsimoProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnProsimoProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsimoProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnProsimoProd.Location = new System.Drawing.Point(252, 368);
            this.BtnProsimoProd.Name = "BtnProsimoProd";
            this.BtnProsimoProd.Size = new System.Drawing.Size(115, 32);
            this.BtnProsimoProd.TabIndex = 39;
            this.BtnProsimoProd.Text = "Próximo";
            this.BtnProsimoProd.UseVisualStyleBackColor = false;
            this.BtnProsimoProd.Click += new System.EventHandler(this.BtnProsimoProd_Click);
            // 
            // BtnAlterProd
            // 
            this.BtnAlterProd.AutoSize = true;
            this.BtnAlterProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnAlterProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAlterProd.Location = new System.Drawing.Point(682, 368);
            this.BtnAlterProd.Name = "BtnAlterProd";
            this.BtnAlterProd.Size = new System.Drawing.Size(115, 32);
            this.BtnAlterProd.TabIndex = 38;
            this.BtnAlterProd.Text = "Alterar";
            this.BtnAlterProd.UseVisualStyleBackColor = false;
            this.BtnAlterProd.Click += new System.EventHandler(this.BtnAlterProd_Click);
            // 
            // BtnNewProd
            // 
            this.BtnNewProd.AutoSize = true;
            this.BtnNewProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnNewProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnNewProd.Location = new System.Drawing.Point(467, 368);
            this.BtnNewProd.Name = "BtnNewProd";
            this.BtnNewProd.Size = new System.Drawing.Size(115, 32);
            this.BtnNewProd.TabIndex = 37;
            this.BtnNewProd.Text = "Novo";
            this.BtnNewProd.UseVisualStyleBackColor = false;
            this.BtnNewProd.Click += new System.EventHandler(this.BtnNewProd_Click);
            // 
            // BtnExcluirProd
            // 
            this.BtnExcluirProd.AutoSize = true;
            this.BtnExcluirProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnExcluirProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnExcluirProd.Location = new System.Drawing.Point(897, 368);
            this.BtnExcluirProd.Name = "BtnExcluirProd";
            this.BtnExcluirProd.Size = new System.Drawing.Size(115, 32);
            this.BtnExcluirProd.TabIndex = 36;
            this.BtnExcluirProd.Text = "Excluir";
            this.BtnExcluirProd.UseVisualStyleBackColor = false;
            this.BtnExcluirProd.Click += new System.EventHandler(this.BtnExcluirProd_Click);
            // 
            // BtnAnteriorProd
            // 
            this.BtnAnteriorProd.AutoSize = true;
            this.BtnAnteriorProd.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnAnteriorProd.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnteriorProd.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAnteriorProd.Location = new System.Drawing.Point(37, 368);
            this.BtnAnteriorProd.Name = "BtnAnteriorProd";
            this.BtnAnteriorProd.Size = new System.Drawing.Size(115, 32);
            this.BtnAnteriorProd.TabIndex = 35;
            this.BtnAnteriorProd.Text = "Anterior";
            this.BtnAnteriorProd.UseVisualStyleBackColor = false;
            this.BtnAnteriorProd.Click += new System.EventHandler(this.BtnAnteriorProd_Click);
            // 
            // PdocDadosProduto
            // 
            this.PdocDadosProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdocDadosProduto_PrintPage);
            // 
            // PpdDadosProdutoView
            // 
            this.PpdDadosProdutoView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PpdDadosProdutoView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PpdDadosProdutoView.ClientSize = new System.Drawing.Size(400, 300);
            this.PpdDadosProdutoView.Document = this.PdocDadosProduto;
            this.PpdDadosProdutoView.Enabled = true;
            this.PpdDadosProdutoView.Icon = ((System.Drawing.Icon)(resources.GetObject("PpdDadosProdutoView.Icon")));
            this.PpdDadosProdutoView.Name = "PpdDadosProdutoView";
            this.PpdDadosProdutoView.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(252, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(545, 32);
            this.button1.TabIndex = 45;
            this.button1.Text = "Fazer 50 Produtos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1056, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelProd);
            this.Controls.Add(this.BtnPrintProd);
            this.Controls.Add(this.BtnPesProd);
            this.Controls.Add(this.BtnExitProd);
            this.Controls.Add(this.BtnSaveProd);
            this.Controls.Add(this.BtnProsimoProd);
            this.Controls.Add(this.BtnAlterProd);
            this.Controls.Add(this.BtnNewProd);
            this.Controls.Add(this.BtnExcluirProd);
            this.Controls.Add(this.BtnAnteriorProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(sg_unidadeLabel);
            this.Controls.Add(this.sg_unidadeTextBox);
            this.Controls.Add(vl_precoLabel);
            this.Controls.Add(this.vl_precoTextBox);
            this.Controls.Add(vl_sellLabel);
            this.Controls.Add(this.vl_sellTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadProd";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private BdCadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private BdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox sg_unidadeTextBox;
        private System.Windows.Forms.TextBox vl_precoTextBox;
        private System.Windows.Forms.TextBox vl_sellTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancelProd;
        private System.Windows.Forms.Button BtnPrintProd;
        private System.Windows.Forms.Button BtnPesProd;
        private System.Windows.Forms.Button BtnExitProd;
        private System.Windows.Forms.Button BtnSaveProd;
        private System.Windows.Forms.Button BtnProsimoProd;
        private System.Windows.Forms.Button BtnAlterProd;
        private System.Windows.Forms.Button BtnNewProd;
        private System.Windows.Forms.Button BtnExcluirProd;
        private System.Windows.Forms.Button BtnAnteriorProd;
        private System.Drawing.Printing.PrintDocument PdocDadosProduto;
        private System.Windows.Forms.PrintPreviewDialog PpdDadosProdutoView;
        private System.Windows.Forms.Button button1;
    }
}