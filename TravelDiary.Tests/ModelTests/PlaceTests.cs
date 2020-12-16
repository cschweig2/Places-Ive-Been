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
      Place newPlace = new Place("Frankfurt", "dummyImageUrl");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GivePlaceACityName_ReturnsInstanceWithCityName_CityName()
    {
      // Arrange
      string cityName = "Philadelphia";
      Place newPlace = new Place(cityName, "dummyImageUrl");
      // Act
      string result = newPlace.CityName;
      // Assert
      Assert.AreEqual("Philadelphia", result);
    }

    [TestMethod]
    public void AddPictureToPlaceInstance_ReturnsInstanceWithImage_Image()
    {
      string cityName = "Toronto";
      string imageUrl = "https://images.app.goo.gl/JPMDgENY2nNjAy7i7";
      Place newPlace = new Place(cityName, imageUrl);
      string result = newPlace.ImageUrl;
      Assert.AreEqual(imageUrl, result);
    }

  }
}