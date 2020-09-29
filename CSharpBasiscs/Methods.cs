using System;
using System.Linq;
namespace AccessModifierAndMethods
{ 
class Methods
{
    void PrintInfo() // here the function takes no arguments
    {
        Console.WriteLine("Printing something..");
        // Multiply(23.f, 337.8f);
        // Multiply(23.f, 337.8f, 88.8f); //we can set the argument value anywhere in the class
        // Sum(2.3, 4.5);
        // Sum(2.3, 3.4, 4.4);
        // Greet(Pzl, Mr);
        // byte[] nubmers = {2,3,4,5,6,7,8,9,0,0};
        // (byte minNumber, byte maxNumber) result = FindMinMax90;
        // PrintCustomerDetails(age:54, name:ShresthaPzl, isMale: Male, address: Lalitpur);



    }
    void PrintSomething(string Message) // here the function takes one argument
    {
        Console.WriteLine(Message);
    }

    float Multiply(float firstNum, float secondNum) // here the function take two arguments
    {
        float product = firstNum * secondNum;
        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum) // here the function take three arguments
    {
        float product = firstNum * secondNum * thirdNum;
        return product;
    }
    // Function Overloading: we call Function Overload when we recall the same function 

    //Variable of number of arguements
    double Sum(params double[] numbers) // Params(is a keyword of C# basicall feature) can take variable number of arguments
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }

    // Optional Arguements

    string Greet(string name, string prefix) // we can set default value in arguments.here we can use like prefix="Miss"
    {
        string fullName = prefix + ", " + name; // or $"{variable}, {Variable}"; - we can add more than two variable easily. Called string Interpolation.
        return fullName;
    }

    //Returning Multiple Value

    (byte, byte) FindMinMax(byte[] numbers)
    {
        byte maxNumber = numbers.Max();
        byte minNumber = numbers.Min();

        return (minNumber, maxNumber);
    }

    // Named Arguements
    void PrintCustomerDetails(string name, string address, byte age, bool isMale)
    {
        Console.WriteLine($"{name},[{age}], {address}");
    }

    //Expression bodied method syntax
    float Addition(float firstNum, float secondNum) => firstNum + secondNum;

}
}