using CommandPattern.Interface;

namespace CommandPattern.Commands
{
    public class JumpCommand : Icommand
    {
        private readonly Dog _dog;

        public JumpCommand(Dog dog) => _dog = dog;

        public void Execute()
        {
            _dog.Jump = true;
            Console.WriteLine("*Jump*");
            _dog.Jump = false;
        }
    }
}
