namespace CAD_CLI.Forms
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.LBL_TITULO = new System.Windows.Forms.Label();
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.LBL_SENHA = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.BTN_ENTRAR = new System.Windows.Forms.Button();
            this.LBL_ADD_USUARIO = new System.Windows.Forms.Label();
            this.LBL_SUBTITULO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.LBL_TITULO.Location = new System.Drawing.Point(132, 25);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(126, 41);
            this.LBL_TITULO.TabIndex = 0;
            this.LBL_TITULO.Text = "CadCli";
            this.LBL_TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_USUARIO.Location = new System.Drawing.Point(44, 109);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(75, 19);
            this.LBL_USUARIO.TabIndex = 1;
            this.LBL_USUARIO.Text = "Usuário:";
            // 
            // LBL_SENHA
            // 
            this.LBL_SENHA.AutoSize = true;
            this.LBL_SENHA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_SENHA.Location = new System.Drawing.Point(44, 160);
            this.LBL_SENHA.Name = "LBL_SENHA";
            this.LBL_SENHA.Size = new System.Drawing.Size(64, 19);
            this.LBL_SENHA.TabIndex = 2;
            this.LBL_SENHA.Text = "Senha:";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(48, 133);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(174, 20);
            this.TXT_USUARIO.TabIndex = 0;
            this.TXT_USUARIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_USUARIO_KeyDown);
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Location = new System.Drawing.Point(48, 183);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(174, 20);
            this.MBX_SENHA.TabIndex = 1;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            this.MBX_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_SENHA_KeyDown);
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.Font = new System.Drawing.Font("Arial", 9F);
            this.BTN_SAIR.Location = new System.Drawing.Point(260, 183);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAIR.TabIndex = 4;
            this.BTN_SAIR.Text = "Sair";
            this.BTN_SAIR.UseVisualStyleBackColor = true;
            this.BTN_SAIR.Click += new System.EventHandler(this.BTN_SAIR_Click);
            // 
            // BTN_ENTRAR
            // 
            this.BTN_ENTRAR.Font = new System.Drawing.Font("Arial", 9F);
            this.BTN_ENTRAR.Location = new System.Drawing.Point(260, 133);
            this.BTN_ENTRAR.Name = "BTN_ENTRAR";
            this.BTN_ENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENTRAR.TabIndex = 3;
            this.BTN_ENTRAR.Text = "Entrar";
            this.BTN_ENTRAR.UseVisualStyleBackColor = true;
            this.BTN_ENTRAR.Click += new System.EventHandler(this.BTN_ENTRAR_Click);
            // 
            // LBL_ADD_USUARIO
            // 
            this.LBL_ADD_USUARIO.AutoSize = true;
            this.LBL_ADD_USUARIO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ADD_USUARIO.Location = new System.Drawing.Point(45, 217);
            this.LBL_ADD_USUARIO.Name = "LBL_ADD_USUARIO";
            this.LBL_ADD_USUARIO.Size = new System.Drawing.Size(120, 16);
            this.LBL_ADD_USUARIO.TabIndex = 2;
            this.LBL_ADD_USUARIO.Text = "Adicionar Usuário";
            this.LBL_ADD_USUARIO.Click += new System.EventHandler(this.LBL_ADD_USUARIO_Click);
            this.LBL_ADD_USUARIO.MouseEnter += new System.EventHandler(this.LBL_ADD_USUARIO_MouseEnter);
            this.LBL_ADD_USUARIO.MouseLeave += new System.EventHandler(this.LBL_ADD_USUARIO_MouseLeave);
            // 
            // LBL_SUBTITULO
            // 
            this.LBL_SUBTITULO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SUBTITULO.Location = new System.Drawing.Point(95, 66);
            this.LBL_SUBTITULO.Name = "LBL_SUBTITULO";
            this.LBL_SUBTITULO.Size = new System.Drawing.Size(200, 23);
            this.LBL_SUBTITULO.TabIndex = 8;
            this.LBL_SUBTITULO.Text = "Sistema de Cadastro de Clientes";
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 254);
            this.Controls.Add(this.LBL_SUBTITULO);
            this.Controls.Add(this.LBL_ADD_USUARIO);
            this.Controls.Add(this.BTN_ENTRAR);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.MBX_SENHA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_SENHA);
            this.Controls.Add(this.LBL_USUARIO);
            this.Controls.Add(this.LBL_TITULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_LOGIN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadCli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_TITULO;
        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.Label LBL_SENHA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Button BTN_SAIR;
        private System.Windows.Forms.Button BTN_ENTRAR;
        private System.Windows.Forms.Label LBL_ADD_USUARIO;
        private System.Windows.Forms.Label LBL_SUBTITULO;
    }
}