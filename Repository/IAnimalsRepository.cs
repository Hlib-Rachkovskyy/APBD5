using APBD5.Model;

namespace APBD5.Repository;

public interface IAnimalsRepository
{
    public IEnumerable<Animal> GetAnimals(string query);
    public int CreateAnimal(Animal animal);
    public int UpdateAnimalData(int idAnimal, Animal animal);
    public int DeleteAnimal(int idAnimal);

}