using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    // Фабрика для создания реализаций интерфейса IDictionaryManagement
    internal class DictionaryManagerFactory
    {
        public static IDictionaryManager CreateDictionaryManager(DictionaryRepository repository)
        {
            return new DictionaryManager(repository);
        }
    }
}
