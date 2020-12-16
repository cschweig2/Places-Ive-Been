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
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    
  }
}