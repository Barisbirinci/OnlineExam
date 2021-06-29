
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OnlineExam.Models.Table
{
    public class QuizViewTable
    {
        [Required]
        public QuizTable QuizTable { get; set; }

        [Required]
        public List<QuestionTable> QuestionTableList { get; set; }
    }
}
