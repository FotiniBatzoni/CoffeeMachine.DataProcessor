using System;
using System.IO;
using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Data;

public class ConsoleCoffeeCountStoreTests
{
    [Fact]
    public void ShouldWriteOutputToConsole()
    {
        //Arrange
        var item = new CoffeeCountItem("Cappucino", 5);
        var stringWriter = new StringWriter();
        var consoleCoffeeCountStore = new ConsoleCoffeeCountStore(stringWriter);

        //Act
        consoleCoffeeCountStore.Save(item);

        //Assert
        var result = stringWriter.ToString();
        Assert.Equal($"{ item.CoffeeType}:{ item.count}{ Environment.NewLine}",result);

    }
}
