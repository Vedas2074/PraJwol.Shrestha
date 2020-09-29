// using System;

//     class Program
//     {
//         static void Main()
//         {
//             SelectionStatment selectionStatment = new SelectionStatment();
//             selectionStatment.LearnSwitchCases();





//         }
//     }

using System;
namespace AccessModifierAndMethods
{
   class Program
{
    static void Main()
    {
        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DOSomething();

        People people = new People();
        people.name = "Shrestha";
        people.Number = 10;
        var x = people.Address;



    }
}
}
