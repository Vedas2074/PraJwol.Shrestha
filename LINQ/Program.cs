using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            int[] numbers = {23, 45, 67, 12, 34, 45, 32, 45, 33, 46 };

            //Find all the elements from numbes array which are less than 75 and greater than 20.

            // USing method syntax - Lambda expression
            var result = numbers.Where(x => x < 75 && x > 20);

            //Query syntax - query expression
            var result1 = from x in numbers 
                          where x < 75 && x > 20
                          select x;

            string[] names = {"Bishnu", "Hari", "Ram", "PraJwol", "Sabin", "Krishna"};

            // FInd names that starts with letter 'S' and having length than 6

            var result2 = from name in names
                          where name.StartsWith("S") && name.Length < 6
                          select name;  

            // Projection
            var result4 = from num in numbers   
                          select num * num;

            //Ordering
            var results4 = from num in numbers  
                           orderby num
                           select num; 
            //Partitioning
            var result5 = numbers.Take(5);
            var result6 = numbers.Skip(5).Take(5);

            // Quantifiers
            var isEvenThere = numbers.Any(num => num % 2 == 0);
            var areAllEvens = numbers.All(num => num % 2 == 0);
            var is26there = numbers.Contains(26);

            var result7 = Enumerable.Range(1, 100);
            var result8 = Enumerable.Repeat("Hello PraJwol!", 10);

            List<Person> people = new List<Person>()
            {
                new Person() {Id = 1, FirstName ="Pzl",LastName ="Shrestha", Address="Lalitpur", Age = 80},
                new Person() {Id = 2, FirstName ="Psk",LastName ="Shrestha", Address="KTM", Age = 8},
                new Person() {Id = 3, FirstName ="Sabin",LastName ="Shrestha", Address="Lalitpur", Age = 20},
                new Person() {Id = 4, FirstName ="Ashok",LastName ="Shrestha", Address="Bhaktapur", Age = 30},
                new Person() {Id = 5, FirstName ="Ijan",LastName ="Shrestha", Address="Lubhoo", Age = 40},
            };
            
            // Find all the people who live in Kathmandu?

            var result9 = from Person in people
                         where Person.Address == "KTM"
                         select Person;

            // Find all the people who are minors
             
             var result10 = from Person in people
                            where Person.Age < 18
                            select Person;

            // Find all minors who live in Bhaktpur

            var result11 = from Person in people
                           where Person.Address == "Bhaktpur"
                           select Person;




        }
    }
}
