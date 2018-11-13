using Portfolio.Data;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private ProjectRepository _projectRepository = null;

        public PortfolioController()
        {
            _projectRepository = new ProjectRepository();
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Projects()
        {
            var projects = _projectRepository.GetProjects();

            return View(projects);
        }

        public ActionResult Experience()
        {
            return View("Experience");
        }

    }
}