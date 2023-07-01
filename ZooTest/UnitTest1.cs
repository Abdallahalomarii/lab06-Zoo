using System.Xml.Linq;
using classes.Concreate_Classes;
using classes;
namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void LionBehaviors()
        {
            // Arrange 
            var lion = new Lion("Simba", 15, 80, true, "Golden", "Spacetoon");

            // Act 
            var eatResult = lion.Eat();
            var sleepResult = lion.Sleep();
            var soundResult = lion.Sound();
            var huntResult = lion.Hunt();

            // Assert 
            Assert.Equal("Simba eating meats so they are Carnivores", eatResult);
            Assert.Equal("Simba sleep under the Trees", sleepResult);
            Assert.Equal("Simba Roars Loudly!", soundResult);
            Assert.Equal("Simba's Hunting for his Prey. his Speed can Reach to 80 Km/h when he is hunting.", huntResult);
        }

        [Fact]
        public void HorseBehaviors()
        {
            // Arrange
            var horse = new Horse("Spirit", 5, 40.0, true, "Brown", "Quarter Horse");

            // Act
            var eatResult = horse.Eat();
            var sleepResult = horse.Sleep();
            var soundResult = horse.Sound();
            var livingResult = horse.Living();

            // Assert
            Assert.Equal("Spirit primarily eats grass and other vegetation, making them herbivores.", eatResult);
            Assert.Equal("Spirit typically sleeps while standing, but they can also lay down.", sleepResult);
            Assert.Equal("Spirit makes sounds like neighing, snorting, and whinnying.", soundResult);
            Assert.Equal("Spirit lives in various habitats, including grasslands, forests, and deserts. They are adaptable and can thrive in different environments.", livingResult);
        }

        [Fact]
        public void EagleBehaviors()
        {
            // Arrange
            Eagle eagle = new Eagle("Baldy", 10, 80.0, 40.0, true, 2.5);

            // Act
            var eatResult = eagle.Eat();
            var sleepResult = eagle.Sleep();
            var soundResult = eagle.Sound();
            var flyResult = eagle.Fly();

            // Assert
            Assert.Equal("Baldy feeds on small mammals, fish, and reptiles.", eatResult);
            Assert.Equal("Baldy rests and sleeps perched on high branches or cliffs.", sleepResult);
            Assert.Equal("Baldy emits a high-pitched screech or whistle as its vocalization.", soundResult);
            Assert.Equal("Baldy soars through the sky with majestic wings, utilizing its exceptional flying abilities.", flyResult);
        }

        [Fact]
        public void DuckBehaviors()
        {
            // Arrange
            var duck = new Duck("Quacky", 3, 10.0, 23.0, true, "Zoo lake");

            // Act
            var eatResult = duck.Eat();
            var sleepResult = duck.Sleep();
            var soundResult = duck.Sound();
            var swimResult = duck.Swim();

            // Assert
            Assert.Equal("Quacky feeds on aquatic plants, insects, and small aquatic animals.", eatResult);
            Assert.Equal("Quacky rests and sleeps on land or in nests near water bodies.", sleepResult);
            Assert.Equal("Quacky makes a quacking sound as its vocalization.", soundResult);
            Assert.Equal("Quacky is a proficient swimmer, moving gracefully through the water at a speed of 10 km/h.", swimResult);
        }

        [Fact]
        public void CrocodileBehaviors()
        {
            // Arrange
            var crocodile = new Crocodile("Snappy", 15, 20.0, false, true, "Green", 5.8);

            // Act
            var eatResult = crocodile.Eat();
            var sleepResult = crocodile.Sleep();
            var soundResult = crocodile.Sound();
            var baskResult = crocodile.BodyLength();

            // Assert
            Assert.Equal("Snappy primarily feeds on fish, birds, and mammals near the water.", eatResult);
            Assert.Equal("Snappy often rests and sunbathes on the banks of rivers or lakes.", sleepResult);
            Assert.Equal("Snappy produces low-frequency vocalizations, including deep rumbles and hisses.", soundResult);
            Assert.Equal("Snappy has a body length of 5.8 Meters", baskResult);
        }

        [Fact]
        public void SnakeBehaviors()
        {
            // Arrange
            var snake = new Snake("Slither", 7, 5.0, true, false, "Black");

            // Act
            var eatResult = snake.Eat();
            var sleepResult = snake.Sleep();
            var soundResult = snake.Sound();
            var shedResult = snake.ShedSkin();

            // Assert
            Assert.Equal("Slither primarily feeds on small mammals, birds, and reptiles.", eatResult);
            Assert.Equal("Slither rests in hidden areas such as burrows or vegetation.", sleepResult);
            Assert.Equal("Slither produces hissing sounds when threatened.", soundResult);
            Assert.Equal("Slither periodically sheds its skin as it grows.", shedResult);
        }
    }
}