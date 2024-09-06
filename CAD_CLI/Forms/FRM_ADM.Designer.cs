namespace CAD_CLI.Forms
{
    partial class FRM_ADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADM));
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.LBL_TITULO = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.LBL_SENHA = new System.Windows.Forms.Label();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.BTN_ENTRAR = new System.Windows.Forms.Button();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_USUARIO.Location = new System.Drawing.Point(26, 51);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(55, 16);
            this.LBL_USUARIO.TabIndex = 0;
            this.LBL_USUARIO.Text = "Usuário:";
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LBL_TITULO.Location = new System.Drawing.Point(56, 18);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(191, 22);
            this.LBL_TITULO.TabIndex = 1;
            this.LBL_TITULO.Text = "Usuário Adminstrador";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(29, 71);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(140, 20);
            this.TXT_USUARIO.TabIndex = 0;
            this.TXT_USUARIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_USUARIO_KeyDown);
            // 
            // LBL_SENHA
            // 
            this.LBL_SENHA.AutoSize = true;
            this.LBL_SENHA.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LBL_SENHA.Location = new System.Drawing.Point(26, 94);
            this.LBL_SENHA.Name = "LBL_SENHA";
            this.LBL_SENHA.Size = new System.Drawing.Size(48, 16);
            this.LBL_SENHA.TabIndex = 3;
            this.LBL_SENHA.Text = "Senha:";
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Location = new System.Drawing.Point(29, 114);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(140, 20);
            this.MBX_SENHA.TabIndex = 1;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            this.MBX_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_SENHA_KeyDown);
            // 
            // BTN_ENTRAR
            // 
            this.BTN_ENTRAR.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_ENTRAR.Location = new System.Drawing.Point(197, 71);
            this.BTN_ENTRAR.Name = "BTN_ENTRAR";
            this.BTN_ENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENTRAR.TabIndex = 2;
            this.BTN_ENTRAR.Text = "Entrar";
            this.BTN_ENTRAR.UseVisualStyleBackColor = true;
            this.BTN_ENTRAR.Click += new System.EventHandler(this.BTN_ENTRAR_Click);
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BTN_SAIR.Location = new System.Drawing.Point(197, 114);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAIR.TabIndex = 3;
            this.BTN_SAIR.Text = "Fechar";
            this.BTN_SAIR.UseVisualStyleBackColor = true;
            this.BTN_SAIR.Click += new System.EventHandler(this.BTN_SAIR_Click);
            // 
            // FRM_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 161);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.BTN_ENTRAR);
            this.Controls.Add(this.MBX_SENHA);
            this.Controls.Add(this.LBL_SENHA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_TITULO);
            this.Controls.Add(this.LBL_USUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Permissão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.Label LBL_TITULO;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label LBL_SENHA;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Button BTN_ENTRAR;
        private System.Windows.Forms.Button BTN_SAIR;
    }
}