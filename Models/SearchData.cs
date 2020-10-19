using System.ComponentModel.DataAnnotations;

namespace SwaggerAPI.Models
{
    public class SearchData
    {
        [StringLength(120, MinimumLength = 3, ErrorMessage = "You must enter password between 3 and 120 Characters")]
        public string q_category { get; set; }
        public int q_people { get; set; }
    }
}