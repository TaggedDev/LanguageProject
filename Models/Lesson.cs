using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingva.Models
{
    public enum ELessonType
    {
        WriteWord,
        WriteTranslation,
        ChooseOption,
        ConnectPairs
    }

    public class Lesson
    {
        public string LanguageParent { get; set; }
        public string LessonType { get; set; }
        public int LessonID { get; set; }
        public int ThemeParentID { get; set; }
        public bool HasTextField { get; set; }
        public string TextFieldContent { get; set; }
        public List<Field> Fields { get; set; }
    }
}
