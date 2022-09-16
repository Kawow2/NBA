using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NBAAPP.Models
{
    public enum PositionModel
    {
        [Display(Name = "Guard")]
        G,        
        [Display(Name = "Forward")]
        F,
        [Display(Name = "Center")]
        C



    }
}
