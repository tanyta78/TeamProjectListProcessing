namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class DeleteCommand:Command
    {
        public DeleteCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
