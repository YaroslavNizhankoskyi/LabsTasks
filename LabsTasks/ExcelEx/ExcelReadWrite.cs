using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;

namespace LabsTasks.ExcelEx
{
    internal static class ExcelReadWrite
    {
        public static void Run()
        {
            const string excelFile = "Movies.xlsx";

            //CreateFile(excelFile);
            Write(excelFile);       
        }

        public static void CreateFile(string fileName)
        {
            Workbook wb = new Workbook();

            wb.Save(fileName, SaveFormat.Xlsx);
        }

        public async static void Write(string fileName)
        {
            var excel = new ExcelMapper();

            var movies = new List<Movie>();

            for(var i = 0; i < 10; i++)
            {
                movies.Add(new Movie(i,$"{i}{i+1}{i+2}","diney"));
            }

            await excel.SaveAsync(
                fileName,
                movies,
                sheetName: "movies"
            );
        }

        public record Movie(
               int Id,
               string Name,
               string StreamingService
        );
    }
}
