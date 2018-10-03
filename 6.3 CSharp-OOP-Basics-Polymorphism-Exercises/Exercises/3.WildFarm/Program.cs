using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var animals = new List<Animal>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var currAnimal = GetAnimal(input);
            animals.Add(currAnimal);

            var currFood = GetFood(input);

            Console.WriteLine(currAnimal.ProduceSound());

            try
            {
                currAnimal.Eat(currFood);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, animals));
    }

    private static Food GetFood(string input)
    {
        var foodList = new List<Food>();

        var foodTokens = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var type = foodTokens[0];

        var foodQuantity = int.Parse(foodTokens[1]);

        switch (type)
        {
            case "Vegetable":
                var vegetable = new Vegetable(foodQuantity);
                foodList.Add(vegetable);
                break;

            case "Fruit":
                var fruit = new Fruit(foodQuantity);
                foodList.Add(fruit);

                break;

            case "Meat":
                var meat = new Meat(foodQuantity);
                foodList.Add(meat);

                break;

            case "Seeds":
                var seed = new Seeds(foodQuantity);
                foodList.Add(seed);

                break;

            default:
                break;
        }

        return foodList.FirstOrDefault();
    }

    private static Animal GetAnimal(string input)
    {
        var animalList = new List<Animal>();

        var animalTokens = input
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var type = animalTokens[0];

        var animalName = animalTokens[1];
        var animalWeight = double.Parse(animalTokens[2]);

        string animalLivingRegion;
        string animalBreed;
        double animalWingSize;

        switch (type)
        {
            case "Cat":
                animalLivingRegion = animalTokens[3];
                animalBreed = animalTokens[4];

                var cat = new Cat(animalName, animalWeight, animalLivingRegion, animalBreed);
                animalList.Add(cat);
                break;

            case "Tiger":
                animalLivingRegion = animalTokens[3];
                animalBreed = animalTokens[4];

                var tiger = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                animalList.Add(tiger);
                break;

            case "Owl":
                animalWingSize = double.Parse(animalTokens[3]);

                var owl = new Owl(animalName, animalWeight, animalWingSize);
                animalList.Add(owl);
                break;

            case "Hen":
                animalWingSize = double.Parse(animalTokens[3]);

                var hen = new Hen(animalName, animalWeight, animalWingSize);
                animalList.Add(hen);
                break;

            case "Mouse":
                animalLivingRegion = animalTokens[3];

                var mouse = new Mouse(animalName, animalWeight, animalLivingRegion);
                animalList.Add(mouse);
                break;

            case "Dog":
                animalLivingRegion = animalTokens[3];

                var dog = new Dog(animalName, animalWeight, animalLivingRegion);
                animalList.Add(dog);
                break;

            default:
                break;
        }

        return animalList.FirstOrDefault();
    }
}

