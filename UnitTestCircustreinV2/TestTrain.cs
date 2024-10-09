namespace UnitTestCircustreinV2;
using CircustreinV2;
using System.Drawing;

[TestClass]
public class TrainTests
{
    private Train train;

    [TestInitialize]
    public void Setup()
    {
        train = new Train();
    }

    [TestMethod]
    public void GetWagons_ShouldReturnEmptyList_WhenNoWagonsAdded()
    {
        // Arrange
        // (Setup is already done in the Setup method)

        // Act
        var wagons = train.GetWagons();

        // Assert
        Assert.AreEqual(0, wagons.Count);
    }

    [TestMethod]
    public void Train_Sort()
    {
        // Arrange
        // (Setup is already done in the Setup method)
        train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
        train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Small));
        train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));

        // Act
        train.SortAnimals();

        // Assert
        Assert.IsTrue(train.animalsDescending[0].GetSize() == Animal.Size.Large);
        Assert.IsTrue(train.animalsDescending[1].GetSize() == Animal.Size.Medium);
        Assert.IsTrue(train.animalsDescending[2].GetSize() == Animal.Size.Small);
    }



}