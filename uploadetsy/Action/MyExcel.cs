using Bunifu.UI.WinForms.BunifuTextbox;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uploadetsy.MyForm;
using uploadetsy.MyObj;

namespace uploadetsy.Action
{
    class MyExcel
    {
        #region Read Excle
        public List<ObjList> ReadExcle(String path, Thread thread , FormMain main)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                // path to your excel file
                
                FileInfo fileInfo = new FileInfo(path);

                ExcelPackage package = new ExcelPackage(fileInfo);
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                // get number of rows and columns in the sheet
              
               // int columns = worksheet.Dimension.Columns; // 7

                List<ObjList> _list = new List<ObjList>();
                // loop through the worksheet rows and columns
                for (int i = 2; true ; i++)
                {
                    String sku = Convert.ToString( worksheet.Cells[i, 1].Value);

                    String title = Convert.ToString(worksheet.Cells[i, 2].Value);

                    String secion = Convert.ToString(worksheet.Cells[i, 3].Value);

                    String tag = Convert.ToString(worksheet.Cells[i, 4].Value);

                    String id_clone = Convert.ToString( worksheet.Cells[i, 5].Value);

                    String link1 = Convert.ToString(worksheet.Cells[i, 7].Value);

                    String link2 = Convert.ToString(worksheet.Cells[i, 8].Value);

                    String link3 = Convert.ToString(worksheet.Cells[i, 9].Value);

                    String link4 = Convert.ToString(worksheet.Cells[i, 10].Value);

                    String link5 = Convert.ToString(worksheet.Cells[i, 11].Value);

                    if  (id_clone == null || id_clone == ""  )
                    {
                        break;
                    }
                    _list.Add(new ObjList(sku, title,secion , tag, id_clone, link1, link2, link3 , link4 , link5));
                
                    /* Do something ...*/

                }

                return _list;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
               // FormMess.Show("Error", "Lõi đọc File Excel", false);
                main.WriteLog("Lỗi tìm thấy file Exce;", Color.Red);
                main.WriteTitleAtion("Stop", Color.Red);
                thread.Abort();
                return null;
            }

        }
        #endregion
    }
}
