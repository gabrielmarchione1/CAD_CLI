using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_CLI.Forms
{
    /// <summary>
    /// Formulário de Login.
    /// </summary>
    public partial class FRM_LOGIN : Form
    {
        private CAD_CLI.NEGOCIOS.CRUD_NEG ObjNEG = new NEGOCIOS.CRUD_NEG();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_LOGIN ObjEnt = new ENTIDADES.CAD_CLI_TBL_LOGIN();

        /// <summary>
        /// Construtor da classe FRM_LOGIN
        /// Inicializa os componentes do formulário de login.
        /// </summary>
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para montar entidade.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano indicando de a entidade foi montada com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENTIDADES.CAD_CLI_TBL_LOGIN();

                if (TXT_USUARIO.Text.Length == 0)
                {
                    return false;
                }
                if (MBX_SENHA.Text.Length == 0)
                {
                    return false;
                }

                ObjEnt.NOME_USUARIO = TXT_USUARIO.Text;
                ObjEnt.SENHA_USUARIO = MBX_SENHA.Text;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar usuário.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool CONSULTAR_USUARIO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_CAD_CLI_TBL_LOGIN(TXT_USUARIO.Text, MBX_SENHA.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou/e Senha inválido(s)!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_USUARIO.Text = "";
                        MBX_SENHA.Text = "";
                        TXT_USUARIO.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Favor, preencher todos os campos corretamente!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de entrada do mouse na área do componente "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                LBL_ADD_USUARIO.ForeColor = Color.Blue;
                LBL_ADD_USUARIO.Font = new Font(LBL_ADD_USUARIO.Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de saída do mouse da área do componente "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                LBL_ADD_USUARIO.ForeColor = Color.Black;
                LBL_ADD_USUARIO.Font = new Font(LBL_ADD_USUARIO.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de click no botão "BTN_SAIR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_SAIR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Evento de click na label "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                CAD_CLI.Forms.FRM_ADM FRM_ADM = new CAD_CLI.Forms.FRM_ADM();
                FRM_ADM.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Evento de ação no botão "BTN_ENTRAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (CONSULTAR_USUARIO() == true)
                {
                    this.Hide();
                    CAD_CLI.Forms.FRM_PRINCIPAL FRM_PRINCIPAL = new CAD_CLI.Forms.FRM_PRINCIPAL();
                    FRM_PRINCIPAL.FormClosed += (s, args) => this.Close();
                    FRM_PRINCIPAL.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Evento de ação KeyDown na "TXT_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_USUARIO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MBX_SENHA.Focus();
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown na "MBX_SENHA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BTN_ENTRAR_Click(sender, e);
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
