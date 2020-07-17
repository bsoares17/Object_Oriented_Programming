using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soares_ConverterCapstone
{
    /************ IT 3500 ****************************************************************
*************************************************************************************
**
** This program was prepared as part of the requirements for IT 3500,
** Object Oriented Programming.
**
** COURSE DESCRIPTION:
** This is the third course in a three-course programming sequence. This course
** introduces Object-Oriented (OO) Programming concepts in a programming language
** using a compatible integrated development environment. It includes the
** principles of OO Programming (OOP); encapsulation, polymorphism, reusable
** code, inheritance, composition, and abstraction.
**
** OOP also introduces graphical user interfaces and teaches the student how to
** properly create an OO graphical user interface.
**
** In addition, this course continues to develop basic problem analysis and
** critical thinking skills that aid the student when developing algorithms.
**
** Prerequisite: IT 2789, Structured Programming
**
** LEVEL:
** This course assumes the student understands the basics of programming and of
** writing code to implement the three basic programming constructs. If further
** assumes the student has the ability to analyze problems and can create
** program designs/algorithms from the problem analysis.
**
** COMPLETION CRITERIA:
** Upon successfully completing this course the student should be able to read a
** client description of a problem, analyze that problem, formulate an algorithm
** that will provide information that will support the client’s solving the
** problem, design and implement the algorithm, and produce the required
** information.
**
** COURSE LEARNING OUTCOMES:
** 1 Given an object to be represented in software, design, code and test a
** program that: defines a class to model the characteristics and behaviors
** of the object, defines appropriate constructors and destructors for the
** class, creates an instance of the object, and calls the methods of the
** object to solve a problem.
** 2 Given a class in a program; design, code, and test a program that controls
** the accessibility of the members of the class.
** 3 Given a set of specifications, design, code, and test a program that
** defines and uses a set of objects in which an instance of one object has a
** composition relationship with another.
** 4 Design, code, and test a program that defines and uses an array of objects.
** 5 Design, code, and test a program that defines and uses appropriate
** overloaded functions or operators.
** 6 Design, code, and test a program that employs inheritance and includes
** overriding.
** 7 Design, code, and test a program that contains statically and dynamically
** bound functions.
** 8 Given a set of objects related through inheritance; design, code, and test
** a program that utilizes an abstract base class.
** 9 Write a program that would generally be considered to be maintainable.
** 10 Given a problem where the resulting solution would be a large program,
** design, code, and test a modular solution using separate header,
** implementation files, and namespaces to manage complexity.
**
*************************************************************************************
*************************************************************************************/

    /*Capstone
    /*************************************************************************************
    *************************************************************************************
    **
    ** ASSIGNMENT:
    ** English to Metric to English Converter
    **
    ** Your employer has asked you to write a program that will convert the English
    ** system of measurement into the metric system of measurement. The program must
    ** accept distances (in the English system) in miles, yards, feet, and inches and
    ** convert these distances into metric distances. The metric output will be
    ** kilometers, meters, and centimeters. Further, it must accept distances in
    ** kilometers, meters, and centimeters and convert these distances into English
    ** distances. The English output will be in miles, yards, feet, and inches.
    **
    ** Miles, yards, feet, kilometers, and meters will be whole numbers (no decimal point)
    ** while inches and centimeters will have one digit to the right of the decimal point.
    **
    ** 1 Describe the Requirements of this solution.
    ** 2 From the requirements, determine the features that must be implemented in the
    ** program.
    ** 3 Prepare a program design that adheres to the principles of clean code.
    ** 4 Include in that design a user-friendly image of the User Interface.
    ** 4 Implement that design in clean, maintainable, and extensible code.
    ** 5 Test your program.
    **
    ** Additional challenge (not required)
    ** A After your program is developed and tested, generate 100 random English inputs
    ** (that has 3 or fewer digits each for miles, yards, and feet and 4
    ** or fewer digits for inches) and convert them into Metric. Save the inputs and
    ** outputs in a file.
    ** B Use the outputs from part A to test the Metric to English conversion.
    **
    ** Limitations:
    ** • No libraries external to the language itself (i.e. nothing from the Internet)
    ** • Be sure to check for invalid or inappropriate inputs and handle them properly
    **
    **************************************************************************************
    **************************************************************************************/
    public class EnglishToMetric
    {
        private int _kilometers = 0;
        private int _meters = 0;
        private double _centimeters = 0;
        private int _miles = 0;
        private double _inches = 0;
        private int _feet = 0;
        private int _yards = 0;

        public void englishToMetric()
        {
        }

        public EnglishToMetric(string inches, string feet, string yards, string miles)
        {
            _inches = Convert.ToDouble(inches);
            _feet = Convert.ToInt32(feet);
            _yards = Convert.ToInt32(yards);
            _miles = Convert.ToInt32(miles);

            convert();
        }

        public void convert()
        {
            int totalYards = 0;
            int totalFeet = 0;
            double totalInches = 0;
            double totalCentimeters = 0;
            int totalMeters = 0;
            int totalKilometers = 0;

            totalYards = _yards + convertMilesToYards(_miles);

            totalFeet = _feet + convertYardsToFeet(totalYards);

            totalInches = _inches + convertFeetToTotalInches(totalFeet);

            totalCentimeters = convertInchesToTotalCentimeters(totalInches);

            _centimeters = findCentimetersAfterInchesAreRemoved(totalCentimeters);

            totalMeters = convertCentimetersToMeters(totalMeters);

            _meters = findMetersAfterCentimetersAreRemoved(totalMeters);

            totalKilometers = convertMetersToKilometers(totalKilometers);

            _kilometers = findKilometersAfterMetersAreRemoved(totalKilometers);
        }

        private int convertMilesToYards(int miles)
        {
            return miles * 1760;
        }

        private int convertYardsToFeet(int totalYards)
        {
            return totalYards * 3;
        }

        private int convertFeetToTotalInches(int totalFeet)
        {
            return totalFeet * 12;
        }

        private int findFeetAfterInchesAreRemovedFromTotalFeet(int totalInches)
        {
            return totalInches * 12;
        }

        private double convertInchesToTotalCentimeters(double totalInches)
        {
            return totalInches * 2.54;
        }

        private double findCentimetersAfterInchesAreRemoved(double totalCentimeters)
        {
            return totalCentimeters * 2.54;
        }

        private int convertCentimetersToMeters(int totalMeters)
        {
            return totalMeters / 100;
        }

        private int findMetersAfterCentimetersAreRemoved(int totalMeters)
        {
            return totalMeters % 100;
        }

        private int convertMetersToKilometers(int totalKilometers)
        {
            return totalKilometers / 1000;
        }

        private int findKilometersAfterMetersAreRemoved(int totalKilometers)
        {
            return totalKilometers % 1000;
        }

        public string getKilometers()
        {
            return _kilometers.ToString();
        }

        public string getMeters()
        {
            return _meters.ToString();
        }

        public string getCentimeters()
        {
            return (round(_centimeters, 1)).ToString();
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