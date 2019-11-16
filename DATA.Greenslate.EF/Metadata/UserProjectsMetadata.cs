using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Greenslate.EF.Metadata
{
    class UserProjectsMetadata
    {
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }

        [Required(ErrorMessage = "Question is required")]
        [Display(Name = "Active Project?")]
        public bool IsActive { get; set; }

        [Display(Name = "Date Project Assigned")]
        [Required(ErrorMessage = "Date is required")]
        public System.DateTime AssignedDate { get; set; }


    }
}
