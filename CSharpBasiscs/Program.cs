﻿// using System;

//     class Program
//     {
//         static void Main()
//         {
//             SelectionStatment selectionStatment = new SelectionStatment();
//             selectionStatment.LearnSwitchCases();





//         }
//     }

using System;
//namespace AccessModifierAndMethods
namespace LearningClasses
{


  class Program
{
   static void Main()
    {
     People people = new People();
        people.name = "Shrestha";
      people.Number = 10;
        var x = people.Address;
    }    
    static void main234()
    {
        var person1 = new Person("Pzl","KTM");
        var person2 = new Person("Ram","Lubu", 12);
        var person3 = new Person("Hari","Hetauda", 23);
        
        Person person = new Person();
        person.Name = "ShresthaPzl";
        person.Age = 12;

        var person4 = new Person("Har3","Lamatar", 23);
        // Accessing Static member
        var x = Person.ScientificName;
        Person.Do();
        var y = Math.Sqrt(123);

        var s = Calculator.Sum<int>(2,5);
        var s1 = Calculator.Sum<decimal>(2.5m, 504.5m);
    }
}  
 }


