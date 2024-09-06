using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_CLI.Forms
{
    /// <summary>
    /// Formulário de cadastro de telefone.
    /// </summary>
    public partial class FRM_CAD_TELEFONE : Form
    {
        private CAD_CLI.NEGOCIOS.CRUD_NEG ObjNEG = new NEGOCIOS.CRUD_NEG();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT ObjEnt = new ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT> ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT> ListaClientes = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();

        /// <summary>
        /// Construtor da classe FRM_CAD_TELEFONE
        /// Inicializa os componentes do formulário de cadastro de telefone.
        /// </summary>
        public FRM_CAD_TELEFONE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para deletar telefones.
        /// </summary>
        /// <returns></returns>
        public bool DELETAR_TELEFONES()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este(s) registro(s)?", " CadCli ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>();

                    foreach (DataGridViewRow item in DGV_DADOS.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["checkBoxColumn"].Value) == true)
                        {
                            ListaEnt.Add(new ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT
                            {
                                ID_TELEFONE = Convert.ToInt32(item.Cells["ID_TELEFONE"].Value.ToString()),
                                //ID_CLIENTE = Convert.ToInt32(item.Cells["ID_CLIENTE"].Value.ToString()),
                                NUMERO_PAIS = Convert.ToInt32(item.Cells["NUMERO_PAIS"].Value.ToString()),
                                NUMERO_DDD = Convert.ToInt32(item.Cells["NUMERO_DDD"].Value.ToString()),
                                NUMERO_TELEFONE = Convert.ToInt32(item.Cells["NUMERO_TELEFONE"].Value.ToString()),
                            });
                        }
                    }

                    if (ListaEnt.Count > 0)
                    {
                        ObjNEG.DELETE_CAD_CLI_TBL_TELEFONE_EM_LOTE(ListaEnt);
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
        /// Método para inserir telefone.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_TELEFONE()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_CAD_CLI_TBL_TELEFONE_EXISTENTE(ObjEnt).Count == 0)
                    {
                        ObjNEG.INSERT_CAD_CLI_TBL_TELEFONE(ObjEnt);
                        MessageBox.Show("Telefone inserido com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este telefone já existe!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// Método para consultar telefones.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_TELEFONE()
        {
            try
            {
                MONTAR_ENTIDADE();

                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_CAD_CLI_TBL_TELEFONE_JOIN(ObjEnt);
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
                DGV_DADOS.Columns["ID_TELEFONE"].Visible = false;
                DGV_DADOS.Columns["NOME_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.Columns["NUMERO_TELEFONE"].DefaultCellStyle.Format = "00000-0000";
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
                ObjEnt = new ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT();

                if (CBX_CLIENTE.SelectedValue == null)
                {
                    return false;
                }
                else
                {
                    ObjEnt.ID_CLIENTE = Convert.ToInt32(CBX_CLIENTE.SelectedValue);
                }

                if (MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 11)
                {
                    return false;
                }

                ObjEnt.NUMERO_PAIS = 55;
                ObjEnt.NUMERO_DDD = Convert.ToInt32(MBX_TELEFONE.Text.Substring(1, 2));
                ObjEnt.NUMERO_TELEFONE = Convert.ToInt32(MBX_TELEFONE.Text.Replace("-", "").Replace(" ", "").Substring(4, 9));
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
                MBX_TELEFONE.Text = "";
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
        private void FRM_CAD_TELEFONE_Load(object sender, EventArgs e)
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

        private void BTN_CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_TELEFONE();
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
                if (INSERIR_TELEFONE())
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
                CONSULTAR_TELEFONE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (DELETAR_TELEFONES())
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
    } 
}
