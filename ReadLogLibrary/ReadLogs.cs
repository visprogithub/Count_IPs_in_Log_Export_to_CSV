using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLogLibrary
{

    public class ReadLogs
    {
     
        public IEnumerable<string> ReadWrite(string logFilePath)
        {

            List<string> logFileLines = File.ReadAllLines(logFilePath)
               .Where(x => x.Contains("GET") && !x.Contains(" 207.114")).ToList();

            List<string> ipsInbound = new List<string>();
            
            foreach (string line in logFileLines)
            {
                ipsInbound.Add(line.Split(' ').Where(str => IsIP(str) == true).First().ToString());
            }

            //the counts aren't unique so I can't use them as the key for the dictionary which means I have to flip them below
            //to match the formatting in the readme

            Dictionary<string, int> ipsAndCounts = ipsInbound
                .GroupBy(str => str)
                .ToDictionary(group => group.Key, group => group.Count());

            return from entry in ipsAndCounts 
                   orderby entry.Value descending, entry.Key descending 
                   select entry.Value.ToString() + ","+ "\"" + entry.Key.ToString() + "\"";

        }
        static bool IsIP(string logFileParseString)
        {
            System.Net.IPAddress ipAddress = null;

            //added if because the ipparse was counting the port and other numerics or dates
            if (logFileParseString.Contains('.'))
            {
                return System.Net.IPAddress.TryParse(logFileParseString, out ipAddress);
            }
            else
            {
                return false;
            }

        }
    }
}

