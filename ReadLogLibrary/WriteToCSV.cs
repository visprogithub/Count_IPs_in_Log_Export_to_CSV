using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ReadLogLibrary
{
    public class WriteToCSV
    {
        public void ExportToCSV(IEnumerable<string> toExport, string filePath)
        {
            
            String csv = String.Join(
              Environment.NewLine,
              toExport.Select(d => d
                                  .Replace("[", "")
                                  .Replace("]",""))
              );

            System.IO.File.WriteAllText(filePath, csv);
        }
    }
}
