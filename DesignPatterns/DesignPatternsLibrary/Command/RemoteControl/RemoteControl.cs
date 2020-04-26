using System.Text;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class RemoteControl
    {
        private readonly ICommand[] onCommands;
        private readonly ICommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[8];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                    + "   " + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
