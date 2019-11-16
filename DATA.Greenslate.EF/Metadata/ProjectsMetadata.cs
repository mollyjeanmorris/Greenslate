using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Greenslate.EF
{
    public class ProjectsMetadata
    {
        [Required(ErrorMessage ="Start Date is required")]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Credits are Required")]
        public int Credits { get; set; }
    }

    [MetadataType(typeof(ProjectsMetadata))]
    public partial class Projects { }
}
