using classes;
using classes.Abstract_Classes;
using classes.Concreate_Classes;
using Zoo.Interface;
namespace Zoo_part2Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestTheClassesThatImplementTheInterFaces()
        {
            //Arrange
            Crocodile croc = new Crocodile("Gustave", 18, 20.7, false, true, "Dark Green", 4.2);
            croc.AverageEgg = 13;
            croc.ClawLength = 4.5;
            croc.SwimmingSpeed = 35;
            
            Snake snake = new Snake("Sankora", 14, 60.5, true, false, "White") { AverageEgg = 20 };
            
            Duck duck = new Duck("Batot", 8, 20.7, 50.4, false, "Zoo lake") { SwimmingSpeed = 40, AverageEgg = 12 };

            Eagle eagle = new Eagle("Crowned Eagle", 18, 90.10, 5.40, true, 10) { AverageEgg = 8, ClawLength = 4.2 };

            //Assert

            Assert.IsAssignableFrom<IEggLayer>(croc);
            Assert.IsAssignableFrom<ISwimable>(croc);
            Assert.IsAssignableFrom<IHaveClaw>(croc);

            Assert.IsAssignableFrom<IEggLayer>(duck);
            Assert.IsAssignableFrom<ISwimable>(duck);

            Assert.IsAssignableFrom<IEggLayer>(eagle);
            Assert.IsAssignableFrom<IHaveClaw>(eagle);

            
            Assert.IsAssignableFrom<IEggLayer>(snake);

        }
        [Fact]
        public void TestTheInheritance()
        {
            //Assert
            Reptiles reptiles = new Crocodile("Croc", 17, 22, false, true, "Dark Green", 4.8);
            // Act
            Assert.False(reptiles.IsPoisonous);
            Assert.True(reptiles.HasLegs);
            Assert.Equal("Dark Green", reptiles.FurColor);
            // Assert
            Assert.True(reptiles is Animal);
        }

        [Fact]
        public void TestIfTheMethodIsOverRidden()
        {
            // Arrange
            Eagle eagle = new Eagle("Crowned Eagle", 18, 90.10, 5.40, true, 10) { AverageEgg = 8, ClawLength = 4.2 };
            // Act
            var result = eagle.Eat();
            // Assert
            Assert.Equal("Crowned Eagle feeds on small mammals, fish, and reptiles.", eagle.Eat().ToString());


        }
        [Fact]
        public void TestIfTheConcreteISanAnimal()
        {
            // Arrange
            Crocodile croc = new Crocodile("Croc", 17, 22, false, true, "Dark Green", 4.8);

            //Assert 
            Assert.IsAssignableFrom<Animal>(croc);

        }
    }
}