using APBD5.Model;

namespace APBD5.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals(string query);
    public void AddAnimal(Animal animal);
    public void UpdateAnimalData(Animal animal);
    public void DeleteAnimal(int idAnimal);
}