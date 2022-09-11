using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NBAAPP.Models
{
    public enum Position
    {
        [Display(Name = "Point Guard")]
        PG,
        [Display(Name = "Shooting Guard")]
        SG,
        [Display(Name = "Small Forward")]
        SF,
        [Display(Name = "Power Forward")]
        PF,
        [Display(Name = "Center")]
        C



    }
}
