using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using xlsx = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.UsesCases;
using System.Linq;
using System.Data;

namespace GestorOrdenesDeTrabajo.Excel
{
    class ExcelController
    {
        private void WriteExcelFileWithRefacciones(DataTable dt)
        {
            using (SaveFileDialog fichero = new SaveFileDialog { Filter = @"Excel files (*.xls or .xlsx)|.xls;*.xls" })
            {
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    int ColumnsCount = dt.Columns.Count;
                    int RowsCount = dt.Rows.Count;
                    object[] Header = new object[ColumnsCount]; 
                    object[,] Cells = new object[RowsCount, ColumnsCount];

                    xlsx.Application xlApp = new xlsx.Application();
                    xlApp.Workbooks.Add();
                    xlsx.Worksheet Worksheet = xlApp.ActiveSheet;

                    // obtenemos los encabezados de la tabla    
                    for (int i = 0; i < ColumnsCount; i++)
                        Header[i] = dt.Columns[i].ColumnName;

                    // obtenemos la informacion de la tabla
                    for (int j = 0; j < RowsCount; j++)
                        for (int i = 0; i < ColumnsCount; i++) 
                            Cells[j, i] = dt.Rows[j][i];

                    // agregamos encabezados en la hoja y les damos formato
                    xlsx.Range HeaderRange = Worksheet.get_Range((xlsx.Range)(Worksheet.Cells[1, 1]), (xlsx.Range)(Worksheet.Cells[1, ColumnsCount]));
                    HeaderRange.Value = Header;
                    HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DimGray);
                    HeaderRange.Font.Bold = true;
                    HeaderRange.Borders.LineStyle = xlsx.XlLineStyle.xlContinuous;

                    // agregamos la informacion en la hoja
                    xlsx.Range DataRange = Worksheet.get_Range((xlsx.Range)(Worksheet.Cells[2, 1]), (xlsx.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount]));
                    DataRange.EntireColumn.NumberFormat = "@"; //da formato de texto, previene que el codigo "00001" se cambie a "1" en excel
                    DataRange.Value = Cells;
                    DataRange.Borders.LineStyle = xlsx.XlLineStyle.xlDash;
                    DataRange.EntireColumn.AutoFit();

                    Worksheet.SaveAs(fichero.FileName);
                    xlApp.Workbooks.Close();
                    xlApp.Quit();

                }
            }
        }

        private (List<Refaccion>, List<Refaccion>) ReadExcelFileForPiezas(string filePath)
        {
            Dictionary<string, Refaccion> exist = RefaccionController.I.GetDictionary();
            Dictionary<string, Refaccion> toAdd = new Dictionary<string, Refaccion>();
            Dictionary<string, Refaccion> toEdit = new Dictionary<string, Refaccion>();

            //Agregar para mostrar elementos repetidos si existen
            //List<Refaccion> repeated = new List<Refaccion>();

            xlsx.Application xlApp = new xlsx.Application();
            xlsx.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            xlsx.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            xlsx.Range xlRange = xlWorksheet.UsedRange;

            int Fila;
            int ultimaFilaConDatos = xlWorksheet.get_Range("B" + xlWorksheet.Rows.Count).get_End(xlsx.XlDirection.xlUp).Row;

            //Obtiene array por filas
            object[,] values = (object[,])xlRange.Value;

            for (Fila = 2; Fila <= ultimaFilaConDatos; Fila++)
            {
                //Valores en Fila,Columna
                int id = Convert.ToInt32(values[Fila, 1]);
                string codigo = Convert.ToString(values[Fila, 2]);
                string descripcion = Convert.ToString(values[Fila, 3]);
                decimal minimo = Convert.ToDecimal(values[Fila, 4]);

                //Revisar que los datos sean consistentes
                if (codigo == null || descripcion == null || minimo < 0.0M)
                    continue;

                //Revisar si se encuentra el codigo en la DB compleidad O(1)
                bool isSaved = exist.ContainsKey(codigo);

                if (id != 0 && isSaved)
                {
                    //Revisar repetidos al ir agregando
                    if (!toEdit.ContainsKey(codigo))
                        toEdit.Add(codigo, new Refaccion
                        {
                            Codigo = codigo,
                            Descripcion = descripcion,
                            PrecioMinimo = minimo,
                            IsDeleted = false
                        });
                }
                else if (!isSaved)
                {
                    if (!toAdd.ContainsKey(codigo))
                        toAdd.Add(codigo, new Refaccion
                        {
                            Codigo = codigo,
                            Descripcion = descripcion,
                            PrecioMinimo = minimo,
                            IsDeleted = false
                        });
                }
            }

            xlWorkbook.Close(false);
            xlApp.Quit();

            return (toAdd.Values.ToList(), toEdit.Values.ToList());
        }

        public bool ImportExcelFrom(string filePath)
        {
            try
            {
                //Obtenemos los valores desde el excel
                var result = ReadExcelFileForPiezas(filePath);

                List<Refaccion> toAdd = result.Item1;
                List<Refaccion> toEdit = result.Item2;

                bool added = RefaccionController.I.AddRange(toAdd);
                //if (!added)
                { /*throw new Exception("No se pudieron agregar algunas refacciones, revice el formato");*/ }

                //Se agregan los valores a la BD
                foreach (var item in toEdit)
                {
                    var edited = RefaccionController.I.EditOnImport(item);
                    //if (edited == null)
                    //{ throw new Exception($"No se pudieron editar algunas refacciones, revice el formato\nID:{item.Id}, Codigo:{item.Codigo}, Descripcion:{item.Descripcion}"); }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A ocurrido un error:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        public bool CreateExcelRefacciones(DataTable refacciones)
        {
            try
            {
                //Los escribimos en el excel
                WriteExcelFileWithRefacciones(refacciones);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A ocurrido un error:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
