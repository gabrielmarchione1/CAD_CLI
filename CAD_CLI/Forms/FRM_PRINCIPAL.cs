using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_CLI.Forms
{
    /// <summary>
    /// Formulário Principal.
    /// </summary>
    public partial class FRM_PRINCIPAL : Form
    {
        /// <summary>
        /// Construtor da classe FRM_PRINCIPAL
        /// Inicializa os componentes do formulário principal.
        /// </summary>
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para fechar o form ativo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_CAD_CLIENTE".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_CLIENTE_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_CLIENTE child = new FRM_CAD_CLIENTE();
                child.MdiParent = this;
                child.Show();
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
        /// Evento de clique no botão "BTN_CAD_ENDERECO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_ENDERECO_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_ENDERECO child = new FRM_CAD_ENDERECO();
                child.MdiParent = this;
                child.Show();
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
        /// Evento de clique no botão "BTN_CAD_TELEFONE".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_TELEFONE_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_TELEFONE child = new FRM_CAD_TELEFONE();
                child.MdiParent = this;
                child.Show();
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
        /// Evento de clique no botão "BTN_CAD_EMAIL".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_EMAIL_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_EMAIL child = new FRM_CAD_EMAIL();
                child.MdiParent = this;
                child.Show();
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
    }
}
