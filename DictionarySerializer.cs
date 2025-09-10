using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    // Английский-Русский| - тип словаря
    // Название темы(если есть, либо пустая строка)|
    // word:translate1, translate2...
    // / - конец темы
    // ! - конец документа
    internal static class DictionarySerializer
    {
        public static string SerializeDictionary(DictionaryRepository repository)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{repository.LanguageWord}-{repository.LanguageTranslate}|");
            foreach (var theme in repository.Themes)
            {
                sb.AppendLine($"{theme.ThemeName}|");
                foreach (var line in theme.Words)
                {
                    sb.AppendLine($"{line.Key}:{line.Value}");
                }
                sb.AppendLine($"/");
            }
            sb.AppendLine("!");

            return sb.ToString();
        }

        public static DictionaryTheme DeserializeTheme(string data)
        {
            DictionaryTheme theme = new DictionaryTheme();           
            // Извлекаем тему themeName и слова
            int index = data.IndexOf('|');
            string themeName = data.Substring(0, index).Trim();
            theme.ThemeName = themeName;
            data = data.Substring(index + 1).Trim();
           
            while (true)
            {
                List<string> list = new List<string>();
                index = data.IndexOf(':');
                string word = data.Substring(0, index).Trim();
                data = data.Substring(index + 1).Trim();
                list.Add(data.Substring(0, data.IndexOf('\n')));
                theme.Words[word] = list;
                data = data.Substring(data.IndexOf('\n') + 1).Trim();
                if (data[0] == '/')
                {
                   
                    break;
                }
            }

            return theme;
        }
        public static DictionaryRepository DeserializeDictionary(string data)
        {
            DictionaryRepository repository = new DictionaryRepository();
            // Извлекаем LanguageWord и LanguageTranslate
            int index = data.IndexOf('-');
            repository.LanguageWord = data.Substring(0, index).Trim();
            data = data.Substring(index + 1);
            index = data.IndexOf('|');
            repository.LanguageTranslate = data.Substring(0, index).Trim();
            data = data.Substring(index + 1).Trim();
            while (data.IndexOf('!') != 0)
            {

            DictionaryTheme theme = DeserializeTheme(data);               
                repository.Themes.Add(theme);
                data = data.Substring(data.IndexOf('/') + 1).Trim();
            }
            return repository;
        }
    }
}
