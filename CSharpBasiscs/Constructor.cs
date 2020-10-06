namespace LearningClasses
{
    public class Person // random class
    {
        // Default Parameterless Constructor
      public Person()
      {

      }  
      public Person(string n, string Address, byte a) // This default constructor and Should be named same as class 
      {
          //Parametrized constructor
          this.Name = n;
          this.Address =Address;
          this.Age = a;
      }
      public Person(string n, string add)
      {
          this.Name = n;
          this.Address = add;
      }  
      public string Name {get; set;}
      public string Address {get; set;}
      public byte Age {get; set;}

      public static string ScientificName = "Homo sapiens"; // static member can call only by class name.

      public static void Do()
      {

      }
    }
}