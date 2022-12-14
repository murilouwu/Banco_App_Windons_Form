
namespace ProjetoBdMuriloGimenez
{
    partial class frmCadClient
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
            System.Windows.Forms.Label cdClientLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClient));
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager();
            this.cdClientTextBox = new System.Windows.Forms.TextBox();
            this.TxtNameClient = new System.Windows.Forms.TextBox();
            this.nm_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cd_rgTextBox = new System.Windows.Forms.TextBox();
            this.BtnCancelClient = new System.Windows.Forms.Button();
            this.BtnPrintClient = new System.Windows.Forms.Button();
            this.BtnPesClient = new System.Windows.Forms.Button();
            this.BtnExitClient = new System.Windows.Forms.Button();
            this.BtnSaveClient = new System.Windows.Forms.Button();
            this.BtnProsimoClient = new System.Windows.Forms.Button();
            this.BtnAlterClient = new System.Windows.Forms.Button();
            this.BtnNewClient = new System.Windows.Forms.Button();
            this.BtnExcluirClient = new System.Windows.Forms.Button();
            this.BtnAnteriorClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cd_cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PdocDadosClient = new System.Drawing.Printing.PrintDocument();
            this.PpdDadosClientView = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            cdClientLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cdClientLabel
            // 
            cdClientLabel.AutoSize = true;
            cdClientLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cdClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cdClientLabel.Location = new System.Drawing.Point(35, 35);
            cdClientLabel.Name = "cdClientLabel";
            cdClientLabel.Size = new System.Drawing.Size(35, 23);
            cdClientLabel.TabIndex = 1;
            cdClientLabel.Text = "Cd";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            nm_clienteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            nm_clienteLabel.Location = new System.Drawing.Point(35, 74);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(60, 23);
            nm_clienteLabel.TabIndex = 3;
            nm_clienteLabel.Text = "Nome";
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            nm_enderecoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            nm_enderecoLabel.Location = new System.Drawing.Point(35, 113);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(95, 23);
            nm_enderecoLabel.TabIndex = 5;
            nm_enderecoLabel.Text = "Endereço";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cd_numeroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cd_numeroLabel.Location = new System.Drawing.Point(35, 152);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(79, 23);
            cd_numeroLabel.TabIndex = 7;
            cd_numeroLabel.Text = "Numero";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            nm_bairroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            nm_bairroLabel.Location = new System.Drawing.Point(35, 191);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(64, 23);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            nm_cidadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            nm_cidadeLabel.Location = new System.Drawing.Point(35, 230);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(71, 23);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            sg_estadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            sg_estadoLabel.Location = new System.Drawing.Point(35, 269);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(71, 23);
            sg_estadoLabel.TabIndex = 13;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cd_cepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cd_cepLabel.Location = new System.Drawing.Point(35, 308);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(48, 23);
            cd_cepLabel.TabIndex = 15;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cd_telefoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cd_telefoneLabel.Location = new System.Drawing.Point(35, 347);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(89, 23);
            cd_telefoneLabel.TabIndex = 17;
            cd_telefoneLabel.Text = "Telefone";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cd_cpfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cd_cpfLabel.Location = new System.Drawing.Point(35, 386);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(46, 23);
            cd_cpfLabel.TabIndex = 19;
            cd_cpfLabel.Text = "CPF";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            cd_rgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cd_rgLabel.Location = new System.Drawing.Point(35, 425);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(37, 23);
            cd_rgLabel.TabIndex = 21;
            cd_rgLabel.Text = "RG";
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "BdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbFonecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cdClientTextBox
            // 
            this.cdClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cdClient", true));
            this.cdClientTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdClientTextBox.Location = new System.Drawing.Point(135, 34);
            this.cdClientTextBox.MaxLength = 1;
            this.cdClientTextBox.Name = "cdClientTextBox";
            this.cdClientTextBox.Size = new System.Drawing.Size(35, 26);
            this.cdClientTextBox.TabIndex = 2;
            // 
            // TxtNameClient
            // 
            this.TxtNameClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cliente", true));
            this.TxtNameClient.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameClient.Location = new System.Drawing.Point(135, 73);
            this.TxtNameClient.MaxLength = 50;
            this.TxtNameClient.Name = "TxtNameClient";
            this.TxtNameClient.Size = new System.Drawing.Size(449, 26);
            this.TxtNameClient.TabIndex = 4;
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_endereco", true));
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(135, 112);
            this.nm_enderecoTextBox.MaxLength = 50;
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(449, 26);
            this.nm_enderecoTextBox.TabIndex = 6;
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_numero", true));
            this.cd_numeroTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_numeroTextBox.Location = new System.Drawing.Point(135, 151);
            this.cd_numeroTextBox.MaxLength = 6;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(144, 26);
            this.cd_numeroTextBox.TabIndex = 8;
            this.cd_numeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cd_numeroTextBox_KeyPress);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(135, 190);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(449, 26);
            this.nm_bairroTextBox.TabIndex = 10;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(135, 229);
            this.nm_cidadeTextBox.MaxLength = 35;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(449, 26);
            this.nm_cidadeTextBox.TabIndex = 12;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(135, 268);
            this.sg_estadoTextBox.MaxLength = 2;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(60, 26);
            this.sg_estadoTextBox.TabIndex = 14;
            // 
            // cd_telefoneTextBox
            // 
            this.cd_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_telefone", true));
            this.cd_telefoneTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_telefoneTextBox.Location = new System.Drawing.Point(135, 346);
            this.cd_telefoneTextBox.MaxLength = 15;
            this.cd_telefoneTextBox.Name = "cd_telefoneTextBox";
            this.cd_telefoneTextBox.Size = new System.Drawing.Size(333, 26);
            this.cd_telefoneTextBox.TabIndex = 18;
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_rg", true));
            this.cd_rgTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_rgTextBox.Location = new System.Drawing.Point(135, 424);
            this.cd_rgTextBox.MaxLength = 12;
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(333, 26);
            this.cd_rgTextBox.TabIndex = 22;
            this.cd_rgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cd_rgTextBox_KeyPress);
            // 
            // BtnCancelClient
            // 
            this.BtnCancelClient.AutoSize = true;
            this.BtnCancelClient.BackColor = System.Drawing.Color.Snow;
            this.BtnCancelClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnCancelClient.Location = new System.Drawing.Point(626, 407);
            this.BtnCancelClient.Name = "BtnCancelClient";
            this.BtnCancelClient.Size = new System.Drawing.Size(115, 32);
            this.BtnCancelClient.TabIndex = 32;
            this.BtnCancelClient.Text = "Cancelar";
            this.BtnCancelClient.UseVisualStyleBackColor = false;
            this.BtnCancelClient.Click += new System.EventHandler(this.BtnCancelClient_Click);
            // 
            // BtnPrintClient
            // 
            this.BtnPrintClient.AutoSize = true;
            this.BtnPrintClient.BackColor = System.Drawing.Color.Snow;
            this.BtnPrintClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnPrintClient.Location = new System.Drawing.Point(876, 407);
            this.BtnPrintClient.Name = "BtnPrintClient";
            this.BtnPrintClient.Size = new System.Drawing.Size(115, 32);
            this.BtnPrintClient.TabIndex = 31;
            this.BtnPrintClient.Text = "Imprimir";
            this.BtnPrintClient.UseVisualStyleBackColor = false;
            this.BtnPrintClient.Click += new System.EventHandler(this.BtnPrintClient_Click);
            // 
            // BtnPesClient
            // 
            this.BtnPesClient.AutoSize = true;
            this.BtnPesClient.BackColor = System.Drawing.Color.Snow;
            this.BtnPesClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnPesClient.Location = new System.Drawing.Point(751, 407);
            this.BtnPesClient.Name = "BtnPesClient";
            this.BtnPesClient.Size = new System.Drawing.Size(115, 32);
            this.BtnPesClient.TabIndex = 30;
            this.BtnPesClient.Text = "Pesquisar";
            this.BtnPesClient.UseVisualStyleBackColor = false;
            this.BtnPesClient.Click += new System.EventHandler(this.BtnPesClient_Click);
            // 
            // BtnExitClient
            // 
            this.BtnExitClient.AutoSize = true;
            this.BtnExitClient.BackColor = System.Drawing.Color.Snow;
            this.BtnExitClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnExitClient.Location = new System.Drawing.Point(1001, 407);
            this.BtnExitClient.Name = "BtnExitClient";
            this.BtnExitClient.Size = new System.Drawing.Size(115, 32);
            this.BtnExitClient.TabIndex = 29;
            this.BtnExitClient.Text = "Sair";
            this.BtnExitClient.UseVisualStyleBackColor = false;
            this.BtnExitClient.Click += new System.EventHandler(this.BtnExitClient_Click);
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.AutoSize = true;
            this.BtnSaveClient.BackColor = System.Drawing.Color.Snow;
            this.BtnSaveClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSaveClient.Location = new System.Drawing.Point(501, 407);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(115, 32);
            this.BtnSaveClient.TabIndex = 28;
            this.BtnSaveClient.Text = "Salvar";
            this.BtnSaveClient.UseVisualStyleBackColor = false;
            this.BtnSaveClient.Click += new System.EventHandler(this.BtnSaveClient_Click);
            // 
            // BtnProsimoClient
            // 
            this.BtnProsimoClient.AutoSize = true;
            this.BtnProsimoClient.BackColor = System.Drawing.Color.Snow;
            this.BtnProsimoClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsimoClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnProsimoClient.Location = new System.Drawing.Point(626, 369);
            this.BtnProsimoClient.Name = "BtnProsimoClient";
            this.BtnProsimoClient.Size = new System.Drawing.Size(115, 32);
            this.BtnProsimoClient.TabIndex = 27;
            this.BtnProsimoClient.Text = "Próximo";
            this.BtnProsimoClient.UseVisualStyleBackColor = false;
            this.BtnProsimoClient.Click += new System.EventHandler(this.BtnProsimoClient_Click);
            // 
            // BtnAlterClient
            // 
            this.BtnAlterClient.AutoSize = true;
            this.BtnAlterClient.BackColor = System.Drawing.Color.Snow;
            this.BtnAlterClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAlterClient.Location = new System.Drawing.Point(876, 369);
            this.BtnAlterClient.Name = "BtnAlterClient";
            this.BtnAlterClient.Size = new System.Drawing.Size(115, 32);
            this.BtnAlterClient.TabIndex = 26;
            this.BtnAlterClient.Text = "Alterar";
            this.BtnAlterClient.UseVisualStyleBackColor = false;
            this.BtnAlterClient.Click += new System.EventHandler(this.BtnAlterClient_Click);
            // 
            // BtnNewClient
            // 
            this.BtnNewClient.AutoSize = true;
            this.BtnNewClient.BackColor = System.Drawing.Color.Snow;
            this.BtnNewClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnNewClient.Location = new System.Drawing.Point(751, 369);
            this.BtnNewClient.Name = "BtnNewClient";
            this.BtnNewClient.Size = new System.Drawing.Size(115, 32);
            this.BtnNewClient.TabIndex = 25;
            this.BtnNewClient.Text = "Novo";
            this.BtnNewClient.UseVisualStyleBackColor = false;
            this.BtnNewClient.Click += new System.EventHandler(this.BtnNewClient_Click);
            // 
            // BtnExcluirClient
            // 
            this.BtnExcluirClient.AutoSize = true;
            this.BtnExcluirClient.BackColor = System.Drawing.Color.Snow;
            this.BtnExcluirClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnExcluirClient.Location = new System.Drawing.Point(1001, 369);
            this.BtnExcluirClient.Name = "BtnExcluirClient";
            this.BtnExcluirClient.Size = new System.Drawing.Size(115, 32);
            this.BtnExcluirClient.TabIndex = 24;
            this.BtnExcluirClient.Text = "Excluir";
            this.BtnExcluirClient.UseVisualStyleBackColor = false;
            this.BtnExcluirClient.Click += new System.EventHandler(this.BtnExcluirClient_Click);
            // 
            // BtnAnteriorClient
            // 
            this.BtnAnteriorClient.AutoSize = true;
            this.BtnAnteriorClient.BackColor = System.Drawing.Color.Snow;
            this.BtnAnteriorClient.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnteriorClient.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAnteriorClient.Location = new System.Drawing.Point(501, 369);
            this.BtnAnteriorClient.Name = "BtnAnteriorClient";
            this.BtnAnteriorClient.Size = new System.Drawing.Size(115, 32);
            this.BtnAnteriorClient.TabIndex = 23;
            this.BtnAnteriorClient.Text = "Anterior";
            this.BtnAnteriorClient.UseVisualStyleBackColor = false;
            this.BtnAnteriorClient.Click += new System.EventHandler(this.BtnAnteriorClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(613, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 306);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.cd_cepTextBox.Location = new System.Drawing.Point(135, 307);
            this.cd_cepTextBox.Mask = "00000-000";
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(333, 26);
            this.cd_cepTextBox.TabIndex = 34;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.cd_cpfTextBox.Location = new System.Drawing.Point(135, 385);
            this.cd_cpfTextBox.Mask = "000.000.000-00";
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(333, 26);
            this.cd_cpfTextBox.TabIndex = 35;
            // 
            // PdocDadosClient
            // 
            this.PdocDadosClient.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdocDadosClient_PrintPage);
            // 
            // PpdDadosClientView
            // 
            this.PpdDadosClientView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PpdDadosClientView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PpdDadosClientView.ClientSize = new System.Drawing.Size(400, 300);
            this.PpdDadosClientView.Document = this.PdocDadosClient;
            this.PpdDadosClientView.Enabled = true;
            this.PpdDadosClientView.Icon = ((System.Drawing.Icon)(resources.GetObject("PpdDadosClientView.Icon")));
            this.PpdDadosClientView.Name = "PpdDadosClientView";
            this.PpdDadosClientView.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(501, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(615, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "Fazer 50 Clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmCadClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1159, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelClient);
            this.Controls.Add(this.BtnPrintClient);
            this.Controls.Add(this.BtnPesClient);
            this.Controls.Add(this.BtnExitClient);
            this.Controls.Add(this.BtnSaveClient);
            this.Controls.Add(this.BtnProsimoClient);
            this.Controls.Add(this.BtnAlterClient);
            this.Controls.Add(this.BtnNewClient);
            this.Controls.Add(this.BtnExcluirClient);
            this.Controls.Add(this.BtnAnteriorClient);
            this.Controls.Add(cdClientLabel);
            this.Controls.Add(this.cdClientTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.TxtNameClient);
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
            this.Controls.Add(cd_telefoneLabel);
            this.Controls.Add(this.cd_telefoneTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadClient";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.frmCadClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private BdCadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private BdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cdClientTextBox;
        private System.Windows.Forms.TextBox TxtNameClient;
        private System.Windows.Forms.TextBox nm_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_telefoneTextBox;
        private System.Windows.Forms.TextBox cd_rgTextBox;
        private System.Windows.Forms.Button BtnCancelClient;
        private System.Windows.Forms.Button BtnPrintClient;
        private System.Windows.Forms.Button BtnPesClient;
        private System.Windows.Forms.Button BtnExitClient;
        private System.Windows.Forms.Button BtnSaveClient;
        private System.Windows.Forms.Button BtnProsimoClient;
        private System.Windows.Forms.Button BtnAlterClient;
        private System.Windows.Forms.Button BtnNewClient;
        private System.Windows.Forms.Button BtnExcluirClient;
        private System.Windows.Forms.Button BtnAnteriorClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox cd_cepTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cpfTextBox;
        private System.Drawing.Printing.PrintDocument PdocDadosClient;
        private System.Windows.Forms.PrintPreviewDialog PpdDadosClientView;
        private System.Windows.Forms.Button button1;
    }
}