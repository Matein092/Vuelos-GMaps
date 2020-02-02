using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class Flight
    {
        //constantes
        public const string CSV = "..\\..\\Vuelos.csv";

        //Asociaciones
        public List<City> cities;
        public City city;



        public Flight()
        {
            cities = new List<City>();
        }

        private void readFlights()
        {
            StreamReader leer = new StreamReader(CSV);
            String linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n"); 
                    linea = leer.ReadLine();
                }

            }
            catch(Exception exception)
            {
                Console.WriteLine("EXCEPTION: " + exception.Message);
            }
        }

        public void citySelected(int index)
        {
            city = cities[index];
        }
        public string getSelectedOrigin()
        {
            string origin = "-";
            if (city != null)
            {
                origin = city.getOrigin();
            }
            return origin;
        }

        public string getSelectedDestination()
        {
            string destination = "-";
            if (city != null)
            {
                destination = city.getOrigin();
            }
            return destination;
        }
        
        public double GetSelectedLongitude()
        {
            double longitude = 0;
            if (city != null)
            {
                longitude = city.getLongitude();
            }
            return longitude;
        }

       
        public double GetSelectedLatitude()
        {
            double latitude = 0;
            if (city != null)
            {
                latitude = city.getLatitude();
            }
            return latitude;
        }

        public string GetSelectedDate()
        {
            string date = "-";
            if (city != null)
            {
                date = city.getDate();
            }
            return date;
        }

        public string GetSelectedHour()
        {
            string hour = "-";
            if (city != null)
            {
                hour = city.getHour();
            }
            return hour;
        }


    }
}

