using classes.Concreate_Classes;
using classes;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba", 15, 80, true, "Golden", "Spacetoon");
            Console.WriteLine($"The Lion Name is : {lion.Name} and his age is {lion.Age}, he has Fur {lion.HasFur} his MainColor is {lion.MainColor}");

            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Sleep());
            Console.WriteLine(lion.Sound());
            Console.WriteLine(lion.Living());
            Console.WriteLine(lion.Dangerous());
            Console.WriteLine(lion.Hunt());

            Console.WriteLine();
            Console.WriteLine();

            Horse horse = new Horse("Spirit", 10, 50.0, true, "White", "Arabian");
            Console.WriteLine($"The Horse Name is : {horse.Name} his age is : {horse.Age}, has fur {horse.HasFur}  his mainColor is {horse.MainColor}");

            Console.WriteLine(horse.Eat());
            Console.WriteLine(horse.Sleep());
            Console.WriteLine(horse.Sound());
            Console.WriteLine(horse.Living());
            Console.WriteLine(horse.Dangerous());
            Console.WriteLine(horse.Gallop());

            Console.WriteLine();
            Console.WriteLine();

            Eagle eagle = new Eagle("Crowned Eagle", 18, 90.10, 5.40, true, 10) { AverageEgg = 8, ClawLength= 4.2 };

            Console.WriteLine($"The Eagle Name is : {eagle.Name} his age is : {eagle.Age}. his  average speed {eagle.Speed}Km/h. ");

            Console.WriteLine(eagle.Eat());
            Console.WriteLine(eagle.Sleep());
            Console.WriteLine(eagle.Sound());
            Console.WriteLine(eagle.Living());
            Console.WriteLine(eagle.Fly());
            Console.WriteLine(eagle.DisplayWingSize());
            Console.WriteLine(eagle.Beak());
            eagle.LayEgg();
            eagle.Claw();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Duck duck = new Duck("Batot", 8, 20.7, 50.4, false, "Zoo lake") { SwimmingSpeed = 40, AverageEgg = 12 };

            Console.WriteLine($"The Duck Name is : {duck.Name} his age is : {duck.Age} , his  average speed {duck.Speed}Km/h. ");

            Console.WriteLine(duck.Eat());
            Console.WriteLine(duck.Sleep());
            Console.WriteLine(duck.Sound());
            Console.WriteLine(duck.Living());
            Console.WriteLine(duck.Fly());
            Console.WriteLine(duck.DisplayWingSize());
            duck.Swimmable();
            duck.LayEgg();


            Console.WriteLine();
            Console.WriteLine();

            Crocodile croc = new Crocodile("Gustave", 18, 20.7, false, true, "Dark Green", 4.2)
            { AverageEgg = 50, SwimmingSpeed = 30 ,ClawLength = 5.4};

            Console.WriteLine($"The Crocodile Name is : {croc.Name} his age is : {croc.Age} , his  average speed {croc.Speed}Km/h. ");

            Console.WriteLine(croc.Eat());
            Console.WriteLine(croc.Sleep());
            Console.WriteLine(croc.Sound());
            Console.WriteLine(croc.Living());
            Console.WriteLine(croc.Legs());
            Console.WriteLine(croc.Fur_Color());
            Console.WriteLine(croc.Poisonous());
            Console.WriteLine(croc.SharpTeeth());
            Console.WriteLine(croc.BodyLength());
            croc.LayEgg();
            croc.Swimmable();
            croc.Claw();

            Console.WriteLine();
            Console.WriteLine();

            Snake snake = new Snake("Sankora", 14, 60.5, true, false, "White") { AverageEgg = 20 };

            Console.WriteLine($"The Snake Name is : {snake.Name} his age is : {snake.Age} , his  average speed {snake.Speed}Km/h. ");


            Console.WriteLine(snake.Eat());
            Console.WriteLine(snake.Sleep());
            Console.WriteLine(snake.Sound());
            Console.WriteLine(snake.Living());
            Console.WriteLine(snake.Legs());
            Console.WriteLine(snake.Fur_Color());
            Console.WriteLine(snake.Poisonous());
            Console.WriteLine(snake.SharpTeeth());
            Console.WriteLine(snake.ShedSkin());
            snake.LayEgg();




        }
    }
}