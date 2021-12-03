using System.Collections.Generic;

namespace Lingva.Models
{
    public enum EThemeLevel
    {
        A1,
        A2,
        B1,
        B2,
        C1,
        C2
    }

    public class Theme
    {
        public ELanguageList LanguageParent { get; set; }
        public EThemeLevel ThemeLevel { get; set; }
        public int ThemeID { get; set; }
        public string ThemeTopic { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}