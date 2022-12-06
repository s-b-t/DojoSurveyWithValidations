#pragma warning disable CS8618
namespace DojoSurveyWithValidations.Models;
using System.ComponentModel.DataAnnotations;

public class Survey
{
    [Required(ErrorMessage="* Name is required!")]
    [MinLength(2, ErrorMessage="* Name must be at least 2 characters!")]
    public string name { get; set; }
    
    [Required(ErrorMessage="* Dojo Location is required!")]
    public string dojoLocation { get; set; }
    
    [Required(ErrorMessage="* Favorite Language is required!")]
    public string favLanguage { get; set; }

    [MinLength(20, ErrorMessage="* Comment must be at least 20 characters!")]
    public string? comment { get; set; }
}