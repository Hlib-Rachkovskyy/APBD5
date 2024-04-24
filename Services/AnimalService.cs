using APBD5.Model;
using APBD5.Repository;

namespace APBD5.Services;

public class AnimalService : IAnimalService
{

    private readonly IAnimalsRepository _animalsRepository;
    public IEnumerable<Animal> GetAnimals(string query)
    {
        return _animalsRepository.GetAnimals(query);
    }

    public void AddAnimal(Animal animal)
    {
        _animalsRepository.AddAnimal(animal);
    }

    public void UpdateAnimalData(Animal animal)
    {
        _animalsRepository.UpdateAnimalData(animal);
    }

    public void DeleteAnimal(int idAnimal)
    {
        _animalsRepository.DeleteAnimal(idAnimal);
    }

   
}