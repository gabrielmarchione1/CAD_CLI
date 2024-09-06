namespace CAD_CLI.Forms
{
    partial class FRM_CAD_USUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAD_USUARIO));
            this.LBL_TITULO = new System.Windows.Forms.Label();
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.LBL_SENHA = new System.Windows.Forms.Label();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.BTN_CADASTRAR = new System.Windows.Forms.Button();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.LBL_CONFIRMAR_SENHA = new System.Windows.Forms.Label();
            this.MBX_CONFIRMAR_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITULO.Location = new System.Drawing.Point(59, 18);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(181, 24);
            this.LBL_TITULO.TabIndex = 0;
            this.LBL_TITULO.Text = "Cadastrar Usuário";
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_USUARIO.Location = new System.Drawing.Point(23, 53);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(55, 16);
            this.LBL_USUARIO.TabIndex = 1;
            this.LBL_USUARIO.Text = "Usuário:";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(26, 75);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(140, 20);
            this.TXT_USUARIO.TabIndex = 0;
            this.TXT_USUARIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_USUARIO_KeyDown);
            // 
            // LBL_SENHA
            // 
            this.LBL_SENHA.AutoSize = true;
            this.LBL_SENHA.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_SENHA.Location = new System.Drawing.Point(23, 98);
            this.LBL_SENHA.Name = "LBL_SENHA";
            this.LBL_SENHA.Size = new System.Drawing.Size(48, 16);
            this.LBL_SENHA.TabIndex = 3;
            this.LBL_SENHA.Text = "Senha:";
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Location = new System.Drawing.Point(26, 120);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(140, 20);
            this.MBX_SENHA.TabIndex = 1;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            this.MBX_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_SENHA_KeyDown);
            // 
            // BTN_CADASTRAR
            // 
            this.BTN_CADASTRAR.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_CADASTRAR.Location = new System.Drawing.Point(200, 75);
            this.BTN_CADASTRAR.Name = "BTN_CADASTRAR";
            this.BTN_CADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_CADASTRAR.TabIndex = 3;
            this.BTN_CADASTRAR.Text = "Cadastrar";
            this.BTN_CADASTRAR.UseVisualStyleBackColor = true;
            this.BTN_CADASTRAR.Click += new System.EventHandler(this.BTN_CADASTRAR_Click);
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_SAIR.Location = new System.Drawing.Point(200, 117);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAIR.TabIndex = 4;
            this.BTN_SAIR.Text = "Fechar";
            this.BTN_SAIR.UseVisualStyleBackColor = true;
            this.BTN_SAIR.Click += new System.EventHandler(this.BTN_SAIR_Click);
            // 
            // LBL_CONFIRMAR_SENHA
            // 
            this.LBL_CONFIRMAR_SENHA.AutoSize = true;
            this.LBL_CONFIRMAR_SENHA.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_CONFIRMAR_SENHA.Location = new System.Drawing.Point(23, 143);
            this.LBL_CONFIRMAR_SENHA.Name = "LBL_CONFIRMAR_SENHA";
            this.LBL_CONFIRMAR_SENHA.Size = new System.Drawing.Size(112, 16);
            this.LBL_CONFIRMAR_SENHA.TabIndex = 7;
            this.LBL_CONFIRMAR_SENHA.Text = "Confirme a senha:";
            // 
            // MBX_CONFIRMAR_SENHA
            // 
            this.MBX_CONFIRMAR_SENHA.Location = new System.Drawing.Point(26, 162);
            this.MBX_CONFIRMAR_SENHA.Name = "MBX_CONFIRMAR_SENHA";
            this.MBX_CONFIRMAR_SENHA.Size = new System.Drawing.Size(140, 20);
            this.MBX_CONFIRMAR_SENHA.TabIndex = 2;
            this.MBX_CONFIRMAR_SENHA.UseSystemPasswordChar = true;
            this.MBX_CONFIRMAR_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_CONFIRMAR_SENHA_KeyDown);
            // 
            // FRM_CAD_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 198);
            this.Controls.Add(this.MBX_CONFIRMAR_SENHA);
            this.Controls.Add(this.LBL_CONFIRMAR_SENHA);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.BTN_CADASTRAR);
            this.Controls.Add(this.MBX_SENHA);
            this.Controls.Add(this.LBL_SENHA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_USUARIO);
            this.Controls.Add(this.LBL_TITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_CAD_USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_TITULO;
        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label LBL_SENHA;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Button BTN_CADASTRAR;
        private System.Windows.Forms.Button BTN_SAIR;
        private System.Windows.Forms.Label LBL_CONFIRMAR_SENHA;
        private System.Windows.Forms.MaskedTextBox MBX_CONFIRMAR_SENHA;
    }
}