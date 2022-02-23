using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDal.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int ExamId { get; set; }
        
        [ForeignKey("ExamId")]
        public ExamDefinition ExamDef { get; set; }
    }
}
