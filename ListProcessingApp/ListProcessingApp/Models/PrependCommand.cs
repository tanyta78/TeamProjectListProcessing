namespace ListProcessingApp.Models
{
    using System.Collections.Generic;
    using System.IO;
    using IO;

    class PrependCommand:Command
    {
        public PrependCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            if (this.CmdData.Length != 2)
            {
                //to do - to change exception when created
                throw new InvalidDataException();
            }

            var strToPrepend = this.CmdData[1];
            this.Input.Insert(0,strToPrepend);
            
            OutputWriter.WriteMessageOnNewLine(string.Join(" ", this.Input));
        }
    }
}
