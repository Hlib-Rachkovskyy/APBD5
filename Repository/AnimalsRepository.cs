using APBD5.Model;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace APBD5.Repository;

public class AnimalsRepository : IAnimalsRepository {

private IConfiguration _configuration;

public AnimalsRepository(IConfiguration configuration)
{
    _configuration = configuration;
}

    public IEnumerable<Animal> GetAnimals()
    {
        var animals = new List<Animal>();
        using var sqlConnection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        sqlConnection.Open();
        using var command = new SqlCommand("SELECT * FROM ANIMALS", sqlConnection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var animal = new Animal
            {
                IdAnimal = (int)reader["IdAnimal"],
                Name = reader["Name"].ToString(),
                Area = reader["Area"].ToString(),
                Category = reader["Category"].ToString(),
            };
            animals.Add(animal);
        }
        return animals;
    }

    public void AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void UpdateAnimalData(int idAnimal)
    {
        throw new NotImplementedException();
    }

    public void DeleteAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimal(int id)
    {
        throw new NotImplementedException();
    }
}