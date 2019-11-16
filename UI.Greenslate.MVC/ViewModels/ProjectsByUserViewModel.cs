using DATA.Greenslate.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Greenslate.MVC.ViewModels
{
    public class ProjectsByUserViewModel
    {
        public List<ProjectByUser> ProjectsByUser { get; set; }

        public List<User> Users { get; set; }
    }

    public class ProjectByUser
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime AssignedDate { get; set; }
        public int TimeToStart { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public int Credits { get; set; }
        public string Status { get; set; }

    }
}