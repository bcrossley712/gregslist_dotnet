

using gregslist_dotnet.Models;

namespace gregslist_dotnet.Controllers.DB
{
  public static class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
          new Car("Dodge", "Ramit", 1900, 8000, "Piece of doo doo", "#FFFFFF", "https://offroadaction.ca/wp-content/uploads/2009/04/t.jpg"),
          new Car("GMC", "Shiny", 2022, 800000, "Really?!", "#FFFFFF", "https://www.gmc.com/content/dam/gmc/na/us/english/index/vehicles/future-vehicles/sierra-ld-mcm/jellybeans/2022-sierra-at4-shortbed-crewcab-summitwhite1.jpg?imwidth=960"),
          new Car("Ford", "Drof", 1980, 8, "Why would you?", "#FFFFFF", "https://cs.copart.com/v1/AUTH_svc.pdoc00001/PIX428/d5e0c08a-3f9e-4031-9084-8af22fa53f81.JPG"),
          new Car("Toyoto", "Truck?", 1985, 5000, "Toyoto makes a truck?", "#FFFFFF", "https://www.thetruthaboutcars.com/wp-content/uploads/2017/10/00-1981-Toyota-Pickup-in-California-Wrecking-Yard-photograph-by-Murilee-Martin.jpg"),
              };
  }
}