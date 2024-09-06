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
using System.Xml.Linq;

namespace CAD_CLI.Forms
{
    /// <summary>
    /// Formulário de cadastro de endereço.
    /// </summary>
    public partial class FRM_CAD_ENDERECO : Form
    {
        private CAD_CLI.NEGOCIOS.CRUD_NEG ObjNEG = new NEGOCIOS.CRUD_NEG();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT ObjEnt = new ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT();
        private CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT> ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>();
        private List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT> ListaClientes = new List<ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>();

        /// <summary>
        /// Construtor da classe FRM_CAD_ENDERECO
        /// Inicializa os componentes do formulário de cadastro de endereço.
        /// </summary>
        public FRM_CAD_ENDERECO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para deletar endereços.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_ENDERECOS()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este(s) registro(s)?", " CadCli ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ListaEnt = new List<ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>();

                    foreach (DataGridViewRow item in DGV_DADOS.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["checkBoxColumn"].Value) == true)
                        {
                            ListaEnt.Add(new ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT
                            {
                                ID_ENDERECO = Convert.ToInt32(item.Cells["ID_ENDERECO"].Value.ToString()),
                                //ID_CLIENTE = Convert.ToInt32(item.Cells["ID_CLIENTE"].Value.ToString()),
                                LOGRADOURO = item.Cells["LOGRADOURO"].Value.ToString(),
                                NUMERO_RUA = Convert.ToInt32(item.Cells["NUMERO_RUA"].Value.ToString()),
                                COMPLEMENTO = item.Cells["COMPLEMENTO"].Value == null ? null : item.Cells["COMPLEMENTO"].Value.ToString(),
                                BAIRRO = item.Cells["BAIRRO"].Value.ToString(),
                                CIDADE = item.Cells["CIDADE"].Value.ToString(),
                                UF = item.Cells["UF"].Value.ToString(),
                                CEP = Convert.ToInt32(item.Cells["CEP"].Value.ToString()),
                            });
                        }
                    }

                    if (ListaEnt.Count > 0)
                    {
                        ObjNEG.DELETE_CAD_CLI_TBL_ENDERECO_EM_LOTE(ListaEnt);
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
        /// Método para alterar endereço.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_ENDERECO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    ObjNEG.UPDATE_CAD_CLI_TBL_ENDERECO(ObjEnt);
                    MessageBox.Show("Endereço alterado com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Método para inserir endereço.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_ENDERECO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_CAD_CLI_TBL_ENDERECO(ObjEnt).Count == 0)
                    {
                        ObjNEG.INSERT_CAD_CLI_TBL_ENDERECO(ObjEnt);
                        MessageBox.Show("Endereço inserido com sucesso!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este cliente já possui um endereço!", " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// Método para consultar endereço.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_ENDERECO()
        {
            try
            {
                MONTAR_ENTIDADE();

                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_CAD_CLI_TBL_ENDERECO_JOIN(ObjEnt);
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
                DGV_DADOS.Columns["ID_CLIENTE"].Visible = false;
                DGV_DADOS.Columns["ID_ENDERECO"].Visible = false;
                DGV_DADOS.Columns["NOME_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.Columns["LOGRADOURO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_DADOS.Columns["CEP"].DefaultCellStyle.Format = "00000-000";
                DGV_DADOS.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidade anterior.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void MONTAR_ENTIDADE_ANTERIOR()
        {
            try
            {
                if (DGV_DADOS.RowCount > 0)
                {
                    ObjEnt_Ant = new ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT();

                    ObjEnt_Ant.ID_ENDERECO = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_ENDERECO"].Value.ToString());
                    ObjEnt_Ant.ID_CLIENTE = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_CLIENTE"].Value.ToString());
                    ObjEnt_Ant.LOGRADOURO = DGV_DADOS.CurrentRow.Cells["LOGRADOURO"].Value.ToString();
                    ObjEnt_Ant.NUMERO_RUA = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["NUMERO_RUA"].Value.ToString());
                    ObjEnt_Ant.COMPLEMENTO = DGV_DADOS.CurrentRow.Cells["COMPLEMENTO"].Value == null ? null : DGV_DADOS.CurrentRow.Cells["COMPLEMENTO"].Value.ToString();
                    //ObjEnt_Ant.COMPLEMENTO = DGV_DADOS.CurrentRow.Cells["COMPLEMENTO"].Value.ToString();
                    ObjEnt_Ant.BAIRRO = DGV_DADOS.CurrentRow.Cells["BAIRRO"].Value.ToString();
                    ObjEnt_Ant.CIDADE = DGV_DADOS.CurrentRow.Cells["CIDADE"].Value.ToString();
                    ObjEnt_Ant.UF = DGV_DADOS.CurrentRow.Cells["UF"].Value.ToString();
                    ObjEnt_Ant.CEP = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["CEP"].Value.ToString());

                    CBX_CLIENTE.SelectedValue = ObjEnt_Ant.ID_CLIENTE;
                    TXT_LOGRADOURO.Text = ObjEnt_Ant.LOGRADOURO;
                    TXT_NUMERO.Text = ObjEnt_Ant.NUMERO_RUA.ToString();
                    TXT_COMPLEMENTO.Text = ObjEnt_Ant.COMPLEMENTO;
                    TXT_BAIRRO.Text = ObjEnt_Ant.BAIRRO;
                    TXT_CIDADE.Text = ObjEnt_Ant.CIDADE;
                    MBX_UF.Text = ObjEnt_Ant.UF;
                    MBX_CEP.Text = ObjEnt_Ant.CEP.ToString("00000000");

                    CBX_CLIENTE.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidade.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano que indica se a entidade foi montada com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT();

                if (ObjEnt_Ant.ID_ENDERECO != 0)
                {
                    ObjEnt.ID_ENDERECO = ObjEnt_Ant.ID_ENDERECO;
                }

                if (CBX_CLIENTE.SelectedValue == null)
                {
                    return false;
                }
                else
                {
                    ObjEnt.ID_CLIENTE = Convert.ToInt32(CBX_CLIENTE.SelectedValue);
                }

                if (TXT_LOGRADOURO.Text.Length == 0)
                {
                    return false;
                }

                if (TXT_NUMERO.Text.Length == 0)
                {
                    return false;
                }

                if (TXT_BAIRRO.Text.Length == 0)
                {
                    return false;
                }

                if (TXT_CIDADE.Text.Length == 0)
                {
                    return false;
                }

                if (MBX_UF.Text.Length != 2)
                {
                    return false;
                }

                if (MBX_CEP.Text.Replace("-", "").Length != 8)
                {
                    return false;
                }

                ObjEnt.LOGRADOURO = TXT_LOGRADOURO.Text;
                ObjEnt.NUMERO_RUA = Convert.ToInt32(TXT_NUMERO.Text);
                ObjEnt.BAIRRO = TXT_BAIRRO.Text;
                ObjEnt.CIDADE = TXT_CIDADE.Text;
                ObjEnt.UF = MBX_UF.Text;
                ObjEnt.CEP = Convert.ToInt32(MBX_CEP.Text.Replace("-", ""));
                if (string.IsNullOrEmpty(TXT_COMPLEMENTO.Text))
                {
                    ObjEnt.COMPLEMENTO = null;
                }
                else
                {
                    ObjEnt.COMPLEMENTO = TXT_COMPLEMENTO.Text;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para limpar dados dos componentes.
        /// </summary>
        public void LIMPAR_DADOS()
        {
            try
            {
                CBX_CLIENTE.SelectedIndex = -1;
                TXT_LOGRADOURO.Text = "";
                TXT_NUMERO.Text = "";
                TXT_COMPLEMENTO.Text = "";
                TXT_BAIRRO.Text = "";
                TXT_CIDADE.Text = "";
                MBX_UF.Text = "";
                MBX_CEP.Text = "";
                DGV_DADOS.DataSource = null;
                CBX_CLIENTE.Enabled = true;
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
        private void FRM_CAD_ENDERECO_Load(object sender, EventArgs e)
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
        /// Evento de clique no botão "BTN_CONSULTAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_ENDERECO();
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
                if (INSERIR_ENDERECO())
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
        /// Evento de clique no botão "BTN_LIMPAR".
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
        /// Evento de clique no botão "BTN_ALTERAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (ALTERAR_ENDERECO())
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
        /// Evento de clique no botão "BTN_DELETAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_DELETAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (DELETAR_ENDERECOS())
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
                CONSULTAR_ENDERECO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " CadCli ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
