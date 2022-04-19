using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Utility
{
    public static class ConvertingStringtoData
    {
        public static T Convert<T>(string data, char separator = '\u002C') where T : class, new()
        {
            string[] dataSet = data.Split(separator);
            int length = dataSet.Length;

            // T tipinde data
            T dataT = new T();

            // Verinin property'lere atanmasi
            for(int i = 0; i < length; i++)
            {
                PropertyInfo prop = typeof(T).GetProperties()[i];
                Type propType = prop.PropertyType;

                dynamic set = dataSet[i].Trim('\"');
                if (propType.Name == "Boolean")
                {
                    if (set == "1")
                        set = true;
                    else
                        set = false;
                }


                dynamic value = System.Convert.ChangeType(set, propType);
                dataT.GetType().GetProperty(prop.Name).SetValue(dataT, value, null);
            }

            return dataT;
        }
    }
}