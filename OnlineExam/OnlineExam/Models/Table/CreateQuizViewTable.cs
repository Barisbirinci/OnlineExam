using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models.Table
{
    public class CreateQuizViewTable
    {
        [Required]
        public List<ArticleTable> ArticleList { get; set; }

        [Required]
        public string SelectedArticleId { get; set; }

        [Required]
        public QuestionTable[] QuestionArr { get; set; } = new QuestionTable[4];

        public string ErrorMessage { get; set; }
    }
}
