using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    // Класс для хранения тем словаря
    internal class DictionaryRepository
    {
        public string LanguageWord;
        public string LanguageTranslate;
        public List<DictionaryTheme> Themes { get; set; }
        public DictionaryRepository()
        {
            Themes = new List<DictionaryTheme>();
        }

      

    }
}
