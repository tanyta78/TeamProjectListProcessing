namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class RollRightCommand:Command
    {
        public RollRightCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
