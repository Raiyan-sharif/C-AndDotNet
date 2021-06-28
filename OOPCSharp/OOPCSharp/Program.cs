using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace OOPCSharp
{
    class Program
    {
        public DataSet ExcelDataSet { get; internal set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = { "This is line1", "This is line2", "This is line3" };
            //using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"D:\C-AndDotNet\OOPCSharp\OOPCSharp\some.text"))
            //{
            //    foreach(var line in lines)
            //    {
            //        writer.WriteLine(line);
            //    }
            //}
            GetDataSet();


        }
        private static DataSet GetDataSet()
        {
            DataSet excelDataSet;
            using (var stream = File.Open(@"D:\C-AndDotNet\OOPCSharp\OOPCSharp\DataDictionaryTemplate.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    excelDataSet = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    });
                }
            }
            return excelDataSet;
        }
    }
}
