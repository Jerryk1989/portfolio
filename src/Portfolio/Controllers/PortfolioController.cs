using Portfolio.Data;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private ProjectRepository _projectRepository;
        private ExperienceRepository _experienceRepository;

        public PortfolioController()
        {
            _projectRepository = new ProjectRepository();
            _experienceRepository = new ExperienceRepository();
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
            var experience = _experienceRepository.GetExperiences();

            return View(experience);
        }

    }
}