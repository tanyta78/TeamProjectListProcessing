using System;

namespace ListProcessingApp.Models
{
    class EndCommand:Command
    {
        public EndCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
