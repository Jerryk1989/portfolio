using Portfolio.Models;

namespace Portfolio.Data
{
    public class ExperienceRepository
    {
        private static Experience[] _experience = new Experience[]
        {
            new Experience()
            {
                ExperienceName = "ASP.NET",
                ExperienceDescription = "This website is made using ASP.NET MVC.  I've also had experience working on my current companies web application, which uses ASP.NET.  My primary focus was working on bugs in our backlog and other tasks handed down from development."
            },
            new Experience()
            {
                ExperienceName = "SQL (SSMS)",
                ExperienceDescription ="I first learned SQL while in school and it's a skill that has been a constant in all of my projects/jobs.  In my current position, I work with SQL daily to locate potential problems.  I also work on SQL import PO's that are put in to the company.  These usually require a custom script written based off the information provided.  I help debug and implement changes to stored procedures."
            },
            new Experience()
            {
                ExperienceName = "RESTful API's",
                ExperienceDescription ="I've worked with creating endpoints in a few of my different projects.  I've also worked with JIRA's REST API in my Python scripts.  Using the REST API, I've been able to automate certain aspects of my current companies ticket queue.  This has saved our team leads from the tedious task of manually going through tickets looking for specific things."
            },
            new Experience()
            {
                ExperienceName = "Java",
                ExperienceDescription ="Java is the first language I really dove into while working at Aston Technologies.  I worked with Java console applications, servlets, JSP's, JDBC, and eventually moved into Spring MVC.  I focused primarily on making endpoints that would retreieve and persist data to the database."
            },
            new Experience()
            {
                ExperienceName = "Ruby on Rails",
                ExperienceDescription ="I was brought in to work with a developer tasked with making our automation testing more usable.  Our previous person had written many scrits with Ruby/Selenium, but unfortunately left.  We were left with many scripts, but no great way to use them.  The project presented was to create a webapp that would allow development and QA to interact with these tests easier. This required the developer and I to pickup Ruby on Rails and start creating the web app from scratch.  I was heavily involved in this project, from creating the relational database, to bringing over the data from the previous database.  This is still a WIP at this point in time."
            },
            new Experience()
            {
                ExperienceName = "Github",
                ExperienceDescription ="At my current position we actually use TFS, but in my free time I use github.  This website and a few other person projects I've worked on can be found on my github page located <a href='http://www.github.com/jerryk1989'>here</a>."
            }
        };

        public Experience[] GetExperiences()
        {
            return _experience;
        }
    }
}