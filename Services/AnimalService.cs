using APBD5.Model;
using APBD5.Repository;

namespace APBD5.Services;

public class AnimalService : IAnimalService
{

    private readonly IAnimalsRepository _animalsRepository;
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalsRepository.GetAnimals();
    }

    public void AddAnimal(Animal animal)
    {
        _animalsRepository.AddAnimal(animal);
    }

    public void UpdateAnimalData(int idAnimal)
    {
        _animalsRepository.UpdateAnimalData(idAnimal);
    }

    public void DeleteAnimal(int idAnimal)
    {
        _animalsRepository.DeleteAnimal(idAnimal);
    }

    public Animal GetAnimal(int id)
    {
        return _animalsRepository.GetAnimal(id);
    }
}