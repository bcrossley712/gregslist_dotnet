
using System.ComponentModel.DataAnnotations;

namespace gregslist_dotnet.Models
{
  public class Car
  {

    public string? Id { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    [Range(1900, 2023)]
    public int? Year { get; set; }
    [Range(0, 20000000)]
    public int? Price { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public string? ImgUrl { get; set; }
    public Car(string? make, string? model, int? year, int? price, string? description, string? color, string? imgUrl)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      Color = color;
      ImgUrl = imgUrl;
    }
  }
}