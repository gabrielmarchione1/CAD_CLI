namespace CAD_CLI.Forms
{
    partial class FRM_CAD_ENDERECO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAD_ENDERECO));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MBX_UF = new System.Windows.Forms.MaskedTextBox();
            this.MBX_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_CIDADE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_BAIRRO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_COMPLEMENTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_NUMERO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_LOGRADOURO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_CLIENTE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_ADICIONAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_ALTERAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_CONSULTAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_DELETAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_LIMPAR_DADOS = new System.Windows.Forms.ToolStripButton();
            this.DGV_DADOS = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MBX_UF);
            this.splitContainer1.Panel1.Controls.Add(this.MBX_CEP);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_CIDADE);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_BAIRRO);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_COMPLEMENTO);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_NUMERO);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.TXT_LOGRADOURO);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CBX_CLIENTE);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_DADOS);
            this.splitContainer1.Size = new System.Drawing.Size(762, 464);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // MBX_UF
            // 
            this.MBX_UF.Location = new System.Drawing.Point(292, 156);
            this.MBX_UF.Mask = "AA";
            this.MBX_UF.Name = "MBX_UF";
            this.MBX_UF.Size = new System.Drawing.Size(28, 20);
            this.MBX_UF.TabIndex = 6;
            // 
            // MBX_CEP
            // 
            this.MBX_CEP.Location = new System.Drawing.Point(292, 200);
            this.MBX_CEP.Mask = "00000-000";
            this.MBX_CEP.Name = "MBX_CEP";
            this.MBX_CEP.Size = new System.Drawing.Size(59, 20);
            this.MBX_CEP.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "UF:";
            // 
            // TXT_CIDADE
            // 
            this.TXT_CIDADE.Location = new System.Drawing.Point(292, 102);
            this.TXT_CIDADE.Name = "TXT_CIDADE";
            this.TXT_CIDADE.Size = new System.Drawing.Size(112, 20);
            this.TXT_CIDADE.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade:";
            // 
            // TXT_BAIRRO
            // 
            this.TXT_BAIRRO.Location = new System.Drawing.Point(292, 51);
            this.TXT_BAIRRO.Name = "TXT_BAIRRO";
            this.TXT_BAIRRO.Size = new System.Drawing.Size(112, 20);
            this.TXT_BAIRRO.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bairro:";
            // 
            // TXT_COMPLEMENTO
            // 
            this.TXT_COMPLEMENTO.Location = new System.Drawing.Point(35, 200);
            this.TXT_COMPLEMENTO.Name = "TXT_COMPLEMENTO";
            this.TXT_COMPLEMENTO.Size = new System.Drawing.Size(193, 20);
            this.TXT_COMPLEMENTO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Complemento:";
            // 
            // TXT_NUMERO
            // 
            this.TXT_NUMERO.Location = new System.Drawing.Point(35, 156);
            this.TXT_NUMERO.Name = "TXT_NUMERO";
            this.TXT_NUMERO.Size = new System.Drawing.Size(44, 20);
            this.TXT_NUMERO.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número:";
            // 
            // TXT_LOGRADOURO
            // 
            this.TXT_LOGRADOURO.Location = new System.Drawing.Point(35, 105);
            this.TXT_LOGRADOURO.Name = "TXT_LOGRADOURO";
            this.TXT_LOGRADOURO.Size = new System.Drawing.Size(193, 20);
            this.TXT_LOGRADOURO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logradouro:";
            // 
            // CBX_CLIENTE
            // 
            this.CBX_CLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_CLIENTE.FormattingEnabled = true;
            this.CBX_CLIENTE.Location = new System.Drawing.Point(35, 50);
            this.CBX_CLIENTE.Name = "CBX_CLIENTE";
            this.CBX_CLIENTE.Size = new System.Drawing.Size(193, 21);
            this.CBX_CLIENTE.TabIndex = 0;
            this.CBX_CLIENTE.SelectionChangeCommitted += new System.EventHandler(this.CBX_CLIENTE_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Cliente:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_ADICIONAR,
            this.toolStripSeparator1,
            this.BTN_ALTERAR,
            this.toolStripSeparator2,
            this.BTN_CONSULTAR,
            this.toolStripSeparator3,
            this.BTN_DELETAR,
            this.toolStripSeparator6,
            this.BTN_LIMPAR_DADOS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_ADICIONAR
            // 
            this.BTN_ADICIONAR.Image = global::CAD_CLI.Properties.Resources.add;
            this.BTN_ADICIONAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_ADICIONAR.Name = "BTN_ADICIONAR";
            this.BTN_ADICIONAR.Size = new System.Drawing.Size(78, 22);
            this.BTN_ADICIONAR.Text = "Adicionar";
            this.BTN_ADICIONAR.Click += new System.EventHandler(this.BTN_ADICIONAR_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_ALTERAR
            // 
            this.BTN_ALTERAR.Image = global::CAD_CLI.Properties.Resources.alterar;
            this.BTN_ALTERAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_ALTERAR.Name = "BTN_ALTERAR";
            this.BTN_ALTERAR.Size = new System.Drawing.Size(62, 22);
            this.BTN_ALTERAR.Text = "Alterar";
            this.BTN_ALTERAR.Click += new System.EventHandler(this.BTN_ALTERAR_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_CONSULTAR
            // 
            this.BTN_CONSULTAR.Image = global::CAD_CLI.Properties.Resources.consultar1;
            this.BTN_CONSULTAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_CONSULTAR.Name = "BTN_CONSULTAR";
            this.BTN_CONSULTAR.Size = new System.Drawing.Size(78, 22);
            this.BTN_CONSULTAR.Text = "Consultar";
            this.BTN_CONSULTAR.Click += new System.EventHandler(this.BTN_CONSULTAR_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_DELETAR
            // 
            this.BTN_DELETAR.Image = global::CAD_CLI.Properties.Resources.deletar;
            this.BTN_DELETAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_DELETAR.Name = "BTN_DELETAR";
            this.BTN_DELETAR.Size = new System.Drawing.Size(64, 22);
            this.BTN_DELETAR.Text = "Deletar";
            this.BTN_DELETAR.Click += new System.EventHandler(this.BTN_DELETAR_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_LIMPAR_DADOS
            // 
            this.BTN_LIMPAR_DADOS.Image = global::CAD_CLI.Properties.Resources.limpar;
            this.BTN_LIMPAR_DADOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_LIMPAR_DADOS.Name = "BTN_LIMPAR_DADOS";
            this.BTN_LIMPAR_DADOS.Size = new System.Drawing.Size(64, 22);
            this.BTN_LIMPAR_DADOS.Text = "Limpar";
            this.BTN_LIMPAR_DADOS.Click += new System.EventHandler(this.BTN_LIMPAR_DADOS_Click);
            // 
            // DGV_DADOS
            // 
            this.DGV_DADOS.AllowUserToAddRows = false;
            this.DGV_DADOS.AllowUserToDeleteRows = false;
            this.DGV_DADOS.AllowUserToResizeRows = false;
            this.DGV_DADOS.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn});
            this.DGV_DADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DADOS.Location = new System.Drawing.Point(0, 0);
            this.DGV_DADOS.Name = "DGV_DADOS";
            this.DGV_DADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DADOS.ShowCellToolTips = false;
            this.DGV_DADOS.Size = new System.Drawing.Size(762, 310);
            this.DGV_DADOS.TabIndex = 1;
            this.DGV_DADOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DADOS_CellClick);
            this.DGV_DADOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DADOS_CellDoubleClick);
            this.DGV_DADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_DADOS_CellFormatting);
            this.DGV_DADOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DADOS_DataBindingComplete);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.Name = "checkBoxColumn";
            // 
            // FRM_CAD_ENDERECO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 464);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_CAD_ENDERECO";
            this.Text = "Cadastro de Endereços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_CAD_ENDERECO_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_ADICIONAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_ALTERAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_CONSULTAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTN_DELETAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTN_LIMPAR_DADOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_CIDADE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_BAIRRO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_COMPLEMENTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_NUMERO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_LOGRADOURO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBX_CLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MBX_CEP;
        public System.Windows.Forms.DataGridView DGV_DADOS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.MaskedTextBox MBX_UF;
    }
}