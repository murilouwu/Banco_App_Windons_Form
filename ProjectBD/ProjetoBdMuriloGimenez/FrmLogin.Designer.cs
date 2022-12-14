namespace ProjetoBdMuriloGimenez
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSairLogin = new System.Windows.Forms.Button();
            this.nm_login = new System.Windows.Forms.TextBox();
            this.cd_senha = new System.Windows.Forms.TextBox();
            this.bdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnEntrarLogin.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEntrarLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEntrarLogin.Location = new System.Drawing.Point(17, 228);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(224, 79);
            this.BtnEntrarLogin.TabIndex = 2;
            this.BtnEntrarLogin.Text = "Entrar";
            this.BtnEntrarLogin.UseVisualStyleBackColor = false;
            this.BtnEntrarLogin.Click += new System.EventHandler(this.BtnEntrarLogin_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // BtnSairLogin
            // 
            this.BtnSairLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnSairLogin.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnSairLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSairLogin.Location = new System.Drawing.Point(267, 228);
            this.BtnSairLogin.Name = "BtnSairLogin";
            this.BtnSairLogin.Size = new System.Drawing.Size(224, 79);
            this.BtnSairLogin.TabIndex = 4;
            this.BtnSairLogin.Text = "Sair";
            this.BtnSairLogin.UseVisualStyleBackColor = false;
            this.BtnSairLogin.Click += new System.EventHandler(this.BtnSairLogin_Click);
            // 
            // nm_login
            // 
            this.nm_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_login.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_login.Location = new System.Drawing.Point(174, 56);
            this.nm_login.MaxLength = 50;
            this.nm_login.Multiline = true;
            this.nm_login.Name = "nm_login";
            this.nm_login.Size = new System.Drawing.Size(317, 51);
            this.nm_login.TabIndex = 5;
            // 
            // cd_senha
            // 
            this.cd_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cd_senha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_senha.Location = new System.Drawing.Point(174, 131);
            this.cd_senha.MaxLength = 50;
            this.cd_senha.Multiline = true;
            this.cd_senha.Name = "cd_senha";
            this.cd_senha.Size = new System.Drawing.Size(317, 51);
            this.cd_senha.TabIndex = 6;
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 355);
            this.Controls.Add(this.cd_senha);
            this.Controls.Add(this.nm_login);
            this.Controls.Add(this.BtnSairLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEntrarLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSairLogin;
        private System.Windows.Forms.TextBox nm_login;
        private System.Windows.Forms.TextBox cd_senha;
        private BdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BdCadastroDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
    }
}