using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory path where output Excel files will be created.
            string dirPath = "C:/excel/";

            // Create Aspose.Cells empty workbook object.
            Aspose.Cells.Workbook workbook = new Workbook();

            workbook.Worksheets[0].Cells["A1"].PutValue("Name");
            workbook.Worksheets[0].Cells["B1"].PutValue("Mark1");
            workbook.Worksheets[0].Cells["C1"].PutValue("Mark2");
            workbook.Worksheets[0].Cells["D1"].PutValue("TotalMarks");

            workbook.Worksheets[0].Cells["A2"].PutValue("Liya");
            workbook.Worksheets[0].Cells["B2"].PutValue("20");
            workbook.Worksheets[0].Cells["C2"].PutValue("30");
            workbook.Worksheets[0].Cells["C2"].PutValue("30"); 

            // Save the workbook in output XLSM format.
            workbook.Save(dirPath + "OutputXLSM.xlsm", SaveFormat.Xlsm);


        }
    }
}

