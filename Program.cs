using ClassesProgram.Math;

namespace ClassesProgram
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result=calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
