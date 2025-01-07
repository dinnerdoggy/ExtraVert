using System;

public class Plant
{
   public string Species;
   public int LightNeeds;
   public decimal AskingPrice;
   public string City;
   public int Zip;
   public bool Sold;

   public Plant(string species, int lightneeds, decimal askingprice, string city, int zip, bool sold)
    {
        Species = species;
        LightNeeds = lightneeds;
        AskingPrice = askingprice;
        City = city;
        Zip = zip;
        Sold = sold;
    }
};

class Program
{
    static void Main(string[] args)
     {
        Plant plant1 = new Plant(
            "Basil",
            5,
            5.00m,
            "Nashville",
            37214,
            true
        );
    Console.WriteLine( plant1.Species );
    }
}
