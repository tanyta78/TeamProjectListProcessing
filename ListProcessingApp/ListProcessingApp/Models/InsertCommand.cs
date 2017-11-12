namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class InsertCommand:Command
    {
        public InsertCommand(List<string>input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
