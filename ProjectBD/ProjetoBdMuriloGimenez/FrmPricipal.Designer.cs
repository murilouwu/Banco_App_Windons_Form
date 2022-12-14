
namespace ProjetoBdMuriloGimenez
{
    partial class FrmPricipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPricipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripItRelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripItRelClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripItRelForne = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripItRelProd = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbxBtnsMenu = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnCadUser = new System.Windows.Forms.Button();
            this.BtnRelFor = new System.Windows.Forms.Button();
            this.LabCadAtl = new System.Windows.Forms.Label();
            this.BtnRelProd = new System.Windows.Forms.Button();
            this.BtnCadClie = new System.Windows.Forms.Button();
            this.BtnRelClie = new System.Windows.Forms.Button();
            this.BtnCadProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadFor = new System.Windows.Forms.Button();
            this.BtnRelUser = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GbxBtnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripItRelUser,
            this.MnStripItRelClient,
            this.MnStripItRelForne,
            this.MnStripItRelProd});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MnStripItRelUser
            // 
            this.MnStripItRelUser.BackColor = System.Drawing.SystemColors.Control;
            this.MnStripItRelUser.Name = "MnStripItRelUser";
            this.MnStripItRelUser.Size = new System.Drawing.Size(180, 22);
            this.MnStripItRelUser.Text = "Usuario";
            this.MnStripItRelUser.Click += new System.EventHandler(this.MnStripItRelUser_Click);
            // 
            // MnStripItRelClient
            // 
            this.MnStripItRelClient.BackColor = System.Drawing.SystemColors.Control;
            this.MnStripItRelClient.Name = "MnStripItRelClient";
            this.MnStripItRelClient.Size = new System.Drawing.Size(180, 22);
            this.MnStripItRelClient.Text = "Clientes";
            this.MnStripItRelClient.Click += new System.EventHandler(this.MnStripItRelClient_Click);
            // 
            // MnStripItRelForne
            // 
            this.MnStripItRelForne.BackColor = System.Drawing.SystemColors.Control;
            this.MnStripItRelForne.Name = "MnStripItRelForne";
            this.MnStripItRelForne.Size = new System.Drawing.Size(180, 22);
            this.MnStripItRelForne.Text = "Fornecedores";
            this.MnStripItRelForne.Click += new System.EventHandler(this.MnStripItRelForne_Click);
            // 
            // MnStripItRelProd
            // 
            this.MnStripItRelProd.BackColor = System.Drawing.SystemColors.Control;
            this.MnStripItRelProd.Name = "MnStripItRelProd";
            this.MnStripItRelProd.Size = new System.Drawing.Size(180, 22);
            this.MnStripItRelProd.Text = "Produtos";
            this.MnStripItRelProd.Click += new System.EventHandler(this.MnStripItRelProd_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.sobreToolStripMenuItem.Text = "Projeto";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // GbxBtnsMenu
            // 
            this.GbxBtnsMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GbxBtnsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GbxBtnsMenu.Controls.Add(this.BtnExit);
            this.GbxBtnsMenu.Controls.Add(this.BtnSobre);
            this.GbxBtnsMenu.Controls.Add(this.BtnCadUser);
            this.GbxBtnsMenu.Controls.Add(this.BtnRelFor);
            this.GbxBtnsMenu.Controls.Add(this.LabCadAtl);
            this.GbxBtnsMenu.Controls.Add(this.BtnRelProd);
            this.GbxBtnsMenu.Controls.Add(this.BtnCadClie);
            this.GbxBtnsMenu.Controls.Add(this.BtnRelClie);
            this.GbxBtnsMenu.Controls.Add(this.BtnCadProd);
            this.GbxBtnsMenu.Controls.Add(this.label1);
            this.GbxBtnsMenu.Controls.Add(this.BtnCadFor);
            this.GbxBtnsMenu.Controls.Add(this.BtnRelUser);
            this.GbxBtnsMenu.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxBtnsMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GbxBtnsMenu.Location = new System.Drawing.Point(40, 44);
            this.GbxBtnsMenu.Name = "GbxBtnsMenu";
            this.GbxBtnsMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GbxBtnsMenu.Size = new System.Drawing.Size(1457, 387);
            this.GbxBtnsMenu.TabIndex = 1;
            this.GbxBtnsMenu.TabStop = false;
            this.GbxBtnsMenu.Text = "Main";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnExit.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnExit.Location = new System.Drawing.Point(647, 216);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(183, 50);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSobre
            // 
            this.BtnSobre.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnSobre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSobre.Location = new System.Drawing.Point(647, 160);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Size = new System.Drawing.Size(183, 50);
            this.BtnSobre.TabIndex = 13;
            this.BtnSobre.Text = "Projeto";
            this.BtnSobre.UseVisualStyleBackColor = false;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // BtnCadUser
            // 
            this.BtnCadUser.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnCadUser.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCadUser.Location = new System.Drawing.Point(432, 104);
            this.BtnCadUser.Name = "BtnCadUser";
            this.BtnCadUser.Size = new System.Drawing.Size(183, 50);
            this.BtnCadUser.TabIndex = 2;
            this.BtnCadUser.Text = "Usuario";
            this.BtnCadUser.UseVisualStyleBackColor = false;
            this.BtnCadUser.Click += new System.EventHandler(this.BtnCadUser_Click);
            // 
            // BtnRelFor
            // 
            this.BtnRelFor.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnRelFor.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelFor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRelFor.Location = new System.Drawing.Point(864, 216);
            this.BtnRelFor.Name = "BtnRelFor";
            this.BtnRelFor.Size = new System.Drawing.Size(183, 50);
            this.BtnRelFor.TabIndex = 12;
            this.BtnRelFor.Text = "Fornecedores";
            this.BtnRelFor.UseVisualStyleBackColor = false;
            this.BtnRelFor.Click += new System.EventHandler(this.BtnRelFor_Click);
            // 
            // LabCadAtl
            // 
            this.LabCadAtl.AutoSize = true;
            this.LabCadAtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadAtl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabCadAtl.Location = new System.Drawing.Point(455, 72);
            this.LabCadAtl.Name = "LabCadAtl";
            this.LabCadAtl.Size = new System.Drawing.Size(118, 29);
            this.LabCadAtl.TabIndex = 4;
            this.LabCadAtl.Text = "Cadastro";
            // 
            // BtnRelProd
            // 
            this.BtnRelProd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnRelProd.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelProd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRelProd.Location = new System.Drawing.Point(864, 272);
            this.BtnRelProd.Name = "BtnRelProd";
            this.BtnRelProd.Size = new System.Drawing.Size(183, 50);
            this.BtnRelProd.TabIndex = 11;
            this.BtnRelProd.Text = "Produtos";
            this.BtnRelProd.UseVisualStyleBackColor = false;
            this.BtnRelProd.Click += new System.EventHandler(this.BtnRelProd_Click);
            // 
            // BtnCadClie
            // 
            this.BtnCadClie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnCadClie.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadClie.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCadClie.Location = new System.Drawing.Point(432, 160);
            this.BtnCadClie.Name = "BtnCadClie";
            this.BtnCadClie.Size = new System.Drawing.Size(183, 50);
            this.BtnCadClie.TabIndex = 5;
            this.BtnCadClie.Text = "Clientes";
            this.BtnCadClie.UseVisualStyleBackColor = false;
            this.BtnCadClie.Click += new System.EventHandler(this.BtnCadClie_Click);
            // 
            // BtnRelClie
            // 
            this.BtnRelClie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnRelClie.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelClie.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRelClie.Location = new System.Drawing.Point(864, 160);
            this.BtnRelClie.Name = "BtnRelClie";
            this.BtnRelClie.Size = new System.Drawing.Size(183, 50);
            this.BtnRelClie.TabIndex = 10;
            this.BtnRelClie.Text = "Clientes";
            this.BtnRelClie.UseVisualStyleBackColor = false;
            this.BtnRelClie.Click += new System.EventHandler(this.BtnRelClie_Click);
            // 
            // BtnCadProd
            // 
            this.BtnCadProd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnCadProd.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadProd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCadProd.Location = new System.Drawing.Point(432, 272);
            this.BtnCadProd.Name = "BtnCadProd";
            this.BtnCadProd.Size = new System.Drawing.Size(183, 50);
            this.BtnCadProd.TabIndex = 6;
            this.BtnCadProd.Text = "Produtos";
            this.BtnCadProd.UseVisualStyleBackColor = false;
            this.BtnCadProd.Click += new System.EventHandler(this.BtnCadProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(893, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Relatórios";
            // 
            // BtnCadFor
            // 
            this.BtnCadFor.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnCadFor.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadFor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCadFor.Location = new System.Drawing.Point(432, 216);
            this.BtnCadFor.Name = "BtnCadFor";
            this.BtnCadFor.Size = new System.Drawing.Size(183, 50);
            this.BtnCadFor.TabIndex = 7;
            this.BtnCadFor.Text = "Fornecedores";
            this.BtnCadFor.UseVisualStyleBackColor = false;
            this.BtnCadFor.Click += new System.EventHandler(this.BtnCadFor_Click);
            // 
            // BtnRelUser
            // 
            this.BtnRelUser.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnRelUser.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRelUser.Location = new System.Drawing.Point(864, 104);
            this.BtnRelUser.Name = "BtnRelUser";
            this.BtnRelUser.Size = new System.Drawing.Size(183, 50);
            this.BtnRelUser.TabIndex = 8;
            this.BtnRelUser.Text = "Usuario";
            this.BtnRelUser.UseVisualStyleBackColor = false;
            this.BtnRelUser.Click += new System.EventHandler(this.BtnRelUser_Click);
            // 
            // FrmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1575, 456);
            this.Controls.Add(this.GbxBtnsMenu);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPricipal";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbxBtnsMenu.ResumeLayout(false);
            this.GbxBtnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox GbxBtnsMenu;
        private System.Windows.Forms.Button BtnCadUser;
        private System.Windows.Forms.Label LabCadAtl;
        private System.Windows.Forms.Button BtnCadClie;
        private System.Windows.Forms.Button BtnCadProd;
        private System.Windows.Forms.Button BtnCadFor;
        private System.Windows.Forms.Button BtnRelFor;
        private System.Windows.Forms.Button BtnRelProd;
        private System.Windows.Forms.Button BtnRelClie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRelUser;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolStripMenuItem MnStripItRelUser;
        private System.Windows.Forms.ToolStripMenuItem MnStripItRelClient;
        private System.Windows.Forms.ToolStripMenuItem MnStripItRelForne;
        private System.Windows.Forms.ToolStripMenuItem MnStripItRelProd;
    }
}

