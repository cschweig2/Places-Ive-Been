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

    [TestMethod]
    public void GetAll_ReturnsListPopulatedWithAllPlaceInstances_List()
    {
      Place newPlace01 = new Place("Boise", "pictureUrl01");
      Place newPlace02 = new Place("Denver", "pictureUrl06");
      List<Place> expectedList = new List<Place> {newPlace01, newPlace02};  
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(expectedList, result);
    }
  }
}