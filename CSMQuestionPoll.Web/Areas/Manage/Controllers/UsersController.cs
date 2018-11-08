using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSMQuestionPoll.Web.Infrastructure.Data.Enums;
using CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using CSMQuestionPoll.Web.Infrastructure.Data.Models;
using CSMQuestionPoll.Web.Models;
using CSMQuestionPoll.Web.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;

        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "")
        {
            Page<User> result = new Page<User>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }
            IQueryable<User> userQuery = (IQueryable<User>)this._context.Users;
            if (string.IsNullOrEmpty(keyword) == false)
            {
                userQuery = userQuery.Where(u => u.FirstName.Contains(keyword)
                                            || u.LastName.Contains(keyword)
                                            || u.EmailAddress.Contains(keyword));
            }
            long queryCount = userQuery.Count();
            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            int skip = (int)(pageSize * (pageIndex - 1));
            List<User> users = userQuery.ToList();
            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.CurrentPage = pageIndex;

            return View(new IndexViewModel()
            {
                Users = result
            });
        }

        [HttpGet, Route("home/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("home/create")]
        public IActionResult Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("index");
            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password does not match Password Confirmation");
                return View();
            }
            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());
            if (user == null)
            {
                user = new User()
                {
                    EmailAddress = model.EmailAddress,
                    Password = model.Password,
                    Gender = model.Gender,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                this._context.Users.Add(user);
                this._context.SaveChanges();
            }
            return RedirectToAction("index");
        }

        [HttpGet, Route("home/change-status/{status}/{userId}")]
        public IActionResult ChangeStatus(string status, Guid? userId)
        {
            var loginStatus = (LoginStatus)Enum.Parse(typeof(LoginStatus), status, true);
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            if (user != null)
            {
                user.LoginStatus = loginStatus;
                this._context.Users.Update(user);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("home/reset-password/{userId}")]
        public IActionResult ResetPassword(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                user.Password = RandomString(8);
                user.LoginStatus = Infrastructure.Data.Enums.LoginStatus.NeedsToChangePassword;
                this._context.Users.Update(user);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        private Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet, Route("home/delete/{userId}")]
        public IActionResult Delete(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                this._context.Users.Remove(user);
                this._context.SaveChanges();
            }
            return RedirectToAction("index");
        }


        //#region
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        //#endregion
    }
}