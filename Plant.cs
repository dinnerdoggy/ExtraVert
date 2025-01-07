using System;

public class Plant
{
   public string Species = "Basil";
   public int LightNeeds = 5;
   public decimal AskingPrice = 5.00m;
   public string City = "Nashville";
   public int Zip = 37214;
   public bool Sold = false;
};

class Program
{
    static void Main()
    {
        // Create an instance of the Plant class
        Plant plant = new Plant();

        // Access the Species property of the instance
        Console.WriteLine($"Species: {plant.Species}");
    }
}