using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using xlsx = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.UsesCases;

namespace GestorOrdenesDeTrabajo.Excel
{
    class ExcelController
    {
        private void WriteExcelFileWithRefacciones(List<Refaccion> list)
        {
            using (SaveFileDialog fichero = new SaveFileDialog { Filter = @"Excel files (*.xls or .xlsx)|.xls;*.xls" })
            {
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    xlsx.Application xlApp = new xlsx.Application();
                    xlsx.Workbook xlWorkbook = xlApp.Workbooks.Add(xlsx.XlWBATemplate.xlWBATWorksheet);
                    xlsx.Worksheet xlWorksheet = (xlsx.Worksheet)xlWorkbook.Worksheets.get_Item(1);
                    xlsx.Range xlRange = xlWorksheet.UsedRange;

                    int Fila = xlWorksheet.get_Range("A" + xlWorksheet.Rows.Count).get_End(xlsx.XlDirection.xlUp).Row;

                    xlWorksheet.Cells[Fila, 1] = "ID";//Columna A
                    xlWorksheet.Cells[Fila, 2] = "Codigo";//Columna B
                    xlWorksheet.Cells[Fila, 3] = "Descripcion";//Columna C
                    xlWorksheet.Cells[Fila, 4] = "Minimo";//Columna D

                    Fila++;
                    DateTime ini = DateTime.Now;
                    foreach (var item in list)
                    {
                        xlWorksheet.Cells[Fila, 1] = item.Id;//Columna A
                        xlWorksheet.Cells[Fila, 2] = item.Codigo;//Columna B
                        xlWorksheet.Cells[Fila, 3] = item.Descripcion;//Columna C
                        xlWorksheet.Cells[Fila, 4] = item.PrecioMinimo;//Columna D
                        Fila++;
                    }
                    DateTime fin = DateTime.Now;
                    Console.WriteLine("inicio: " + ini.TimeOfDay);
                    Console.WriteLine("Fin:    " + fin.TimeOfDay);

                    xlWorkbook.SaveAs(fichero.FileName, xlsx.XlFileFormat.xlWorkbookNormal,
                                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false,
                                    xlsx.XlSaveAsAccessMode.xlShared, false, false,
                                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    xlWorkbook.Close(true);
                    xlApp.Quit();
                }

            }
        }

        private  List<Refaccion> ReadExcelFileForPiezas(string filePath)
        {   
            List<Refaccion> p = new List<Refaccion>();
            xlsx.Application xlApp = new xlsx.Application();
            xlsx.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            xlsx.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            xlsx.Range xlRange = xlWorksheet.UsedRange;
            int Fila;
            int ultimaFilaConDatos = xlWorksheet.get_Range("B" + xlWorksheet.Rows.Count).get_End(xlsx.XlDirection.xlUp).Row;
            for (Fila = 2; Fila <= ultimaFilaConDatos; Fila++)
            {
                int id = Convert.ToInt32((xlRange.Cells[Fila, 1] as xlsx.Range).Value);
                string codigo = Convert.ToString((xlRange.Cells[Fila, 2] as xlsx.Range).Value);
                string descripcion = Convert.ToString((xlRange.Cells[Fila, 3] as xlsx.Range).Value);
                decimal minimo = Convert.ToDecimal((xlRange.Cells[Fila, 4] as xlsx.Range).Value);
                p.Add(new Refaccion
                {
                    Id = id,
                    Codigo = codigo,
                    Descripcion = descripcion,
                    PrecioMinimo = minimo
                });
            }
            xlWorkbook.Close(false);
            xlApp.Quit();

            return p;
        }

        public bool ImportExcelFrom(string filePath)
        {
            try
            {
                //Obtenemos los valores desde el excel
                List<Refaccion> refacciones = ReadExcelFileForPiezas(filePath); 

                //Se agregan los valores a la BD
                foreach(var item in refacciones)
                {
                    Console.WriteLine($"Id: {item.Id} codigo: {item.Codigo} descripcion: {item.Descripcion} minimo: {item.PrecioMinimo}");
                    //TODO agregar refacciones a la BD - Tomar en cuenta que en caso de ya estar registrado el producto, este debe de editarse en lugar de agregarse nuevamente
                }

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"A ocurrido un error:\n\n{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }


        public bool CreateExcelRefacciones()
        {
            try
            {
                //Obtenemos las refacciones desde la BD
                var refacciones = RefaccionController.I.GetLista();

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
