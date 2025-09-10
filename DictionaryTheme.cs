using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class DictionaryTheme
    {
        public string ThemeName { get; set; }
        public Dictionary<string, List<string>> Words { get; set; }

        public DictionaryTheme()
        {
            ThemeName = "";
            Words = new Dictionary<string, List<string>>();
        }
        public DictionaryTheme(string themeName)
        {
            ThemeName = themeName;
            Words = new Dictionary<string, List<string>>();
        }

        public bool AddWord(string word, List<string> translations)
        {
            if (!Words.ContainsKey(word))
            {
                Words[word] = translations;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveWord(string word)
        {
            return Words.Remove(word);
        }

        public List<string> GetTranslations(string word)
        {
            return Words.ContainsKey(word) ? Words[word] : null;
        }


        public void Clear()
        {
            if (Words != null)
            {
                Words.Clear();
            }
        }

        public bool DelWord(string word)
        {
            if (Words.ContainsKey(word))
            {
                Words.Remove(word);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DelTranslation(string word, string translation)
        {

            if (Words.ContainsKey(word))
            {
                if (Words[word].Contains(translation))
                {
                    if (Words[word].Count > 1)
                    {
                        Words[word].Remove(translation);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetTranslation(string word)
        {
            Words.TryGetValue(word, out List<string> translations);
            return translations;
        }

        public string FindFirstWord(string word)
        {
            Words.TryGetValue(word, out List<string> translations);
            return translations.FirstOrDefault(); ;
        }
        public string ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return null;
            }
        }

        public void WrightToFile(string path, string date)

        {
            File.WriteAllText(path, date);
        }


    }
}
