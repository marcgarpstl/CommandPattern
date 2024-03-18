using System.Xml.Schema;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simulator = new DogSimulator();

            simulator.Run();
        }
    }
}
