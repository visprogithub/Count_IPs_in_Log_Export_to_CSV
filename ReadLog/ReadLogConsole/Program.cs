using ReadLogLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadLogConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];

            HandleFile(filePath);

        }

        private static void HandleFile(string filePath)
        {
            ReadLogs readLog = new ReadLogs();

            IEnumerable<string> ipsAndCounts = readLog.ReadWrite(filePath+"access.log");

            WriteToCSV writeIPsandCount = new WriteToCSV();

            writeIPsandCount.ExportToCSV(ipsAndCounts, filePath + "report.csv");
        }

    }
}