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

    public IEnumerable<Animal> GetAnimals(string query)
    {
        var animals = new List<Animal>();
        using var sqlConnection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        sqlConnection.Open();
        using var command = new SqlCommand("SELECT * FROM ANIMALS a ORDER BY @query", sqlConnection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var animal = new Animal
            {
                IdAnimal = (int)reader["IdAnimal"],
                Name = reader["Name"].ToString(),
                Area = reader["Area"].ToString(),
                Category = reader["Category"].ToString(),
                Description = reader["Description"].ToString()
            };
            animals.Add(animal);
        }
        return animals;
    }

    public int AddAnimal(Animal animal)
    {
        using var sqlConnection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        sqlConnection.Open();
        using var comand = new SqlCommand("INSERT INTO ANIMALS (Name, Area, Category, Description) VALUES (@Name, @Area, @Category, @Description)", sqlConnection);
        comand.Parameters.AddWithValue("@Area", animal.Area);
        comand.Parameters.AddWithValue("@Category", animal.Category);
        comand.Parameters.AddWithValue("@Name", animal.Name);
        comand.Parameters.AddWithValue("@Description", animal.Description);

        var count = comand.ExecuteNonQuery();
        return count;
    }

    public int UpdateAnimalData(Animal animal)
    {
        using var SqlConnection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        SqlConnection.Open();
        using var SqlCommand = new SqlCommand("UPDATE ANIMALS SET Name = @name, Description = @description, Category = @category, Area = @area WHERE IdAnimal = @idAnimal", SqlConnection);
        SqlCommand.Parameters.AddWithValue("@idAnimal", animal.IdAnimal);
        SqlCommand.Parameters.AddWithValue("@name", animal.Name);
        SqlCommand.Parameters.AddWithValue("@description", animal.Description);
        SqlCommand.Parameters.AddWithValue("@category", animal.Category);
        SqlCommand.Parameters.AddWithValue("@area", animal.Area);

        
        
        var count = SqlCommand.ExecuteNonQuery();
        return count;
    }

    public int DeleteAnimal(int idAnimal)
    {
        using var sqlConnection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        sqlConnection.Open();
        using var sqlCommand = new SqlCommand("DELETE FROM ANIMALS WHERE IdAnimal = @idAnimal", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@idAnimal", idAnimal);
        var count = sqlCommand.ExecuteNonQuery();
        return count;
    }
    
}