namespace UnitTestCircustreinV2;
using CircustreinV2;


[TestClass]
public class TestWagon
{

    [TestMethod]
    public void TestAddAnimal_Success()
    {
        // Arrange
        var wagon = new Wagon();
        var animal = new Animal(Animal.Diet.Carnivore, Animal.Size.Medium); // Medium size, which gives 3 points

        // Act
        var result = wagon.CanAddAnimal(animal);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(1, wagon.GetAnimals().Count);
    }

    [TestMethod]
    public void TestAddAnimal_Fail_TooManyPoints()
    {
        // Arrange
        var wagon = new Wagon();
        var animal1 = new Animal(Animal.Diet.Herbivore, Animal.Size.Large); // Large size, which gives 5 points
        var animal2 = new Animal(Animal.Diet.Carnivore, Animal.Size.Large); // Large size, which gives 5 points

        // Act
        wagon.CanAddAnimal(animal1);
        var result = wagon.CanAddAnimal(animal2);

        // Assert
        Assert.IsFalse(result);
        Assert.AreEqual(1, wagon.GetAnimals().Count);
    }

    [TestMethod]
    public void TestGetTotalPoints()
    {
        // Arrange
        var wagon = new Wagon();
        var animal1 = new Animal(Animal.Diet.Herbivore, Animal.Size.Small); // Small size, which gives 1 point
        var animal2 = new Animal(Animal.Diet.Herbivore, Animal.Size.Medium); // Medium size, which gives 3 points

        // Act
        wagon.CanAddAnimal(animal1);
        wagon.CanAddAnimal(animal2);
        var totalPoints = wagon.GetTotalPoints();

        // Assert
        Assert.AreEqual(4, totalPoints);
    }
}
