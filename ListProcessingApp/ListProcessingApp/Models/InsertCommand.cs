using System;

namespace ListProcessingApp.Models
{
    class InsertCommand:Command
    {
        public InsertCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
