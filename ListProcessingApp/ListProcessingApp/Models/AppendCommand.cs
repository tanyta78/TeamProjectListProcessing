using System;

namespace ListProcessingApp.Models
{
    class AppendCommand:Command
    {
        public AppendCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
