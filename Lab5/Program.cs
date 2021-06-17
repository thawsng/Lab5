using System;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "ID001",
                Name = "Spring Hero",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            var unversityTeacher = new UniversityTeacher
            {
                IdentityNumber = "ID002",
                Name = "Xuan Hung",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(unversityTeacher.CalculateSalary());
        }
    }
}