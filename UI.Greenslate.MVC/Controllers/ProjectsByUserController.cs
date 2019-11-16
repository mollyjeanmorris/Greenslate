using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Greenslate.MVC.ViewModels;
using DATA.Greenslate.EF;

namespace UI.Greenslate.MVC.Controllers
{
    public class ProjectsByUserController : Controller
    {
        private GreenslateEntities db = new GreenslateEntities();

        public List<ProjectByUser> LoadListProjectsForAllUsers()
        {
            List<ProjectByUser> projectByUsers = new List<ProjectByUser>();
            List<UserProject> userProjects = GetListUserProjectsForAllUsers();

            foreach (UserProject up in userProjects)
            {
                Project proj = GetProjectByProjectId(up.ProjectId);
                ProjectByUser pbu = new ProjectByUser()
                {
                    UserId = up.UserId,
                    ProjectId = proj.Id,
                    ProjectStartDate = proj.StartDate,
                    TimeToStart = Convert.ToInt32(proj.StartDate.Subtract(up.AssignedDate).TotalDays),
                    AssignedDate = up.AssignedDate,
                    ProjectEndDate = proj.EndDate,
                    Credits = proj.Credits,
                    Status = up.IsActive ? "Active" : "Inactive"
                };

                projectByUsers.Add(pbu);

            }

            return projectByUsers;
        }

        public List<UserProject> GetListUserProjectsByUserId(int UserId)
        {

            List<UserProject> userProjects = (from up in db.UserProjects
                                              where up.UserId == UserId
                                              select up).ToList();

            return userProjects;
        }

        public List<UserProject> GetListUserProjectsForAllUsers()
        {

            List<UserProject> userProjects = (from up in db.UserProjects
                                              select up).ToList();

            return userProjects;
        }

        public Project GetProjectByProjectId(int ProjectId)
        {

            Project project = (from p in db.Projects
                               where p.Id == ProjectId
                               select p).FirstOrDefault();

            return project;
        }

    }
}