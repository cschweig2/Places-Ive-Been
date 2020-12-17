using System.Collections.Generic;

namespace TravelDiary.Models
{
    public class Place
    {
        public string CityName {get; set;}
        public string ImageUrl {get; set;}
        public int Id {get;}
        public static List<Place> placesList = new List<Place> {};

        public Place(string cityName, string imageUrl)
        {
            CityName = cityName;
            ImageUrl = imageUrl;
            placesList.Add(this);
            Id = 2;
        }

        public static List<Place> GetAll()
        {
            return placesList;
        }

        public static void ClearAll()
        {
            placesList.Clear();
        }

    }
}