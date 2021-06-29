using AutoMapper;
using OnlineExam.Models;

using OnlineExam.Models.Table;

namespace OnlineExam.Helper
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<UserTable, User>().ReverseMap();
            CreateMap<ArticleTable, Quiz>().ReverseMap();
            CreateMap<QuestionTable, Question>().ReverseMap();
            CreateMap<QuizTable, Quiz>().ReverseMap();
        }
    }
}
