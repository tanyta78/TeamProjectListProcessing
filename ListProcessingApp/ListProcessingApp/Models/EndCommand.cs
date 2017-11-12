namespace ListProcessingApp.Models
{
    using System.Collections.Generic;

    class EndCommand:Command
    {
        public EndCommand(List<string>input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
