using System;
using System.Collections.Generic;

namespace ClubManagementWeb
{
    // WeatherService implements the IWeatherService contract.
    // Returns simulated but realistic weather data based on zip code prefix.
    // Simulated data is used to ensure reliable deployment on WebStrar server.
    public class WeatherService : IWeatherService
    {
        // GetWeather: takes a zip code string, returns a formatted weather report string.
        // Input:  zipCode — 5-digit US zip code (e.g. "85281")
        // Output: string  — formatted weather description with temp and conditions
        public string GetWeather(string zipCode)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(zipCode) || zipCode.Trim().Length < 3)
                return "Error: Please provide a valid zip code.";

            string zip = zipCode.Trim();
            string prefix = zip.Substring(0, 3);

            // Map zip code prefix ranges to US regions with realistic weather
            // Based on USPS zip code geographic distribution
            string city, conditions, humidity;
            int tempF;

            if (IsInRange(prefix, "850", "865"))      // Arizona
            {
                city = "Arizona"; tempF = 95;
                conditions = "Sunny and dry";
                humidity = "15%";
            }
            else if (IsInRange(prefix, "900", "961")) // California
            {
                city = "California"; tempF = 72;
                conditions = "Partly cloudy";
                humidity = "55%";
            }
            else if (IsInRange(prefix, "100", "149")) // New York
            {
                city = "New York"; tempF = 58;
                conditions = "Overcast with light winds";
                humidity = "70%";
            }
            else if (IsInRange(prefix, "606", "627")) // Illinois/Chicago
            {
                city = "Illinois"; tempF = 52;
                conditions = "Windy and cloudy";
                humidity = "65%";
            }
            else if (IsInRange(prefix, "770", "779")) // Texas/Houston
            {
                city = "Texas"; tempF = 85;
                conditions = "Humid and partly sunny";
                humidity = "80%";
            }
            else if (IsInRange(prefix, "330", "349")) // Florida
            {
                city = "Florida"; tempF = 88;
                conditions = "Thunderstorms likely";
                humidity = "90%";
            }
            else if (IsInRange(prefix, "980", "994")) // Washington State
            {
                city = "Washington"; tempF = 55;
                conditions = "Rainy and overcast";
                humidity = "85%";
            }
            else if (IsInRange(prefix, "300", "319")) // Georgia
            {
                city = "Georgia"; tempF = 78;
                conditions = "Mostly sunny";
                humidity = "60%";
            }
            else                                       // Default / unknown
            {
                city = "United States"; tempF = 65;
                conditions = "Mild and clear";
                humidity = "50%";
            }

            // Convert to Celsius
            int tempC = (int)Math.Round((tempF - 32) * 5.0 / 9.0);

            // Return formatted weather report
            return string.Format(
                "Zip Code: {0} | Region: {1} | Temperature: {2}°F ({3}°C) | " +
                "Conditions: {4} | Humidity: {5} | Updated: {6}",
                zip, city, tempF, tempC, conditions, humidity,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            );
        }

        // Helper: checks if a 3-digit prefix string falls within a range (inclusive)
        private bool IsInRange(string prefix, string low, string high)
        {
            return string.Compare(prefix, low) >= 0 &&
                   string.Compare(prefix, high) <= 0;
        }
    }
}