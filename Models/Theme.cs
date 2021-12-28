using System.Collections.Generic;

namespace Lingva.Models
{

    public class Theme
    {
        public string LanguageParent { get; set; }
        public string ThemeLanguageLevel { get; set; }
        public int ThemeID { get; set; }
        public string ThemeTopic { get; set; }
        public List<Task> Lessons { get; set; }
    }
}