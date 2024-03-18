using CommandPattern.Interface;

namespace CommandPattern.Commands
{
    public class StayCommand : Icommand
    {
        private readonly Dog _dog;

        public StayCommand(Dog dog) => _dog = dog;

        public void Execute()
        {
            if (_dog.Stay == true)
            {
                Console.WriteLine("Dog is standing still");
                return;
            }
            _dog.Stay = true;
            _dog.Run = false;
            Console.WriteLine("Dog has stopped");
        }
    }
}
