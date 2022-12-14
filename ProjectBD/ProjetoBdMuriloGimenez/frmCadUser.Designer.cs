
namespace ProjetoBdMuriloGimenez
{
    partial class frmCadUser
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
            System.Windows.Forms.Label LabCdUser;
            System.Windows.Forms.Label LabNomeUser;
            System.Windows.Forms.Label LabNvlUser;
            System.Windows.Forms.Label LabLogUser;
            System.Windows.Forms.Label LabPassUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUser));
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbUsuarioTableAdapter();
            this.TxtCodUser = new System.Windows.Forms.TextBox();
            this.TxtNameUser = new System.Windows.Forms.TextBox();
            this.TxtNivelUser = new System.Windows.Forms.TextBox();
            this.TxtLogUser = new System.Windows.Forms.TextBox();
            this.TxtPassUser = new System.Windows.Forms.TextBox();
            this.BtnAnteriorUser = new System.Windows.Forms.Button();
            this.BtnExcluirUser = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.BtnAlterUser = new System.Windows.Forms.Button();
            this.BtnProsimoUser = new System.Windows.Forms.Button();
            this.BtnCancelUser = new System.Windows.Forms.Button();
            this.BtnPrintUser = new System.Windows.Forms.Button();
            this.BtnPesUser = new System.Windows.Forms.Button();
            this.BtnExitUser = new System.Windows.Forms.Button();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PdocDadosUser = new System.Drawing.Printing.PrintDocument();
            this.PpdDadosUserView = new System.Windows.Forms.PrintPreviewDialog();
            this.BtnAdd10User = new System.Windows.Forms.Button();
            LabCdUser = new System.Windows.Forms.Label();
            LabNomeUser = new System.Windows.Forms.Label();
            LabNvlUser = new System.Windows.Forms.Label();
            LabLogUser = new System.Windows.Forms.Label();
            LabPassUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabCdUser
            // 
            LabCdUser.AutoSize = true;
            LabCdUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabCdUser.ForeColor = System.Drawing.Color.SaddleBrown;
            LabCdUser.Location = new System.Drawing.Point(19, 32);
            LabCdUser.Name = "LabCdUser";
            LabCdUser.Size = new System.Drawing.Size(71, 23);
            LabCdUser.TabIndex = 1;
            LabCdUser.Text = "Código";
            // 
            // LabNomeUser
            // 
            LabNomeUser.AutoSize = true;
            LabNomeUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabNomeUser.ForeColor = System.Drawing.Color.SaddleBrown;
            LabNomeUser.Location = new System.Drawing.Point(19, 80);
            LabNomeUser.Name = "LabNomeUser";
            LabNomeUser.Size = new System.Drawing.Size(60, 23);
            LabNomeUser.TabIndex = 3;
            LabNomeUser.Text = "Nome";
            // 
            // LabNvlUser
            // 
            LabNvlUser.AutoSize = true;
            LabNvlUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabNvlUser.ForeColor = System.Drawing.Color.SaddleBrown;
            LabNvlUser.Location = new System.Drawing.Point(19, 128);
            LabNvlUser.Name = "LabNvlUser";
            LabNvlUser.Size = new System.Drawing.Size(55, 23);
            LabNvlUser.TabIndex = 5;
            LabNvlUser.Text = "Nivel";
            // 
            // LabLogUser
            // 
            LabLogUser.AutoSize = true;
            LabLogUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabLogUser.ForeColor = System.Drawing.Color.SaddleBrown;
            LabLogUser.Location = new System.Drawing.Point(19, 176);
            LabLogUser.Name = "LabLogUser";
            LabLogUser.Size = new System.Drawing.Size(59, 23);
            LabLogUser.TabIndex = 7;
            LabLogUser.Text = "Login";
            // 
            // LabPassUser
            // 
            LabPassUser.AutoSize = true;
            LabPassUser.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabPassUser.ForeColor = System.Drawing.Color.SaddleBrown;
            LabPassUser.Location = new System.Drawing.Point(19, 224);
            LabPassUser.Name = "LabPassUser";
            LabPassUser.Size = new System.Drawing.Size(63, 23);
            LabPassUser.TabIndex = 9;
            LabPassUser.Text = "Senha";
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "BdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // TxtCodUser
            // 
            this.TxtCodUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_usuario", true));
            this.TxtCodUser.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodUser.Location = new System.Drawing.Point(133, 32);
            this.TxtCodUser.MaxLength = 1;
            this.TxtCodUser.Name = "TxtCodUser";
            this.TxtCodUser.Size = new System.Drawing.Size(41, 23);
            this.TxtCodUser.TabIndex = 2;
            // 
            // TxtNameUser
            // 
            this.TxtNameUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_usuario", true));
            this.TxtNameUser.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameUser.Location = new System.Drawing.Point(133, 80);
            this.TxtNameUser.MaxLength = 50;
            this.TxtNameUser.Name = "TxtNameUser";
            this.TxtNameUser.Size = new System.Drawing.Size(537, 23);
            this.TxtNameUser.TabIndex = 4;
            // 
            // TxtNivelUser
            // 
            this.TxtNivelUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "sg_nivel", true));
            this.TxtNivelUser.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNivelUser.Location = new System.Drawing.Point(133, 128);
            this.TxtNivelUser.MaxLength = 1;
            this.TxtNivelUser.Name = "TxtNivelUser";
            this.TxtNivelUser.Size = new System.Drawing.Size(41, 23);
            this.TxtNivelUser.TabIndex = 6;
            this.TxtNivelUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNivelUser_KeyPress);
            // 
            // TxtLogUser
            // 
            this.TxtLogUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_login", true));
            this.TxtLogUser.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogUser.Location = new System.Drawing.Point(133, 176);
            this.TxtLogUser.MaxLength = 15;
            this.TxtLogUser.Name = "TxtLogUser";
            this.TxtLogUser.Size = new System.Drawing.Size(366, 23);
            this.TxtLogUser.TabIndex = 8;
            // 
            // TxtPassUser
            // 
            this.TxtPassUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_senha", true));
            this.TxtPassUser.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassUser.Location = new System.Drawing.Point(133, 224);
            this.TxtPassUser.MaxLength = 15;
            this.TxtPassUser.Name = "TxtPassUser";
            this.TxtPassUser.Size = new System.Drawing.Size(366, 23);
            this.TxtPassUser.TabIndex = 10;
            this.TxtPassUser.UseSystemPasswordChar = true;
            // 
            // BtnAnteriorUser
            // 
            this.BtnAnteriorUser.AutoSize = true;
            this.BtnAnteriorUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnAnteriorUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnteriorUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnAnteriorUser.Location = new System.Drawing.Point(76, 320);
            this.BtnAnteriorUser.Name = "BtnAnteriorUser";
            this.BtnAnteriorUser.Size = new System.Drawing.Size(115, 32);
            this.BtnAnteriorUser.TabIndex = 11;
            this.BtnAnteriorUser.Text = "Anterior";
            this.BtnAnteriorUser.UseVisualStyleBackColor = false;
            this.BtnAnteriorUser.Click += new System.EventHandler(this.BtnAnteriorUser_Click);
            // 
            // BtnExcluirUser
            // 
            this.BtnExcluirUser.AutoSize = true;
            this.BtnExcluirUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnExcluirUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnExcluirUser.Location = new System.Drawing.Point(576, 320);
            this.BtnExcluirUser.Name = "BtnExcluirUser";
            this.BtnExcluirUser.Size = new System.Drawing.Size(115, 32);
            this.BtnExcluirUser.TabIndex = 13;
            this.BtnExcluirUser.Text = "Excluir";
            this.BtnExcluirUser.UseVisualStyleBackColor = false;
            this.BtnExcluirUser.Click += new System.EventHandler(this.BtnExcluirUser_Click);
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.AutoSize = true;
            this.BtnNewUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnNewUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnNewUser.Location = new System.Drawing.Point(326, 320);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(115, 32);
            this.BtnNewUser.TabIndex = 14;
            this.BtnNewUser.Text = "Novo";
            this.BtnNewUser.UseVisualStyleBackColor = false;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // BtnAlterUser
            // 
            this.BtnAlterUser.AutoSize = true;
            this.BtnAlterUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnAlterUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnAlterUser.Location = new System.Drawing.Point(451, 320);
            this.BtnAlterUser.Name = "BtnAlterUser";
            this.BtnAlterUser.Size = new System.Drawing.Size(115, 32);
            this.BtnAlterUser.TabIndex = 15;
            this.BtnAlterUser.Text = "Alterar";
            this.BtnAlterUser.UseVisualStyleBackColor = false;
            this.BtnAlterUser.Click += new System.EventHandler(this.BtnAlterUser_Click);
            // 
            // BtnProsimoUser
            // 
            this.BtnProsimoUser.AutoSize = true;
            this.BtnProsimoUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnProsimoUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsimoUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnProsimoUser.Location = new System.Drawing.Point(201, 320);
            this.BtnProsimoUser.Name = "BtnProsimoUser";
            this.BtnProsimoUser.Size = new System.Drawing.Size(115, 32);
            this.BtnProsimoUser.TabIndex = 16;
            this.BtnProsimoUser.Text = "Próximo";
            this.BtnProsimoUser.UseVisualStyleBackColor = false;
            this.BtnProsimoUser.Click += new System.EventHandler(this.BtnProsimoUser_Click);
            // 
            // BtnCancelUser
            // 
            this.BtnCancelUser.AutoSize = true;
            this.BtnCancelUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnCancelUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnCancelUser.Location = new System.Drawing.Point(201, 358);
            this.BtnCancelUser.Name = "BtnCancelUser";
            this.BtnCancelUser.Size = new System.Drawing.Size(115, 32);
            this.BtnCancelUser.TabIndex = 21;
            this.BtnCancelUser.Text = "Cancelar";
            this.BtnCancelUser.UseVisualStyleBackColor = false;
            this.BtnCancelUser.Click += new System.EventHandler(this.BtnCancelUser_Click);
            // 
            // BtnPrintUser
            // 
            this.BtnPrintUser.AutoSize = true;
            this.BtnPrintUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnPrintUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnPrintUser.Location = new System.Drawing.Point(451, 358);
            this.BtnPrintUser.Name = "BtnPrintUser";
            this.BtnPrintUser.Size = new System.Drawing.Size(115, 32);
            this.BtnPrintUser.TabIndex = 20;
            this.BtnPrintUser.Text = "Imprimir";
            this.BtnPrintUser.UseVisualStyleBackColor = false;
            this.BtnPrintUser.Click += new System.EventHandler(this.BtnPrintUser_Click);
            // 
            // BtnPesUser
            // 
            this.BtnPesUser.AutoSize = true;
            this.BtnPesUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnPesUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnPesUser.Location = new System.Drawing.Point(326, 358);
            this.BtnPesUser.Name = "BtnPesUser";
            this.BtnPesUser.Size = new System.Drawing.Size(115, 32);
            this.BtnPesUser.TabIndex = 19;
            this.BtnPesUser.Text = "Pesquisar";
            this.BtnPesUser.UseVisualStyleBackColor = false;
            this.BtnPesUser.Click += new System.EventHandler(this.BtnPesUser_Click);
            // 
            // BtnExitUser
            // 
            this.BtnExitUser.AutoSize = true;
            this.BtnExitUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnExitUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnExitUser.Location = new System.Drawing.Point(576, 358);
            this.BtnExitUser.Name = "BtnExitUser";
            this.BtnExitUser.Size = new System.Drawing.Size(115, 32);
            this.BtnExitUser.TabIndex = 18;
            this.BtnExitUser.Text = "Sair";
            this.BtnExitUser.UseVisualStyleBackColor = false;
            this.BtnExitUser.Click += new System.EventHandler(this.BtnExitUser_Click);
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.AutoSize = true;
            this.BtnSaveUser.BackColor = System.Drawing.Color.Chocolate;
            this.BtnSaveUser.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveUser.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnSaveUser.Location = new System.Drawing.Point(76, 358);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(115, 32);
            this.BtnSaveUser.TabIndex = 17;
            this.BtnSaveUser.Text = "Salvar";
            this.BtnSaveUser.UseVisualStyleBackColor = false;
            this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(559, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 128);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // PdocDadosUser
            // 
            this.PdocDadosUser.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdocDadosUser_PrintPage);
            // 
            // PpdDadosUserView
            // 
            this.PpdDadosUserView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PpdDadosUserView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PpdDadosUserView.ClientSize = new System.Drawing.Size(400, 300);
            this.PpdDadosUserView.Document = this.PdocDadosUser;
            this.PpdDadosUserView.Enabled = true;
            this.PpdDadosUserView.Icon = ((System.Drawing.Icon)(resources.GetObject("PpdDadosUserView.Icon")));
            this.PpdDadosUserView.Name = "PpdDadosUserView";
            this.PpdDadosUserView.Visible = false;
            // 
            // BtnAdd10User
            // 
            this.BtnAdd10User.AutoSize = true;
            this.BtnAdd10User.BackColor = System.Drawing.Color.Chocolate;
            this.BtnAdd10User.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd10User.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnAdd10User.Location = new System.Drawing.Point(201, 396);
            this.BtnAdd10User.Name = "BtnAdd10User";
            this.BtnAdd10User.Size = new System.Drawing.Size(365, 32);
            this.BtnAdd10User.TabIndex = 35;
            this.BtnAdd10User.Text = "Fazer 50 cadastros";
            this.BtnAdd10User.UseVisualStyleBackColor = false;
            this.BtnAdd10User.Click += new System.EventHandler(this.BtnAdd10User_Click);
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdd10User);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelUser);
            this.Controls.Add(this.BtnPrintUser);
            this.Controls.Add(this.BtnPesUser);
            this.Controls.Add(this.BtnExitUser);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.BtnProsimoUser);
            this.Controls.Add(this.BtnAlterUser);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.BtnExcluirUser);
            this.Controls.Add(this.BtnAnteriorUser);
            this.Controls.Add(LabCdUser);
            this.Controls.Add(this.TxtCodUser);
            this.Controls.Add(LabNomeUser);
            this.Controls.Add(this.TxtNameUser);
            this.Controls.Add(LabNvlUser);
            this.Controls.Add(this.TxtNivelUser);
            this.Controls.Add(LabLogUser);
            this.Controls.Add(this.TxtLogUser);
            this.Controls.Add(LabPassUser);
            this.Controls.Add(this.TxtPassUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadUser";
            this.Text = "Cadastrar User";
            this.Load += new System.EventHandler(this.frmCadUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BdCadastroDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.TextBox TxtCodUser;
        private System.Windows.Forms.TextBox TxtNameUser;
        private System.Windows.Forms.TextBox TxtNivelUser;
        private System.Windows.Forms.TextBox TxtLogUser;
        private System.Windows.Forms.TextBox TxtPassUser;
        private System.Windows.Forms.Button BtnAnteriorUser;
        private System.Windows.Forms.Button BtnExcluirUser;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.Button BtnAlterUser;
        private System.Windows.Forms.Button BtnProsimoUser;
        private System.Windows.Forms.Button BtnCancelUser;
        private System.Windows.Forms.Button BtnPrintUser;
        private System.Windows.Forms.Button BtnPesUser;
        private System.Windows.Forms.Button BtnExitUser;
        private System.Windows.Forms.Button BtnSaveUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument PdocDadosUser;
        private System.Windows.Forms.PrintPreviewDialog PpdDadosUserView;
        private System.Windows.Forms.Button BtnAdd10User;
    }
}