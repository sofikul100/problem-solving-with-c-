using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
class AttendanceP{
    public AttendanceP() { 
                  string filePath = @"D:\Dosuments\net\prac\experiment.txt";
        // Read all lines into an array
        string[] lines = File.ReadAllLines(filePath);

        // Define a regex pattern to match proxy, date, and time
        string pattern = @"(\d{8})\s+(\d{8}):\s+(\d{6}):";

         int proxyFinal = 16742837;
         string dateFinal = "";
         string inTime = "";
         string outTime = "";

        var regex = new Regex(pattern);



        foreach (var line in lines)
        {
            var match = regex.Match(line);

            if (match.Success)
            {
                string proxy = match.Groups[1].Value.Trim();
                string datef = match.Groups[2].Value.Trim();
                string time = match.Groups[3].Value.Trim();

                if(proxyFinal == int.Parse(proxy)){
                    dateFinal = datef;
                    if(time.StartsWith("0")){
                       inTime = time;
                    }
                    outTime = time;
                }
                
            }
        }

        

        Console.WriteLine(" Date -> " + dateFinal + " inTime-> " + inTime + " "  + "Out Time -> " + outTime);


    }
}