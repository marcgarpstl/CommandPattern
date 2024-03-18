using CommandPattern.Interface;

namespace CommandPattern.Commands
{
    public class RunCommand : Icommand
    {
        private readonly Dog _dog;

        public RunCommand(Dog dog) => _dog = dog;

        public void Execute()
        {
            if (_dog.Run == true)
            {
                Console.WriteLine("Dog is already running");
                return;
            }
            _dog.Run = true;
            _dog.Stay = false;
            Console.WriteLine("Dog is running");
        }
    }
}
