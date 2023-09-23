using Mentor.DAL;
using Mentor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor.Controllers
{
    public class HomeController : Controller
    {

        public AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;        
        }
        public IActionResult Index()
        {
            HomeVM vm = new();
          
            vm.AboutContent = _appDbContext.aboutContents.Include(a=>a.AboutListContent).FirstOrDefault();
            ////Product sildikki viewcomponentegore
            vm.HeroContent = _appDbContext.HeroContent.FirstOrDefault();
            vm.IconSection = _appDbContext.iconSections.ToList();
           vm.PopularCategory=_appDbContext.popularCategories.Include(p=>p.popularCourses).ToList();
            vm.WhyChooseUs=_appDbContext.WhyChooseUs.ToList();
      //onetonede adi firstordefault olur
            return View(vm);
        }
    }
}
