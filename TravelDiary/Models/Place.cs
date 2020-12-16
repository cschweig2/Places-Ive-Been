using System.Collections.Generic;

namespace TravelDiary.Models
{
    public class Place
    {
        public string CityName;
        private int id;

        public Place(string cityName)
        {
            CityName = cityName;
            id = 0;
        }


    }
}