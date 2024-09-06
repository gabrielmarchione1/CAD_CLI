namespace CAD_CLI.Forms
{
    partial class FRM_PRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRINCIPAL));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTN_CAD_CLIENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CAD_ENDERECO = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CAD_TELEFONE = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CAD_EMAIL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_CAD_CLIENTE,
            this.BTN_CAD_ENDERECO,
            this.BTN_CAD_TELEFONE,
            this.BTN_CAD_EMAIL});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton1.Text = "&Cadastrar";
            // 
            // BTN_CAD_CLIENTE
            // 
            this.BTN_CAD_CLIENTE.Image = global::CAD_CLI.Properties.Resources.cad_cliente1;
            this.BTN_CAD_CLIENTE.Name = "BTN_CAD_CLIENTE";
            this.BTN_CAD_CLIENTE.Size = new System.Drawing.Size(123, 22);
            this.BTN_CAD_CLIENTE.Text = "C&liente";
            this.BTN_CAD_CLIENTE.Click += new System.EventHandler(this.BTN_CAD_CLIENTE_Click);
            // 
            // BTN_CAD_ENDERECO
            // 
            this.BTN_CAD_ENDERECO.Image = global::CAD_CLI.Properties.Resources.cad_end1;
            this.BTN_CAD_ENDERECO.Name = "BTN_CAD_ENDERECO";
            this.BTN_CAD_ENDERECO.Size = new System.Drawing.Size(123, 22);
            this.BTN_CAD_ENDERECO.Text = "&Endereço";
            this.BTN_CAD_ENDERECO.Click += new System.EventHandler(this.BTN_CAD_ENDERECO_Click);
            // 
            // BTN_CAD_TELEFONE
            // 
            this.BTN_CAD_TELEFONE.Image = global::CAD_CLI.Properties.Resources.cad_tel1;
            this.BTN_CAD_TELEFONE.Name = "BTN_CAD_TELEFONE";
            this.BTN_CAD_TELEFONE.Size = new System.Drawing.Size(123, 22);
            this.BTN_CAD_TELEFONE.Text = "&Telefone";
            this.BTN_CAD_TELEFONE.Click += new System.EventHandler(this.BTN_CAD_TELEFONE_Click);
            // 
            // BTN_CAD_EMAIL
            // 
            this.BTN_CAD_EMAIL.Image = global::CAD_CLI.Properties.Resources.cad_email2;
            this.BTN_CAD_EMAIL.Name = "BTN_CAD_EMAIL";
            this.BTN_CAD_EMAIL.Size = new System.Drawing.Size(123, 22);
            this.BTN_CAD_EMAIL.Text = "E&mail";
            this.BTN_CAD_EMAIL.Click += new System.EventHandler(this.BTN_CAD_EMAIL_Click);
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FRM_PRINCIPAL";
            this.Text = "CadCli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_CLIENTE;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_ENDERECO;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_TELEFONE;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_EMAIL;
    }
}