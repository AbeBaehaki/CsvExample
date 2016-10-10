using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader streamReader = File.OpenText("mock_data.csv"))
            {
                var csvConfiguration = new CsvConfiguration();
                csvConfiguration.RegisterClassMap<SampleDataMap>();

                var csv = new CsvReader(streamReader, csvConfiguration);
                var records = csv.GetRecords<SampleData>();

                foreach (var record in records)
                {
                    Console.WriteLine($"Number={record.Number}, Name={record.Name}, Date={record.Date}, Boolean={record.Boolean}");
                }
            }

            Console.ReadKey();
        }
    }
}
