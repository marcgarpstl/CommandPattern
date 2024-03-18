using CommandPattern.Interface;

namespace CommandPattern
{
    public class InputHandler
    {
        public void HandleInput(Icommand command)
        {
            command.Execute();
        }
    }
}
