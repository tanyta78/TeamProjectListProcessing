namespace ListProcessingApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using IO;
  

    class DeleteCommand:Command
    {
        public DeleteCommand(List<string> input, string[] cmdData) : base(input, cmdData)
        {
        }

        public override void Execute()
        {           
            if (this.CmdData.Length != 2)
            {
                //to do - to change exception when created
                throw new InvalidDataException();
            }

            var indexForDeleting = int.Parse(this.CmdData[1]);

            if(indexForDeleting < 0 || indexForDeleting > Input.Count-1)
            {
                Console.WriteLine($"Error: invalid index {indexForDeleting}");
            }
            else
            {
                this.Input.RemoveAt(indexForDeleting);
                OutputWriter.WriteMessageOnNewLine(string.Join(" ", this.Input));
            }
            
            
        }
    }
}
