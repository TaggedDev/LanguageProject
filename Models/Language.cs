using System.Collections.Generic;

namespace Lingva.Models
{
    public enum ELanguageList
    {
        English,
        Russian,
        Deutsch
    }

    public class Language
    {
        public ELanguageList LanguageType { get; set; }
        public List<Theme> Themes { get; set; }
    }
}
