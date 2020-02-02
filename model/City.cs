using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class City
    {
        private String origin;
        private String destination;
        private String date;
        private String hour;
        private String flightNumber;
        private double latitude;
        private double longitude;

        public City(String origin, String destination, String date, String hour, String flightNumber, double latitude, double longitude)
        {
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.hour = hour;
            this.flightNumber = flightNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }


        public double getLatitude()
        {
            return latitude;
        }

        public void setLatitude(double latitude)
        {
            this.latitude = latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }

        public void setLongitude(double longitude)
        {
            this.longitude = longitude;
        }

        public String getOrigin()
        {
            return origin;
        }

        public void setOrigin(String origin)
        {
            this.origin = origin;
        }

        public String getDestination()
        {
            return destination;
        }

        public void setDestination(String destination)
        {
            this.destination = destination;
        }

        public String getDate()
        {
            return date;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getHour()
        {
            return hour;
        }

        public void setHour(String hour)
        {
            this.hour = hour;
        }

        public String getFlightNumber()
        {
            return flightNumber;
        }

        public void setFlightNumber(String flightNumber)
        {
            this.flightNumber = flightNumber;
        }

    }
}
