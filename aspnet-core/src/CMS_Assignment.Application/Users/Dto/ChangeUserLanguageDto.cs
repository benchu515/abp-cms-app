using System.ComponentModel.DataAnnotations;

namespace CMS_Assignment.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}