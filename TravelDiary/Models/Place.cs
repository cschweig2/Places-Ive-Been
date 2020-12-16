using System.Collections.Generic;

namespace TravelDiary.Models
{
    public class Place
    {
        public string CityName {get; set;}
        public string ImageUrl {get; set;}
        // private int id {get;}
        public static List<Place> placesList = new List<Place> {};

        public Place(string cityName, string imageUrl)
        {
            CityName = cityName;
            ImageUrl = imageUrl;
            placesList.Add(this);
            // id = 0;
        }

        public static List<Place> GetAll()
        {
            placesList = new List<Place> {};
            return placesList;
        }

        public static void ClearAll()
        {
            placesList.Clear();
        }
    }
}