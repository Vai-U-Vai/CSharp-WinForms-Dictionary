using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal interface IDictionaryManager
    {
        DictionaryRepository Repository { get; set; }
        bool AddWord(string word, List<string> translations);
        void RemoveWord(string key);
        void Clear();
        void DelWord(List<string> word);
        void DelTranslation(string word, List<string> translation);
        List<string> GetTranslation(string word);
        List<string> GetAllTranslations(string str);
        string GetWordByTranslation(string word);
        string ReadFromFile(string path);
        void WrightToFile(string path, string date);
    }
}
