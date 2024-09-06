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
    /// Formulário de cadastro de email.
    /// </summary>
    public partial class FRM_CAD_EMAIL : Form
    {
        private CAD_CLI.NEGOCIOS.CRUD_NEG ObjNEG = new NEGOCIOS.CRUD_NEG();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT ObjEnt = new ENTIDADES.CAD_CLI_TBL_EMAIL_ENT();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_EMAIL_ENT();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT> ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT> ListaClientes = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();

        /// <summary>
        /// Construtor da classe FRM_CAD_EMAIL
        /// Inicializa os componentes do formulário de cadastro de email.
        /// </summary>
        public FRM_CAD_EMAIL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para deletar emails.
        /// </summary>
        /// <returns></returns>
        public bool DELETAR_EMAILS()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este(s) registro(s)?", " CadCli ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>();

                    foreach (DataGridViewRow item in DGV_DADOS.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["checkBoxColumn"].Value) == true)
                        {
                            ListaEnt.Add(new ENTIDADES.CAD_CLI_TBL_EMAIL_ENT
                            {
                                ID_EMAIL = Convert.ToInt32(item.Cells["ID_EMAIL"].Value.ToString()),
                                //ID_CLIENTE = Convert.ToInt32(item.Cells["ID_CLIENTE"].Value.ToString()),
                                ENDERECO_EMAIL = item.Cells["ENDERECO_EMAIL"].Value.ToString()                    
                            });
                        }
                    }

                    if (ListaEnt.Count > 0)
                    {
                        ObjNEG.DELETE_CAD_CLI_TBL_EMAIL_EM_LOTE(ListaEnt);
                        MessageBox.Show("Registro(s) excluído(s) com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Selecione pelo menos uma linha!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir email.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_EMAIL()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_CAD_CLI_TBL_EMAIL_EXISTENTE(ObjEnt).Count == 0)
                    {
                        ObjNEG.INSERT_CAD_CLI_TBL_EMAIL(ObjEnt);
                        MessageBox.Show("E-mail inserido com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este E-mail já existe!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// Método para consultar emails.
        /// </summary>
        public void CONSULTAR_EMAIL()
        {
            try
            {
                MONTAR_ENTIDADE();

                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_CAD_CLI_TBL_EMAIL_JOIN(ObjEnt);
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para layout do GridView.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LAYOUT_GRID()
        {
            try
            {
                DGV_DADOS.Columns["ID_EMAIL"].Visible = false;
                DGV_DADOS.Columns["NOME_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.Columns["ENDERECO_EMAIL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidade.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENTIDADES.CAD_CLI_TBL_EMAIL_ENT();

                if (CBX_CLIENTE.SelectedValue == null)
                {
                    return false;
                }
                else
                {
                    ObjEnt.ID_CLIENTE = Convert.ToInt32(CBX_CLIENTE.SelectedValue);
                }

                if ((TXT_EMAIL.Text.Length == 0) || (!TXT_EMAIL.Text.Contains("@")))
                {
                    return false;
                }

                ObjEnt.ENDERECO_EMAIL = TXT_EMAIL.Text;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para limpar dados dos campos.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LIMPAR_DADOS()
        {
            try
            {
                CBX_CLIENTE.SelectedIndex = -1;
                TXT_EMAIL.Text = "";
                DGV_DADOS.DataSource = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para carregar a ComboBox de cliente.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CARREGAR_COMBO()
        {
            try
            {
                ListaClientes = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();
                ListaClientes = ObjNEG.SELECT_CAD_CLI_TBL_CLIENTE_ENT(new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT());
                CBX_CLIENTE.DataSource = ListaClientes;
                CBX_CLIENTE.DisplayMember = "NOME_CLIENTE";
                CBX_CLIENTE.ValueMember = "ID_CLIENTE";
                int ID_CLIENTE = Convert.ToInt32(CBX_CLIENTE.SelectedValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de Load do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_CAD_EMAIL_Load(object sender, EventArgs e)
        {
            try
            {
                CARREGAR_COMBO();
                LIMPAR_DADOS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique na linha do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool cell_checked = false;
                if (e.RowIndex >= 0)
                {
                    cell_checked = Convert.ToBoolean(DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value);

                    if (cell_checked == true)
                    {
                        DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value = false;
                    }
                    else if (cell_checked == false)
                    {
                        DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de preenchimento do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DGV_DADOS.AutoResizeColumns();
                foreach (DataGridViewColumn coluna in DGV_DADOS.Columns)
                {
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.ReadOnly = true;
                }

                LAYOUT_GRID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_CONSULTAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_EMAIL();
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
        /// Evento de clique no botão "BTN_LIMPAR_DADOS".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_LIMPAR_DADOS_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LIMPAR_DADOS();
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
        /// Evento de clique no botão "BTN_ADICIONAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (INSERIR_EMAIL())
                {
                    BTN_CONSULTAR_Click(sender, e);
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
        /// Evento de clique no botão "BTN_DELETAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_DELETAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (DELETAR_EMAILS())
                {
                    BTN_CONSULTAR_Click(sender, e);
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
        /// Evento de clique no item da ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_CLIENTE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CONSULTAR_EMAIL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
