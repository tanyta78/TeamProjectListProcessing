namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class SortCommand:Command
    {
        public SortCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
