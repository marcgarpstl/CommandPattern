using CommandPattern.Interface;

namespace CommandPattern.Commands
{
    public class BarkCommand : Icommand
    {
        private readonly Dog _dog;

        public BarkCommand(Dog dog) => _dog = dog;

        public void Execute()
        {
            _dog.Bark = true;
            Console.WriteLine("Woff woff");
            _dog.Bark = false;
        }
    }
}
