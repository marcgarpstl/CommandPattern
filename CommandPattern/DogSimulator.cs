using CommandPattern.Commands;

namespace CommandPattern
{
    public class DogSimulator
    {
        private Dog _dog;

        private InputHandler _inputHandler;

        internal void Start()
        {
            if (_dog == null) _dog = new Dog();
            if (_inputHandler == null) _inputHandler = new InputHandler();
        }
        public void Update(ConsoleKey key)
        {
            if (key == ConsoleKey.B)
            {
                _inputHandler.HandleInput(new BarkCommand(_dog));
            }
            else if (key == ConsoleKey.Spacebar)
            {
                _inputHandler.HandleInput(new JumpCommand(_dog));
            }
            else if (key == ConsoleKey.R)
            {
                _inputHandler.HandleInput(new RunCommand(_dog));
            }
            else if(key == ConsoleKey.S) 
            {
                _inputHandler.HandleInput(new StayCommand(_dog));
            }
            else
            {
                _inputHandler.HandleInput(new InvalidCommand());
            }
        }

        public void Run()
        {
            Start();

            while (true)
            { 
                Console.WriteLine("Dogsimulator" +
                    "\n" +
                    "\nUse 'Spacebar' to jump" +
                    "\nUse 'R' to run" +
                    "\nUse 'S' to stay" +
                    "\nUse 'B' to bark" +
                    "\nUse 'Q' or 'ESC' to quit" +
                    "\n");
                var keyInput = Console.ReadKey();
                if (keyInput.Key == ConsoleKey.Q || keyInput.Key == ConsoleKey.Escape)
                {
                    break;
                }
                var key = keyInput.Key;
                Console.Clear();
                Update(key);
                Console.WriteLine("--------------");
            }
        }
    }
}
