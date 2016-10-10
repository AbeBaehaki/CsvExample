using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvExample
{
    public sealed class SampleDataMap : CsvClassMap<SampleData>
    {
        public SampleDataMap()
        {
            Map(m => m.Number).Name("number");
            Map(m => m.Name).Name("name");
            Map(m => m.Boolean).Name("boolean");

            Map(m => m.Date).ConvertUsing(row =>
            {
                return DateTime.ParseExact(row.GetField("date"), "M/d/yyyy", null);
            });
        }
    }
}
