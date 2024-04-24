using APBD5.Model;
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
    public IActionResult GetAnimals(string query = "name")
    {
        return Ok(_animalService.GetAnimals(query));
    }
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{idAnimal:int}")]
    public IActionResult UpdateAnimal(int idAnimal, Animal animal)
    {
        _animalService.UpdateAnimalData(idAnimal ,animal);
        return NoContent();
    }

    [HttpDelete("{idAnimal:int}")]
    public IActionResult DeleteAnimal(int idAnimal)
    {
        _animalService.DeleteAnimal(idAnimal);
        return NoContent();
    }
}