using APBD5.Model;

namespace APBD5.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    public void AddAnimal(Animal animal);
    public void UpdateAnimalData(int idAnimal);
    public void DeleteAnimal(int idAnimal);
    public Animal GetAnimal(int id);
}