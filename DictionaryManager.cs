using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    // Класс для управления словарём
    internal class DictionaryManager: IDictionaryManager
    {        

        public DictionaryRepository Repository { get ; set ; }

        public DictionaryManager(DictionaryRepository dR)
        {
            Repository = dR;
        }

        //---------------------------------------------- РАБОТА С ТЕМАМИ ----------------------------------------

        public bool IfThemeExist(string name)
        {
            foreach (DictionaryTheme t in Repository.Themes)
            {
                if (t.ThemeName == name)
                    return true;
            }
            return false;
        }
        public void AddTheme(string path)
        {
            DictionaryTheme theme = new DictionaryTheme();
            string str = theme.ReadFromFile(path);
            if (str != null)
            {
                Repository.Themes.Add(DictionarySerializer.DeserializeTheme(str));
            }
        }

        public bool RemoveTheme(string themeName)
        {
            return Repository.Themes.RemoveAll(theme => theme.ThemeName == themeName) > 0;
        }

        public string GetThemeNameFromWord(string word)
        {

            return Repository.Themes.FirstOrDefault(theme => theme.Words.ContainsKey(word)).ThemeName;
        }
        public DictionaryTheme GetTheme(string themeName)
        {
            return Repository.Themes.FirstOrDefault(theme => theme.ThemeName == themeName);
        }

        //---------------------------------------------- РАБОТА СО СЛОВАРЁМ ----------------------------------------
        public List<string> GetTranslation(string word)
        {
            foreach (DictionaryTheme theme in Repository.Themes)
            {
                if (theme.Words.ContainsKey(word))
                {
                    return theme.Words[word];
                }
            }
            return new List<string> { "" };
        }

        public List<string> GetAllTranslations(string str)
        {
            List<string> list = Help.GetListFromString(str);
            List<string> listRezult = new List<string> { };
            foreach (var l in list)
            {
                listRezult.Add(Help.GetStringFromListSpaced(GetTranslation(l)));
            }


            return listRezult;
        }

        public string GetWordByTranslation(string word)
        {
            foreach (DictionaryTheme t in Repository.Themes)
            {
                foreach (var pair in t.Words)
                {
                    if (pair.Value.Contains(word))
                    {
                        return pair.Key;
                    }
                }
            }
            return null;
        }




        public bool AddWord(string word, List<string> translations)
        {
            throw new NotImplementedException();
        }

        public void RemoveWord(string key)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void DelWord(List<string> word)
        {
            throw new NotImplementedException();
        }

        public void DelTranslation(string word, List<string> translation)
        {
            throw new NotImplementedException();
        }

        public string ReadFromFile(string path)
        {
            throw new NotImplementedException();
        }

        public void WrightToFile(string path, string date)
        {
            throw new NotImplementedException();
        }

       
    }
}
