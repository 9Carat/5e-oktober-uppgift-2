namespace _5e_oktober_uppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar olika instanser av klasserna och anropar metoderna
            // Det blir smidigare att mata in temperaturen i klassinstanserna istället för metoden men då behöver vi constructorn 
            TempClass temp1 = new TempClass();
            double tempK = temp1.Convert(30);
            Fahrenheit temp2 = new Fahrenheit();
            double tempC = temp2.Convert(40);
            Celsius temp3 = new Celsius();
            double tempF = temp3.Convert(50);

            Console.WriteLine(tempK + " grader Kelvin");
            Console.WriteLine(tempC + " grader Fahrenheit");
            Console.WriteLine(tempF + " grader Celsius");
        }
    }
}