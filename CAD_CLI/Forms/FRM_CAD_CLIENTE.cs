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
    /// Formulário de cadastro de cliente.
    /// </summary>
    public partial class FRM_CAD_CLIENTE : Form
    {
        private CAD_CLI.NEGOCIOS.CRUD_NEG ObjNEG = new NEGOCIOS.CRUD_NEG();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT ObjEnt = new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT> ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();

        /// <summary>
        /// Construtor da classe FRM_CAD_CLIENTE
        /// Inicializa os componentes do formulário de cadastro de cliente.
        /// </summary>
        public FRM_CAD_CLIENTE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para deletar clientes.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano que indica se o(s) cliente(s) foi/foram deletado com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_CLIENTES()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este(s) registro(s)?", " CadCli ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();

                    foreach (DataGridViewRow item in DGV_DADOS.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["checkBoxColumn"].Value) == true)
                        {
                            ListaEnt.Add(new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT
                            {
                                ID_CLIENTE = Convert.ToInt32(item.Cells["ID_CLIENTE"].Value.ToString()),
                                NOME_CLIENTE = item.Cells["NOME_CLIENTE"].Value.ToString(),
                                CPF_CLIENTE = Convert.ToInt32(item.Cells["CPF_CLIENTE"].Value.ToString()),
                                CPF_CONTROLE = Convert.ToInt32(item.Cells["CPF_CONTROLE"].Value.ToString()),
                                DATA_NASCIMENTO = Convert.ToDateTime(item.Cells["DATA_NASCIMENTO"].Value.ToString())
                            });
                        }
                    }

                    if (ListaEnt.Count > 0)
                    {
                        ObjNEG.DELETE_CAD_CLI_TBL_CLIENTE_ENT_EM_LOTE(ListaEnt);
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
        /// Método para layout do GridView.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LAYOUT_GRID()
        {
            try
            {
                DGV_DADOS.Columns["ID_CLIENTE"].Visible = false;
                DGV_DADOS.Columns["NOME_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.Columns["CPF_CLIENTE"].DefaultCellStyle.Format = "000,000,000";
                DGV_DADOS.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar cliente.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano que indica se o cliente foi alterado com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_CLIENTE()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    ObjNEG.UPDATE_CAD_CLI_TBL_CLIENTE_ENT(ObjEnt);
                    MessageBox.Show("Cliente alterado com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LIMPAR_DADOS();
                    return true;
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
        /// Método para montar entidade anterior;
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void MONTAR_ENTIDADE_ANTERIOR()
        {
            try
            {
                if (DGV_DADOS.RowCount > 0)
                {
                    ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT();

                    ObjEnt_Ant.ID_CLIENTE = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_CLIENTE"].Value.ToString());
                    ObjEnt_Ant.NOME_CLIENTE = DGV_DADOS.CurrentRow.Cells["NOME_CLIENTE"].Value.ToString();
                    ObjEnt_Ant.CPF_CLIENTE = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["CPF_CLIENTE"].Value.ToString());
                    ObjEnt_Ant.CPF_CONTROLE = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["CPF_CONTROLE"].Value.ToString());
                    ObjEnt_Ant.DATA_NASCIMENTO = Convert.ToDateTime(DGV_DADOS.CurrentRow.Cells["DATA_NASCIMENTO"].Value.ToString());

                    TXT_NOME.Text = ObjEnt_Ant.NOME_CLIENTE;
                    MBX_CPF.Text = ObjEnt_Ant.CPF_CLIENTE.ToString() + ObjEnt_Ant.CPF_CONTROLE.ToString();
                    MBX_DATA.Text = ObjEnt_Ant.DATA_NASCIMENTO.ToString();

                    MBX_CPF.Enabled = false;
                    MBX_DATA.Enabled = false;
                }
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
                TXT_NOME.Text = string.Empty;
                MBX_CPF.Text = string.Empty;
                MBX_DATA.Text = string.Empty;
                DGV_DADOS.DataSource = null;
                MBX_CPF.Enabled = true;
                MBX_DATA.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir cliente.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano que indica se o cliente foi inserido com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_CLIENTE()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_CAD_CLI_TBL_CLIENTE_ENT(ObjEnt).Count == 0)
                    {
                        ObjNEG.INSERT_CAD_CLI_TBL_CLIENTE_ENT(ObjEnt);
                        MessageBox.Show("Cliente inserido com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este CPF já existe!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// Método para consultar clientes.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_CLIENTE()
        {
            try
            {
                MONTAR_ENTIDADE();

                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_CAD_CLI_TBL_CLIENTE_ENT(ObjEnt);
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidades.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano que indica se a entidade foi montada com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT();

                if (ObjEnt_Ant.ID_CLIENTE != 0)
                {
                    ObjEnt.ID_CLIENTE = ObjEnt_Ant.ID_CLIENTE;
                }

                if (MBX_CPF.Text.Replace(".", "").Replace("-", "").Length != 11)
                {
                    return false;
                }
                else
                {
                    ObjEnt.CPF_CLIENTE = Convert.ToInt32(MBX_CPF.Text.Substring(0, 11).Replace(".", ""));
                    ObjEnt.CPF_CONTROLE = Convert.ToInt32(MBX_CPF.Text.Substring(12, 2));
                }

                if (TXT_NOME.Text.Length == 0)
                {
                    return false;
                }

                if (MBX_DATA.Text.Replace("/", "").Length != 8 || Convert.ToInt32(MBX_DATA.Text.Substring(0, 2)) > 31 || Convert.ToInt32(MBX_DATA.Text.Substring(3, 2)) > 12 || Convert.ToInt32(MBX_DATA.Text.Substring(6, 4)) >= 2024)
                {
                    return false;
                }
                else
                {
                    ObjEnt.DATA_NASCIMENTO = Convert.ToDateTime(MBX_DATA.Text);
                }

                ObjEnt.NOME_CLIENTE = TXT_NOME.Text;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
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
        /// Evento de clique do evento "BTN_CONSULTAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_CLIENTE();
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
        /// Evento de ação do botão "BTN_ADICIONAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (INSERIR_CLIENTE())
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
        /// Evento de ação do botão "BTN_ALTERAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (ALTERAR_CLIENTE())
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
        /// Evento de duplo clique na linha selecionada do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                MONTAR_ENTIDADE_ANTERIOR();
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
        /// Evento de clique do botão "LIMPAR_DADOS".
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
        /// Evento de ação do botão "BTN_DELETAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_DELETAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (DELETAR_CLIENTES())
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
