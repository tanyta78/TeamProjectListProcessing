namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class ReverseCommand:Command
    {
        public ReverseCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
