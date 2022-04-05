

using gregslist_dotnet.Controllers.DB;
using gregslist_dotnet.Models;

namespace gregslist_dotnet.Services
{
  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return FakeDb.Cars;
    }

    internal Car GetById(string id)
    {
      Car found = FakeDb.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal Car Create(Car body)
    {
      FakeDb.Cars.Add(body);
      return body;
    }

    internal Car Update(Car body)
    {
      Car original = GetById(body.Id);
      original.Color = body.Color ?? original.Color;
      original.Description = body.Description ?? original.Description;
      original.ImgUrl = body.ImgUrl ?? original.ImgUrl;
      original.Make = body.Make ?? original.Make;
      original.Model = body.Model ?? original.Model;
      original.Price = body.Price != null ? body.Price : original.Price;
      original.Year = body.Year != null ? body.Year : original.Year;

      return original;
    }

    internal void Delete(string id)
    {
      Car found = GetById(id);
      FakeDb.Cars.Remove(found);
    }
  }
}