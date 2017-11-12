namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class PrependCommand:Command
    {
        public PrependCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
