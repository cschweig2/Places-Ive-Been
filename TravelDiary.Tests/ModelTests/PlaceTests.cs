using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class TravelDiaryTests
  {
    [TestMethod]
    public void CreateAPlace_ReturnsNewInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Frankfurt");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GivePlaceACityName_ReturnsInstanceWithCityName_CityName()
    {
      // Arrange
      string cityName = "Philadelphia";
      Place newPlace = new Place(cityName);
      // Act
      string result = newPlace.CityName;
      // Assert
      Assert.AreEqual("Philadelphia", result);
    }

  }
}