using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingApplication.Areas.Identity.Data;
using OnlineVotingApplication.Data;
using OnlineVotingApplication.ViewModel;
using System.Threading.Tasks;

namespace OnlineVotingApplication.Controllers
{
    public class Admin : Controller
    {
        private UserManager<OnlineVotingApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly OnlineVotingApplicationContext _context;


        public Admin(
        UserManager<OnlineVotingApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        OnlineVotingApplicationContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public async Task<IActionResult> ViewVoters()
        {
            var voters = await (from user in _context.Users
                                join userRole in _context.UserRoles on user.Id equals userRole.UserId
                                join role in _context.Roles on userRole.RoleId equals role.Id
                                where role.Name == "Admin"
                                select user).ToListAsync();

            var viewModel = new ConvertApplicationUser(voters);
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = _context.Users.Where(x => x.Id.Equals(id)).FirstOrDefault();
            ConvertApplicationUser viewModelUser = ConvertApplicationUser.EditConvertModel(user);

            return View(viewModelUser);
        }
        [HttpPost]
        public IActionResult Update(string id, ConvertApplicationUser vm)
        {
            var user = _context.Users.Where(x => x.Id.Equals(id)).FirstOrDefault();
            user.IsVoter = vm.IsVoter;
            _context.SaveChanges();
            return RedirectToAction("ViewVoters");
        }

        public IActionResult Index()
        {
            List<OnlineVotingApplicationUser> users = _context.Users.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult CreateCandidate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCandidate(Candidate candidate)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(string id)
        {
            var user = _context.Users.Where(x => x.Id.Equals(id)).FirstOrDefault();
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("ViewVoters");
        }
    }
}
