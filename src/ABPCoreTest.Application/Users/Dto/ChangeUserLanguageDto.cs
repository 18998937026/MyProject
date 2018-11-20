using System.ComponentModel.DataAnnotations;

namespace ABPCoreTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}