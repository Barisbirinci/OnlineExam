using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OnlineExam.Models.Table
{
    public class QuestionTable
    {
        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string AnswerA { get; set; }

        [Required]
        public string AnswerB { get; set; }

        [Required]
        public string AnswerC { get; set; }

        [Required]
        public string AnswerD { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }
    }
}
