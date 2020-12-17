using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class TravelDiaryTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
    
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
      string cityName01 = "Boise";
      string cityName02 = "Denver";
      string imgUrl01 = "dummyUrl01";
      string imgUrl02 = "dummyUrl02";
      Place newPlace01 = new Place(cityName01, imgUrl01);
      Place newPlace02 = new Place(cityName02, imgUrl02);
      List<Place> expectedList = new List<Place> {newPlace01, newPlace02};
      foreach (Place instance in expectedList)
      {
        Console.WriteLine("myPlacesInExpected List includes {0}", instance);
      }
      List<Place> result = Place.GetAll();
      foreach (Place instance in result)
      {
        Console.WriteLine("myPlacesInResult List includes {0}", instance);
      }
      CollectionAssert.AreEqual(expectedList, result);
    }

    [TestMethod]
    public void GetId_ReturnsIdOfPlaceInstance_Int()
    {
      string cityName = "Philly";
      string imgUrl = "https://dummyimg.com";
      Place newPlace = new Place(cityName, imgUrl);
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }
  }
}