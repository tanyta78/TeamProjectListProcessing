using System;

namespace ListProcessingApp.Models
{
    class CountCommand:Command
    {
        public CountCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
