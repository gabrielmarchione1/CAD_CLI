using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.NEGOCIOS
{
    /// <summary>
    /// Classe de negócio para a tela de cadastro de clientes.
    /// </summary>
    public class FRM_CAD_CLIENTE_NEG
    {
        private readonly CAD_CLI.DADOS.CRUD_DADOS ObjDAD = new DADOS.CRUD_DADOS();

        /// <summary>
        /// Método para inserir em lote.
        /// </summary>
        /// <param name="CaminhoArquivo"></param>
        /// <exception cref="Exception"></exception>
        public void INSERIR_BULKCOPY(string CaminhoArquivo)
        {
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(CaminhoArquivo);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage XLS = new ExcelPackage(fi))
                {
                    ExcelWorksheet sheet = XLS.Workbook.Worksheets[0];

                    DataTable dt_imp = new DataTable();
                    dt_imp = ExportDataTable(sheet, false);
                    dt_imp.Columns.RemoveAt(0);

                    foreach (DataRow row in dt_imp.Rows)
                    {
                        // Verifica se o valor da coluna "COMPLEMENTO" é um espaço em branco
                        if (row["COLUMN_6"] != null && row["COLUMN_6"].ToString().Trim() == "")
                        {
                            // Define o valor como DBNull (NULL no banco de dados)
                            row["COLUMN_6"] = DBNull.Value;
                        }
                    }

                    //foreach (DataRow row in dt_imp.Rows)
                    //{
                    //    // Obtém o valor da coluna como string
                    //    string dateValue = row["DATA_NASCIMENTO"]?.ToString();

                    //    // Verifica se o valor não é nulo ou vazio
                    //    if (!string.IsNullOrEmpty(dateValue))
                    //    {
                    //        // Tenta converter a string para DateTime
                    //        if (DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                    //        {
                    //            // Converte para o formato yyyy-MM-dd e atualiza o DataTable
                    //            row["DATA_NASCIMENTO"] = date.ToString("yyyy-MM-dd");
                    //        }
                    //    }
                    //}

                    ObjDAD.INSERT_BULKCOPY("dbo.CAD_CLI_TBL_CLIENTE_BULKCOPY_TEMP", dt_imp);
                    ObjDAD.EXECUTA_SP_SEM_RETORNO("dbo.CAD_CLI_SP_INSERIR_DADOS");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para gerar o modelo de importação
        /// </summary>
        /// <param name="CaminhoPasta"></param>
        /// <exception cref="Exception"></exception>
        public void GERAR_MODELO(string CaminhoPasta)
        {
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(CaminhoPasta + "\\Modelo_Importacao_Clientes.xlsx");

                if (fi.Exists)
                {
                    fi.Delete();
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage XLS = new ExcelPackage(fi))
                {
                    ExcelWorksheet sheet = XLS.Workbook.Worksheets.Add("Plan");

                    sheet.Cells["A1"].Value = "NOME_CLIENTE";
                    sheet.Cells["B1"].Value = "CPF_CLIENTE";
                    sheet.Cells["C1"].Value = "DATA_NASCIMENTO";
                    sheet.Cells["D1"].Value = "LOGRADOURO";
                    sheet.Cells["E1"].Value = "NUMERO_RUA";
                    sheet.Cells["F1"].Value = "COMPLEMENTO";
                    sheet.Cells["G1"].Value = "BAIRRO";
                    sheet.Cells["H1"].Value = "CIDADE";
                    sheet.Cells["I1"].Value = "UF";
                    sheet.Cells["J1"].Value = "CEP";
                    sheet.Cells["K1"].Value = "NUMERO_DDD";
                    sheet.Cells["L1"].Value = "NUMERO_TELEFONE";
                    sheet.Cells["M1"].Value = "ENDERECO_EMAIL";

                    sheet.Cells.AutoFitColumns();
                    //int columnIndex = 2; // Índice da coluna que você deseja formatar
                    //var column = sheet.Column(columnIndex);
                    //column.Style.Numberformat.Format = "@";

                    XLS.Save();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Cria um DataTable a partir de uma planilha do Excel (ExcelWorksheet).
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="exportColumnNames"></param>
        /// <returns></returns>
        public static DataTable ExportDataTable(ExcelWorksheet sheet, bool exportColumnNames)
        {
            try
            {
                DataTable dataTable = new DataTable();
                int row = sheet.Dimension.End.Row;
                int column = sheet.Dimension.End.Column;
                dataTable.Columns.Add("ID", typeof(int));
                if (exportColumnNames)
                {
                    for (int i = 1; i <= column; i++)
                    {
                        dataTable.Columns.Add(sheet.Cells[1, i].Value.ToString(), typeof(string));
                    }
                }
                else
                {
                    for (int j = 1; j <= column; j++)
                    {
                        dataTable.Columns.Add("COLUMN_" + j, typeof(string));
                    }
                }

                for (int row_ini = 2; row_ini <= row; row_ini++)
                {
                    ExcelRange excelRange = sheet.Cells[row_ini, 1, row_ini, column];
                    DataRow dataRow = dataTable.Rows.Add();
                    int coluna;
                    for (coluna = 1; coluna <= column; coluna++)
                    {
                        dataRow[0] = row_ini - 1;
                        if (sheet.Cells[row_ini, coluna].Value == null)
                        {
                            dataRow[coluna] = "";// se o valor for nulo
                        }
                        else if (formats.Any((string x) => x == sheet.Cells[row_ini, coluna].Style.Numberformat.Format))
                        {
                            if (sheet.Cells[row_ini, coluna].Value.ToString().Contains("/"))
                            {
                                dataRow[coluna] = sheet.Cells[row_ini, coluna].Value.ToString();
                            }
                            else if (sheet.Cells[row_ini, coluna].Value.ToString().All(char.IsDigit))
                            {
                                dataRow[coluna] = DateTime.FromOADate((double)sheet.Cells[row_ini, coluna].Value).ToString();
                            }
                            else
                            {
                                dataRow[coluna] = sheet.Cells[row_ini, coluna].Value.ToString();
                            }
                        }
                        else
                        {
                            dataRow[coluna] = sheet.Cells[row_ini, coluna].Value.ToString();
                        }
                    }

                    if (deletar_linha_vazia(dataRow, coluna_id: true))
                    {
                        dataTable.Rows.RemoveAt(dataTable.Rows.IndexOf(dataRow));
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para deletar linhas vazias dt.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="coluna_id"></param>
        /// <returns></returns>
        public static bool deletar_linha_vazia(DataRow row, bool coluna_id = false)
        {
            try
            {
                int num = 0;
                if (coluna_id)
                {
                    num++;
                    object[] itemArray = row.ItemArray;
                    foreach (object obj in itemArray)
                    {
                        if ((obj == null) | (obj == DBNull.Value) | obj.Equals(""))
                        {
                            num++;
                        }
                    }
                }
                else
                {
                    object[] itemArray2 = row.ItemArray;
                    foreach (object obj2 in itemArray2)
                    {
                        if ((obj2 == null) | (obj2 == DBNull.Value) | obj2.Equals(""))
                        {
                            num++;
                        }
                    }
                }

                if (num == row.ItemArray.Length)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Formato de datas.
        /// </summary>
        private static string[] formats = new string[29]
        {
            "dd/MM/yyyy", "d/M/yyyy", "dd/mm/yy", "d/m/yy", "dd-MM-yyyy", "d-M-yyyy", "dd-MM-yy", "d-M-yy", "dd/mm/yy;@", "dd/mm/yy@",
            "dd/mm/yyyy;@", "dd/mm/yyyy@", "dd.MM.yyyy", "d.M.yyyy", "dd.MM.yy", "d.M.yy", "dd MM yyyy", "d M yyyy", "dd MM yy", "d M yy",
            "MM/dd/yyyy", "M/d/yyyy", "MM/dd/yy", "M/d/yy", "M/dd/yyyy", "M/d/yyyy", "MM/d/yyyy", "mm-dd-yy", "m/d/yyyy"
        };

        /// <summary>
        /// Cria um DataTable a partir de uma planilha do Excel (ExcelWorksheet).
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        /*public DataTable ExportDataTable(ExcelWorksheet sheet)
        {
            DataTable dt = new DataTable();

            // Adiciona as colunas ao DataTable
            foreach (var firstRowCell in sheet.Cells[1, 1, 1, sheet.Dimension.End.Column])
            {
                dt.Columns.Add(firstRowCell.Text);
            }

            // Adiciona as linhas ao DataTable
            for (int rowNum = 2; rowNum <= sheet.Dimension.End.Row; rowNum++)
            {
                var row = sheet.Cells[rowNum, 1, rowNum, sheet.Dimension.End.Column];
                DataRow dataRow = dt.NewRow();

                foreach (var cell in row)
                {
                    dataRow[cell.Start.Column - 1] = cell.Text;
                }

                dt.Rows.Add(dataRow);
            }

            dt.Columns[2].DataType = typeof(string);
            return dt;
        }*/

    }
}
