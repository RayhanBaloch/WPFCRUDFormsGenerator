using System.ComponentModel.DataAnnotations;

namespace CrudFormGeneratorConsole.Models;

public class PersonModel
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Full Name")]
    public string PersonName { get; set; } = string.Empty;

    [Display(Name = "Age")]
    public int Age { get; set; }
}
