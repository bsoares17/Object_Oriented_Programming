using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soares_ConverterCapstone
{
    public class MetricToEnglish
    {
        private int _kilometers = 0;
        private int _meters = 0;
        private double _centimeters = 0;
        private int _miles = 0;
        private double _inches = 0;
        private int _feet = 0;
        private int _yards = 0;

        public void metricToEnglish()
        {
        }

        public MetricToEnglish(string kilometers, string meters, string centimeters)
        {
            _kilometers = Convert.ToInt32(kilometers);
            _meters = Convert.ToInt32(meters);
            _centimeters = Convert.ToDouble(centimeters);

            convert();
        }

        public void convert()
        {
            double totalCentimeters = 0;
            int totalMeters = 0;
            double totalInches = 0;
            int totalFeet = 0;
            int totalYards = 0;
            int totalMiles = 0;

            totalMeters = convertKilometersToMeters() + _meters;

            totalCentimeters = convertMetersToCentimeters(totalCentimeters) + _centimeters;

            totalInches = convertTotalCentimetersToTotalInches(totalCentimeters);

            totalFeet = (int)convertTotalInchesToTotalFeet(totalInches);

            _inches = findInchesAfterFeetAreRemoved(totalInches);

            totalYards = convertTotalFeetToYards(totalFeet);

            _feet = findFeetAfterYardsAreRemovedFromTotalFeet(totalFeet);

            totalMiles = convertYardsToMiles(totalMiles);

            _yards = findYardsAfterMilesAreRemovedFromTotalYards(totalMiles);
        }

        private int convertKilometersToMeters()
        {
            return _kilometers * 1000;
        }

        private double convertMetersToCentimeters(double totalCentimeters)
        {
            return totalCentimeters * 100;
        }

        private double convertTotalCentimetersToTotalInches(double totalCentimeters)
        {
            return totalCentimeters / 2.54;
        }

        private double convertTotalInchesToTotalFeet(double totalInches)
        {
            return totalInches / 12;
        }

        private double findInchesAfterFeetAreRemoved(double totalInches)
        {
            Convert.ToInt32(totalInches); //modulus uses ints, but totalInches has to be a double hence totalInches being typecasted
            return totalInches % 12;
        }

        private int convertTotalFeetToYards(int totalFeet)
        {
            return totalFeet / 3;
        }

        private int findFeetAfterYardsAreRemovedFromTotalFeet(int totalYards)
        {
            return totalYards % 3;
        }

        private int convertYardsToMiles(int totalMiles)
        {
            return totalMiles / 1706;
        }

        private int findYardsAfterMilesAreRemovedFromTotalYards(int totalYards)
        {
            return totalYards % 1760;
        }

        public string getInches()
        {
            return (round(_inches, 1)).ToString();
        }

        public string getFeet()
        {
            return _feet.ToString();
        }

        public string getYards()
        {
            return _yards.ToString();
        }

        public string getMiles()
        {
            return _miles.ToString();
        }

        public double round(double numberToRound, int numberOfPlaces)
        {
            double tempDouble = (numberToRound * Math.Pow(10, numberOfPlaces));

            tempDouble += .5;

            int tempInt = (int)tempDouble;

            tempDouble = tempInt / Math.Pow(10, numberOfPlaces);

            return tempDouble;
        }
    }
}