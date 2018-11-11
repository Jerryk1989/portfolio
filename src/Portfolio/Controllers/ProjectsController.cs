using Portfolio.Data;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private ProjectRepository _projectRepository = null;

        public ProjectsController()
        {
            _projectRepository = new ProjectRepository();
        }

        public ActionResult Index()
        {
            var projects = _projectRepository.GetProjects();

            return View(projects);
        }

    }
}