using APBD5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD5.Controllers;

[Route("api/animal")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    
    
    [HttpGet]
    public IActionResult GetAnimals(string query)
    {
        return Ok(_animalService.GetAnimals(query));
    }
    
}