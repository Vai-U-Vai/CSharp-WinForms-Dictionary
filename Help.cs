using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal static class Help
    {
        public static string GetStringFromList(List<string> list)
        {           
            string str = string.Join(", ", list);
            return str;
        }
        public static string GetStringFromListSpaced(List<string> list)
        {
            string str = string.Join("", list);
            return str;
        }

        //public static List<string> GetListFromString(string str)
        //{            
        //    List<string> list = str.Split(',').Select(t => t.Trim()).ToList();
        //    return list;
        //}
        public static List<string> GetListFromString(string str)
        {
            char[] separators = { ',', ' ', '!', ':', '?', '-', '.', '\n' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.ToList();
        }       
    }
}
