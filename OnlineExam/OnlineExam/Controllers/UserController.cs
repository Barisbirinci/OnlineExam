using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Helper;
using OnlineExam.Models;
using OnlineExam.Models.Table;
using OnlineExam.Repository;

namespace OnlineExam.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IMapper _mapper;

        public UserController(IRepositoryFactory repositoryFactory, IMapper mapper)
        {
            _repositoryFactory = repositoryFactory;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString(Constants.SessionUserId) != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserTable userTable)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "User register validation failed" });
            }

            IUserRepository userRepository = _repositoryFactory.GetUserRepository();

            if (await userRepository.UserExistsAsync(userTable.Username))
            {
                return Json(new { success = false, message = $"User Already Exists: {userTable.Username}" });
            }

            User user = _mapper.Map<User>(userTable);

            await userRepository.CreateUserAsync(user);
            await _repositoryFactory.SaveAsync();

            return Json(new { success = true, message = "Register successful", url = Url.Action("Login", "User") });
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserTable userTable)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "User login validation failed" });
            }

            IUserRepository userRepository = _repositoryFactory.GetUserRepository();

            if (!await userRepository.UserExistsAsync(userTable.Username, userTable.Password))
            {
                return Json(new { success = false, message = "Username or password is incorrect" });
            }

            var userFromDb = await userRepository.GetUserAsync(userTable.Username);

            HttpContext.Session.SetString(Constants.SessionUserId, userFromDb.Id.ToString());

            return Json(new { success = true, message = "Login successful", url = Url.Action("Index", "Home") });
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString(Constants.SessionUserId) != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(Constants.SessionUserId);

            return RedirectToAction("Login", "User");
        }
    }
}
