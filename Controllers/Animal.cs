using Microsoft.AspNetCore.Mvc;

namespace APBD5.Controllers;

[Route("api/animal")]
[ApiController]
public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals(string query)
    {
        
        
        return Ok();
    }
    
}