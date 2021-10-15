using System;

namespace GettersAndSettersOefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pedro = new Person();
            pedro.setAge(12);

            
            //kan ook gelijk 
            int newAge = pedro.GetAge();
            Console.WriteLine(newAge);
        }
    }
}
