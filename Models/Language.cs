using System.Collections.Generic;

namespace Lingva.Models
{
    public enum ELanguageList
    {
        Russian,
        English,
        Deutsch
    }

    public class Language
    {
        public ELanguageList LanguageType { get; set; }
        public List<Theme> Theme { get; set; }
    }
}
