namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class RollLeftCommand:Command
    {
        public RollLeftCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
