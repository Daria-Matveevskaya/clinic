using NPOI.HPSF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace Clinic.Common
{
    public static class DataGridViewExtensions
    {
        public static void ExportToExcel(this DataGridView dataGridView, string name, List<string> captions, string sign)
        {
            // Создать новую рабочую книгу
            IWorkbook workbook = new XSSFWorkbook();

            // Создать новый лист
            ISheet sheet = workbook.CreateSheet("Лист 1");
            
            // Настроить стиль заголовока документа
            IFont captionFont = workbook.CreateFont();
            captionFont.IsBold = true;
            ICellStyle captionStyle = workbook.CreateCellStyle();
            captionStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            captionStyle.SetFont(captionFont);

            // Заполнить данными заголовок документа
            int rowIndex = 0;
            foreach (var caption in captions)
            {
                ICell captionCell = sheet.CreateRow(rowIndex).CreateCell(0);
                captionCell.SetCellValue(caption);
                captionCell.CellStyle = captionStyle;
                CellRangeAddress region = new(rowIndex, rowIndex++, 0, dataGridView.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1);
                sheet.AddMergedRegion(region);
            }

            // Настроить стиль ячеек шапки талицы
            ICellStyle headerStyle = workbook.CreateCellStyle();
            headerStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            headerStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            headerStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            headerStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            headerStyle.SetFont(captionFont);

            // Заполнить данными ячейки шапки таблицы
            sheet.CreateRow(rowIndex++);
            IRow headerRow = sheet.CreateRow(rowIndex++);
            int colIndex = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible)
                {
                    ICell headerCell = headerRow.CreateCell(colIndex++);
                    headerCell.SetCellValue(column.HeaderText);
                    headerCell.CellStyle = headerStyle;
                }
            }

            // Настроить стиль ячеек таблицы
            ICellStyle style = workbook.CreateCellStyle();
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

            // Заполнить данными ячейки таблицы
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                colIndex = 0;
                IRow newRow = sheet.CreateRow(rowIndex++);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        ICell newCell = newRow.CreateCell(colIndex++);

                        if (cell.Value?.GetType() == typeof(double) && cell.Value != DBNull.Value)
                        {
                            newCell.SetCellType(CellType.Numeric);
                            newCell.SetCellValue((double)cell.Value);
                        }
                        else
                        {
                            newCell.SetCellValue(cell.Value?.ToString());
                        }

                        newCell.CellStyle = style;
                    }
                }
            }

            // Настроить автоширинуа столбцов таблицы
            colIndex = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible)
                {
                    sheet.AutoSizeColumn(colIndex++);
                }
            }

            // Настроить стиль подписи документа
            ICellStyle signStyle = workbook.CreateCellStyle();
            signStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;

            //Заполнить данными подпись документа
            sheet.CreateRow(rowIndex++);
            ICell signCell = sheet.CreateRow(rowIndex).CreateCell(0);
            signCell.SetCellValue($"/{sign}/");
            signCell.CellStyle = signStyle;
            CellRangeAddress signRegion = new(rowIndex, rowIndex++, 0, dataGridView.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1);
            sheet.AddMergedRegion(signRegion);

            // Сохраить документ Excel
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = $"{name}_{DateTime.Now:yyyyMMddHHmmssfff}.xlsx";

            using FileStream fileStream = new(Path.Combine(folderPath, filePath), FileMode.Create, FileAccess.Write);
            workbook.Write(fileStream, false);

            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select, \"{0}\"", Path.Combine(folderPath, filePath)));
        }
    }
}
