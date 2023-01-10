﻿
using System;

namespace WiredBrainCoffee.DataProcessor.Parsing;

public class CsvLineParsrTests
{
    [Fact]
    public void ShouldPassValidLine()
    {
        //Arrange
        string[] csvLines = new[] { "Cappuccino;10/27/2022 8:06:04 AM" };

        //Act
        var machineDataItems = CsvLineParser.Parse(csvLines);

        //Assert
        Assert.NotNull(machineDataItems);
        Assert.Single(machineDataItems);
        Assert.Equal("Cappuccino", machineDataItems[0].CoffeeType);
        Assert.Equal(new DateTime(2022, 10, 27, 8, 6, 4), machineDataItems[0].CreatedAt);

    }

    [Fact]
    public void ShouldSkipEmptyLines()
    {
        //Arrange
        string[] csvLines = new[] { "", "   " };

        //Act
        var machineDataItems = CsvLineParser.Parse(csvLines);

        //Assert
        Assert.NotNull(machineDataItems);
        Assert.Empty(machineDataItems);
    }

    [Fact]
    public void ShouldThrowExceptionForInvalidLine()
    {
        //Arrange
        string[] csvLines = new[] { "Cappuccino" };

        //Act
        Assert.Throws<Exception>( ()=> CsvLineParser.Parse(csvLines));
    }
}