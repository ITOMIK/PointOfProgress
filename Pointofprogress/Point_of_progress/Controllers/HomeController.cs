using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Point_of_progress.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Point_of_progress.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserContext db_users;
        private LogInContext log_context;
        public bool _isregistrated;
        public string _loggin = "";
        public string _name = "";
        public string _role = "";
        public int _balance = 0;
        private TaskContext db_Tasks;
        private CompanyContext db_Companies;

        public HomeController(ILogger<HomeController> logger, UserContext db_users, LogInContext log_context, TaskContext db_Tasks, CompanyContext db_Companies)
        {
            _logger = logger;
            this.db_users = db_users;
            this.log_context = log_context;
            _isregistrated = this.log_context.LogIns.ToList()[0].islog;
            _name = this.log_context.LogIns.ToList()[0].name;
            _loggin = this.log_context.LogIns.ToList()[0].login;
            _role = this.log_context.LogIns.ToList()[0].role;
            _balance = this.log_context.LogIns.ToList()[0].balance;
            this.db_Tasks = db_Tasks;
            this.db_Companies = db_Companies;
        }

        public async Task<IActionResult> Index()
        {

            var obj = new IndexPage() { UserList = await db_users.Users.ToListAsync(), isregistrated = _isregistrated };
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public int IdForUsers(List<User> listobj)
        {
            int maxint = 0;
            foreach( var item in listobj.OrderBy(x=> x.id ))
            {
                if (item.id - maxint == 1) { maxint++; }
                else { maxint++; break; }
            }
            return maxint++;
        }
        public int IdForTasks(List<Models.Task> listobj)
        {
            int maxint = 0;
            foreach (var item in listobj.OrderBy(x => x.id))
            {
                if (item.id - maxint == 1) { maxint++; }
                else { maxint++; break; }
            }
            return maxint++;
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(string? login, string? password)
        {
            var Users = db_users.Users;
            var LogIn = log_context.LogIns;
            var ObjToSend = new IndexPage() { isregistrated = LogIn.ToList()[0].islog, UserList = await db_users.Users.ToListAsync() };
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return NotFound();
            }
            if(Users.FirstOrDefaultAsync(x=> x.login==login) !=null)
            {
                var obj = await db_users.Users.FirstOrDefaultAsync(p => p.login == login);
                if (obj == null) { ObjToSend.isregistrated = false;   return View("index", ObjToSend); }

                if (obj.password == password)
                {
                    var _login = await LogIn.FirstOrDefaultAsync(p => p.id == 1);
                    _login.name=obj.name;
                    _login.password=obj.password;
                    _login.islog = true;
                    _login.login=obj.login;
                    _login.role=obj.role;
                    _login.balance=obj.balance;
                    await log_context.SaveChangesAsync();
                    ObjToSend.isregistrated = true;
                }
                await log_context.SaveChangesAsync();
                return View("Index",ObjToSend);
            }
            return NotFound();
           
        }
        public async Task<IActionResult> Tasks()
        {

            var obj = new TasksPage() { TaskList = await db_Tasks.Tasks.ToListAsync(), isregistrated = _isregistrated, UserList= await db_users.Users.ToListAsync(), role=_role };
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            var LogIn = log_context.LogIns;
            var ObjToSend = new IndexPage() { isregistrated = false, UserList = await db_users.Users.ToListAsync() };
            var _login = await LogIn.FirstOrDefaultAsync(p => p.id == 1);
            _login.islog = false;
            await log_context.SaveChangesAsync();
            return View("Index", ObjToSend);
        }
            [HttpPost]
        public async Task<IActionResult> AddNewUser( string? name="", string? login="", string? password="", string? role="", int companyid=-1)
        {
            var Users = db_users.Users;
            foreach ( var item in Users)
            {
                if (item.login == login)
                {
                    return NotFound();
                }
            }
            User obj = new User() {name=name,login=login, password=password, role=role, companyid=companyid, id= IdForUsers(db_users.Users.ToList()) };
            Users.Add(obj);
            await db_users.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(int? id)
        { 
            if (id != null)
            {
                User obj = await db_users.Users.FirstOrDefaultAsync(p => p.id == id);
                if (obj != null)
                {
                    db_users.Users.Remove(obj);
                    await db_users.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(int? id, string? name = "", string? login = "", string? password = "", string? role = "", int companyid = -1)
        {
            if (id != null)
            {
                User obj = await db_users.Users.FirstOrDefaultAsync(p => p.id == id);
                if (obj != null)
                {
                    obj.name = name;
                    obj.login = login;
                    obj.password = password;
                    obj.role = role;
                    obj.companyid = companyid;
                    await db_users.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddNewTask(string? name = "", string? comments = "", string? date = "", int userid = -1)
        {
            var Tasks = db_Tasks.Tasks;

            Models.Task obj = new Models.Task() { name = name, comments = comments, date = date, userid = userid, id = IdForTasks(db_Tasks.Tasks.ToList()) };
            Tasks.Add(obj);
            await db_Tasks.SaveChangesAsync();
            return RedirectToAction("Tasks");
        }
        public async Task<IActionResult> Profile(int id=1)
        {
            var Users = db_users.Users;
            var User = Users.FirstOrDefault(p => p.id == id);
            var obj = new ProfilePage() {id=User.id, companyid=User.companyid, login=User.login, name=User.name, password= User.password, role= User.role, CompanyList= db_Companies.Companies.ToList(), isreg=_isregistrated };
            return View("Profile", obj);
        }
        public async Task<IActionResult> Raiting(int id=1)
        {
            var obj =new RaitingPage(){UserList=db_users.Users.ToList(), name= db_users.Users.ToList().FirstOrDefault(x=> x.id==id).name, isreg=_isregistrated};
            return View("Raiting",obj);
        }
        public async Task<IActionResult> Shop()
        {

            var obj = new ShopPage() { Items= new List<Item>(), isreg = _isregistrated };
            obj.Items.Add(new Item() { name = "Оплачеваемый Отгул", price = 1000 });
            obj.Items.Add(new Item() { name = "Возможность опаздать на 20 минут", price = 500 });
            obj.Items.Add(new Item() { name = "День в другой должности", price = 700 });
            return View("Shop", obj);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
