using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingva.Models
{
    public class Field
    {
        public int LessonParentID { get; set; }
        public string Content { get; set; }
        public List<string> AnswersAliases { get; set; }
    }
}
