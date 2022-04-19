using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Utility
{
    public class CsvFileManager
    {
        private readonly string _filePath;
        public CsvFileManager(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            _filePath = filePath;
        }

        public List<T> Read<T>() where T : class, new()
        {
            List<T> data = new List<T>();

            if (File.Exists(_filePath))
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string line = reader.ReadLine();

                    while ((line = reader.ReadLine()) != null)
                        data.Add(ConvertingStringtoData.Convert<T>(line, '\u003B'));
                }
            }

            return data;
        }
    }
}
