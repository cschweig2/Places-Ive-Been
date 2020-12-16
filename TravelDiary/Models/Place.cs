using System.Collections.Generic;

namespace TravelDiary.Models
{
    public class Place
    {
        public string CityName;
        public string ImageUrl;
        private int id;

        public Place(string cityName, string imageUrl)
        {
            CityName = cityName;
            ImageUrl = imageUrl;
            id = 0;
        }


    }
}