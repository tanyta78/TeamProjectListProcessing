namespace ListProcessingApp.Models
{
    using System;
    using System.Collections.Generic;

    class CountCommand:Command
    {
        public CountCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
