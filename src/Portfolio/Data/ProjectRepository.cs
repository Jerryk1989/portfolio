using Portfolio.Models;

namespace Portfolio.Data
{
    public class ProjectRepository
    {

        private static Project[] _projects = new Project[]
        {
            new Project()
            {
                Id = 1,
                ProjectName = "Folder Compare",
                PrimaryLanguage = "Python",
                Description = "This program lets you select two folders and compares the files within them.  It outputs the differences."
            },
            new Project()
            {
                Id = 2,
                ProjectName = "Easy SQL",
                PrimaryLanguage = "Python",
                Description = "This is a simple program that makes SQL queries more accessible to those who are less familiar with writing their own SQL queries."
            },
            new Project()
            {
                Id = 3,
                ProjectName = "Ticket Tracker",
                PrimaryLanguage = "Python",
                Description = "Using the JIRA API, this program (with permissions setup on JIRA) goes through ticket queues and finds specific tickets with the last comment having specific key words.  Once it has run, the list of tickets with matching keywords is automatically emailed out."
            },
            new Project()
            {
                Id = 4,
                ProjectName = "Unassigned!",
                PrimaryLanguage = "Python",
                Description = "Using the JIRA API, this program is setup to check a specific project on JIRA every minute for unassigned tickets.  If it finds one, it displays a pop up box for the user to let them know a ticket is unassigned and needs to be assigned."
            }
        };

        public Project[] GetProjects()
        {
            return _projects;
        }
    }
}