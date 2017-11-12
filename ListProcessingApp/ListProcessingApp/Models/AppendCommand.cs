namespace ListProcessingApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using IO;

    class AppendCommand:Command
    {
        public AppendCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {
            if (this.CmdData.Length!=2)
            {
                //to do - to change exception when created
                throw new InvalidDataException();
            }

            var strToAppend = this.CmdData[1];
            this.Input.Add(strToAppend);
            OutputWriter.WriteMessageOnNewLine(string.Join(" ",this.Input));
        }

        
    }
}
