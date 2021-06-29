﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Helper;
using OnlineExam.Models;
using OnlineExam.Models.Table;
using OnlineExam.Proxy;
using OnlineExam.Repository;

namespace OnlineExam.Controllers
{
    public class QuizController : Controller
    {
        private readonly IWiredProxy _wiredProxy;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IMapper _mapper;

        public QuizController(IWiredProxy wiredProxy, IRepositoryFactory repositoryFactory, IMapper mapper)
        {
            _wiredProxy = wiredProxy;
            _repositoryFactory = repositoryFactory;
            _mapper = mapper;
        }

        [BindProperty]
        public CreateQuizViewTable CreateQuizViewTable { get; set; }

        public async Task<IActionResult> CreateQuiz()
        {
            if (HttpContext.Session.GetString(Constants.SessionUserId) == null)
            {
                return Redirect(Url.Action("Login", "User"));
            }

            var articleList = await _wiredProxy.GetLastFiveArticlesAsync();

            CreateQuizViewTable = new CreateQuizViewTable();
            CreateQuizViewTable.ArticleList = articleList.ToList();

            return View(CreateQuizViewTable);
        }

        [HttpPost]
        [ActionName("CreateQuiz")]
        public async Task<IActionResult> CreateQuizPost()
        {
            CreateQuizViewTable.ErrorMessage = null;

            if (ModelState.IsValid)
            {
                // Distinct question control
                if (CreateQuizViewTable.QuestionArr.Select(q => q.QuestionText).Distinct().Count() != 4)
                {
                    CreateQuizViewTable.ErrorMessage = "Questions should be unique";

                    return View(CreateQuizViewTable);
                }

                //Distinct answers control
                foreach(var q in CreateQuizViewTable.QuestionArr)
                {
                    if(q.AnswerA == q.AnswerB ||
                        q.AnswerA == q.AnswerC ||
                        q.AnswerA == q.AnswerD ||
                        q.AnswerB == q.AnswerC ||
                        q.AnswerB == q.AnswerD ||
                        q.AnswerC == q.AnswerD)
                    {
                        CreateQuizViewTable.ErrorMessage = "A question cannot have the same answer more than once";

                        return View(CreateQuizViewTable);
                    }
                }

                var transaction = await _repositoryFactory.BeginTransactionAsync();

                var quizRepository = _repositoryFactory.GetQuizRepository();

                var selectedArt = CreateQuizViewTable.ArticleList.FirstOrDefault(a => a.ArticleId == CreateQuizViewTable.SelectedArticleId);

                if (selectedArt == null)
                {
                    return View(CreateQuizViewTable);
                }

                var quiz = _mapper.Map<Quiz>(selectedArt);

                await quizRepository.CreateQuizAsync(quiz);
                await _repositoryFactory.SaveAsync();

                var questionRepository = _repositoryFactory.GetQuestionRepository();

                foreach (var item in CreateQuizViewTable.QuestionArr)
                {
                    var ques = _mapper.Map<Question>(item);
                    ques.QuizId = quiz.Id;

                    await questionRepository.CreateQuestionAsync(ques);
                }

                await _repositoryFactory.SaveAsync();

                transaction.Commit();

                return RedirectToAction("Index", "Quiz");
            }

            return View(CreateQuizViewTable);
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString(Constants.SessionUserId) == null)
            {
                return Redirect(Url.Action("Login", "User"));
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuizzes()
        {
            var quizRepository = _repositoryFactory.GetQuizRepository();

            var quizList = await quizRepository.GetAllQuizzesAsync();

            var quizDtoList = _mapper.Map<List<QuizTable>>(quizList.ToList());

            return Json(new { data = quizDtoList });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var quizRepository = _repositoryFactory.GetQuizRepository();

            var quizFromDb = await quizRepository.GetQuizAsync(id);

            if (quizFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            quizRepository.DeleteQuiz(quizFromDb);
            await _repositoryFactory.SaveAsync();

            return Json(new { success = true, message = "Delete successful" });
        }

        [HttpGet]
        public async Task<IActionResult> Quiz(int id)
        {
            if (HttpContext.Session.GetString(Constants.SessionUserId) == null)
            {
                return Redirect(Url.Action("Login", "User"));
            }

            var quizRepository = _repositoryFactory.GetQuizRepository();
            var questionRepository = _repositoryFactory.GetQuestionRepository();

            var quizFromDb = await quizRepository.GetQuizAsync(id);

            // If quiz does not exist
            if (quizFromDb == null)
            {
                return Redirect(Url.Action("Index", "Quiz"));
            }

            var questionList = await questionRepository.GetAllQuestionsAsync(id);

            var quizDto = _mapper.Map<QuizTable>(quizFromDb);
            var questionDtoList = _mapper.Map<List<QuestionTable>>(questionList);

            var quizViewDto = new QuizViewTable();

            quizViewDto.QuizTable = quizDto;
            quizViewDto.QuestionTableList = questionDtoList;

            return View(quizViewDto);
        }
    }
}
