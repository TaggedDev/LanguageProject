using System.Collections.Generic;

namespace Lingva.Models
{
    public enum ELessonType
    {
        WriteWord,
        WriteTranslation,
        ChooseOption,
        ConnectPairs
    }

    public class Task
    {
        public string LanguageParent { get; set; }
        public string LessonType { get; set; }
        public int LessonParentID { get; set; }
        public int ThemeParentID { get; set; }
        public bool HasTextField { get; set; }
        public string TextFieldContent { get; set; }
        public List<Field> Fields { get; set; }
    }
}
