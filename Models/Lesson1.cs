using System;

namespace Lingva.Models
{
    public class Lesson1
    {
        public int ID { get; set; }
        public int ThemeParentID { get; set; }
        public string LanguageParent { get; set; }
        public string LessonTitle { get; set; }
        public DateTime CreationTimestamp { get; set; }
    }
}
