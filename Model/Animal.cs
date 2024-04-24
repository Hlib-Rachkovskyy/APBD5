using System.ComponentModel.DataAnnotations;

namespace APBD5.Model;

public class Animal
{
    [Required]
    public int IdAnimal { get; set; }
    [Required]
    [StringLength(200)]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public string Area { get; set; }
    
}