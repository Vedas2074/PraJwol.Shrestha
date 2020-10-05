using System;
namespace AccessModifierAndMethods
{

 public class AccessModifier // default is internal
{
    int x;
    int y;
    internal void DOSomething() //By default it is private
    {

    }

    public int CalculateAverage(int[] numbers)
    {
        //Calculate Average
        return 0;
    }
}

}