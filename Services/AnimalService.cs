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

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimalData(int idAnimal, Animal animal)
    {
        return _animalsRepository.UpdateAnimalData(idAnimal, animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }

   
}