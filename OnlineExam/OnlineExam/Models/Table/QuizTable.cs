using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models.Table
{
    public class QuizTable
    {
        public int Id { get; set; }

        [Required]
        public string ArticleId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public string CreatedStr { get { return Created.ToString("yyyy-MM-dd"); } }
    }
}
