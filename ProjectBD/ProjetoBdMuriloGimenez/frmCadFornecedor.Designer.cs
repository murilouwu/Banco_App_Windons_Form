
namespace ProjetoBdMuriloGimenez
{
    partial class frmCadFornecedor
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
            System.Windows.Forms.Label id_fonecedorLabel;
            System.Windows.Forms.Label nm_fonecedorLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedor));
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbFonecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFonecedorTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter();
            this.tableAdapterManager = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager();
            this.id_fonecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fonecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.cd_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cd_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.cd_ieTextBox = new System.Windows.Forms.TextBox();
            this.BtnCancelFor = new System.Windows.Forms.Button();
            this.BtnPrintFor = new System.Windows.Forms.Button();
            this.BtnPesFor = new System.Windows.Forms.Button();
            this.BtnExitFor = new System.Windows.Forms.Button();
            this.BtnSaveFor = new System.Windows.Forms.Button();
            this.BtnProsimoFor = new System.Windows.Forms.Button();
            this.BtnAlterFor = new System.Windows.Forms.Button();
            this.BtnNewFor = new System.Windows.Forms.Button();
            this.BtnExcluirFor = new System.Windows.Forms.Button();
            this.BtnAnteriorFor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PpdDadosClientView = new System.Windows.Forms.PrintPreviewDialog();
            this.PdocDadosProduto = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            id_fonecedorLabel = new System.Windows.Forms.Label();
            nm_fonecedorLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_fonecedorLabel
            // 
            id_fonecedorLabel.AutoSize = true;
            id_fonecedorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_fonecedorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_fonecedorLabel.Location = new System.Drawing.Point(37, 26);
            id_fonecedorLabel.Name = "id_fonecedorLabel";
            id_fonecedorLabel.Size = new System.Drawing.Size(32, 20);
            id_fonecedorLabel.TabIndex = 1;
            id_fonecedorLabel.Text = "Cd";
            // 
            // nm_fonecedorLabel
            // 
            nm_fonecedorLabel.AutoSize = true;
            nm_fonecedorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fonecedorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nm_fonecedorLabel.Location = new System.Drawing.Point(37, 65);
            nm_fonecedorLabel.Name = "nm_fonecedorLabel";
            nm_fonecedorLabel.Size = new System.Drawing.Size(60, 20);
            nm_fonecedorLabel.TabIndex = 3;
            nm_fonecedorLabel.Text = "Nome";
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nm_enderecoLabel.Location = new System.Drawing.Point(37, 104);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(91, 20);
            nm_enderecoLabel.TabIndex = 5;
            nm_enderecoLabel.Text = "Endereço";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_numeroLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cd_numeroLabel.Location = new System.Drawing.Point(37, 143);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(78, 20);
            cd_numeroLabel.TabIndex = 7;
            cd_numeroLabel.Text = "Número";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nm_bairroLabel.Location = new System.Drawing.Point(37, 182);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(63, 20);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nm_cidadeLabel.Location = new System.Drawing.Point(37, 221);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(71, 20);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            sg_estadoLabel.Location = new System.Drawing.Point(37, 260);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(71, 20);
            sg_estadoLabel.TabIndex = 13;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cd_cepLabel.Location = new System.Drawing.Point(37, 299);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(43, 20);
            cd_cepLabel.TabIndex = 15;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_telefoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cd_telefoneLabel.Location = new System.Drawing.Point(37, 338);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(88, 20);
            cd_telefoneLabel.TabIndex = 17;
            cd_telefoneLabel.Text = "Telefone";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cd_cnpjLabel.Location = new System.Drawing.Point(37, 377);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(53, 20);
            cd_cnpjLabel.TabIndex = 19;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cd_ieLabel.Location = new System.Drawing.Point(37, 416);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(28, 20);
            cd_ieLabel.TabIndex = 21;
            cd_ieLabel.Text = "IE";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFonecedorTableAdapter = this.tbFonecedorTableAdapter;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_fonecedorTextBox
            // 
            this.id_fonecedorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_fonecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "Id_fonecedor", true));
            this.id_fonecedorTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_fonecedorTextBox.Location = new System.Drawing.Point(180, 25);
            this.id_fonecedorTextBox.Name = "id_fonecedorTextBox";
            this.id_fonecedorTextBox.Size = new System.Drawing.Size(40, 25);
            this.id_fonecedorTextBox.TabIndex = 2;
            // 
            // nm_fonecedorTextBox
            // 
            this.nm_fonecedorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_fonecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "nm_fonecedor", true));
            this.nm_fonecedorTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_fonecedorTextBox.Location = new System.Drawing.Point(180, 64);
            this.nm_fonecedorTextBox.MaxLength = 50;
            this.nm_fonecedorTextBox.Name = "nm_fonecedorTextBox";
            this.nm_fonecedorTextBox.Size = new System.Drawing.Size(249, 25);
            this.nm_fonecedorTextBox.TabIndex = 4;
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "nm_endereco", true));
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(180, 103);
            this.nm_enderecoTextBox.MaxLength = 50;
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(249, 25);
            this.nm_enderecoTextBox.TabIndex = 6;
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "cd_numero", true));
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_numeroTextBox.Location = new System.Drawing.Point(180, 142);
            this.cd_numeroTextBox.MaxLength = 6;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(40, 25);
            this.cd_numeroTextBox.TabIndex = 8;
            this.cd_numeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cd_numeroTextBox_KeyPress);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(180, 181);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(182, 25);
            this.nm_bairroTextBox.TabIndex = 10;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(180, 220);
            this.nm_cidadeTextBox.MaxLength = 35;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(182, 25);
            this.nm_cidadeTextBox.TabIndex = 12;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(180, 259);
            this.sg_estadoTextBox.MaxLength = 2;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(40, 25);
            this.sg_estadoTextBox.TabIndex = 14;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepTextBox.Location = new System.Drawing.Point(180, 298);
            this.cd_cepTextBox.MaxLength = 9;
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(182, 25);
            this.cd_cepTextBox.TabIndex = 16;
            this.cd_cepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cd_cepTextBox_KeyPress);
            // 
            // cd_telefoneTextBox
            // 
            this.cd_telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "cd_telefone", true));
            this.cd_telefoneTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_telefoneTextBox.Location = new System.Drawing.Point(180, 337);
            this.cd_telefoneTextBox.MaxLength = 15;
            this.cd_telefoneTextBox.Name = "cd_telefoneTextBox";
            this.cd_telefoneTextBox.Size = new System.Drawing.Size(182, 25);
            this.cd_telefoneTextBox.TabIndex = 18;
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(180, 376);
            this.cd_cnpjTextBox.MaxLength = 18;
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(182, 25);
            this.cd_cnpjTextBox.TabIndex = 20;
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFonecedorBindingSource, "cd_ie", true));
            this.cd_ieTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ieTextBox.Location = new System.Drawing.Point(180, 415);
            this.cd_ieTextBox.MaxLength = 15;
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(182, 25);
            this.cd_ieTextBox.TabIndex = 22;
            // 
            // BtnCancelFor
            // 
            this.BtnCancelFor.AutoSize = true;
            this.BtnCancelFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnCancelFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnCancelFor.Location = new System.Drawing.Point(587, 266);
            this.BtnCancelFor.Name = "BtnCancelFor";
            this.BtnCancelFor.Size = new System.Drawing.Size(115, 39);
            this.BtnCancelFor.TabIndex = 42;
            this.BtnCancelFor.Text = "Cancelar";
            this.BtnCancelFor.UseVisualStyleBackColor = false;
            this.BtnCancelFor.Click += new System.EventHandler(this.BtnCancelFor_Click);
            // 
            // BtnPrintFor
            // 
            this.BtnPrintFor.AutoSize = true;
            this.BtnPrintFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnPrintFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnPrintFor.Location = new System.Drawing.Point(587, 371);
            this.BtnPrintFor.Name = "BtnPrintFor";
            this.BtnPrintFor.Size = new System.Drawing.Size(115, 39);
            this.BtnPrintFor.TabIndex = 41;
            this.BtnPrintFor.Text = "Imprimir";
            this.BtnPrintFor.UseVisualStyleBackColor = false;
            this.BtnPrintFor.Click += new System.EventHandler(this.BtnPrintFor_Click);
            // 
            // BtnPesFor
            // 
            this.BtnPesFor.AutoSize = true;
            this.BtnPesFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnPesFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnPesFor.Location = new System.Drawing.Point(431, 371);
            this.BtnPesFor.Name = "BtnPesFor";
            this.BtnPesFor.Size = new System.Drawing.Size(117, 39);
            this.BtnPesFor.TabIndex = 40;
            this.BtnPesFor.Text = "Pesquisar";
            this.BtnPesFor.UseVisualStyleBackColor = false;
            this.BtnPesFor.Click += new System.EventHandler(this.BtnPesFor_Click);
            // 
            // BtnExitFor
            // 
            this.BtnExitFor.AutoSize = true;
            this.BtnExitFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnExitFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnExitFor.Location = new System.Drawing.Point(587, 416);
            this.BtnExitFor.Name = "BtnExitFor";
            this.BtnExitFor.Size = new System.Drawing.Size(115, 39);
            this.BtnExitFor.TabIndex = 39;
            this.BtnExitFor.Text = "Sair";
            this.BtnExitFor.UseVisualStyleBackColor = false;
            this.BtnExitFor.Click += new System.EventHandler(this.BtnExitFor_Click);
            // 
            // BtnSaveFor
            // 
            this.BtnSaveFor.AutoSize = true;
            this.BtnSaveFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnSaveFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnSaveFor.Location = new System.Drawing.Point(429, 266);
            this.BtnSaveFor.Name = "BtnSaveFor";
            this.BtnSaveFor.Size = new System.Drawing.Size(119, 39);
            this.BtnSaveFor.TabIndex = 38;
            this.BtnSaveFor.Text = "Salvar";
            this.BtnSaveFor.UseVisualStyleBackColor = false;
            this.BtnSaveFor.Click += new System.EventHandler(this.BtnSaveFor_Click);
            // 
            // BtnProsimoFor
            // 
            this.BtnProsimoFor.AutoSize = true;
            this.BtnProsimoFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnProsimoFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProsimoFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsimoFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnProsimoFor.Location = new System.Drawing.Point(587, 221);
            this.BtnProsimoFor.Name = "BtnProsimoFor";
            this.BtnProsimoFor.Size = new System.Drawing.Size(115, 39);
            this.BtnProsimoFor.TabIndex = 37;
            this.BtnProsimoFor.Text = "Próximo";
            this.BtnProsimoFor.UseVisualStyleBackColor = false;
            this.BtnProsimoFor.Click += new System.EventHandler(this.BtnProsimoFor_Click);
            // 
            // BtnAlterFor
            // 
            this.BtnAlterFor.AutoSize = true;
            this.BtnAlterFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnAlterFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnAlterFor.Location = new System.Drawing.Point(587, 326);
            this.BtnAlterFor.Name = "BtnAlterFor";
            this.BtnAlterFor.Size = new System.Drawing.Size(115, 39);
            this.BtnAlterFor.TabIndex = 36;
            this.BtnAlterFor.Text = "Alterar";
            this.BtnAlterFor.UseVisualStyleBackColor = false;
            this.BtnAlterFor.Click += new System.EventHandler(this.BtnAlterFor_Click);
            // 
            // BtnNewFor
            // 
            this.BtnNewFor.AutoSize = true;
            this.BtnNewFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnNewFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnNewFor.Location = new System.Drawing.Point(431, 326);
            this.BtnNewFor.Name = "BtnNewFor";
            this.BtnNewFor.Size = new System.Drawing.Size(117, 39);
            this.BtnNewFor.TabIndex = 35;
            this.BtnNewFor.Text = "Novo";
            this.BtnNewFor.UseVisualStyleBackColor = false;
            this.BtnNewFor.Click += new System.EventHandler(this.BtnNewFor_Click);
            // 
            // BtnExcluirFor
            // 
            this.BtnExcluirFor.AutoSize = true;
            this.BtnExcluirFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnExcluirFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnExcluirFor.Location = new System.Drawing.Point(429, 416);
            this.BtnExcluirFor.Name = "BtnExcluirFor";
            this.BtnExcluirFor.Size = new System.Drawing.Size(119, 39);
            this.BtnExcluirFor.TabIndex = 34;
            this.BtnExcluirFor.Text = "Excluir";
            this.BtnExcluirFor.UseVisualStyleBackColor = false;
            this.BtnExcluirFor.Click += new System.EventHandler(this.BtnExcluirFor_Click);
            // 
            // BtnAnteriorFor
            // 
            this.BtnAnteriorFor.AutoSize = true;
            this.BtnAnteriorFor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnAnteriorFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnteriorFor.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnteriorFor.ForeColor = System.Drawing.Color.Gray;
            this.BtnAnteriorFor.Location = new System.Drawing.Point(429, 221);
            this.BtnAnteriorFor.Name = "BtnAnteriorFor";
            this.BtnAnteriorFor.Size = new System.Drawing.Size(119, 39);
            this.BtnAnteriorFor.TabIndex = 33;
            this.BtnAnteriorFor.Text = "Anterior";
            this.BtnAnteriorFor.UseVisualStyleBackColor = false;
            this.BtnAnteriorFor.Click += new System.EventHandler(this.BtnAnteriorFor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 151);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // PpdDadosClientView
            // 
            this.PpdDadosClientView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PpdDadosClientView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PpdDadosClientView.ClientSize = new System.Drawing.Size(400, 300);
            this.PpdDadosClientView.Document = this.PdocDadosProduto;
            this.PpdDadosClientView.Enabled = true;
            this.PpdDadosClientView.Icon = ((System.Drawing.Icon)(resources.GetObject("PpdDadosClientView.Icon")));
            this.PpdDadosClientView.Name = "PpdDadosClientView";
            this.PpdDadosClientView.Visible = false;
            // 
            // PdocDadosProduto
            // 
            this.PdocDadosProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdocDadosProduto_PrintPage);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(429, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 39);
            this.button1.TabIndex = 44;
            this.button1.Text = "Fazer 50 fornecedores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(716, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelFor);
            this.Controls.Add(this.BtnPrintFor);
            this.Controls.Add(this.BtnPesFor);
            this.Controls.Add(this.BtnExitFor);
            this.Controls.Add(this.BtnSaveFor);
            this.Controls.Add(this.BtnProsimoFor);
            this.Controls.Add(this.BtnAlterFor);
            this.Controls.Add(this.BtnNewFor);
            this.Controls.Add(this.BtnExcluirFor);
            this.Controls.Add(this.BtnAnteriorFor);
            this.Controls.Add(id_fonecedorLabel);
            this.Controls.Add(this.id_fonecedorTextBox);
            this.Controls.Add(nm_fonecedorLabel);
            this.Controls.Add(this.nm_fonecedorTextBox);
            this.Controls.Add(nm_enderecoLabel);
            this.Controls.Add(this.nm_enderecoTextBox);
            this.Controls.Add(cd_numeroLabel);
            this.Controls.Add(this.cd_numeroTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(cd_telefoneLabel);
            this.Controls.Add(this.cd_telefoneTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.cd_cnpjTextBox);
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.cd_ieTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbFonecedorBindingSource;
        private BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter tbFonecedorTableAdapter;
        private BdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_fonecedorTextBox;
        private System.Windows.Forms.TextBox nm_fonecedorTextBox;
        private System.Windows.Forms.TextBox nm_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox cd_telefoneTextBox;
        private System.Windows.Forms.TextBox cd_cnpjTextBox;
        private System.Windows.Forms.TextBox cd_ieTextBox;
        private System.Windows.Forms.Button BtnCancelFor;
        private System.Windows.Forms.Button BtnPrintFor;
        private System.Windows.Forms.Button BtnPesFor;
        private System.Windows.Forms.Button BtnExitFor;
        private System.Windows.Forms.Button BtnSaveFor;
        private System.Windows.Forms.Button BtnProsimoFor;
        private System.Windows.Forms.Button BtnAlterFor;
        private System.Windows.Forms.Button BtnNewFor;
        private System.Windows.Forms.Button BtnExcluirFor;
        private System.Windows.Forms.Button BtnAnteriorFor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog PpdDadosClientView;
        private System.Drawing.Printing.PrintDocument PdocDadosProduto;
        private System.Windows.Forms.Button button1;
    }
}